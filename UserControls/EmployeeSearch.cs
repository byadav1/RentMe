using RentMe.Controller;
using RentMe.Model;
using RentMe.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// This UserControl models a search form
    /// which will allow the user to view registered
    /// RentMe Employees. This UserControl also directs
    /// the user to register a new Employee or edit
    /// an existing Employee's information.
    /// </summary>
    public partial class EmployeeSearch : UserControl
    {
        private readonly EmployeesController employeesController;
        private List<Employee> employeeSearchResults;

        /// <summary>
        /// Initialize the UserControl.
        /// </summary>
        public EmployeeSearch()
        {
            InitializeComponent();
            this.employeesController = new EmployeesController();
            this.RefreshControl();
        }

        /// <summary>
        /// Refreshes the DataGridView to display
        /// all RentMe Employees.
        /// </summary>
        public void RefreshControl()
        {
            List<Employee> employees = this.employeesController.GetEmployees();
            this.DisplayEmployeesList(employees);
            this.viewAllEmployeesButton.Enabled = false;
            this.searchEmployeeTextBox.Clear();
        }

        /// <summary>
        /// Event Handler for Search button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButtonClick(object sender, EventArgs e)
        {
            try
            {
                Employee employee = this.CreateEmployeeFromSearch();
                if (this.employeesController.ValidEmployeeSearch(employee))
                {
                    this.employeeSearchResults = this.employeesController.GetEmployeesFromSearch(employee);
                    this.DisplayEmployeesList(this.employeeSearchResults);
                    this.viewAllEmployeesButton.Enabled = true;
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
        /// Event handler for Update button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.employeeDataGridView.SelectedRows[0];
                Employee employee = new Employee
                {
                    EmployeeID = Convert.ToInt32(row.Cells["employeeID"].Value),
                    FName = row.Cells["fname"].Value.ToString(),
                    LName = row.Cells["lname"].Value.ToString(),
                    DOB = (DateTime)row.Cells["dob"].Value,
                    Phone = row.Cells["phone"].Value.ToString(),
                    Sex = row.Cells["sex"].Value.ToString(),
                    Address1 = row.Cells["address1"].Value.ToString(),
                    Address2 = row.Cells["address2"].Value.ToString(),
                    City = row.Cells["city"].Value.ToString(),
                    State = row.Cells["state"].Value.ToString(),
                    Zip = row.Cells["zip"].Value.ToString(),
                    Username = row.Cells["username"].Value.ToString(),
                    Type = row.Cells["type"].Value.ToString(),
                    Active = Convert.ToBoolean(row.Cells["active"].Value.ToString())
                };
                
                Form employeeServicesDialog = new EmployeeServicesDialog(true, employee);
                Form owner = ((Form)this.TopLevelControl);
                owner.Hide();
                this.statusMessage.Visible = false;
                DialogResult result = employeeServicesDialog.ShowDialog();              
                if (result == DialogResult.OK)
                {
                    owner.Show();
                    this.RefreshControl();                    
                }
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }

        }

        /// <summary>
        /// Event Handler for Register employee button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButtonClick(object sender, EventArgs e)
        {
            Form owner = ((Form)this.TopLevelControl);
            Form employeeServicesDialog = new EmployeeServicesDialog(false, new Employee());
            owner.Hide();
            this.statusMessage.Visible = false;
            DialogResult result = employeeServicesDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                owner.Show();
                this.RefreshControl();
            }
        }

        /// <summary>
        /// Event Handler for View All Employees button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAllEmployeesButtonClick(object sender, EventArgs e)
        {
            this.RefreshControl();
            this.statusMessage.Visible = false;
        }

        /// <summary>
        /// Display all RentMe employees.
        /// </summary>
        private void DisplayEmployeesList(List<Employee> employees)
        {
            if (employees == null)
            {
                throw new ArgumentException("Employees list cannot be null");
            }
            if (employees.Count < 1)
            {
                throw new ArgumentException("No RentMe employees exist");
            }
            else
            {
                this.employeeBindingSource.Clear();
                this.employeeBindingSource.DataSource = employees;
                this.DecorateDataGridView();
                this.updateButton.Enabled = true;
            }
        }

        /// <summary>
        /// Configures the appearance of Employees DataGridView.
        /// </summary>
        private void DecorateDataGridView()
        {
            foreach (DataGridViewRow row in this.employeeDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["active"].Value))
                {
                    if (string.Equals(row.Cells["type"].Value.ToString(), "Admin"))
                    {
                        row.DefaultCellStyle.BackColor = Color.PowderBlue;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    }
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                }
            }
        }

        /// <summary>
        /// Takes input from the search field
        /// and returns a Member.
        /// </summary>
        /// <returns></returns>
        private Employee CreateEmployeeFromSearch()
        {
            Employee employee = new Employee();
            TextBox search = this.searchEmployeeTextBox;
            if (search.Text == "")
            {
                throw new ArgumentException("Member search field cannot be empty");
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
        /// Event Handler for TextField text changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchEmployeeTextBoxTextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.searchEmployeeTextBox.Text))
            {
                this.searchButton.Enabled = false;
            }
            else
            {
                this.searchButton.Enabled = true;
            }

            this.statusMessage.Visible = false;
        }
    }
}
