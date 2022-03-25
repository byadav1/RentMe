using RentMe.Controller;
using RentMe.Model;
using RentMe.Validators;
using System;
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
                if (this.membersController.ValidMemberSearch(member))
                {
                    member = this.membersController.GetMemberFromSearch(member);                   
                    this.ToggleFormButtons(true);
                    this.SetFields(member);
                }
            }
            catch(ArgumentException ae)
            {
                this.errorMessage.Visible = true;
                this.errorMessage.Text = ae.Message;
                this.ToggleFormButtons(false);
            }        
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
        /// Event handler for update button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButtonClick(object sender, System.EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for clear button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonClick(object sender, System.EventArgs e)
        {

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
                    "Should consist of numbers and be in XXX-XXX-XXXX format");
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
                    regex = new Regex("[a-zA-Z]");
                    break;
                case "lnameTextBox":
                    regex = new Regex("[a-zA-Z]");
                    break;
                case "phoneTextBox":
                    regex = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
                    break;
                case "address1TextBox":
                    regex = new Regex("^[0-9a-zA-Z#&/. -]+$");
                    break;
                case "cityTextBox":
                    regex = new Regex("[a-zA-Z]");
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
    }
}
