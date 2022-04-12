using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    public partial class ViewRentalTransactions : UserControl
    {
        private readonly RentalTransactionsController rentalTransactionsController;
        private List<RentalTransaction> rentalTransactionSearchResults;

        public ViewRentalTransactions()
        {
            InitializeComponent();
            this.rentalTransactionsController = new RentalTransactionsController();
            this.RefreshDataGrid();
        }

        /// <summary>
        /// Refreshes the DataGridView to display
        /// all RentMe Rental Transactions.
        /// </summary>
        public void RefreshDataGrid()
        {
            List<RentalTransaction> rentals = this.rentalTransactionsController.GetRentalTransactions();
            this.DisplayRentalsList(rentals);
            this.viewAllRentalsButton.Enabled = false;
            this.searchRentalTextBox.Clear();
            this.searchByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Event Handler for Search button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButtonClick(object sender, System.EventArgs e)
        {
            try
            {
                RentalTransaction rentalTransaction = this.CreateRentalTransactionFromSearch();
                if (this.rentalTransactionsController.ValidTransactionSearch(rentalTransaction))
                {
                    this.rentalTransactionSearchResults = this.rentalTransactionsController.GetRentalTransactionsFromSearch(rentalTransaction);
                    this.DisplayRentalsList(this.rentalTransactionSearchResults);
                    this.viewAllRentalsButton.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        /// <summary>
        /// Creates RentalTransaction object based on search input.
        /// </summary>
        /// <returns>RentalTransaction</returns>
        private RentalTransaction CreateRentalTransactionFromSearch()
        {
            RentalTransaction rental = new RentalTransaction();
            string search = this.searchRentalTextBox.Text;
  
            if (String.IsNullOrEmpty(search) || !Int32.TryParse(search, out int ID))
            {
                throw new ArgumentException("Please enter a valid ID for search");
            }

            switch (this.searchByComboBox.SelectedItem)
            {
                case "TransactionID":
                    rental.TransactionID = ID;
                    break;
                case "EmployeeID":
                    rental.EmployeeID = ID;
                    break;
                case "MemberID":
                    rental.MemberID = ID;
                    break;
                default:
                    break;
            }

            return rental;
        }

        /// <summary>
        /// Event Handler for View All button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAllButtonClick(object sender, System.EventArgs e)
        {
            this.RefreshDataGrid();
        }

        /// <summary>
        /// Display all RentMe rental transactions.
        /// </summary>
        private void DisplayRentalsList(List<RentalTransaction> rentals)
        {
            if (rentals == null)
            {
                throw new ArgumentException("Rental transactions list cannot be null");
            }
            if (rentals.Count < 1)
            {
                throw new ArgumentException("No RentMe rental transactions exist");
            }
            else
            {
                this.rentalTransactionBindingSource.Clear();
                this.rentalTransactionBindingSource.DataSource = rentals;
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
                this.statusMessage.ForeColor = Color.Red;
            }
            else
            {
                this.statusMessage.ForeColor = Color.Black;
            }

            this.statusMessage.Text = message;
            this.statusMessage.Visible = true;
        }

        /// <summary>
        /// Event Handler for TextField text changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchRentalTextBoxTextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.searchRentalTextBox.Text))
            {
                this.searchRentalsButton.Enabled = false;
            }
            else
            {
                this.searchRentalsButton.Enabled = true;
            }
        }
    }
}
