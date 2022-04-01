using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RentMe.Validators;
using System.Drawing;


namespace RentMe.UserControls
{
    /// <summary>
    /// This UserControl models a form
    /// which will enable the update, deletion,
    /// or registration of a RentMe member
    /// </summary>
    public partial class MemberServices : UserControl
    {
        private readonly MembersController membersController;
        private Member memberSearchDetails;

        /// <summary>
        /// Initialize the control.
        /// </summary>
        public MemberServices()
        {
            InitializeComponent();
            this.InitializeControls();
            this.membersController = new MembersController();
        }

        /// <summary>
        /// Initializes the default values
        /// for the form controls.
        /// </summary>
        private void InitializeControls()
        {
            this.sexComboBox.SelectedIndex = 0;
            this.dobPicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        /// <summary>
        /// Event handler for search button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                this.memberSearchDetails = this.CreateMemberFromSearch();
                if (this.membersController.ValidMemberSearch(this.memberSearchDetails))
                {
                    this.memberSearchDetails = this.membersController.GetMemberFromSearch(this.memberSearchDetails);
                    this.ToggleFormButtons(true);
                    this.SetFields(this.memberSearchDetails);
                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);
                this.ToggleFormButtons(false);
            }
        }

       
     

        /// <summary>
        /// Event handler for update button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButtonClick(object sender, System.EventArgs e)
        {
            this.statusMessage.Text = "";
            try
            {
                this.ValidateFormFields();
                this.ProcessUpdate();
            }
            catch (Exception ex)
            {
                this.statusMessage.Visible = true;
                this.statusMessage.Text = ex.Message;
            }

        }


        /// <summary>
        /// Processes the update.
        /// </summary>
        private void ProcessUpdate()
        {

            Member memberUpdateData =
                new Member()
                {
                    MemberID = this.memberSearchDetails.MemberID,
                    FName = this.fnameTextBox.Text,
                    LName = this.lnameTextBox.Text,
                    DOB = this.dobPicker.Value,
                    Sex = this.sexComboBox.Text,
                    Phone = this.phoneTextBox.Text,
                    Address1 = this.address1TextBox.Text,
                    Address2 = this.address2TextBox.Text,
                    City = this.cityTextBox.Text,
                    Zip = this.zipTextBox.Text,
                    State = this.stateTextBox.Text
                };
            if (this.CheckUpdates(memberUpdateData))
            {
                if (this.membersController.UpdateMemberInformation(this.memberSearchDetails, memberUpdateData))
                {
                    this.UpdateStatusMessage("Member information updated successfully", false);
                    this.memberSearchDetails = this.membersController.GetMemberFromSearch(memberUpdateData);
                }
                else
                {

                    this.UpdateStatusMessage("Member information cannot be perfomed.Something went wrong "+
                        "with the process or member data is updated at the backend", true);
                    
                };
            }
            else
            {
                this.UpdateStatusMessage("No Changes made to the Member Data", true);
            }
        }

        /// <summary>
        /// Checks the updates.
        /// </summary>
        /// <param name="memberUpdateData">The member update data.</param>
        /// <returns></returns>
        private bool CheckUpdates(Member memberUpdateData)
        {
            List<Member> lstOld_MemberData = new List<Member>();
            List<Member> lstNew_MemberData = new List<Member>();
            bool isModified = false;
            lstOld_MemberData.Add(this.memberSearchDetails);
            lstNew_MemberData.Add(memberUpdateData);
            if (lstOld_MemberData.Count > 0 && lstNew_MemberData.Count > 0)
            {
                var result = lstNew_MemberData.Where(l2 =>
                      lstOld_MemberData.Any(l1 => l2.MemberID == l1.MemberID
                              && (l1.FName != l2.FName || l1.LName != l2.LName ||
                             l1.DOB != l2.DOB ||
                              l1.Phone != l2.Phone ||
                              l1.Sex != l2.Sex || l1.Address1 != l2.Address1 ||
                              l1.Address2 != l2.Address2 || l1.State != l2.State ||
                              l1.City != l2.City || l1.Zip != l2.Zip
                              )));
                isModified = result.Any();

            }
            return isModified;
        }


       

        /// <summary>
        /// Event handler for register member button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                Member member = this.CreateMemberFromFormFields();
                if (this.ConfirmMemberRegistration(member) == DialogResult.OK)
                {
                    this.membersController.RegisterNewMember(member);
                    UpdateStatusMessage("Member registration successfully!\n" +
                    "MemberID is " + member.MemberID, false);
                    this.ToggleFormButtons(true);
                }
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        /// <summary>
        /// Event handler for clear button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClick(object sender, System.EventArgs e)
        {
            this.ToggleFormButtons(false);
            this.ClearFields();
        }

        /// <summary>
        /// Clears the form fields.
        /// </summary>
        private void ClearFields()
        {
            void func(Control.ControlCollection controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = 0;
                    }
                    else if (control is DateTimePicker)
                    {
                        (control as DateTimePicker).Value = (control as DateTimePicker).MaxDate;
                    }
                    else
                    {
                        func(control.Controls);
                    }
            }

            func(Controls);
        }

        /// <summary>
        /// Takes input from the search field
        /// and returns a Member.
        /// </summary>
        /// <returns></returns>
        private Member CreateMemberFromSearch()
        {
            Member member = new Member();
            TextBox search = this.searchMemberTextBox;
            if (search.Text == "")
            {
                throw new ArgumentException("Member search field cannot be empty");
            }
            else if (new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$").IsMatch(search.Text))
            {
                member.Phone = search.Text;

            }
            else if (new Regex("[a-zA-Z] [a-zA-Z]").IsMatch(search.Text))
            {
                member.FName = search.Text.Substring(0, search.Text.IndexOf(" "));
                member.LName = search.Text.Substring(search.Text.IndexOf(" ") + 1);
            }
            else if (Int32.TryParse(search.Text, out int memberID))
            {
                member.MemberID = memberID;
            }

            return member;
        }

        /// <summary>
        /// Creates a new Member using validated
        /// form fields.
        /// </summary>
        /// <returns>Member object from fields</returns>
        private Member CreateMemberFromFormFields()
        {
            this.ValidateFormFields();
            Member member = new Member()
            {
                FName = this.fnameTextBox.Text,
                LName = this.lnameTextBox.Text,
                Sex = this.sexComboBox.GetItemText(this.sexComboBox.SelectedItem),
                Phone = this.phoneTextBox.Text,
                DOB = this.dobPicker.Value,
                Address1 = this.address1TextBox.Text,
                Address2 = this.address2TextBox.Text,
                City = this.cityTextBox.Text,
                State = this.stateTextBox.Text,
                Zip = this.zipTextBox.Text
            };
            return member;
        }

        /// <summary>
        /// Prompts the user to confirm
        /// that they want to register a RentMe member.
        /// </summary>
        /// <param name="incident"></param>
        private DialogResult ConfirmMemberRegistration(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            DialogResult result = MessageBox.Show("Are you sure you want to register new RentMe member:\n" +
                member.FName + " " + member.LName + "?",
                "Confirm Member Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
        }

        /// <summary>
        /// Set form fields to reflect Member information
        /// </summary>
        /// <param name="member"></param>
        private void SetFields(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            this.fnameTextBox.Text = member.FName;
            this.lnameTextBox.Text = member.LName;
            this.sexComboBox.SelectedIndex = this.sexComboBox.FindStringExact(member.Sex);
            this.phoneTextBox.Text = member.Phone;
            this.dobPicker.Value = member.DOB;
            this.address1TextBox.Text = member.Address1;
            this.address2TextBox.Text = member.Address2;
            this.cityTextBox.Text = member.City;
            this.stateTextBox.Text = member.State;
            this.zipTextBox.Text = member.Zip;
        }

        /// <summary>
        /// Event handler for form field text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFieldChanged(object sender, System.EventArgs e)
        {
            this.statusMessage.Visible = false;
        }


        /// <summary>
        /// Validates the required form fields.
        /// </summary>
        private void ValidateFormFields()
        {
            if (this.InvalidInput(this.fnameTextBox, this.GenerateRegexForTextBox(this.fnameTextBox)) ||
                this.InvalidInput(this.lnameTextBox, this.GenerateRegexForTextBox(this.lnameTextBox)))
            {
                throw new Exception("Name should consist of letters and not:\n" + 
                    "be empty, include numbers, or special characters");
            }
            else if (this.InvalidInput(this.phoneTextBox, this.GenerateRegexForTextBox(this.phoneTextBox)))
            {
                throw new Exception("Invalid phone number.\n" +
                    "Should consist of numbers and be in XXX-XXX-XXXX format");
            }
            else if (this.InvalidInput(this.address1TextBox, this.GenerateRegexForTextBox(this.address1TextBox)))
            {
                throw new Exception("Address 1 cannot be empty:\n" +
                    "special characters except / - . # & are prohibited");
            }
            else if (this.InvalidInput(this.cityTextBox, this.GenerateRegexForTextBox(this.cityTextBox)))
            {
                throw new Exception("City should consist of letters and not:\n " +
                    "be empty, include numbers, or special characters");
            }
            else if (this.InvalidInput(this.stateTextBox, this.GenerateRegexForTextBox(this.stateTextBox)))
            {
                throw new Exception("State cannot be empty and must be two letters");
            }
            else if (this.InvalidInput(this.zipTextBox, this.GenerateRegexForTextBox(this.zipTextBox)))
            {
                throw new Exception("Zip code cannot be empty and must be five numbers");
            }
        }

        /// <summary>
        /// Returns true if textBox text 
        /// doesn't match regex
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="regex"></param>
        /// <returns></returns>
        private bool InvalidInput(TextBox textBox, Regex regex)
        {
            if (textBox == null || regex == null)
            {
                throw new ArgumentException("TextBox and Regex cannot be null");
            }

            return !regex.IsMatch(textBox.Text);
        }

        /// <summary>
        /// Generates a regex based upon
        /// the passed TextBox form field.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        private Regex GenerateRegexForTextBox(TextBox textBox)
        {
            if (textBox == null)
            {
                throw new ArgumentException("TextBox cannot be null");
            }

            Regex regex = new Regex("");
            switch (textBox.Name)
            {
                case "fnameTextBox":
                    regex = new Regex("^[a-zA-Z]+$");
                    break;
                case "lnameTextBox":
                    regex = new Regex("^[a-zA-Z]+$");
                    break;
                case "phoneTextBox":
                    regex = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
                    break;
                case "address1TextBox":
                    regex = new Regex("^[0-9a-zA-Z#&/. -]+$");
                    break;
                case "cityTextBox":
                    regex = new Regex("^[a-zA-Z ]+$");
                    break;
                case "stateTextBox":
                    regex = new Regex("^[a-zA-Z]{2}$");
                    break;
                case "zipTextBox":
                    regex = new Regex("[0-9]{5}");
                    break;
                default:
                    break;
            }

            return regex;
        }

        /// <summary>
        /// Enables, disables buttons based on state of the form.
        /// </summary>
        private void ToggleFormButtons(bool enabled)
        {
            this.updateButton.Enabled = enabled;
            this.deleteButton.Enabled = enabled;
            this.registerButton.Enabled = !enabled;
        }

        /// <summary>
        /// Updates the error message to reflect 
        /// the status of the form.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isError"></param>
        private void UpdateStatusMessage(string message, bool isError)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Message cannot be null or empty");
            }

            if (isError)
            {
                this.statusMessage.ForeColor = Color.Red;
            }
            else
            {
                this.statusMessage.ForeColor = Color.Black;
            }

            this.statusMessage.Text = message;
            this.statusMessage.Visible = true;
        }
    }
}
