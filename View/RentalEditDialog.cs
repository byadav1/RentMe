
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
           
        }

        private bool ValidateValues()
        {
            if (currentQuantity ==this.rentQuantityTextBox.Text && 
                this.rentDateTimePicker.Value == currenDueDate)
            {
                MessageBox.Show("No change detected in Quantity or Due date");
                return false;
            }
            else if (this.rentDateTimePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("Dues date cannot be today or less than currnet date ");
                return false;
            }

            return true;


        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
