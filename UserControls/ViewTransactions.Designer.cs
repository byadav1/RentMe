
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewTransactionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTransactionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchMemberLabel = new System.Windows.Forms.Label();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.filterResultsComboBox = new System.Windows.Forms.ComboBox();
            this.viewTransactionsHeaderLabel = new System.Windows.Forms.Label();
            this.statusMessage = new System.Windows.Forms.Label();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewRentalsButton = new System.Windows.Forms.Button();
            this.viewReturnsButton = new System.Windows.Forms.Button();
            this.viewAllTransactionsButton = new System.Windows.Forms.Button();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewTransactionsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            this.searchTransactionsTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
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
            this.transactionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transactionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionType,
            this.RentalTransactionID,
            this.ReturnTransactionID,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
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
            this.transactionDataGridView.TabIndex = 27;
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
            this.searchByComboBox.Location = new System.Drawing.Point(168, 7);
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
            "Returns"});
            this.filterResultsComboBox.Location = new System.Drawing.Point(382, 8);
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
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.viewTransactionsTableLayoutPanel.SetColumnSpan(this.buttonsTableLayoutPanel, 2);
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsTableLayoutPanel.Controls.Add(this.viewRentalsButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.viewReturnsButton, 2, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.viewAllTransactionsButton, 1, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 653);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(1074, 69);
            this.buttonsTableLayoutPanel.TabIndex = 27;
            // 
            // viewRentalsButton
            // 
            this.viewRentalsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewRentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRentalsButton.Location = new System.Drawing.Point(117, 4);
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
            this.viewReturnsButton.Location = new System.Drawing.Point(836, 4);
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
            this.viewAllTransactionsButton.Location = new System.Drawing.Point(476, 4);
            this.viewAllTransactionsButton.Name = "viewAllTransactionsButton";
            this.viewAllTransactionsButton.Size = new System.Drawing.Size(120, 60);
            this.viewAllTransactionsButton.TabIndex = 28;
            this.viewAllTransactionsButton.Text = "View All";
            this.viewAllTransactionsButton.UseVisualStyleBackColor = true;
            this.viewAllTransactionsButton.Click += new System.EventHandler(this.ViewAllButtonClick);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(RentMe.Model.Transaction);
            // 
            // TransactionType
            // 
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.HeaderText = "TransactionType";
            this.TransactionType.MinimumWidth = 6;
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            this.TransactionType.Width = 144;
            // 
            // RentalTransactionID
            // 
            this.RentalTransactionID.DataPropertyName = "RentalTransactionID";
            this.RentalTransactionID.HeaderText = "Rental TransactionID";
            this.RentalTransactionID.MinimumWidth = 6;
            this.RentalTransactionID.Name = "RentalTransactionID";
            this.RentalTransactionID.ReadOnly = true;
            this.RentalTransactionID.Width = 155;
            // 
            // ReturnTransactionID
            // 
            this.ReturnTransactionID.DataPropertyName = "ReturnTransactionID";
            this.ReturnTransactionID.HeaderText = "Return TransactionID";
            this.ReturnTransactionID.MinimumWidth = 6;
            this.ReturnTransactionID.Name = "ReturnTransactionID";
            this.ReturnTransactionID.ReadOnly = true;
            this.ReturnTransactionID.Width = 157;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn4.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 101;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FurnitureName";
            this.dataGridViewTextBoxColumn5.HeaderText = "FurnitureName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 131;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FurnitureCategory";
            this.dataGridViewTextBoxColumn6.HeaderText = "FurnitureCategory";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 151;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FurnitureStyle";
            this.dataGridViewTextBoxColumn7.HeaderText = "FurnitureStyle";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RentalDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn9.HeaderText = "RentalDate";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 108;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DueDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn10.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 93;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ReturnDate";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn11.HeaderText = "ReturnDate";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 110;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "RentalCharge";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn12.HeaderText = "RentalCharge";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 124;
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
            this.searchTransactionsTableLayoutPanel.ResumeLayout(false);
            this.searchTransactionsTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button viewRentalsButton;
        private System.Windows.Forms.Button viewAllTransactionsButton;
        private System.Windows.Forms.Button viewReturnsButton;
        private System.Windows.Forms.ComboBox filterResultsComboBox;
        private System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}
