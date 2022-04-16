using System;
using System.Collections.Generic;
using System.ComponentModel;
using RentMe.Controller;
using System.Windows.Forms;
using RentMe.Model;
using System.Linq;
using System.Drawing;

namespace RentMe.View
{
    public partial class ViewCartDialog : Form
    {

        private RentCartController cartController;
        private FurnitureRentController rentController;
        private List<RentFurniture> cartList;
        private Member rentMember;

        public ViewCartDialog(Member member)
        {
            InitializeComponent();
            this.rentMember = member;
            this.cartController = new RentCartController();
            this.rentController = new FurnitureRentController();
            _ = new List<RentFurniture>();
        }

        private void ViewCartDialog_Load(object sender, EventArgs e)
        {
            this.cartDataGrideView.ReadOnly = false;
            this.DisplayRentData();
            foreach (DataGridViewColumn dc in this.cartDataGrideView.Columns)
            {
                if (!dc.Index.Equals(7) && !dc.Index.Equals(8))
                {
                    dc.ReadOnly = true;
                }
                else
                {
                    dc.ReadOnly = false;
                    dc.DefaultCellStyle.ForeColor = Color.Blue;
                    dc.DefaultCellStyle.ForeColor = Color.Blue;
                }

            }
        }

        private void DisplayRentData()
        {
            try
            {
                this.rentFurnitureBindingSource.DataSource = null;
                this.rentFurnitureBindingSource.Clear();
                this.cartList = this.cartController.GetRentItem();

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
}
