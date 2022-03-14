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
        private void LoginFormClosedEventHandle(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
