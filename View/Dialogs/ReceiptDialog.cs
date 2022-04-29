using RentMe.Model;
using RentMe.Model.Validators;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// This form models a Dialog which
    /// displays the receipt for a
    /// furniture transaction.
    /// </summary>
    public partial class ReceiptDialog : Form
    {
        /// <summary>
        /// Initialize the form.
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="memberName"></param>
        /// <param name="isRental"></param>
        public ReceiptDialog(List<ReceiptItem> receipt, string memberName, bool isRental)
        {
            this.ValidateReceipt(receipt);
            this.ValidateMemberName(memberName);
            InitializeComponent();
            this.CreateReceipt(receipt, memberName, isRental);
        }

        /// <summary>
        /// Create the receipt.
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="memberName"></param>
        /// <param name="isRental"></param>
        private void CreateReceipt(List<ReceiptItem> receipt, string memberName, bool isRental)
        {
            this.memberNameLabel.Text += memberName;
            this.receiptDateLabel.Text += DateTime.Now.ToShortDateString();
            this.totalLabel.Text += this.GetTotal(receipt).ToString("c2");
            this.AddItemsToReceiptListView(receipt, isRental);

            if (isRental)
            {
                this.receiptHeaderLabel.Text = "Rental Receipt";
            }
            else
            {
                this.receiptHeaderLabel.Text = "Return Receipt";
            }
        }

        /// <summary>
        /// Adds items to the receipt.
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="isRental"></param>
        private void AddItemsToReceiptListView(List<ReceiptItem> receipt, bool isRental)
        {
            try
            {
                this.ValidateReceipt(receipt);
                this.CreateColumns(isRental);
                this.AddItems(receipt, isRental);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.receiptListView.Clear();
            }
        }

        /// <summary>
        /// Adds the ListView columns based
        /// on type of receipt.
        /// </summary>
        /// <param name="isRental"></param>
        private void CreateColumns(bool isRental)
        {
            if (isRental)
            {
                this.receiptListView.Columns.Add("Furniture ID");
                this.receiptListView.Columns.Add("Description");
                this.receiptListView.Columns.Add("Rental Date");
                this.receiptListView.Columns.Add("Quantity");
                this.receiptListView.Columns.Add("Daily Rate");
                this.receiptListView.Columns.Add("No. of Days");
                this.receiptListView.Columns.Add("Subtotal");
            }
            else
            {
                this.receiptListView.Columns.Add("Furniture ID");
                this.receiptListView.Columns.Add("Description");
                this.receiptListView.Columns.Add("Return Due Date");
                this.receiptListView.Columns.Add("Returned Date");
                this.receiptListView.Columns.Add("Quantity");
                this.receiptListView.Columns.Add("Daily Rate");
                this.receiptListView.Columns.Add("No. of Days");
                this.receiptListView.Columns.Add("Late Fee");
                this.receiptListView.Columns.Add("Subtotal");
            }

            this.receiptListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.receiptListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Add transaction items to ListView.
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="isRental"></param>
        private void AddItems(List<ReceiptItem> receipt, bool isRental)
        {
            this.ValidateReceipt(receipt);
            for (int i = 0; i < receipt.Count; i++)
            {
                var item = receipt[i];
                ReceiptItemValidator.ValidateReceiptItemNotNull(item);
                if (isRental)
                {
                    this.receiptListView.Items.Add(Convert.ToString(item.FurnitureID));
                    this.receiptListView.Items[i].SubItems.Add(item.Description);
                    this.receiptListView.Items[i].SubItems.Add(item.RentalDate.ToShortDateString());
                    this.receiptListView.Items[i].SubItems.Add(Convert.ToString(item.Quantity));
                    this.receiptListView.Items[i].SubItems.Add(item.DailyRate.ToString("C2"));
                    this.receiptListView.Items[i].SubItems.Add(Convert.ToString(item.NumberOfDays));
                    this.receiptListView.Items[i].SubItems.Add(item.SubTotal.ToString("C2"));
                }
                else
                {
                    this.receiptListView.Items.Add(Convert.ToString(item.FurnitureID));
                    this.receiptListView.Items[i].SubItems.Add(item.Description);
                    this.receiptListView.Items[i].SubItems.Add(item.RentalDueDate.ToShortDateString());
                    this.receiptListView.Items[i].SubItems.Add(item.ReturnedDate.ToShortDateString());
                    this.receiptListView.Items[i].SubItems.Add(Convert.ToString(item.Quantity));
                    this.receiptListView.Items[i].SubItems.Add(item.DailyRate.ToString("C2"));
                    this.receiptListView.Items[i].SubItems.Add(Convert.ToString(item.NumberOfDays));
                    this.receiptListView.Items[i].SubItems.Add(item.LateFee.ToString("C2"));
                    this.receiptListView.Items[i].SubItems.Add(item.SubTotal.ToString("C2"));
                }
            }
        }


        /// <summary>
        /// Get total for receipt.
        /// </summary>
        /// <param name="receipt"></param>
        /// <returns>Receipt total</returns>
        private decimal GetTotal(List<ReceiptItem> receipt)
        {
            decimal total = 0;
            foreach (ReceiptItem item in receipt)
            {
                ReceiptItemValidator.ValidateReceiptItemNotNull(item);
                total += item.SubTotal;
            }

            return total;
        }

        /// <summary>
        /// Checks that a Member's name is 
        /// in first name + last name format.
        /// </summary>
        /// <param name="memberName"></param>
        private void ValidateMemberName(string memberName)
        {
            Regex memberNameRegex = new Regex("^[A-Z][a-z]+ [A-Z][a-z]+$");
            if (string.IsNullOrWhiteSpace(memberName) || !memberNameRegex.IsMatch(memberName))
            {
                throw new ArgumentException("Must use the member's first and last name");
            }
        }

        /// <summary>
        /// Checks that a transaction exists.
        /// </summary>
        /// <param name="transaction"></param>
        private void ValidateReceipt(List<ReceiptItem> receipt)
        {
            if (receipt.Count < 1 || receipt == null)
            {
                throw new ArgumentException("Transaction cannot be null or empty");
            }
        }

        /// <summary>
        /// EVent Handler for Close button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            GC.Collect();
        }

        /// <summary>
        /// Event Handler for Form close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReceiptDialogFormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            GC.Collect();
        }
    }
}
