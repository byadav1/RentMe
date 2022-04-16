using RentMe.Controller;
using RentMe.Model;
using RentMe.Model.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    public partial class ViewTransactions : UserControl
    {
        /// <summary>
        /// This UserControl models a search form where
        /// the user will be able to view the
        /// RentMe Transaction history. They will be able to 
        /// search by an ID of either the Transaction, Employee,
        /// or Member. A filter for active rentals can also be applied.
        /// </summary>
        private readonly TransactionsController transactionController;
        private List<Transaction> transactionSearchResults;

        /// <summary>
        /// Initialize the UserControl.
        /// </summary>
        public ViewTransactions()
        {
            InitializeComponent();
            this.transactionController = new TransactionsController();
            this.RefreshControl();
        }

        /// <summary>
        /// Refreshes the DataGridView to display
        /// all RentMe Rental Transactions.
        /// </summary>
        public void RefreshControl()
        {
            try
            {
                List<Transaction> rentals = this.transactionController.GetTransactions();
                this.DisplayRentalsList(rentals);
                this.viewAllTransactionsButton.Enabled = false;
                this.viewRentalsButton.Enabled = true;
                this.viewActiveRentalsButton.Enabled = true;
                this.viewReturnsButton.Enabled = true;
                this.searchTextBox.Clear();
                this.searchByComboBox.SelectedIndex = 0;
                this.filterResultsComboBox.SelectedIndex = 0;
            }
             catch(Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }       
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
                Transaction transaction = this.CreateRentalTransactionFromSearch();
                if (this.transactionController.ValidTransactionSearch(transaction))
                {
                    this.SearchTransactions(transaction);
                    this.DisplayRentalsList(this.transactionSearchResults);                    
                    this.viewAllTransactionsButton.Enabled = true;
                    this.viewRentalsButton.Enabled = true;
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
        private Transaction CreateRentalTransactionFromSearch()
        {
            Transaction rental = new Transaction();
            string search = this.searchTextBox.Text;
  
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
        /// Searches based on selected filter.
        /// </summary>
        /// <param name="transaction"></param>
        private void SearchTransactions(Transaction transaction)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            string filter = this.filterResultsComboBox.GetItemText(this.filterResultsComboBox.SelectedItem);
            this.transactionSearchResults = this.transactionController
                .SearchTransactions(transaction, filter);   
        }

        /// <summary>
        /// Event Handler for View All button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAllButtonClick(object sender, System.EventArgs e)
        {
            this.RefreshControl();
        }

        /// <summary>
        /// Event Handler for View Rentals button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewRentalsButtonClick(object sender, EventArgs e)
        {
            try
            {
                List<Transaction> rentals = this.transactionController.GetRentalTransactions();
                this.DisplayRentalsList(rentals);
                this.viewAllTransactionsButton.Enabled = true;
                this.viewRentalsButton.Enabled = false;
                this.viewActiveRentalsButton.Enabled = true;
                this.viewReturnsButton.Enabled = true;
                this.searchTextBox.Clear();
                this.searchByComboBox.SelectedIndex = 0;
                this.filterResultsComboBox.SelectedIndex = 0;                
            }
            catch(Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        /// <summary>
        /// Event Handler for View Active Rentals button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewActiveRentalsButtonClick(object sender, EventArgs e)
        {
            try
            {
                List<Transaction> rentals = this.transactionController.GetActiveRentalTransactions();
                this.DisplayRentalsList(rentals);
                this.viewAllTransactionsButton.Enabled = true;
                this.viewRentalsButton.Enabled = true;
                this.viewActiveRentalsButton.Enabled = false;
                this.viewReturnsButton.Enabled = true;
                this.searchTextBox.Clear();
                this.searchByComboBox.SelectedIndex = 0;
                this.filterResultsComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        /// <summary>
        /// Event Handler for View Returns button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewReturnsButtonClick(object sender, EventArgs e)
        {
            try
            {
                List<Transaction> rentals = this.transactionController.GetReturnTransactions();
                this.DisplayRentalsList(rentals);
                this.viewAllTransactionsButton.Enabled = true;
                this.viewRentalsButton.Enabled = true;
                this.viewActiveRentalsButton.Enabled = true;
                this.viewReturnsButton.Enabled = false;
                this.searchTextBox.Clear();
                this.searchByComboBox.SelectedIndex = 0;
                this.filterResultsComboBox.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }          
        }

        /// <summary>
        /// Display all RentMe rental transactions.
        /// </summary>
        private void DisplayRentalsList(List<Transaction> rentals)
        {
            if (rentals == null)
            {
                throw new ArgumentException("Rental transactions list cannot be null");
            }
            if (rentals.Count < 1)
            {
                throw new ArgumentException("No transaction results found");
            }
            else
            {              
                this.transactionBindingSource.Clear();
                this.transactionBindingSource.DataSource = rentals;
                this.DecorateDataGridView();
            }
        }

        /// <summary>
        /// Configures the appearance of Transactions DataGridView.
        /// </summary>
        private void DecorateDataGridView()
        {
            Console.WriteLine(this.transactionDataGridView.Rows.Count);
            foreach (DataGridViewRow row in this.transactionDataGridView.Rows)
            {
                if (string.Equals(row.Cells["TransactionType"].Value.ToString(), "Rental"))
                {
                    row.DefaultCellStyle.BackColor = Color.PowderBlue;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                }
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
            this.statusMessage.Visible = false;
            if (String.IsNullOrWhiteSpace(this.searchTextBox.Text))
            {
                this.searchButton.Enabled = false;
            }
            else
            {
                this.searchButton.Enabled = true;
            }
        }

        /// <summary>
        /// Event Handler for ComboBox enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterResultsComboBoxEnter(object sender, EventArgs e)
        {
            this.statusMessage.Visible = false;
        }
    }
}
