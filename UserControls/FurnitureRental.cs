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
    /// User controller for FurnitureRental display Furnitures to rent 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class FurnitureRental : UserControl
    {

        private readonly FurnitureController furnitureController;
        private List<Furniture> furnitureSearchResults;
        private readonly MembersController memberController;
        private readonly EmployeesController employeeController;
        private Furniture furnitureSearchDetails;
        private List<string> categoryList;
        private List<string> styleList;
        private Member MemberRent;
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
            this.employeeController = new EmployeesController();
            this.cartController = new RentCartController();
            this.rentFurnitureList = new List<RentFurniture>();
            this.ToggleFormButtons();
        }

        private void FurnitureSearchButtonClick(object sender, EventArgs e)
        {
            if (this.SetSearchValues())
            {
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
                this.rentalStatusLabel.Text = "Please ensure furniture ID is a valid number. " + exe.Message;
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

        private void FurnitureRentalLoad(object sender, EventArgs e)
        {
            this.styleComboBox.Enabled = false;
            this.categoryComboBox.Enabled = false;
            this.furnitureDateGridView.Columns[7].Visible = false;
            this.furnitureDateGridView.Columns[8].Visible = false;
            this.furnitureDateGridView.Columns[9].Visible = false;
            this.furnitureDateGridView.ReadOnly = true;
            this.LoadComboBox();
            this.furnitureIDTextBox.Focus();
        }


        private void StyleComboBoxVisibleChanged(object sender, EventArgs e)
        {
            this.styleComboBox.DataSource = this.styleList;
            this.styleComboBox.Text = "";
        }

        private void CategoryComboBoxVisibleChanged(object sender, EventArgs e)
        {
            this.categoryComboBox.DataSource = this.categoryList;
            this.categoryComboBox.Text = "";
        }

        /// <summary>
        /// Loads the ComboBox for furniture category and style.
        /// </summary>
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
        /// <summary>
        /// Furnitures the rental visible changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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
            this.furnitureBindingSource.DataSource = null;
            this.LoadComboBox();
        }

        /// <summary>
        /// Handles the Click event of the MemberSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MemberSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member memberRental = this.CreateMemberFromSearch();
                if (this.memberController.ValidMemberSearch(memberRental))
                {
                    List<Member> memberFoundList = this.memberController.GetMembersFromSearch(memberRental);
                    if (!memberFoundList.Any() || memberFoundList.Count > 1)
                    {
                        this.UpdateStatusMessage("No member found or multipl member found.", true);
                    }
                    else
                    {
                        this.MemberRent = memberFoundList[0];

                        this.DisplayMemberDetails();
                    }
                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);

            }
        }

        /// <summary>
        /// Takes input from the search field
        /// and returns a Member.
        /// </summary>
        /// <returns></returns>
        private Member CreateMemberFromSearch()
        {
            Member member = new Member();
            TextBox search = this.memberIDRentTextBox;
            if (search.Text == "")
            {
                throw new ArgumentException("Member search field cannot be empty");
            }
            else if (!string.IsNullOrEmpty(search.Text) && Convert.ToInt32(search.Text) > 0)
            {
                member.MemberID = Convert.ToInt32(search.Text);
            }
            else
            {
                throw new ArgumentException("Member ID should be a valid number");
            }
            return member;
        }

        /// <summary>
        /// Displays the member details.
        /// </summary>
        private void DisplayMemberDetails()
        {
            this.memberIDLabel.Visible = true;
            this.memberFirstName.Visible = true;
            this.memberIDLabel.Text = "MemberId: " + this.MemberRent.MemberID.ToString();
            this.memberFirstName.Text = "Name: " + this.MemberRent.FName + " " + this.MemberRent.LName;
            this.memberIDRentTextBox.Clear();
            this.viewCartLinkLabel.Enabled = true;
            this.rentAllButton.Enabled = true;
            this.addToCartButton.Enabled = true;
            this.EnableRenting();
        }

        /// <summary>
        /// Enables renting feature if memeber data is available
        /// </summary>
        private void EnableRenting()
        {
            try
            {
                this.furnitureDateGridView.ReadOnly = false;
                foreach (DataGridViewColumn dc in this.furnitureDateGridView.Columns)
                {
                    if (!dc.Index.Equals(7) && !dc.Index.Equals(8) && !dc.Index.Equals(9))
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
                this.SetUpDataGridView();
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);

            }
        }

        /// <summary>
        /// Sets up Furniture data grid view on member data found
        /// </summary>
        private void SetUpDataGridView()
        {
            this.furnitureDateGridView.Columns[7].Visible = true;
            this.furnitureDateGridView.Columns[8].Visible = true;
            this.furnitureDateGridView.Columns[9].Visible = true;
            this.furnitureDateGridView.EnableHeadersVisualStyles = false;
            this.furnitureDateGridView.Columns[7].HeaderCell.Style.ForeColor = Color.Blue;
            this.furnitureDateGridView.Columns[9].HeaderCell.Style.ForeColor = Color.Blue;
            this.furnitureDateGridView.Columns[8].HeaderCell.Style.ForeColor = Color.Blue;
        }


        private void AddToCartButton_Click(object sender, EventArgs e)
        {

            this.rentalStatusLabel.Visible = false;
            this.rentFurnitureList = new List<RentFurniture>();
            string message = "";
            bool itemSelected = false;
            foreach (DataGridViewRow row in this.furnitureDateGridView.Rows)
            {
                row.Cells[7].Style.BackColor = Color.White;
                row.Cells[8].Style.BackColor = Color.White;
                row.Cells[9].Style.BackColor = Color.White;
                if (Convert.ToBoolean(row.Cells[9].Value))
                {
                    itemSelected = true;
                    message = this.ValidateMissingRentalItemDetails(row, message); ;
                    if (message == "")
                    {
                        message = this.ValidateRentalItemDetails(row, message);
                        if (message == "")
                        {
                            this.AddItemsToCart(row);
                        }
                    }
                }
            }
            if (!itemSelected)
            {
               this.UpdateStatusMessage("Please select the items to Rent.", true);
            }
            else if (this.rentFurnitureList.Any())
            {
                this.cartController.AddFurnituresToRent(this.rentFurnitureList);
                this.UpdateStatusMessage("Items added to the cart.", false);
                this.Reset();
            }
            else
            {
                this.UpdateStatusMessage(message, true);
            }

        }
        private void AddItemsToCart(DataGridViewRow row)
        {
            this.rentFurnitureList.Add(this.CreateRentalData(row));
        }

        private RentFurniture CreateRentalData(DataGridViewRow row)
        {

            int dueDays = Int32.Parse(row.Cells[8].Value.ToString());
            int rentCount = Int32.Parse(row.Cells[7].Value.ToString());
            DateTime dueDate = DateTime.Today.AddDays(dueDays);
            RentFurniture rentItem = new RentFurniture
            {
                FurnitureID = int.Parse(row.Cells[0].Value.ToString()),
                FurnitureRentQuantity = rentCount,
                RentalAmount = float.Parse(row.Cells[6].Value.ToString())
            };
            rentItem.TotalItemRentalAmount = float.Parse(row.Cells[6].Value.ToString()) * rentItem.FurnitureRentQuantity * dueDays;
            rentItem.FurnitureRentMemberID = this.MemberRent.MemberID;
            rentItem.FurnitureRentEmployeeID = this.GetEmployeeID();
            rentItem.Name = row.Cells[1].Value.ToString();
            rentItem.Description = row.Cells[2].Value.ToString();
            rentItem.Category = row.Cells[3].Value.ToString();
            rentItem.Style = row.Cells[4].Value.ToString();
            rentItem.DueDate = dueDate;
            return rentItem;
        }
        private string ValidateMissingRentalItemDetails(DataGridViewRow row, string message)
        {
            if (string.IsNullOrEmpty((string)row.Cells[7].Value) && string.IsNullOrEmpty((string)row.Cells[8].Value))
            {
                row.Cells[7].Style.BackColor = Color.Red;
                row.Cells[8].Style.BackColor = Color.Red;
                this.rentFurnitureList.Clear();
                return "Please enter the Quantity and return date to rent";
            }
            else if (string.IsNullOrEmpty((string)row.Cells[7].Value))
            {

                row.Cells[7].Style.BackColor = Color.Red;
                this.rentFurnitureList.Clear();
                return "Please enter the Quantity to rent"; ;
            }
            else if (string.IsNullOrEmpty((string)row.Cells[8].Value))
            {

                row.Cells[8].Style.BackColor = Color.Red;
                this.rentFurnitureList.Clear();
                return "Please enter the Rental days to rent"; ;
            }
            return message;
        }

        private string ValidateRentalItemDetails(DataGridViewRow row, string message)
        {
            try
            {
                int rentCount = Int32.Parse(row.Cells[7].Value.ToString());
                int availableCount = Int32.Parse(row.Cells[5].Value.ToString());
                int dueDays = Int32.Parse(row.Cells[8].Value.ToString());
                if ((rentCount < 1 || rentCount > availableCount) && (dueDays < 1 || dueDays > 365))
                {
                    return "Quantity exceeds available furniture count or Quantity cannot be 0. Rental days cannot be 0 or more than 365";
                }
                else if (rentCount < 0 || rentCount > availableCount)
                {
                    return "Please check the quantity it exceeds the available furniture count";
                }
                else if (dueDays > 365)
                {
                    return "Rental days cannot be more than 365 days.";
                }

            }
            catch (Exception e)
            {
                this.UpdateStatusMessage(e.Message, true);
            }
            return message;
        }

        /// <summary>
        /// Resets the Furniture data grid view 
        /// </summary>
        private void Reset()
        {
            foreach (DataGridViewRow row in this.furnitureDateGridView.Rows)
            {
                row.Cells[7].Value = "";
                row.Cells[9].Value = false;
                row.Cells[8].Value = "";
                row.Cells[7].Style.BackColor = Color.White;
                row.Cells[8].Style.BackColor = Color.White; ;
                row.Cells[9].Style.BackColor = Color.White;
                this.rentalStatusLabel.Text = "";
                this.rentalStatusLabel.Visible = false;
            }
        }

        /// <summary>
        /// Checks all the furnitures to rents
        /// </summary>
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
            this.rentalStatusLabel.Text = "";
            this.rentalStatusLabel.Visible = false;
            using (Form viewCartDialog = new View.ViewCartDialog())
            {
                DialogResult result = viewCartDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Reset();
                    this.UpdateStatusMessage("Your Rent Order submitted Sucessfully", false);
                }


            }
        }

        private void FurnitureDateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.furnitureDateGridView.DefaultCellStyle.BackColor = Color.White;

        }
        /// <summary>
        /// Gets the Login employee identifier.
        /// </summary>
        /// <returns></returns>
        private int GetEmployeeID()
        {
            return this.employeeController.GetLoginEmployeeData().EmployeeID;
        }

        /// <summary>
        /// Clears the form fields.
        /// </summary>
        private void ClearFields()
        {
            this.furnitureIDTextBox.Text = "";
            this.categoryComboBox.Text = "";
            this.styleComboBox.Text = "";
            this.furnitureBindingSource.DataSource = null;
            this.rentalStatusLabel.Visible = false;
            this.rentalStatusLabel.Text = "";
            this.memberIDRentTextBox.Enabled = false;
            this.memberIDRentTextBox.Text = "";
            this.memberFirstName.Text = "";
            this.memberIDLabel.Text = "";
            this.memberFirstName.Visible = false;
            this.memberIDLabel.Visible = false;

        }
    }


}
