using System;
using RentMe.Controller;
using RentMe.Model;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace RentMe.UserControls
{
    /// <summary>
    /// User controller for FurnitureRental display user view and process user inputs
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class FurnitureRental : UserControl
    {

        private readonly FurnitureController furnitureController;
        private  List<Furniture> furnitureSearchResults;
        private readonly MembersController memberController;
        private Furniture furnitureSearchDetails;
        private List<string> categoryList;
        private List<string> styleList;
        private Member MemberRent;
        private bool isMemberAvailable =false;
        private readonly RentCartController cartController;

        private List<RentFurniture> rentFurnitureList;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureRental"/> class.
        /// </summary>
        public FurnitureRental()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.memberController = new MembersController();
            this.cartController = new RentCartController();
            this.rentFurnitureList = new List<RentFurniture>();
            this.ToggleFormButtons();          
           
        }

        private void FurnitureSearchButtonClick(object sender, EventArgs e)
        {
            if (this.SetSearchValues()) {;

                this.DisplayResults();
            };
            
        }

        private bool SetSearchValues()
        {
            try
            {
                this.furnitureSearchDetails = new Furniture();
                if (!string.IsNullOrEmpty(this.furnitureIDTextBox.Text) && Convert.ToInt32(this.furnitureIDTextBox.Text) > 0)
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
                    this.rentalStatusLabel.Text = "Please  enter FurnitureId or Style or category to search. " +
                        "Please ensure furniture ID is a valid number!!";
                    return false;
                }
            }
            catch (Exception exe)
            {
                this.rentalStatusLabel.Visible = true;
                this.rentalStatusLabel.Text = "Please ensure furniture ID is a valid number. "+ exe.Message;
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

                this.furnitureBindingSource.Clear();
               this.furnitureSearchResults = this.furnitureController.GetFurnitureDetails(this.furnitureSearchDetails);

                if (this.furnitureSearchResults.Any())
                {

                    this.furnitureBindingSource.DataSource = this.furnitureSearchResults;

                    this.furnitureBindingSource.DataSource = this.furnitureSearchResults.Select(o => new
                    {
                        o.FurnitureID,
                        o.Name,
                        o.Description,
                        o.Category,
                        o.Style,
                        Quantity = o.Quantity,
                       o.DailyRentalRate
                        
                    }).ToList();
                    this.rentalStatusLabel.Visible = false;
                    this.rentalStatusLabel.Text = "";
                    this.memberIDRentTextBox.Enabled = true;
                    this.memberSearchButton.Enabled = true;
                    this.furnitureDateGridView.Enabled = true;
                }
                else
                {
                    this.rentalStatusLabel.Visible = true;
                    this.furnitureBindingSource.DataSource = null;
                    this.rentalStatusLabel.Text = "No furniture found for the entered value. Please enter the valid value";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Database transaction -" + ex.Message,
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
          
            this.rentalStatusLabel.Visible = false;
            this.rentalStatusLabel.Text = "";
            this.memberIDRentTextBox.Text = "";

        }

        private void FurnitureRentalLoad(object sender, EventArgs e)
        {                    
            this.styleComboBox.Enabled = false;
            this.categoryComboBox.Enabled = false;
            this.furnitureDateGridView.Enabled = false;
            this.furnitureDateGridView.ReadOnly = true;
            this.LoadComboBox();
            this.furnitureIDTextBox.Focus();
        }


        private void StyleComboBoxVisibleChanged(object sender, EventArgs e)
        {
            this.styleComboBox.DataSource = this.styleList;
            this.styleComboBox.Text ="";
        }

        private void CategoryComboBoxVisibleChanged(object sender, EventArgs e)
        {
            this.categoryComboBox.DataSource = this.categoryList;
            this.categoryComboBox.Text = "";
        }

        private void LoadComboBox()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Database transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
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
            this.viewCartLinkLabel.Enabled = false;
           
            this.addToCartButton.Enabled = false;
            this.rentAllButton.Enabled = false;
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {

            this.ToggleFormButtons();
            this.stylerRadiobutton.Checked = false;
            this.idRadioButton.Checked = false;
            this.categoryRadioButton.Checked = false;
            this.ClearFields();
        }

        private void StyleComboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CategoryComboBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void IdRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            this.ClearFields();
            this.furnitureIDTextBox.Enabled = true;
            this.styleComboBox.Enabled = false;
            this.categoryComboBox.Enabled = false;
            this.memberIDRentTextBox.Enabled = false;
            this.memberSearchButton.Enabled = false;
           

        }

        private void CategoryRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            this.ClearFields();
            this.furnitureIDTextBox.Enabled = false;
            this.styleComboBox.Enabled = false;
            this.categoryComboBox.Enabled = true;
           
        }

        private void StylerRadiobuttonCheckedChanged(object sender, EventArgs e)
        {
            this.ClearFields();
            this.furnitureIDTextBox.Enabled = false;
            this.styleComboBox.Enabled = true;
            this.categoryComboBox.Enabled = false;
            this.memberIDRentTextBox.Enabled = false;
            this.memberSearchButton.Enabled = false;
            this.memberIDRentTextBox.Enabled = false;
            this.memberSearchButton.Enabled = false;
            this.memberIDRentTextBox.Enabled = false;
            this.memberSearchButton.Enabled = false;

        }

        private void FurnitureRentalVisibleChanged(object sender, System.EventArgs e)
        {
            this.ClearFields();
            this.furnitureIDTextBox.Focus();
            this.styleComboBox.Enabled = false;
            this.categoryComboBox.Enabled = false;
            this.stylerRadiobutton.Checked = false;
            this.idRadioButton.Checked = true;
            this.categoryRadioButton.Checked = false;
            this.memberIDRentTextBox.Enabled = false;
            this.memberSearchButton.Enabled = false;
            this.LoadComboBox();
        }


        private void MemberSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentalStatusLabel.Visible = false;
                this.rentalStatusLabel.Text = "";  
                if (!int.TryParse(this.memberIDRentTextBox.Text, out int numericValue))
                {
                    this.rentalStatusLabel.Visible = true;
                    this.rentalStatusLabel.Text = " Member Id should be a valid number, please enter the valid the Member Id";
                    return;
                }
                Member memberSearch = new Member
                {
                    MemberID = Int32.Parse(this.memberIDRentTextBox.Text)
                };
                this.DisplayMemberDetails(memberSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Member ID search -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMemberDetails(Member memberSearch)
        {
            this.MemberRent = this.memberController.GetMembersFromSearch(memberSearch)[0];
            if (this.MemberRent == null)
            {
                throw new ArgumentException(" No member found with member ID + " + memberSearch.MemberID.ToString());
              
            }

                this.memberIDLabel.Visible = true;
                this.memberFirstName.Visible = true;
                this.memberIDLabel.Text = "MemberId: " + this.MemberRent.MemberID.ToString();
                this.memberFirstName.Text = "Name: " + this.MemberRent.FName + " " + this.MemberRent.LName;
                this.isMemberAvailable = true;
                this.memberIDRentTextBox.Clear();
                this.viewCartLinkLabel.Enabled = true;
                this.rentAllButton.Enabled = true;
                this.addToCartButton.Enabled = true;
                this.EnableRenting();
        }

        private void EnableRenting()
        {
            this.furnitureDateGridView.ReadOnly = false;
            if (isMemberAvailable) {

                foreach (DataGridViewColumn dc in this.furnitureDateGridView.Columns)
                {
                   if (!dc.Index.Equals(7) && !dc.Index.Equals(8) && !dc.Index.Equals(9))
                    {
                        dc.ReadOnly = true;
                    }
                   else
                    {
                        dc.ReadOnly = false;
                    }

                }
                

            }
        }




        private void AddToCartButton_Click(object sender, EventArgs e)
        {

            this.rentalStatusLabel.Visible = false;
            this.rentFurnitureList = new List<RentFurniture>();
           
            foreach (DataGridViewRow row in this.furnitureDateGridView.Rows)
            {
                
               bool isSelected = Convert.ToBoolean(row.Cells[9].Value);
                            
                if (isSelected) {
                    if (string.IsNullOrEmpty((string)row.Cells[7].Value))
                    {
                        this.UpdateStatusMessage("Please enter the Quantity to rent", true); ;
                        row.Cells[7].Style.BackColor = System.Drawing.Color.Red;
                        return;

                    }
                    else if (string.IsNullOrEmpty((string)row.Cells[8].Value))
                    {
                        row.Cells[8].Style.BackColor = System.Drawing.Color.Red;
                        this.UpdateStatusMessage("Please enter the due date to rent", true); ;
                        return;
                    }
                    else
                    {
                        int result = Int32.Parse(row.Cells[7].Value.ToString());
                        if (result > 0)
                        {
                          
                            RentFurniture rentItem = new RentFurniture
                            {
                                FurnitureID = int.Parse(row.Cells[0].Value.ToString()),
                                FurnitureRentQuantity = result,
                                RentalAmount = float.Parse(row.Cells[8].Value.ToString())
                            };
                            rentItem.TotalItemRentalAmount = float.Parse(row.Cells[8].Value.ToString()) * rentItem.FurnitureRentQuantity;
                            rentItem.FurnitureRentMemberID = this.MemberRent.MemberID;
                            rentItem.Name = row.Cells[1].Value.ToString();
                            rentItem.Description = row.Cells[2].Value.ToString();
                            rentItem.Category = row.Cells[3].Value.ToString();
                            rentItem.Style = row.Cells[4].Value.ToString();
                            rentItem.FurnitureRentEmployeeID = 1;
                            this.rentFurnitureList.Add(rentItem);
                        }
                    }
                }              
            }

            if (this.rentFurnitureList.Any())
            {
               this.cartController.AddFurnituresToRent (this.rentFurnitureList);
                this.UpdateStatusMessage("Items added to the cart.",false);            
                this.Reset();
            }
            else
            {
                this.UpdateStatusMessage("Please select the Items to rent.", true);
            }
        }

        private void Reset()
        {
            foreach (DataGridViewRow row in this.furnitureDateGridView.Rows)
            {
                 row.Cells[7].Value = "";
                row.Cells[9].Value = false;
                row.Cells[8].Value = "";
            }
        }

            private void RentAllButton_Click(object sender, EventArgs e)
        {
         
            foreach (DataGridViewRow row in this.furnitureDateGridView.Rows)
            {
                row.Cells[9].Value = true; ; 
            }

           
        }

        /// <summary>
        /// Updates the error message to reflect 
        /// the status of the form.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isError"></param>
        private void UpdateStatusMessage(string message, bool isError)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Message cannot be null or empty");
            }

            if (isError)
            {
                this.rentalStatusLabel.ForeColor = Color.Red;
            }
            else
            {
                this.rentalStatusLabel.ForeColor = Color.Green;
            }

            this.rentalStatusLabel.Text = message;
            this.rentalStatusLabel.Visible = true;
        }

        private void ViewCartLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form viewCartDialog = new View.ViewCartDialog(this.MemberRent))
            {
                DialogResult result = viewCartDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Reset();
                    this.UpdateStatusMessage("Your Rent Order submitted Sucessfully",false);
                }

               
            }
        }

    }

    
}
