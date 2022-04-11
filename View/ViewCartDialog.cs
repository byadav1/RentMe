using System;
using System.Collections.Generic;
using System.ComponentModel;
using RentMe.Controller;
using System.Windows.Forms;
using RentMe.Model;

namespace RentMe.View
{
    public partial class ViewCartDialog : Form
    {

        private FurnitureRentController rentController;
        private Member rentMember;
        public ViewCartDialog(Member member)
        {
            InitializeComponent();
            this.rentMember = member;
        }

        private void ViewCartDialog_Load(object sender, EventArgs e)
        {
            this.rentController = new FurnitureRentController();
            this.DisplayRentData();
        }

        private void DisplayRentData()
        {
            this.cartDataGrideView.DataSource = null;
            this.cartDataGrideView.DataSource = this.rentController.GetRentItem(this.rentMember);

        }


    }
}
