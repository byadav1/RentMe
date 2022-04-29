using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// This form models a Dialog which
    /// displays the confirmation  for a
    /// furniture transaction.
    /// </summary>
    public partial class ReturnConfirmDialog : Form
    {
        private readonly List<ReturnTransaction> returnTransactionList;
        private readonly string memberName;

        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="returnTransaction"></param>
        /// <param name="memberName"></param>
        public ReturnConfirmDialog(List<ReturnTransaction> returnTransaction, string memberName)
        {
            InitializeComponent();
            this.returnTransactionList = returnTransaction;
            this.memberName = memberName;
        }

        /// <summary>
        /// Event Handler for Dialog load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnConfirmDialogLoad(object sender, EventArgs e)
        {
            this.PopulateForm();
        }

        /// <summary>
        /// Populate the form fields.
        /// </summary>
        private void PopulateForm()
        {         
            this.memberNameLabel.Text = this.memberName;
            this.returnTransactionDataGridView.DataSource = null;
            this.returnTransactionDataGridView.DataSource = this.returnTransactionList;
        }

        /// <summary>
        /// Event Handler for Confirmation button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Event Handler for Cancel button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
