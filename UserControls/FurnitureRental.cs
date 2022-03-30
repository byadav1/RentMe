using System;
using RentMe.Controller;
using RentMe.Model;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RentMe.UserControls
{
    public partial class FurnitureRental : UserControl
    {

        private readonly FurnitureController furnitureController;
        private Furniture furnitureSearchDetails;
        private List<string> categoryList;
        private List<string> styleList;
        public FurnitureRental()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.ToggleFormButtons();
        }

        private void FurnitureSearchButton_Click(object sender, EventArgs e)
        {

            if (this.SetSearchValues()) {;

                this.DisplayResults();
                     };
        }

        private bool SetSearchValues()
        {
            this.furnitureSearchDetails = new Furniture();
            if (!string.IsNullOrEmpty(this.furnitureIDTextBox.Text))
            {
                this.furnitureSearchDetails.FurnitureID = Convert.ToInt32(this.furnitureIDTextBox.Text);
            }
            else if (!string.IsNullOrEmpty(this.styleComboBox.Text))
            {
                this.furnitureSearchDetails.Style = this.styleComboBox.Text;
            }
            else if (!string.IsNullOrEmpty(this.categoryComboBox.Text))
            {

                this.furnitureSearchDetails.Category = this.categoryComboBox.Text;
            }
            else
            {
                this.rentalStatusLabel.Visible = true;
                this.rentalStatusLabel.Text = "Please enter FurnitureId or Style or category to search!!";
                return false;
            }
            return true;

        }

        /// <summary>
        /// Refresh the data grid view with all open incidents.
        /// </summary>
        private void DisplayResults()
        {
            try
            {
                this.furnitureListView.Items.Clear();
                ListViewItem listViewItem = null;
                foreach (Furniture furnitureItem in this.furnitureController.GetFurnitureDetails(this.furnitureSearchDetails))
                {

                    listViewItem = new ListViewItem(Convert.ToString( furnitureItem.FurnitureID), 0);
                    listViewItem.SubItems.Add(furnitureItem.Name);
                    listViewItem.SubItems.Add(furnitureItem.Description);
                    listViewItem.SubItems.Add(furnitureItem.Category);
                    listViewItem.SubItems.Add(furnitureItem.Style);
                    listViewItem.SubItems.Add(Convert.ToString(furnitureItem.DailyRentalRate));
                    listViewItem.SubItems.Add(Convert.ToString(furnitureItem.Quantity));

                    this.furnitureListView.Items.AddRange(new ListViewItem[] { listViewItem });

                }
                this.rentalStatusLabel.Visible = false;
                this.rentalStatusLabel.Text = "";
            }
            catch (Exception exe)
            {
                MessageBox.Show("Error occured on - Database transaction -" + exe.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Clears the form fields.
        /// </summary>
        private void ClearFields()
        {
            this.furnitureIDTextBox.Text = "";
            this.categoryComboBox.Text = "";
            this.styleComboBox.Text = "";
            this.furnitureListView.Items.Clear();
            this.rentalStatusLabel.Visible = false;
            this.rentalStatusLabel.Text = "";

        }

        private void FurnitureRental_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();

        }
        private void LoadComboBox()
        {
            this.categoryComboBox.DataSource = null; ;
            this.categoryList = this.furnitureController.GetFurnituresCategory();
            this.categoryList.Sort();
            this.categoryComboBox.DataSource = this.categoryList;
            this.categoryComboBox.Text = "";

            this.styleComboBox.DataSource = null;
            this.styleList = this.furnitureController.GetFurnituresStyle();
            this.styleList.Sort();
            this.styleComboBox.DataSource = this.styleList;
            this.styleComboBox.Text = "";

        }


        /// <summary>
        /// Event handler for form field text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFieldChanged(object sender, System.EventArgs e)
        {
            this.rentalStatusLabel.Visible = false;
        }

        /// Enables, disables buttons based on state of the form.
        /// </summary>
        private void ToggleFormButtons()
        {
            this.viewCartButton.Enabled = false;
            this.orderDetailsButton.Enabled = false;
            this.addToCartButton.Enabled = false;
            this.rentAllButton.Enabled = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            this.ToggleFormButtons();
            this.ClearFields();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
