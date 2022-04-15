using System;
using System.Collections.Generic;
using System.ComponentModel;
using RentMe.Controller;
using System.Windows.Forms;
using RentMe.Model;
using System.Linq;

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
           this.DisplayRentData();

           
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
                        o.DueDate,
                           o.TotalItemRentalAmount,
                       o.FurnitureRentQuantity
                    }).ToList();
                    this.CalculateTotal();

                }



                else
                {
                    this.submitOrderButton.Enabled = false;
                    this.emptyCartButton.Enabled = false;
                }
               
            }catch (Exception ex)
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
                this.amountLabel.Text="$0.00";
                  
            }

        }

        private void CartDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.cartDataGrideView.Columns[e.ColumnIndex].Name== "DeleteItem")
            {

                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.cartList.RemoveAt(cartDataGrideView.CurrentCell.RowIndex);
                    this.rentFurnitureBindingSource.RemoveCurrent();
                this.CalculateTotal();
            }
            else if (this.cartDataGrideView.Columns[e.ColumnIndex].Name == "UpdateItem")
            {

                //   RentFurniture newRentFurniture= (RentFurniture)this.rentFurnitureBindingSource.Current;
                // 
                //      this.cartList[cartDataGrideView.CurrentCell.RowIndex] = newRentFurniture;

                RentFurniture rentFurniture = this.cartList.ElementAt(cartDataGrideView.CurrentCell.RowIndex);
                int rowIndex = e.RowIndex; 
                DataGridViewRow row = this.cartDataGrideView.Rows[rowIndex];
                MessageBox.Show(row.Cells[9].Value.ToString());
                rentFurniture.FurnitureRentQuantity = Int32.Parse(row.Cells[9].Value.ToString());
                this.cartList[cartDataGrideView.CurrentCell.RowIndex] = rentFurniture;
             
                //this.rentFurnitureBindingSource.DataSource = this.cartList.Select(o => new
                //{
                //    o.FurnitureID,
                //    o.Name,
                //    o.Description,
                //    o.Category,
                //    o.Style,
                //    o.RentalAmount,
                //    o.DueDate,
                //    o.TotalItemRentalAmount,
                //    o.FurnitureRentQuantity
                //}).ToList();
                this.CalculateTotal();

            }
         
        }

    }
}
