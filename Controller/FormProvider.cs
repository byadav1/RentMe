using RentMe.View;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as an accessor
    /// of each form.
    /// </summary>
    public class FormProvider
    {
        /// <summary>
        /// Manages MainForm instance.
        /// </summary>
        public static MainForm MainForm
        {
            get
            {
                if (_mainForm == null)
                {
                    _mainForm = new MainForm();
                }
                return _mainForm;
            }
        }
        private static MainForm _mainForm;

        /// <summary>
        /// Manages LoginForm instance.
        /// </summary>
        public static LoginForm LoginForm
            {
                get
                {
                    if (_loginForm == null)
                    {
                        _loginForm = new LoginForm();
                    }
                    return _loginForm;
                }
            }
            private static LoginForm _loginForm;
    }
}
