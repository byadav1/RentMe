
using System;
using System.Windows.Forms;

namespace RentMe.View
{

    /// <summary>
    /// The dailog  provides user an option to change teh due date and quantity of an item available in the cart
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RentalEditDialog : Form
    {

        public static string NewQuantity  { get; set; }
        public static DateTime NewDueDate { get; set; }

        private readonly string currentQuantity;
        private readonly DateTime currenDueDate;

        public RentalEditDialog()
        {
           
          
        }
        public RentalEditDialog(string quantitydata,DateTime dueDateUpdate)
        {
            InitializeComponent();
            currentQuantity = quantitydata;
            currenDueDate = dueDateUpdate;
            this.rentQuantityTextBox.Text = quantitydata;
            this.rentDateTimePicker.Value = dueDateUpdate;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ValidateValues())
            {
                NewQuantity = this.rentQuantityTextBox.Text;
                NewDueDate = this.rentDateTimePicker.Value;
            }
            else
            {
                MessageBox.Show("No change in Quantity or Due date");

            }
        }

        private bool ValidateValues()
        {
            if (currentQuantity ==this.rentQuantityTextBox.Text && 
                this.rentDateTimePicker.Value == currenDueDate)
            {                
                return false;
            }

            return true;


        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
