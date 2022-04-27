using RentMe.Controller;
using RentMe.Model;
using RentMe.View;
using System;
using RentMe.Crypto;
using System.Drawing;
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
                    Password = PasswordHash.GetSha256Hash(this.passwordTextBox.Text),

                };
                if (true)
                {
                    new MainForm(employee).Show();
                    this.passwordTextBox.Clear();
                    this.Hide();
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
        /// Validates usernameTextBox entry for login.
        /// </summary>
        /// <returns>true for valid login</returns>
        private bool ValidLogin(Employee employee)
        {
            return this.employeesController.ValidEmployeeLogin(employee);
        }

        /// <summary>
        /// Event Handler for login fields changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginTextBoxTextChangedEventHandle(object sender, EventArgs e)
        {
            this.UpdateStatusMessage("Username and password are case-sensitive", false);
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
