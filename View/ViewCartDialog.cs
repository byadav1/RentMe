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
                this.CreateReceipt();
                this.rentController.AddFurnituresToRent(this.cartList);
                this._cartController.UpdateRentalCart(this.member);
                this.cartList.Clear();               
            }
            else
            {
                this.Show();
            }
        }

        private void ShowReceipt()
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

        private void CreateReceipt()
        {
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

        private void CartDataGrideViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.cartDataGrideView.Columns[e.ColumnIndex].Name == "DeleteItem")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.cartList.RemoveAt(cartDataGrideView.CurrentCell.RowIndex);
                this._cartController.DeleteCartItem(cartDataGrideView.CurrentCell.RowIndex);
                this.rentFurnitureBindingSource.RemoveCurrent();
                this.CalculateTotal();
            }

            if (this.cartDataGrideView.Columns[e.ColumnIndex].Name == "Edit")

            {
                string quantitydata = Convert.ToString(this.cartDataGrideView[6, this.cartDataGrideView.CurrentCell.RowIndex].Value);

                DateTime dueDateUpdate = Convert.ToDateTime(this.cartDataGrideView[7, this.cartDataGrideView.CurrentCell.RowIndex].Value);


                using (Form rentalDialog = new RentalEditDialog(quantitydata, dueDateUpdate))
                {
                    DialogResult result = rentalDialog.ShowDialog();

                    
                    if (result == DialogResult.Yes)
                    {
                        int dueDays = (int)(RentalEditDialog.NewDueDate - DateTime.Today).TotalDays;                      
                        RentFurniture updateFurniture = new RentFurniture();
                        updateFurniture.FurnitureID = (int)this.cartDataGrideView[0, this.cartDataGrideView.CurrentCell.RowIndex].Value;
                        updateFurniture.Name = (string)this.cartDataGrideView[1, this.cartDataGrideView.CurrentCell.RowIndex].Value;
                        updateFurniture.Category = (string)this.cartDataGrideView[2, this.cartDataGrideView.CurrentCell.RowIndex].Value;
                        updateFurniture.Style = (string)this.cartDataGrideView[3, this.cartDataGrideView.CurrentCell.RowIndex].Value;
                        updateFurniture.Description = (string)this.cartDataGrideView[4, this.cartDataGrideView.CurrentCell.RowIndex].Value;
                        updateFurniture.RentalAmount = (float)this.cartDataGrideView[5, this.cartDataGrideView.CurrentCell.RowIndex].Value;
                        updateFurniture.FurnitureRentQuantity = Convert.ToInt32( RentalEditDialog.NewQuantity);
                        updateFurniture.DueDate = dueDateUpdate.AddDays(1);
                        updateFurniture.FurnitureRentMemberID = this.member.MemberID;
                        updateFurniture.TotalItemRentalAmount = 
                            (float)this.cartDataGrideView[5, this.cartDataGrideView.CurrentCell.RowIndex].Value *
                            (int)this.cartDataGrideView[6, this.cartDataGrideView.CurrentCell.RowIndex].Value * dueDays;                     
                        this._cartController.UpdateCartItem(cartDataGrideView.CurrentCell.RowIndex, updateFurniture);
                        this.DisplayRentData();
                       
                    };

                }
            }
        }
    }

}
