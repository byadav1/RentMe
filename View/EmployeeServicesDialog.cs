using RentMe.Controller;
using RentMe.Model;
using RentMe.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// This Dialog serves as a services form
    /// to view and update RentMe Employee information.
    /// </summary>
    public partial class EmployeeServicesDialog : Form
    {
        private readonly EmployeesController employeesController;
        private readonly StatesController statesController;
        private Employee employeeSearchDetails;

        /// <summary>
        /// Initialize the form.
        /// </summary>
        /// <param name="isUpdate"></param>
        /// <param name="employee"></param>
        public EmployeeServicesDialog(bool isUpdate, Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            InitializeComponent();
            this.employeesController = new EmployeesController();
            this.statesController = new StatesController();
            this.employeeSearchDetails = employee;
            this.InitializeControls(isUpdate);
        }

        /// <summary>
        /// Initializes the default values
        /// for the form controls.
        /// </summary>
        private void InitializeControls(bool isUpdate)
        {
            this.stateComboBox.DataSource = this.statesController.GetStateNames();

            if (isUpdate)
            {
                this.ToggleFormButtons(true);
                this.SetFields(this.employeeSearchDetails);               
            }
            else
            {
                this.ToggleFormButtons(false);
                this.sexComboBox.SelectedIndex = 0;
                this.stateComboBox.SelectedIndex = 0;
                this.dobPicker.MaxDate = DateTime.Now.AddYears(-18);                
            }
        }

        /// <summary>
        /// Event handler for Add Employee Button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployeeButtonClick(object sender, EventArgs e)
        {
            try
            {
                Employee employee = this.CreateEmployeeFromFormFields();
                if (this.ConfirmEmployeeRegistration(employee) == DialogResult.OK)
                {
                    this.employeesController.RegisterNewEmployee(employee);

                    this.ClearFields();
                    UpdateStatusMessage("Employee registration successfully!\n" +
                   "EmployeeID is " + employee.EmployeeID, false);

                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);
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
            State state = new State
            {
                StateName = this.stateComboBox.GetItemText(this.stateComboBox.SelectedItem)
            };
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
                State = this.statesController.GetStateCode(state).StateCode,
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
            else if (this.InvalidInput(this.zipTextBox, this.GenerateRegexForTextBox(this.zipTextBox)))
            {
                throw new Exception("Zip code cannot be empty and must be five numbers");
            }
            else if (this.InvalidInput(this.usernameTextBox, this.GenerateRegexForTextBox(this.usernameTextBox)))
            {
                throw new Exception("Username must be at least 5 characters:\n" +
                    "special characters except _ are prohibited");
            }
            else if (this.InvalidInput(this.passwordTextBox, this.GenerateRegexForTextBox(this.passwordTextBox))
                && (this.addEmployeeButton.Enabled
                || this.addEmployeeButton.Enabled == false && !String.IsNullOrWhiteSpace(this.passwordTextBox.Text)))
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
                case "zipTextBox":
                    regex = new Regex("^[0-9]{5}$");
                    break;
                case "usernameTextBox":
                    regex = new Regex("^[a-zA-Z0-9_]{5,50}$");
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
        /// Prompts the user to confirm
        /// an update to an Employee's login credentials.
        /// </summary>
        /// <param name="incident"></param>
        private DialogResult ConfirmUpdateEmployeeProfile(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            DialogResult result = MessageBox.Show("Are you sure you want to update the profile of:\n" +
                employee.FName + " " + employee.LName + "?",
                "Confirm Employee Profile Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
        }

        /// <summary>
        /// Prompts the user to confirm
        /// an update to an Employee's login credentials.
        /// </summary>
        /// <param name="incident"></param>
        private DialogResult ConfirmUpdateEmployeeLogin(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            DialogResult result = MessageBox.Show("Are you sure you want to update login credentials for:\n" +
                employee.FName + " " + employee.LName + "?",
                "Confirm Employee Login Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
        }

        /// <summary>
        /// Event handler for clear button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClick(object sender, EventArgs e)
        {
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
                    else if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
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
            State state = new State
            {
                StateCode = employee.State
            };
            this.fnameTextBox.Text = employee.FName;
            this.lnameTextBox.Text = employee.LName;
            this.sexComboBox.SelectedIndex = this.sexComboBox.FindStringExact(employee.Sex);
            this.phoneTextBox.Text = employee.Phone;
            this.dobPicker.Value = employee.DOB;
            this.address1TextBox.Text = employee.Address1;
            this.address2TextBox.Text = employee.Address2;
            this.cityTextBox.Text = employee.City;
            this.stateComboBox.SelectedIndex = this.stateComboBox.FindStringExact(this.statesController.GetStateName(state).StateName);
            this.zipTextBox.Text = employee.Zip;
            this.usernameTextBox.Text = employee.Username;
            if (employee.Type == "Admin")
            {
                this.isAdministratorCheckBox.Checked = true;
            }
            else
            {
                this.isAdministratorCheckBox.Checked = false;
            }

            this.DisplayEmployeeActiveStatus();           
            this.DisableEmployeeData(this.employeeSearchDetails.Active);
        }

        /// <summary>
        /// Disable all text fileds if employee is not an active employee
        /// </summary>
        private void DisableEmployeeData(bool isEditable)
        {
            if (!isEditable)
            {
                this.UpdateStatusMessage("Only active employees can receive profile updates", false);
            }
            this.fnameTextBox.Enabled = isEditable;
            this.lnameTextBox.Enabled = isEditable;
            this.sexComboBox.Enabled = isEditable;
            this.phoneTextBox.Enabled = isEditable;
            this.dobPicker.Enabled = isEditable;
            this.address1TextBox.Enabled = isEditable;
            this.address2TextBox.Enabled = isEditable;
            this.cityTextBox.Enabled = isEditable;
            this.stateComboBox.Enabled = isEditable;
            this.zipTextBox.Enabled = isEditable;
            this.usernameTextBox.Enabled = isEditable;
            this.activeCheckBox.Enabled = isEditable;
            this.updateProfileButton.Enabled = isEditable;
            this.isAdministratorCheckBox.Enabled = isEditable;
            this.updateLoginButton.Enabled = isEditable;
            this.passwordTextBox.Enabled = isEditable;
            this.clearButton.Enabled = isEditable;
        }

        /// <summary>
        ///Dipslay employee status
        /// </summary>
        private void DisplayEmployeeActiveStatus()
        {
            if (employeeSearchDetails.Active)
            {
                this.activeCheckBox.Checked = true;
                this.toggleActiveButton.Text = "Mark Inactive";
            }
            else
            {
                this.activeCheckBox.Checked = false;
                this.toggleActiveButton.Text = "Mark Active";
            }
        }

        /// <summary>
        /// Enables, disables buttons based on state of the form.
        /// </summary>
        private void ToggleFormButtons(bool enabled)
        {
            this.updateProfileButton.Enabled = enabled;
            this.toggleActiveButton.Enabled = enabled;
            this.updateLoginButton.Enabled = enabled;
            this.addEmployeeButton.Enabled = !enabled;
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
        private void ToggleActiveButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                Employee employeeUpdateData = this.ReadData();
                // Check for change in Employees table before execution
                if (this.CheckUpdates(employeeUpdateData))
                {
                    this.UpdateStatusMessage("We see there is a change in the data. Employee active status cannot be updated.\n" +
                        "Please save your changes and then delete an employee", true);
                    return;
                }

                // Delete operation
                string message;
                if (this.employeesController.DeleteOrRestoreEmployee(this.employeeSearchDetails))
                {
                    if (this.employeeSearchDetails.Active)
                    {
                        message = "Employee restored successfully";
                    }
                    else
                    {
                        message = "Employee deactivated successfully";
                    }
                    this.UpdateStatusMessage(message, false);
                    this.DisplayEmployeeActiveStatus();
                    this.DisableEmployeeData(this.employeeSearchDetails.Active);
                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        /// <summary>
        /// Event handler for Update Profile button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateProfileButtonClick(object sender, EventArgs e)
        {
            try
            {
                Employee employeeUpdateData = this.ReadData();
                //detect the change in username and passoerd field
                if (this.CheckPasswordOrUserNameUpdate(employeeUpdateData))
                {
                    this.UpdateStatusMessage("Username and password has to be changed using Update Login", true);
                    return;
                }
                this.ValidateFormFields();

                if (this.CheckUpdates(employeeUpdateData) && this.ConfirmUpdateEmployeeProfile(employeeUpdateData) == DialogResult.OK)
                {
                    if (this.employeesController.UpdateEmployeeInformation(this.employeeSearchDetails, employeeUpdateData))
                    {
                        this.RefreshEmployeeUpdate(employeeUpdateData);

                        this.UpdateStatusMessage("Employee information updated successfully", false);

                    }
                    else
                    {
                        this.UpdateStatusMessage("Employee information cannot be updated.\n" +
                            "Something went wrong with the process or employee data is updated at the backend", true);
                    };
                }

                else
                {
                    this.UpdateStatusMessage("No changes detected for employee profile", true);
                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);
            }
            catch (Exception ex)
            {

                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        private void RefreshEmployeeUpdate(Employee employeeUpdateData)
        {
            List<Employee> employeeData = this.employeesController.GetEmployeesFromSearch(employeeUpdateData);
            if (employeeData.Count == 1)
            {
                this.employeeSearchDetails = employeeData[0];
                this.SetFields(employeeData[0]);
            }
        }


        /// <summary>
        /// Read change in data for an employeee
        /// </summary>
        /// <returns></returns>
        private Employee ReadData()
        {
            State state = new State
            {
                StateName = this.stateComboBox.GetItemText(this.stateComboBox.SelectedItem)
            };
            string employeeType = "Regular";
            if (isAdministratorCheckBox.Checked)
            {
                employeeType = "Admin";
            }
            Employee employeeUpdateData =
                new Employee()
                {
                    EmployeeID = this.employeeSearchDetails.EmployeeID,
                    FName = this.fnameTextBox.Text,
                    LName = this.lnameTextBox.Text,
                    DOB = this.dobPicker.Value,
                    Sex = this.sexComboBox.Text,
                    Phone = this.phoneTextBox.Text,
                    Address1 = this.address1TextBox.Text,
                    Address2 = this.address2TextBox.Text,
                    City = this.cityTextBox.Text,
                    Zip = this.zipTextBox.Text,
                    State = this.statesController.GetStateCode(state).StateCode,
                    Username = this.usernameTextBox.Text,
                    Type = employeeType,
                    Password = this.passwordTextBox.Text
                };
            return employeeUpdateData;
        }


        /// <summary>
        /// Check if the any of the data has changed to update
        /// </summary>
        /// <param name="employeeUpdateData"></param>
        /// <returns></returns>
        private bool CheckUpdates(Employee employeeUpdateData)
        {
            List<Employee> lstOld_employeeData = new List<Employee>();
            List<Employee> lstNew_employeeData = new List<Employee>();
            bool isModified = false;
            lstOld_employeeData.Add(this.employeeSearchDetails);
            lstNew_employeeData.Add(employeeUpdateData);
            if (lstOld_employeeData.Count > 0 && lstNew_employeeData.Count > 0)
            {


                var result = lstNew_employeeData.Where(l2 =>
                      lstOld_employeeData.Any(l1 => l2.EmployeeID == l1.EmployeeID
                              && ((!String.Equals(l1.FName, l2.FName, StringComparison.OrdinalIgnoreCase)) ||
                              (!String.Equals(l1.LName, l2.LName, StringComparison.OrdinalIgnoreCase)) ||
                             l1.DOB != l2.DOB ||
                              l1.Phone != l2.Phone ||
                               (!String.Equals(l1.Sex, l2.Sex, StringComparison.OrdinalIgnoreCase)) ||
                                (!String.Equals(l1.Address1, l2.Address1, StringComparison.OrdinalIgnoreCase)) ||
                             (!String.Equals(l1.Address2, l2.Address2, StringComparison.OrdinalIgnoreCase)) ||
                               (!String.Equals(l1.City, l2.City, StringComparison.OrdinalIgnoreCase)) ||
                               l1.Zip != l2.Zip
                              || (!String.Equals(l1.Type, l2.Type, StringComparison.OrdinalIgnoreCase))
                              )));

                isModified = result.Any();
            }

            return isModified;
        }

        /// <summary>
        /// Event handler for changing Active CheckBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this.activeCheckBox.Checked = !this.activeCheckBox.Checked;
        }

        /// <summary>
        /// Password change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateLoginButtonClick(object sender, EventArgs e)
        {
            try
            {
                Employee employeeUpdateData = this.ReadData();
                if (this.CheckUpdates(employeeUpdateData))
                {
                    this.UpdateStatusMessage("We see changes in Employee profile data.\n Please update the employee profile data using Update Profile ", true);
                    return;
                }
                if (string.IsNullOrEmpty(this.usernameTextBox.Text) && string.IsNullOrEmpty(this.passwordTextBox.Text))
                {
                    this.UpdateStatusMessage("Please enter a valid username or passsword ", true);
                    return;
                }

                if (this.CheckPasswordOrUserNameUpdate(employeeUpdateData) && this.ConfirmUpdateEmployeeLogin(employeeUpdateData) == DialogResult.OK)
                {
                    if (this.employeesController.UpdateEmployeeUserNameORPassword(this.employeeSearchDetails, employeeUpdateData))
                    {
                        this.passwordTextBox.Text = "";
                        this.RefreshEmployeeUpdate(employeeUpdateData);
                        this.UpdateStatusMessage("Employee login updated successfully", false);
                    }
                    else
                    {
                        this.UpdateStatusMessage("Employee login update cannot be perfomed.\n" +
                            "Something went wrong with the process or employee data is updated at the backend", true);
                    };
                }
                else
                {
                    this.UpdateStatusMessage("No changes detected in employee username or password. Pleaes note Password cannot be same as previous password.", true);
                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        /// <summary>
        /// Check if passoword changed from existing
        /// </summary>
        /// <param name="employeeUpdateData"></param>
        /// <returns></returns>
        private bool CheckPasswordOrUserNameUpdate(Employee employeeUpdateData)
        {
            if (this.InvalidInput(this.usernameTextBox, this.GenerateRegexForTextBox(this.usernameTextBox)))
            {
                throw new Exception("Username must be at least 5 characters:\n" +
                    "special characters except _ are prohibited");
            }
            else if (this.InvalidInput(this.passwordTextBox, this.GenerateRegexForTextBox(this.passwordTextBox))
                 && (this.addEmployeeButton.Enabled
                 || this.addEmployeeButton.Enabled == false && !String.IsNullOrWhiteSpace(this.passwordTextBox.Text)))
            {
                throw new Exception("Password must be between 8-20 characters: " +
                    "must contain at least one Uppercase, Lowercase letter, one number, and valid special character ! @ _ - [ ] ?");
            }

            if (!string.IsNullOrEmpty(employeeUpdateData.Password))
            {
                return this.employeesController.Checkpassword(this.employeeSearchDetails, employeeUpdateData);
            }

            return this.employeeSearchDetails.Username != employeeUpdateData.Username;
        }

        /// <summary>
        /// Event Handler for Close button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            GC.Collect();
        }

        /// <summary>
        /// Event Handler for Form close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeServicesDialogFormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            GC.Collect();
        }
    }
}
