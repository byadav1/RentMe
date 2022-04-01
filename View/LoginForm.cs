using RentMe.Controller;
using RentMe.Model;
using RentMe.View;
using System;
using System.Windows.Forms;

namespace RentMe
{
    /// <summary>
    /// This form serves as a login 
    /// for the RentMe employee application.
    /// </summary>
    public partial class LoginForm : Form
    {

        private readonly EmployeesController employeesController;
        /// <summary>
        /// Initializes LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.employeesController = new EmployeesController();
        }

        /// <summary>
        /// Hides errorMessage when login info changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginTextBoxTextChangedEventHandle(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        /// <summary>
        /// Validates username and password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButtonClickEventHandle(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee
                {
                    Username = this.usernameTextBox.Text,
                    Password = this.passwordTextBox.Text,
                    
                };
                if (ValidLogin(employee))
                {
                    new MainForm(employee).Show();
                    this.Hide();
                }
            }
            catch (ArgumentException ae)
            {
                this.errorMessage.Visible = true;
                this.errorMessage.Text = ae.Message;
            }
        }

        /// <summary>
        /// Validates usernameTextBox entry for login.
        /// </summary>
        /// <returns>true for valid login</returns>
        private bool ValidLogin(Employee employee)
        {
            return this.employeesController.ValidEmployeeLogin(employee);
        }

        /// <summary>
        /// Closes the application upon form closure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginFormClosedEventHandle(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
