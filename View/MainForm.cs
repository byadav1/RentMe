using RentMe.Controller;
using System;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// This form serves as the main hub
    /// for the RentMe application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the application upon form closure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormClosedEventHandle(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        /// <summary>
        /// Logs the user out and returns to LoginForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutLinkClickedEventHandle(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormProvider.LoginForm.Show();
            this.Dispose();
            GC.Collect();
        }
    }
}
