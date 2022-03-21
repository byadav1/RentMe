using RentMe.Controller;
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
        /// <summary>
        /// Initializes LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
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
            if (ValidateLogin())
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                errorMessage.Visible = true;
            }
        }

        /// <summary>
        /// Validates usernameTextBox entry for login.
        /// </summary>
        /// <returns>true for valid login</returns>
        private bool ValidateLogin()
        {
            return (usernameTextBox.Text == "Bill") && (passwordTextBox.Text == "password1234");
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
