using RentMe.Controller;
using RentMe.Model;
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
        private Employee loginUser;
        private readonly EmployeesController employeeController;

        public MainForm()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// Initializes MainForm with login user
        /// </summary>
        public MainForm(Employee currentLoginUser)
        {
            InitializeComponent();
            this.loginUser = currentLoginUser;
            this.employeeController = new EmployeesController();
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

        /// <summary>
        /// Event handler for form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormLoad(object sender, EventArgs e)
        {
            try
            {
                this.loginUser = this.employeeController.GetCurrentEmployeeData(this.loginUser);
                if (this.loginUser != null)
                {
                    this.currentUserLabel.Text = "Welcome, " + this.loginUser.FName + " " + this.loginUser.LName +
                        "!\nUsername: " + this.loginUser.Username;                   
                }
                if (this.loginUser.Type == "Regular")
                {
                    this.mainTabControl.TabPages.Remove(this.searchEmployeeTabPage);
                }
                else
                {
                    this.mainTabControl.TabPages.Remove(this.searchMemberTabPage);
                    this.mainTabControl.TabPages.Remove(this.furnitureSearchTabPage);
                    this.mainTabControl.TabPages.Remove(this.viewTransactionsTabPage);
                }

            }
            catch (Exception exe)
            {
                MessageBox.Show("Application load failed", "Error ocured: " + exe.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event Handler for Tab Index changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.mainTabControl.SelectedTab.Text)
            {
                case "Search Member":
                    this.memberSearch.RefreshControl();
                    break;
                case "Search Employee":
                    this.employeeSearch.RefreshControl();
                    break;
                case "Search Furniture":
                    break;
                case "View Rentals":
                    this.viewTransactions.RefreshControl();
                    break;
                default:
                    break;
            }
        }
    }
}
