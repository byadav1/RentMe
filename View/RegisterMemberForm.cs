using System;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class RegisterMemberForm : Form
    {
        public RegisterMemberForm()
        {
            InitializeComponent();
            this.InitializeControls();
            
        }

        /// <summary>
        /// Initializes the default values
        /// for the form controls.
        /// </summary>
        private void InitializeControls()
        {
            this.sexComboBox.SelectedIndex = 0;
            this.dobPicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        /// <summary>
        /// Event handler for register button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButtonClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handle for clear button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClick(object sender, System.EventArgs e)
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
                    else
                    {
                        func(control.Controls);
                    }
            }

            func(Controls);           
        }

        /// <summary>
        /// Event handler for cancel button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hides errorMessage when input changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlValueChangedEventHandle(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }
    }
}
