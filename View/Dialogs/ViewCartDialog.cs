using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace RentMe.View
{
    /// <summary>
    /// This form models a Dialog which
    /// displays the cart for a
    /// furniture rental item.
    /// </summary>>
    public partial class ViewCartDialog : Form
    {
        private readonly RentCartController _cartController;
        private readonly FurnitureRentController rentController;
        private readonly Member member;
        private List<RentFurniture> cartList;
        private List<ReceiptItem> receiptList;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewCartDialog"/> class.
        /// </summary>
        /// <param name="searchMember">The search member.</param>
        public ViewCartDialog(Member searchMember)
        {
            InitializeComponent();
            this._cartController = new RentCartController();
            this.rentController = new FurnitureRentController();
            _ = new List<ReceiptItem>();
            this.member = searchMember;
            _ = new List<RentFurniture>();

        }

        /// <summary>
        /// Event Handler for Dialog load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewCartDialogLoad(object sender, EventArgs e)
        {
            this.DisplayRentData();
        }

        /// <summary>
        /// Displays the rent data.
        /// </summary>
        private void DisplayRentData()
        {
            try
            {
                this.rentFurnitureBindingSource.DataSource = null;
                this.rentFurnitureBindingSource.Clear();
                this.cartList = this._cartController.GetRentItem(this.member);

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
                        o.AvailableQunatity,
                        o.TotalItemRentalAmount,
                        o.FurnitureRentQuantity,
                        o.DueDate
                    }).ToList();
                    this.CalculateTotal();
                    this.submitOrderButton.Enabled = true;
                    this.emptyCartButton.Enabled = true;
                   
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

        /// <summary>
        /// Calculates the total.
        /// </summary>
        private void CalculateTotal()
        {
            var totalAmountToPay = this.cartList.Sum(cart => cart.TotalItemRentalAmount);
            this.amountLabel.Text = "$" + totalAmountToPay;
            this.submitOrderButton.Enabled = true;
            this.emptyCartButton.Enabled = true;
        }

        /// <summary>
        /// Event Handler for Submit Order button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitOrderButtonClick(object sender, EventArgs e)
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
                this._cartController.UpdateRentalCart(this.member);
                this.cartList.Clear();
                this.CreateReceipt();
            }
            else
            {
                this.Show();
            }
        }

        /// <summary>
        /// Creates the receipt.
        /// </summary>
        private void CreateReceipt()
        {
            try { 
                var list = from x in this.cartList
                           select new ReceiptItem
                           {
                               FurnitureID = x.FurnitureID,
                               Description = x.Description,
                               RentalDate = DateTime.Now,
                               DailyRate = Convert.ToDecimal(x.RentalAmount),
                               NumberOfDays = (int)(x.DueDate - DateTime.Today).TotalDays,
                               Quantity = x.FurnitureRentQuantity,
                               SubTotal = (decimal)x.TotalItemRentalAmount
                           };

                this.receiptList = list.ToList();
                if (this.receiptList.Any())
                {
                    this.ShowReceipt();
                }
            }
             catch (Exception e)
            {
                MessageBox.Show("Receipt display failed text , "+ e.Message, "Receipt",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        /// <summary>
        /// Shows the receipt.
        /// </summary>
        private void ShowReceipt()
        {
            try
            {
                using (Form viewReceiptDialog = new View.ReceiptDialog(this.receiptList, this.member.FName + " " + this.member.LName, true))
                {
                    DialogResult result = viewReceiptDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Receipt display failed text , "+ e.Message, "Receipt",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event Handler for Empty Cart button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmptyCartButtonClick(object sender, EventArgs e)
        {
            if (this.cartList.Any())
            {
                this.cartList.Clear();
                this._cartController.UpdateRentalCart(this.member);
                this.rentFurnitureBindingSource.DataSource = null;
                this.cartDataGrideView.DataSource = null;
                this.submitOrderButton.Enabled = false;
                this.amountLabel.Text = "$0.00";
            }
           
            this.emptyCartButton.Enabled = false;
        }

        /// <summary>
        /// Event Handler for DataGridViewCell click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartDataGrideViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (this.cartDataGrideView.Columns[e.ColumnIndex].Name == "DeleteItem")
                {
                    if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.cartList.RemoveAt(cartDataGrideView.CurrentCell.RowIndex);
                        this._cartController.DeleteCartItem(cartDataGrideView.CurrentCell.RowIndex);
                        this.rentFurnitureBindingSource.RemoveCurrent();
                        this.CalculateTotal();
                    }
                }

                if (this.cartDataGrideView.Columns[e.ColumnIndex].Name == "EditItem")

                {
                    string quantitydata = Convert.ToString(this.cartDataGrideView[6, this.cartDataGrideView.CurrentCell.RowIndex].Value);

                    DateTime dueDateUpdate = Convert.ToDateTime(this.cartDataGrideView[7, this.cartDataGrideView.CurrentCell.RowIndex].Value);
                    RentFurniture updateFurniture = this.cartList[(cartDataGrideView.CurrentCell.RowIndex)];

                    using (Form rentalDialog = new RentalEditDialog(quantitydata, dueDateUpdate, updateFurniture.AvailableQunatity))
                    {
                        DialogResult result = rentalDialog.ShowDialog();

                        if (result == DialogResult.Yes)
                        {
                            updateFurniture.FurnitureRentQuantity = Convert.ToInt32(RentalEditDialog.NewQuantity);
                            updateFurniture.DueDate = Convert.ToDateTime(RentalEditDialog.NewDueDate);

                            this._cartController.UpdateCartItem(cartDataGrideView.CurrentCell.RowIndex, updateFurniture);
                            this.DisplayRentData();
                        };
                    }
                }
            
            }
            catch (Exception exe)
            {
                MessageBox.Show("Edit/delete display failed text , "+ exe.Message, "Receipt",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

    }
}
