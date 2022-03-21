using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class RegisterMemberForm : Form
    {
        public RegisterMemberForm()
        {
            InitializeComponent();
            this.InitializeControls();
            
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
        /// Event handler for register button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.ValidateFormFields();
            } catch (Exception ex)
            {
                this.errorMessage.Visible = true;
                this.errorMessage.Text = ex.Message;
            }
        }

        /// <summary>
        /// Hides errorMessage when input changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlValueChangedEventHandle(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
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
                    regex = new Regex("^[0-9]{3}[-][0-9]{3}[-][0-9]{4}$");
                    break;
                case "address1TextBox":
                    regex = new Regex("^[0-9a-zA-Z#&/. -]+$");
                    break;
                case "cityTextBox":
                    regex = new Regex("^[a-zA-Z]+$");
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
        /// Event handle for clear button click.
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
        /// Event handler for cancel button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, System.EventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }
    }
}
