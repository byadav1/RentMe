using RentMe.Controller;
using RentMe.Model;
using RentMe.Validators;
using RentMe.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
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
        private readonly ReturnTransactionController returnTransactionController;
        private readonly EmployeesController employeeController;
        private Member memberSearchDetails;
        private List<RentalTransaction> rentalTransactionList;
        private readonly List<ReturnTransaction> returnTransactionsList;
        private readonly List<ReceiptItem> receiptItemsList;



        /// <summary>
        /// Constructor to initialize instant variables
        /// </summary>
        public FurnitureReturn()
        {
            InitializeComponent();
            this.membersController = new MembersController();
            this.rentalTransactionController = new RentalTransactionController();
            this.returnTransactionController = new ReturnTransactionController();
            this.employeeController = new EmployeesController();
            this.rentalTransactionList = new List<RentalTransaction>();
            this.returnTransactionsList = new List<ReturnTransaction>();
            this.receiptItemsList = new List<ReceiptItem>();
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

        private int GetEmployeeID()
        {

            return this.employeeController.GetLoginEmployeeData().EmployeeID;
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

                    if (this.rentalTransactionList.Count == 0)
                    {
                        this.UpdateStatusMessage("No Furniture To Return", true);
                        return;
                    }
                    this.SetFields(this.memberSearchDetails);
                    this.rentalTransactionDataGridView.DataSource = this.rentalTransactionList;
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

        private void ProcessReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ProcessReturn();
                String memberNameDisplay = "Name: " + this.memberSearchDetails.FName + " " + this.memberSearchDetails.LName;
                if (!this.GetReturnConfirmDialog(memberNameDisplay))
                {
                    this.returnTransactionsList.Clear();
                    return;
                }
                this.CreateReceipt();
                String memberName = this.memberSearchDetails.FName + " " + this.memberSearchDetails.LName;
                this.GetReceiptDialog(memberName);
                this.searchTextbox.Text = "";
                this.ClearField();
            }
            catch (NullReferenceException )
            {
                this.UpdateStatusMessage("Quantity can't be empty", true);
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);

            }

        }

        private void CreateReceipt()
        {
            foreach (ReturnTransaction returnTransaction in this.returnTransactionsList)
            {
                ReceiptItem receiptItem = new ReceiptItem
                {
                    FurnitureID = returnTransaction.FurnitureID,
                    Description = returnTransaction.Description,
                    DailyRate = returnTransaction.RentalRate,
                    DueDate = returnTransaction.DueDate,
                    NumberOfDays = Convert.ToInt32(returnTransaction.Days),
                    Quantity = returnTransaction.Quantity,
                    ReturnedDate = returnTransaction.ReturnDate,
                    RefundAmount = returnTransaction.Refund,
                    LateFee = returnTransaction.Fine,
                    SubTotal = returnTransaction.SubTotal
                };

                this.receiptItemsList.Add(receiptItem);
            }
        }

        private void ProcessReturn()
        {
            foreach (DataGridViewRow row in this.rentalTransactionDataGridView.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["returnMe"].Value);
                if (isSelected)
                {
                   
                    if (!int.TryParse(row.Cells["ReturnQuantity"].Value.ToString(), out int quatityvalue))
                    {
                        throw new ArgumentException("Quantity should be a valid number");
                    }

                    int returnQuantity = Int32.Parse(row.Cells["ReturnQuantity"].Value.ToString());
                    if (returnQuantity > 0)
                    {
                        ReturnTransaction returnTransaction = new ReturnTransaction
                        {
                            Description = (row.Cells["Description"].Value.ToString()),
                            FurnitureID = int.Parse(row.Cells["FurnitureID"].Value.ToString()),
                            RentedItemsID = int.Parse(row.Cells["RentedItemsID"].Value.ToString()),
                            Quantity = int.Parse(row.Cells["ReturnQuantity"].Value.ToString()),
                            FurnitureName = (row.Cells["FurnitureName"].Value.ToString()),
                            RentDate = DateTime.Parse(row.Cells["RentDate"].Value.ToString()),
                            DueDate = DateTime.Parse(row.Cells["DueDate"].Value.ToString()),
                            RentalRate = float.Parse(row.Cells["RentalRate"].Value.ToString()),
                            ReturnDate = DateTime.Now,
                            EmployeeID = this.GetEmployeeID()
                        };

                        double days = Math.Abs((returnTransaction.DueDate - returnTransaction.ReturnDate).TotalDays);
                        if (days > 0)
                        {
                            returnTransaction.Days = days;
                            returnTransaction.Fine = Convert.ToDecimal(returnTransaction.RentalRate * days);
                            returnTransaction.SubTotal = returnTransaction.Quantity * returnTransaction.Fine;
                        }
                        else if (days < 0)
                        {
                            returnTransaction.Days = days;
                            returnTransaction.Refund = Convert.ToDecimal(returnTransaction.RentalRate * Math.Abs(days));
                            returnTransaction.SubTotal = returnTransaction.Quantity * returnTransaction.Refund;
                        }
                        else
                        {
                            returnTransaction.Days = 0;
                            returnTransaction.Refund = 0;
                            returnTransaction.Fine = 0;
                            returnTransaction.SubTotal = 0;
                        }

                        this.returnTransactionsList.Add(returnTransaction);


                    }
                    else
                    {
                        string message = "Return Quantity can't be zero or less than zero";
                        this.UpdateStatusMessage(message, true);
                    }

                }
            }
            if (this.returnTransactionsList.Count == 0)
            {
                throw new ArgumentException("Must select an furniture to return");
            }
        }

        private Boolean GetReturnConfirmDialog(String memberNameDisplay)
        {
            using (Form ReturnConfirmDialog = new ReturnConfirmDialog(this.returnTransactionsList, memberNameDisplay))
            {
                DialogResult result = ReturnConfirmDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (ReturnTransaction returnTransaction in this.returnTransactionsList)
                    {
                        this.returnTransactionController.AddReturnFurniture(returnTransaction);
                    }
                    return true;
                   
                }
                return false;
                
            }




        }

        private void GetReceiptDialog(String memberName)
        {
            using (Form ReceiptDialog = new ReceiptDialog(this.receiptItemsList, memberName, false))
            {
                DialogResult result = ReceiptDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return;
                }

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearField();
            this.searchTextbox.Text = "";
        }

        private void ClearField()
        {
            this.rentalTransactionDataGridView.DataSource = null;
            this.memberIDLabel.Text = "";
            this.memberIDLabel.Visible = false;
            this.memberNameLabel.Text = "";
            this.memberNameLabel.Visible = false;
            this.statusMessageLabel.Text = "";
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            this.ClearField();
        }
    }

}
