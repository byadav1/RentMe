using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
                Member member = this.CreateMemberFromSearch();
                //  this.membersController.MemberSearchSuccessful(member);
                this.memberSearchDetails = this.membersController.SearchMember(member);
                this.DisplayMemberDetails();
            }
            catch (ArgumentException ae)
            {
                this.errorMessage.Visible = true;
                this.errorMessage.Text = ae.Message;
            }

        }
        private void DisplayMemberDetails()
        {
            this.fnameTextBox.Text = this.memberSearchDetails.FName;
            this.lnameTextBox.Text = this.memberSearchDetails.FName;
            this.phoneTextBox.Text = this.memberSearchDetails.Phone;
            // this.dobPicker.Text = this.memberSearchDetails.DOB.ToString("MM/dd/yyyy");

            this.sexComboBox.Text = this.memberSearchDetails.Sex;
            this.address1TextBox.Text = this.memberSearchDetails.Address1;
            this.address2TextBox.Text = this.memberSearchDetails.Address2;
            this.cityTextBox.Text = this.memberSearchDetails.City;
            this.zipTextBox.Text = this.memberSearchDetails.Zip;
            this.stateTextBox.Text = this.memberSearchDetails.State;
            this.updateButton.Enabled = true; ;
            this.deleteButton.Enabled = true; ;
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
            if (Int32.TryParse(search.Text, out int memberID))
            {
                member.MemberID = memberID;
            }
            else if (this.InvalidInput(search, this.GenerateRegexForTextBox(this.phoneTextBox)))
            {
                member.Phone = search.Text;
            }
            else if (new Regex("/[[:alpha:]][[:space:]][[:alpha:]]/g").IsMatch(search.Text))
            {
                member.FName = search.Text.Substring(0, search.Text.IndexOf(" "));
                member.LName = search.Text.Substring(search.Text.IndexOf(" " + 1));
            }

            return member;
        }

        /// <summary>
        /// Event handler for update button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButtonClick(object sender, System.EventArgs e)
        {

            try
            {
                //   this.ValidateFormFields();
                this.ProcessUpdate();
            }
            catch (Exception ex)
            {
                this.errorMessage.Visible = true;
                this.errorMessage.Text = ex.Message;
            }

        }

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
                    this.errorMessage.Visible = true;

                    this.errorMessage.Text = "Member information updated successfully";
                    this.memberSearchDetails = this.membersController.SearchMember(memberUpdateData);
                };
            }
            else
            {
                this.errorMessage.Visible = true;
                this.errorMessage.Text = "No Updates found!!";
            }
        }

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
        /// Event handler for clear button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonClick(object sender, System.EventArgs e)
        {

            try
            {

                if (this.membersController.DeleteMember(this.memberSearchDetails))
                {
                    this.errorMessage.Visible = true;
                    this.errorMessage.Text = "Member deleted  successfully";
                }
                else
                {
                    this.errorMessage.Visible = true;
                    this.errorMessage.Text = "Member deletion failed!!";
                };
            }
            catch (Exception ex)
            {
                this.errorMessage.Visible = true;
                this.errorMessage.Text = ex.Message;
            }

        }

        /// <summary>
        /// Event handler for clear button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClick(object sender, System.EventArgs e)
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
        /// Event handler for register member button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                this.ValidateFormFields();
            }
            catch (Exception ex)
            {
                this.errorMessage.Visible = true;
                this.errorMessage.Text = ex.Message;
            }
        }

        /// <summary>
        /// Event handler for form field text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFieldChanged(object sender, System.EventArgs e)
        {
            this.errorMessage.Visible = false;
        }

        /// <summary>
        /// Validates the required form fields.
        /// </summary>
        private void ValidateFormFields()
        {
            if (this.InvalidInput(this.fnameTextBox, this.GenerateRegexForTextBox(this.fnameTextBox)) ||
                this.InvalidInput(this.lnameTextBox, this.GenerateRegexForTextBox(this.lnameTextBox)))
            {
                throw new Exception("Name should consist of letters and not:\n be empty, include numbers, or special characters");
            }
            else if (this.InvalidInput(this.phoneTextBox, this.GenerateRegexForTextBox(this.phoneTextBox)))
            {
                throw new Exception("Invalid phone number.\n" +
                    "Should use the format XXX-XXX-XXXX");
            }
            else if (this.InvalidInput(this.address1TextBox, this.GenerateRegexForTextBox(this.address1TextBox)))
            {
                throw new Exception("Address 1 cannot be empty: " +
                    "special characters except - and . are prohibited");
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
                    regex = new Regex("/[[:alpha:]]/m");
                    break;
                case "lnameTextBox":
                    regex = new Regex("/[[:alpha:]]/m");
                    break;
                case "phoneTextBox":
                    regex = new Regex("^[0-9]{3}[-][0-9]{3}[-][0-9]{4}$");
                    break;
                case "address1TextBox":
                    regex = new Regex("^[0-9a-zA-Z#&/. -]+$");
                    break;
                case "cityTextBox":
                    regex = new Regex("/[[:alpha:]]/m");
                    break;
                case "stateTextBox":
                    regex = new Regex("^[a-zA-Z]{2}$");
                    break;
                case "zipTextBox":
                    regex = new Regex("^[0-9]{5}$");
                    break;
                default:
                    break;
            }

            return regex;
        }
    }
}
