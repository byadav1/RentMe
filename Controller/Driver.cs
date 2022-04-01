using RentMe.Controller;
using System;
using System.Windows.Forms;

namespace RentMe
{
    /// <summary>
    /// This is the entry point of the application.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormProvider.LoginForm);

           // Application.Run(new View.MainForm());
        }
    }
}
