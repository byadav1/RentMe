
namespace RentMe.UserControls
{
    partial class ViewTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewTransactionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTransactionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchMemberLabel = new System.Windows.Forms.Label();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.filterResultsComboBox = new System.Windows.Forms.ComboBox();
            this.viewTransactionsHeaderLabel = new System.Windows.Forms.Label();
            this.statusMessage = new System.Windows.Forms.Label();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewActiveRentalsButton = new System.Windows.Forms.Button();
            this.viewRentalsButton = new System.Windows.Forms.Button();
            this.viewReturnsButton = new System.Windows.Forms.Button();
            this.viewAllTransactionsButton = new System.Windows.Forms.Button();
            this.viewTransactionsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.searchTransactionsTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewTransactionsTableLayoutPanel
            // 
            this.viewTransactionsTableLayoutPanel.ColumnCount = 2;
            this.viewTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.transactionDataGridView, 0, 2);
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.searchTransactionsTableLayoutPanel, 0, 1);
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.viewTransactionsHeaderLabel, 0, 0);
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.statusMessage, 0, 3);
            this.viewTransactionsTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 4);
            this.viewTransactionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTransactionsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.viewTransactionsTableLayoutPanel.Name = "viewTransactionsTableLayoutPanel";
            this.viewTransactionsTableLayoutPanel.RowCount = 5;
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.viewTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewTransactionsTableLayoutPanel.Size = new System.Drawing.Size(1080, 725);
            this.viewTransactionsTableLayoutPanel.TabIndex = 0;
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.AllowUserToAddRows = false;
            this.transactionDataGridView.AllowUserToDeleteRows = false;
            this.transactionDataGridView.AutoGenerateColumns = false;
            this.transactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.transactionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionType,
            this.TransactionID,
            this.EmployeeID,
            this.MemberID,
            this.FurnitureName,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.Quantity,
            this.RentalDate,
            this.DueDate,
            this.ReturnDate,
            this.RentalCharge});
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.transactionDataGridView, 2);
            this.transactionDataGridView.DataSource = this.transactionBindingSource;
            this.transactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionDataGridView.Location = new System.Drawing.Point(3, 183);
            this.transactionDataGridView.MultiSelect = false;
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.ReadOnly = true;
            this.transactionDataGridView.RowHeadersWidth = 51;
            this.transactionDataGridView.RowTemplate.Height = 24;
            this.transactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionDataGridView.Size = new System.Drawing.Size(1074, 392);
            this.transactionDataGridView.TabIndex = 26;
            // 
            // TransactionType
            // 
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.HeaderText = "Type";
            this.TransactionType.MinimumWidth = 6;
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            this.TransactionType.Width = 69;
            // 
            // TransactionID
            // 
            this.TransactionID.DataPropertyName = "TransactionID";
            this.TransactionID.HeaderText = "TransactionID";
            this.TransactionID.MinimumWidth = 6;
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            this.TransactionID.Width = 125;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 112;
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            this.MemberID.HeaderText = "MemberID";
            this.MemberID.MinimumWidth = 6;
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Width = 101;
            // 
            // FurnitureName
            // 
            this.FurnitureName.DataPropertyName = "FurnitureName";
            this.FurnitureName.HeaderText = "Furniture Name";
            this.FurnitureName.MinimumWidth = 6;
            this.FurnitureName.Name = "FurnitureName";
            this.FurnitureName.ReadOnly = true;
            this.FurnitureName.Width = 124;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.DataPropertyName = "FurnitureCategory";
            this.FurnitureCategory.HeaderText = "Furniture Category";
            this.FurnitureCategory.MinimumWidth = 6;
            this.FurnitureCategory.Name = "FurnitureCategory";
            this.FurnitureCategory.ReadOnly = true;
            this.FurnitureCategory.Width = 142;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.DataPropertyName = "FurnitureStyle";
            this.FurnitureStyle.HeaderText = "Furniture Style";
            this.FurnitureStyle.MinimumWidth = 6;
            this.FurnitureStyle.Name = "FurnitureStyle";
            this.FurnitureStyle.ReadOnly = true;
            this.FurnitureStyle.Width = 118;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 90;
            // 
            // RentalDate
            // 
            this.RentalDate.DataPropertyName = "RentalDate";
            this.RentalDate.HeaderText = "Rental Date";
            this.RentalDate.MinimumWidth = 6;
            this.RentalDate.Name = "RentalDate";
            this.RentalDate.ReadOnly = true;
            this.RentalDate.Width = 103;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 90;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Width = 105;
            // 
            // RentalCharge
            // 
            this.RentalCharge.DataPropertyName = "RentalCharge";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.RentalCharge.DefaultCellStyle = dataGridViewCellStyle2;
            this.RentalCharge.HeaderText = "Rental Charge";
            this.RentalCharge.MinimumWidth = 6;
            this.RentalCharge.Name = "RentalCharge";
            this.RentalCharge.ReadOnly = true;
            this.RentalCharge.Width = 118;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(RentMe.Model.Transaction);
            // 
            // searchTransactionsTableLayoutPanel
            // 
            this.searchTransactionsTableLayoutPanel.ColumnCount = 6;
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.searchTransactionsTableLayoutPanel, 2);
            this.searchTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.searchTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchTransactionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.searchTransactionsTableLayoutPanel.Controls.Add(this.searchButton, 4, 0);
            this.searchTransactionsTableLayoutPanel.Controls.Add(this.searchTextBox, 3, 0);
            this.searchTransactionsTableLayoutPanel.Controls.Add(this.searchMemberLabel, 1, 1);
            this.searchTransactionsTableLayoutPanel.Controls.Add(this.searchByComboBox, 1, 0);
            this.searchTransactionsTableLayoutPanel.Controls.Add(this.filterResultsComboBox, 2, 0);
            this.searchTransactionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTransactionsTableLayoutPanel.Location = new System.Drawing.Point(3, 111);
            this.searchTransactionsTableLayoutPanel.Name = "searchTransactionsTableLayoutPanel";
            this.searchTransactionsTableLayoutPanel.RowCount = 2;
            this.searchTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.searchTransactionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchTransactionsTableLayoutPanel.Size = new System.Drawing.Size(1074, 66);
            this.searchTransactionsTableLayoutPanel.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.Enabled = false;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(806, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(596, 9);
            this.searchTextBox.MaxLength = 10;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 28);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchRentalTextBoxTextChanged);
            // 
            // searchMemberLabel
            // 
            this.searchMemberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchMemberLabel.AutoSize = true;
            this.searchTransactionsTableLayoutPanel.SetColumnSpan(this.searchMemberLabel, 4);
            this.searchMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberLabel.Location = new System.Drawing.Point(320, 46);
            this.searchMemberLabel.Name = "searchMemberLabel";
            this.searchMemberLabel.Size = new System.Drawing.Size(430, 20);
            this.searchMemberLabel.TabIndex = 3;
            this.searchMemberLabel.Text = "Search by ID of either transaction, employee, or member";
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "TransactionID",
            "EmployeeID",
            "MemberID"});
            this.searchByComboBox.Location = new System.Drawing.Point(168, 8);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(200, 30);
            this.searchByComboBox.TabIndex = 4;
            this.searchByComboBox.Enter += new System.EventHandler(this.FilterResultsComboBoxEnter);
            // 
            // filterResultsComboBox
            // 
            this.filterResultsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterResultsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterResultsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterResultsComboBox.FormattingEnabled = true;
            this.filterResultsComboBox.Items.AddRange(new object[] {
            "All Transactions",
            "Rentals",
            "Returns",
            "Active Rentals"});
            this.filterResultsComboBox.Location = new System.Drawing.Point(382, 7);
            this.filterResultsComboBox.Name = "filterResultsComboBox";
            this.filterResultsComboBox.Size = new System.Drawing.Size(200, 30);
            this.filterResultsComboBox.TabIndex = 6;
            this.filterResultsComboBox.Enter += new System.EventHandler(this.FilterResultsComboBoxEnter);
            // 
            // viewTransactionsHeaderLabel
            // 
            this.viewTransactionsHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewTransactionsHeaderLabel.AutoSize = true;
            this.viewTransactionsHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.viewTransactionsHeaderLabel, 2);
            this.viewTransactionsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTransactionsHeaderLabel.Location = new System.Drawing.Point(310, 24);
            this.viewTransactionsHeaderLabel.Name = "viewTransactionsHeaderLabel";
            this.viewTransactionsHeaderLabel.Size = new System.Drawing.Size(459, 60);
            this.viewTransactionsHeaderLabel.TabIndex = 4;
            this.viewTransactionsHeaderLabel.Text = "Transaction History";
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
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 4;
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.buttonsTableLayoutPanel, 2);
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsTableLayoutPanel.Controls.Add(this.viewActiveRentalsButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.viewRentalsButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.viewReturnsButton, 3, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.viewAllTransactionsButton, 2, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 653);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(1074, 69);
            this.buttonsTableLayoutPanel.TabIndex = 27;
            // 
            // viewActiveRentalsButton
            // 
            this.viewActiveRentalsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewActiveRentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewActiveRentalsButton.Location = new System.Drawing.Point(342, 4);
            this.viewActiveRentalsButton.Name = "viewActiveRentalsButton";
            this.viewActiveRentalsButton.Size = new System.Drawing.Size(120, 60);
            this.viewActiveRentalsButton.TabIndex = 31;
            this.viewActiveRentalsButton.Text = "View Active Rentals";
            this.viewActiveRentalsButton.UseVisualStyleBackColor = true;
            this.viewActiveRentalsButton.Click += new System.EventHandler(this.ViewActiveRentalsButtonClick);
            // 
            // viewRentalsButton
            // 
            this.viewRentalsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewRentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRentalsButton.Location = new System.Drawing.Point(74, 4);
            this.viewRentalsButton.Name = "viewRentalsButton";
            this.viewRentalsButton.Size = new System.Drawing.Size(120, 60);
            this.viewRentalsButton.TabIndex = 29;
            this.viewRentalsButton.Text = "View Rentals";
            this.viewRentalsButton.UseVisualStyleBackColor = true;
            this.viewRentalsButton.Click += new System.EventHandler(this.ViewRentalsButtonClick);
            // 
            // viewReturnsButton
            // 
            this.viewReturnsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewReturnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReturnsButton.Location = new System.Drawing.Point(879, 4);
            this.viewReturnsButton.Name = "viewReturnsButton";
            this.viewReturnsButton.Size = new System.Drawing.Size(120, 60);
            this.viewReturnsButton.TabIndex = 30;
            this.viewReturnsButton.Text = "View Returns";
            this.viewReturnsButton.UseVisualStyleBackColor = true;
            this.viewReturnsButton.Click += new System.EventHandler(this.ViewReturnsButtonClick);
            // 
            // viewAllTransactionsButton
            // 
            this.viewAllTransactionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewAllTransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllTransactionsButton.Location = new System.Drawing.Point(610, 4);
            this.viewAllTransactionsButton.Name = "viewAllTransactionsButton";
            this.viewAllTransactionsButton.Size = new System.Drawing.Size(120, 60);
            this.viewAllTransactionsButton.TabIndex = 28;
            this.viewAllTransactionsButton.Text = "View All";
            this.viewAllTransactionsButton.UseVisualStyleBackColor = true;
            this.viewAllTransactionsButton.Click += new System.EventHandler(this.ViewAllButtonClick);
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewTransactionsTableLayoutPanel);
            this.Name = "ViewTransactions";
            this.Size = new System.Drawing.Size(1080, 725);
            this.viewTransactionsTableLayoutPanel.ResumeLayout(false);
            this.viewTransactionsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.searchTransactionsTableLayoutPanel.ResumeLayout(false);
            this.searchTransactionsTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel viewTransactionsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel searchTransactionsTableLayoutPanel;
        private System.Windows.Forms.Label searchMemberLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label viewTransactionsHeaderLabel;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button viewRentalsButton;
        private System.Windows.Forms.Button viewAllTransactionsButton;
        private System.Windows.Forms.Button viewReturnsButton;
        private System.Windows.Forms.ComboBox filterResultsComboBox;
        private System.Windows.Forms.Button viewActiveRentalsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCharge;
    }
}
