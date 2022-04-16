using System;
using System.Collections.Generic;
using RentMe.Controller;
using System.Windows.Forms;
using RentMe.Model;
using System.Linq;
namespace RentMe.View
{
    public partial class ViewCartDialog : Form
    {

        private readonly RentCartController _cartController;
        private readonly FurnitureRentController rentController;
        private List<RentFurniture> cartList;
     

        public ViewCartDialog()
        {
            InitializeComponent();
            this._cartController = new RentCartController();
            this.rentController = new FurnitureRentController();
            _ = new List<RentFurniture>();
        }

        private void ViewCartDialog_Load(object sender, EventArgs e)
        {
           
            this.DisplayRentData();
           
        }

        private void DisplayRentData()
        {
            try
            {
                this.rentFurnitureBindingSource.DataSource = null;
                this.rentFurnitureBindingSource.Clear();
                this.cartList = this._cartController.GetRentItem();

                if (this.cartList.Any())
                {
                    this.rentFurnitureBindingSource.DataSource = this.cartList.Select(o => new
                    {
                        o.FurnitureID,
                        o.Name,
                        o.Description,
                        o.Category,
                        o.Style,
                        o.RentalAmount,
                        o.TotalItemRentalAmount,
                        o.FurnitureRentQuantity,
                        o.DueDate
                    }).ToList();
                    this.CalculateTotal();

                }
                else
                {
                    this.submitOrderButton.Enabled = false;
                    this.emptyCartButton.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Displaying the cart items -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CalculateTotal()
        {
            var totalAmountToPay = this.cartList.Sum(cart => cart.TotalItemRentalAmount);
            this.amountLabel.Text = "$" + totalAmountToPay;
            this.submitOrderButton.Enabled = true;
            this.emptyCartButton.Enabled = true;
        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {
            if (!this.cartList.Any())
            {
                return;
            }
            var result = MessageBox.Show("Are you sure want to Submit the Furniture Rental ", "Order submitting",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.rentController.AddFurnituresToRent(this.cartList);
                this.cartList.Clear();
            }
            else
            {
                this.Show();
            }

        }

        private void EmptyCartButton_Click(object sender, EventArgs e)
        {
            if (this.cartList.Any())
            {
                this.cartList.Clear();
                this.rentFurnitureBindingSource.DataSource = null;
                this.cartDataGrideView.DataSource = null;
                this.submitOrderButton.Enabled = false;
                this.amountLabel.Text = "$0.00";

            }

        }

        private void CartDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.cartDataGrideView.Columns[e.ColumnIndex].Name == "DeleteItem")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.cartList.RemoveAt(cartDataGrideView.CurrentCell.RowIndex);
                this.rentFurnitureBindingSource.RemoveCurrent();
                this.CalculateTotal();
            }

        }

    }


}
