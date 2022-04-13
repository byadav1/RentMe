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
        private Member rentMember;
        
        public ViewCartDialog(Member member)
        {
            InitializeComponent();
            this.rentMember = member;
        }

        private void ViewCartDialog_Load(object sender, EventArgs e)
        {
            this.cartController = new RentCartController();
            this.DisplayRentData();
        }

        private void DisplayRentData()
        {
            this.cartDataGrideView.DataSource = null;
            List<RentFurniture> cartList = this.cartController.GetRentItem();
            // this.cartDataGrideView.DataSource = this.cartController.GetRentItem();

            this.cartDataGrideView.DataSource = cartList.Select(o => new
            { FurnitureID = o.FurnitureID, Description = o.Description,
            Category = o.Category,                Style = o.Style,
            rentPerItem=o.RentalAmount , Quantity= o.FurnitureRentQuantity


            }).ToList();

        }


    }
}
