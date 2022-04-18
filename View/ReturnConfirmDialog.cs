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

        private List<ReturnTransaction> returnTransactionList;
        private string memberName;

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

        private void PopulateForm()
        {
            this.memberNameLabel.Text = this.memberName;
            this.returnTransactionDataGridView.DataSource = this.returnTransactionList;

        }

        private void ReturnConfirmDialogLoad(object sender, EventArgs e)
        {
            this.PopulateForm();
        }

        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
