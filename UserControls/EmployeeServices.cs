using RentMe.Controller;
using RentMe.Model;
using RentMe.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// This UserControl models a form
    /// which will enable the update, deletion,
    /// or registration of a RentMe employee
    /// </summary>
    public partial class EmployeeServices : UserControl
    {
        private readonly EmployeesController employeesController;
        private Employee employee;

        /// <summary>
        /// Initialize the control.
        /// </summary>
        public EmployeeServices()
        {
            InitializeComponent();
            this.InitializeControls();
            this.employeesController = new EmployeesController();
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
        private void SearchButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.employee = this.CreateEmployeeFromSearch();
                if (this.employeesController.ValidEmployeeSearch(this.employee))
                {
                    this.employee = this.employeesController.GetEmployeeFromSearch(this.employee);
                    this.ToggleFormButtons(true);
                    this.SetFields(this.employee);
                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);
                this.ToggleFormButtons(false);
            }
        }

        /// <summary>
        /// Takes input from the search field
        /// and returns a Member.
        /// </summary>
        /// <returns>Employee with assigned attributes</returns>
        private Employee CreateEmployeeFromSearch()
        {
            Employee employee = new Employee();
            TextBox search = this.searchEmployeeTextBox;
            if (search.Text == "")
            {
                throw new ArgumentException("Employee search field cannot be empty");
            }
            else if (new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$").IsMatch(search.Text))
            {
                employee.Phone = search.Text;

            }
            else if (new Regex("[a-zA-Z] [a-zA-Z]").IsMatch(search.Text))
            {
                employee.FName = search.Text.Substring(0, search.Text.IndexOf(" "));
                employee.LName = search.Text.Substring(search.Text.IndexOf(" ") + 1);
            }
            else if (Int32.TryParse(search.Text, out int employeeID))
            {
                employee.EmployeeID = employeeID;
            }

            return employee;
        }

        /// <summary>
        /// Event handler for register employee button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButtonClick(object sender, EventArgs e)
        {
            try
            {
                Employee employee = this.CreateEmployeeFromFormFields();
                if (this.ConfirmEmployeeRegistration(employee) == DialogResult.OK)
                {
                    this.employeesController.RegisterNewEmployee(employee);
                    UpdateStatusMessage("Employee registration successfully!\n" +
                    "EmployeeID is " + employee.EmployeeID, false);
                    this.ToggleFormButtons(true);
                }
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        /// <summary>
        /// Creates a new Employee using validated
        /// form fields.
        /// </summary>
        /// <returns>Employee object from fields</returns>
        private Employee CreateEmployeeFromFormFields()
        {
            this.ValidateFormFields();
            Employee employee = new Employee()
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
                Zip = this.zipTextBox.Text,
                Username = this.usernameTextBox.Text,
                Password = this.passwordTextBox.Text
            };
            if (this.isAdministratorCheckBox.Checked)
            {
                employee.Type = "Admin";
            }
            else
            {
                employee.Type = "Regular";
            }

            return employee;
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
                throw new Exception("Invalid phone number:\n" +
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
            else if (this.InvalidInput(this.usernameTextBox, this.GenerateRegexForTextBox(this.usernameTextBox)))
            {
                throw new Exception("Username must be at least 8 characters:\n" +
                    "special characters except _ are prohibited");
            }
            else if (this.InvalidInput(this.passwordTextBox, this.GenerateRegexForTextBox(this.passwordTextBox)))
            {
                throw new Exception("Password must be between 8-20 characters: " +
                    "must contain at least one Uppercase, Lowercase letter, one number, and valid special character ! @ _ - [ ] ?");
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
        /// <returns>Regex assigned to TextBox case</returns>
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
                    regex = new Regex("^[0-9a-zA-Z#&\\/. -]+$");
                    break;
                case "cityTextBox":
                    regex = new Regex("^[a-zA-Z ]+$");
                    break;
                case "stateTextBox":
                    regex = new Regex("^[a-zA-Z]{2}$");
                    break;
                case "zipTextBox":
                    regex = new Regex("^[0-9]{5}$");
                    break;
                case "usernameTextBox":
                    regex = new Regex("^[a-zA-Z0-9_]{8,50}$");
                    break;
                case "passwordTextBox":
                    regex = new Regex("^(?:(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@_\\-\\[\\]\\?]).*)[a-zA-Z0-9!@_\\[\\]\\?]{8,20}$");
                    break;
                default:
                    break;
            }

            return regex;
        }

        /// <summary>
        /// Prompts the user to confirm
        /// that they want to register a RentMe employee.
        /// </summary>
        /// <param name="incident"></param>
        private DialogResult ConfirmEmployeeRegistration(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            DialogResult result = MessageBox.Show("Are you sure you want to register new RentMe employee:\n" +
                employee.FName + " " + employee.LName + "?",
                "Confirm Employee Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
        }

        /// <summary>
        /// Event handler for clear button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClick(object sender, EventArgs e)
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
        /// Set form fields to reflect Employee information
        /// </summary>
        /// <param name="employee"></param>
        private void SetFields(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            this.fnameTextBox.Text = employee.FName;
            this.lnameTextBox.Text = employee.LName;
            this.sexComboBox.SelectedIndex = this.sexComboBox.FindStringExact(employee.Sex);
            this.phoneTextBox.Text = employee.Phone;
            this.dobPicker.Value = employee.DOB;
            this.address1TextBox.Text = employee.Address1;
            this.address2TextBox.Text = employee.Address2;
            this.cityTextBox.Text = employee.City;
            this.stateTextBox.Text = employee.State;
            this.zipTextBox.Text = employee.Zip;
            this.usernameTextBox.Text = employee.Username;
            
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
        /// Event handler for clear button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, System.EventArgs e)
        {

            try
            {
                Employee employeeUpdateData = this.ReadData();
                // check if there is an update with employee data
                if (this.CheckUpdates(employeeUpdateData))
                {
                    this.UpdateStatusMessage("We see there is a change in data.Employee deletion cannot be perfomed." +
                        "Please save your changes and then delete an employee", true);
                    return;
                }
                //Delete operation
                if (this.employeesController.DeleteEmployee(this.employee))
                {
                    this.UpdateStatusMessage("Employee deleted successfully", false);                   
                }
                else
                {
                    this.UpdateStatusMessage("Employee deletion failed at database transaction.", true);
                };
            }
            catch (Exception ex)
            {
                this.statusMessage.Visible = true;
                this.statusMessage.Text = ex.Message;
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
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


        private void ProcessUpdate()
        {
            Employee employeeUpdateData =this.ReadData();
            if (this.CheckUpdates(employeeUpdateData))
            {
                if (this.employeesController.UpdateEmployeeInformation(this.employee, employeeUpdateData))
                {
              
                    this.UpdateStatusMessage("Employee information updated successfully", false);
                    this.employee = this.employeesController.GetEmployeeFromSearch(employeeUpdateData);
                }
                else
                {
                    this.UpdateStatusMessage("Employee information cannot be perfomed." +
                        "Something went wrong with the process or employee data is updated at the backend", true);

                };
            }
            else
            {
                this.UpdateStatusMessage("No changes done on employee data!!", true);
               
            }
        }

        private Employee ReadData()
        {

            string employeeType = "Regular";
            if (isAdministratorCheckBox.Checked)
            {
                employeeType = "Admin";
            }
            Employee employeeUpdateData =
                new Employee()
                {
                    EmployeeID = this.employee.EmployeeID,
                    FName = this.fnameTextBox.Text,
                    LName = this.lnameTextBox.Text,
                    DOB = this.dobPicker.Value,
                    Sex = this.sexComboBox.Text,
                    Phone = this.phoneTextBox.Text,
                    Address1 = this.address1TextBox.Text,
                    Address2 = this.address2TextBox.Text,
                    City = this.cityTextBox.Text,
                    Zip = this.zipTextBox.Text,
                    State = this.stateTextBox.Text,
                    Username = this.usernameTextBox.Text,
                    Type = employeeType
                };
            return employeeUpdateData;
        }
        private bool CheckUpdates(Employee employeeUpdateData)
        {
            List<Employee> lstOld_employeeData = new List<Employee>();
            List<Employee> lstNew_employeeData = new List<Employee>();
            bool isModified = false;
            lstOld_employeeData.Add(this.employee);
            lstNew_employeeData.Add(employeeUpdateData);
            if (lstOld_employeeData.Count > 0 && lstNew_employeeData.Count > 0)
            {
                var result = lstNew_employeeData.Where(l2 =>
                      lstOld_employeeData.Any(l1 => l2.EmployeeID == l1.EmployeeID
                              && (l1.FName != l2.FName || l1.LName != l2.LName ||
                             l1.DOB != l2.DOB ||
                              l1.Phone != l2.Phone ||
                              l1.Sex != l2.Sex || l1.Address1 != l2.Address1 ||
                              l1.Address2 != l2.Address2 || l1.State != l2.State ||
                              l1.City != l2.City || l1.Zip != l2.Zip || l1.Username != l2.Username 
                              || l1.Type != l2.Type
                              )));
                isModified = result.Any();

            }

            return isModified;
        }

    }
}
