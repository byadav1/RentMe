
namespace RentMe.UserControls
{
    partial class ViewRentalTransactions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.viewTransactionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rentalTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAllRentalsButton = new System.Windows.Forms.Button();
            this.searchMemberTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchMemberLabel = new System.Windows.Forms.Label();
            this.searchRentalTextBox = new System.Windows.Forms.TextBox();
            this.searchRentalsButton = new System.Windows.Forms.Button();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.viewRentalTransactionsHeaderLabel = new System.Windows.Forms.Label();
            this.statusMessage = new System.Windows.Forms.Label();
            this.viewTransactionsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).BeginInit();
            this.searchMemberTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewTransactionsTableLayoutPanel
            // 
            this.viewTransactionsTableLayoutPanel.ColumnCount = 2;
            this.viewTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.rentalTransactionDataGridView, 0, 2);
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.viewAllRentalsButton, 0, 4);
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.searchMemberTableLayoutPanel, 0, 1);
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.viewRentalTransactionsHeaderLabel, 0, 0);
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.statusMessage, 0, 3);
            this.viewTransactionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTransactionsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.viewTransactionsTableLayoutPanel.Name = "viewTransactionsTableLayoutPanel";
            this.viewTransactionsTableLayoutPanel.RowCount = 5;
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.viewTransactionsTableLayoutPanel.Size = new System.Drawing.Size(1080, 724);
            this.viewTransactionsTableLayoutPanel.TabIndex = 0;
            // 
            // rentalTransactionDataGridView
            // 
            this.rentalTransactionDataGridView.AutoGenerateColumns = false;
            this.rentalTransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentalTransactionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rentalTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.rentalTransactionDataGridView, 2);
            this.rentalTransactionDataGridView.DataSource = this.rentalTransactionBindingSource;
            this.rentalTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTransactionDataGridView.Location = new System.Drawing.Point(3, 183);
            this.rentalTransactionDataGridView.MultiSelect = false;
            this.rentalTransactionDataGridView.Name = "rentalTransactionDataGridView";
            this.rentalTransactionDataGridView.RowHeadersWidth = 51;
            this.rentalTransactionDataGridView.RowTemplate.Height = 24;
            this.rentalTransactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalTransactionDataGridView.Size = new System.Drawing.Size(1074, 392);
            this.rentalTransactionDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransactionID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn3.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RentalDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "RentalDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // rentalTransactionBindingSource
            // 
            this.rentalTransactionBindingSource.DataSource = typeof(RentMe.Model.RentalTransaction);
            // 
            // viewAllRentalsButton
            // 
            this.viewAllRentalsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.viewAllRentalsButton, 2);
            this.viewAllRentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllRentalsButton.Location = new System.Drawing.Point(480, 667);
            this.viewAllRentalsButton.Name = "viewAllRentalsButton";
            this.viewAllRentalsButton.Size = new System.Drawing.Size(120, 40);
            this.viewAllRentalsButton.TabIndex = 26;
            this.viewAllRentalsButton.Text = "View All";
            this.viewAllRentalsButton.UseVisualStyleBackColor = true;
            this.viewAllRentalsButton.Click += new System.EventHandler(this.ViewAllButtonClick);
            // 
            // searchMemberTableLayoutPanel
            // 
            this.searchMemberTableLayoutPanel.ColumnCount = 5;
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.searchMemberTableLayoutPanel, 2);
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchMemberLabel, 1, 1);
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchRentalTextBox, 1, 0);
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchRentalsButton, 2, 0);
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchByComboBox, 3, 0);
            this.searchMemberTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchMemberTableLayoutPanel.Location = new System.Drawing.Point(3, 111);
            this.searchMemberTableLayoutPanel.Name = "searchMemberTableLayoutPanel";
            this.searchMemberTableLayoutPanel.RowCount = 2;
            this.searchMemberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.searchMemberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchMemberTableLayoutPanel.Size = new System.Drawing.Size(1074, 66);
            this.searchMemberTableLayoutPanel.TabIndex = 5;
            // 
            // searchMemberLabel
            // 
            this.searchMemberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchMemberLabel.AutoSize = true;
            this.searchMemberTableLayoutPanel.SetColumnSpan(this.searchMemberLabel, 3);
            this.searchMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberLabel.Location = new System.Drawing.Point(320, 46);
            this.searchMemberLabel.Name = "searchMemberLabel";
            this.searchMemberLabel.Size = new System.Drawing.Size(430, 20);
            this.searchMemberLabel.TabIndex = 3;
            this.searchMemberLabel.Text = "Search by ID of either transaction, employee, or member";
            // 
            // searchRentalTextBox
            // 
            this.searchRentalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchRentalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRentalTextBox.Location = new System.Drawing.Point(279, 9);
            this.searchRentalTextBox.MaxLength = 10;
            this.searchRentalTextBox.Name = "searchRentalTextBox";
            this.searchRentalTextBox.Size = new System.Drawing.Size(200, 28);
            this.searchRentalTextBox.TabIndex = 1;
            // 
            // searchRentalsButton
            // 
            this.searchRentalsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchRentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRentalsButton.Location = new System.Drawing.Point(485, 8);
            this.searchRentalsButton.Name = "searchRentalsButton";
            this.searchRentalsButton.Size = new System.Drawing.Size(100, 30);
            this.searchRentalsButton.TabIndex = 2;
            this.searchRentalsButton.Text = "Search";
            this.searchRentalsButton.UseVisualStyleBackColor = true;
            this.searchRentalsButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "TransactionID",
            "EmployeeID",
            "MemberID"});
            this.searchByComboBox.Location = new System.Drawing.Point(592, 7);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(200, 30);
            this.searchByComboBox.TabIndex = 4;
            // 
            // viewRentalTransactionsHeaderLabel
            // 
            this.viewRentalTransactionsHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewRentalTransactionsHeaderLabel.AutoSize = true;
            this.viewRentalTransactionsHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.viewRentalTransactionsHeaderLabel, 2);
            this.viewRentalTransactionsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRentalTransactionsHeaderLabel.Location = new System.Drawing.Point(204, 24);
            this.viewRentalTransactionsHeaderLabel.Name = "viewRentalTransactionsHeaderLabel";
            this.viewRentalTransactionsHeaderLabel.Size = new System.Drawing.Size(671, 60);
            this.viewRentalTransactionsHeaderLabel.TabIndex = 4;
            this.viewRentalTransactionsHeaderLabel.Text = "Member Rental Transactions";
            // 
            // statusMessage
            // 
            this.statusMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusMessage.AutoSize = true;
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.statusMessage, 2);
            this.statusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessage.ForeColor = System.Drawing.Color.Red;
            this.statusMessage.Location = new System.Drawing.Point(480, 604);
            this.statusMessage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(119, 24);
            this.statusMessage.TabIndex = 25;
            this.statusMessage.Text = "Invalid Fields";
            this.statusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusMessage.Visible = false;
            // 
            // ViewRentalTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewTransactionsTableLayoutPanel);
            this.Name = "ViewRentalTransactions";
            this.Size = new System.Drawing.Size(1080, 724);
            this.viewTransactionsTableLayoutPanel.ResumeLayout(false);
            this.viewTransactionsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).EndInit();
            this.searchMemberTableLayoutPanel.ResumeLayout(false);
            this.searchMemberTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel viewTransactionsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel searchMemberTableLayoutPanel;
        private System.Windows.Forms.Label searchMemberLabel;
        private System.Windows.Forms.TextBox searchRentalTextBox;
        private System.Windows.Forms.Button searchRentalsButton;
        private System.Windows.Forms.Label viewRentalTransactionsHeaderLabel;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.Button viewAllRentalsButton;
        private System.Windows.Forms.DataGridView rentalTransactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource rentalTransactionBindingSource;
        private System.Windows.Forms.ComboBox searchByComboBox;
    }
}
