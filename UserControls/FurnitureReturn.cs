using RentMe.Controller;
using RentMe.Model;
using RentMe.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// Add Furniture return Usercontrol
    /// </summary>
    public partial class FurnitureReturn : UserControl
    {
        private readonly MembersController membersController;
        private readonly RentalTransactionController rentalTransactionController;
        private Member memberSearchDetails;
        private List<RentalTransaction> rentalTransactionList;
      
       
        /// <summary>
        /// Constructor to initialize instant variables
        /// </summary>
        public FurnitureReturn()
        {
            InitializeComponent();
            this.membersController = new MembersController();
            this.rentalTransactionController = new RentalTransactionController();
            this.rentalTransactionList = new List<RentalTransaction>();

        }

        /// <summary>
        /// Takes input from the search field
        /// and returns a Member.
        /// </summary>
        /// <returns></returns>
        private Member CreateMemberFromSearch()
        {
            Member member = new Member();
            TextBox search = this.searchTextbox;
            if (search.Text == "")
            {
                throw new ArgumentException("Member search field cannot be empty");
            }
            else if (new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$").IsMatch(search.Text))
            {
                member.Phone = search.Text;

            }
            else if (new Regex("[a-zA-Z] [a-zA-Z]").IsMatch(search.Text))
            {
                member.FName = search.Text.Substring(0, search.Text.IndexOf(" "));
                member.LName = search.Text.Substring(search.Text.IndexOf(" ") + 1);
            }
            else if (Int32.TryParse(search.Text, out int memberID))
            {
                member.MemberID = memberID;
            }

            return member;
        }

        private void SetFields(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);

            this.memberIDLabel.Text = "MemberId: " + member.MemberID.ToString();
            this.memberIDLabel.Visible = true;
            this.memberNameLabel.Text = "Name: " + member.FName + " " + member.LName;
            this.memberNameLabel.Visible = true;
        }



        private void SearchButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                this.memberSearchDetails = this.CreateMemberFromSearch();
                if (this.membersController.ValidMemberSearch(this.memberSearchDetails))
                {
                    this.memberSearchDetails = this.membersController.GetMemberFromSearch(this.memberSearchDetails);


                    this.rentalTransactionList = this.rentalTransactionController.GetRetalTransactionByMemberID(this.memberSearchDetails.MemberID);
                    this.SetFields(this.memberSearchDetails);
                    this.rentalTransactionDataGridView.DataSource = this.rentalTransactionList;
                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);
                //  this.ToggleFormButtons(false);
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
                // this.ToggleFormButtons(false);
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
                this.statusMessageLabel.ForeColor = Color.Red;
            }
            else
            {
                this.statusMessageLabel.ForeColor = Color.Black;
            }

            this.statusMessageLabel.Text = message;
            this.statusMessageLabel.Visible = true;
        }

        //private void ProcessReturnButton_Click(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow row in this.rentReturnFurnitureDataGridView.Rows)
        //    {

        //        bool isSelected = Convert.ToBoolean(row.Cells["returnMe"].Value);
        //        if (isSelected)
        //        {
        //            int returnQuantity = Int32.Parse(row.Cells["ReturnQuantity"].Value.ToString());
        //            if (returnQuantity > 0)
        //            {
        //                ReturnFurniture returnFurniture = new ReturnFurniture
        //                {
        //                    RentedItemsID = int.Parse(row.Cells["RentedItemsID"].Value.ToString()),
        //                    Quantity = int.Parse(row.Cells["ReturnQuantity"].Value.ToString()),
        //                    FurnitureName = (row.Cells["FurnitureName"].Value.ToString()),
        //                    RentDate = DateTime.Parse(row.Cells["RentDate"].Value.ToString()),
        //                    DueDate = DateTime.Parse(row.Cells["DueDate"].Value.ToString()),
        //                    RentalRate = float.Parse(row.Cells["RentalRate"].Value.ToString()),
        //                    ReturnDate = DateTime.Now,
        //                    EmployeeID = 1
        //                };


        //                //if (int.Parse(row.Cells["ReturnQuantity"].Value.ToString()) > )

        //                double days = Math.Abs((returnFurniture.DueDate - returnFurniture.ReturnDate).TotalDays);
        //                if (days > 0)
        //                {
        //                    returnFurniture.Days = days;
        //                    returnFurniture.Fine = returnFurniture.RentalRate * (float)days;
        //                    returnFurniture.SubTotal = returnFurniture.Quantity * returnFurniture.Fine;
        //                }
        //                else if (days < 0)
        //                {
        //                    returnFurniture.Days = days;
        //                    returnFurniture.Refund = returnFurniture.RentalRate * Math.Abs((float)days);
        //                    returnFurniture.SubTotal = returnFurniture.Quantity * returnFurniture.Refund;
        //                }
        //                else
        //                {
        //                    returnFurniture.Days = 0;
        //                    returnFurniture.Refund = 0;
        //                    returnFurniture.Fine = 0;
        //                    returnFurniture.SubTotal = 0;
        //                }

        //                this.returnFurnituresList.Add(returnFurniture);

        //            }
        //            else
        //            {
        //                string message = "Return Quantity can't be zero or less than zero";
        //                this.UpdateStatusMessage(message, true);
        //            }

        //        }
        //    }

        //    String memberName = "Name: " + this.memberSearchDetails.FName + " " + this.memberSearchDetails.LName;
        //    using (Form confirmReturnDialog = new ConfirmReturnDialog(this.returnFurnituresList, memberName))
        //    {
        //        DialogResult result = confirmReturnDialog.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            foreach (ReturnFurniture returnFurniture in this.returnFurnituresList)
        //            {
        //                this.furnitureReturnController.AddReturnFurniture(returnFurniture);
        //            }

        //        }

        //    }
        //}


    }
}
