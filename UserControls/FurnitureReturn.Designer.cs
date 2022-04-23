
namespace RentMe.UserControls
{
    partial class FurnitureReturn
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
            this.RentalMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rentalTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.rentalTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchMemberLabel = new System.Windows.Forms.Label();
            this.furnitureReturnHeaderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.memberTabelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.statusMessageLabel = new System.Windows.Forms.Label();
            this.processButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.processReturnbutton = new System.Windows.Forms.Button();
            this.RentedItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnMe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RentalMainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.memberTabelLayoutPanel.SuspendLayout();
            this.processButtonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RentalMainTableLayoutPanel
            // 
            this.RentalMainTableLayoutPanel.ColumnCount = 1;
            this.RentalMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RentalMainTableLayoutPanel.Controls.Add(this.rentalTransactionDataGridView, 0, 5);
            this.RentalMainTableLayoutPanel.Controls.Add(this.searchMemberLabel, 0, 2);
            this.RentalMainTableLayoutPanel.Controls.Add(this.furnitureReturnHeaderLabel, 0, 0);
            this.RentalMainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.RentalMainTableLayoutPanel.Controls.Add(this.memberTabelLayoutPanel, 0, 3);
            this.RentalMainTableLayoutPanel.Controls.Add(this.statusMessageLabel, 0, 4);
            this.RentalMainTableLayoutPanel.Controls.Add(this.processButtonLayoutPanel, 0, 6);
            this.RentalMainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentalMainTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalMainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RentalMainTableLayoutPanel.Name = "RentalMainTableLayoutPanel";
            this.RentalMainTableLayoutPanel.RowCount = 7;
            this.RentalMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06194F));
            this.RentalMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.322561F));
            this.RentalMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.028589F));
            this.RentalMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.28672F));
            this.RentalMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.028589F));
            this.RentalMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.23824F));
            this.RentalMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.033354F));
            this.RentalMainTableLayoutPanel.Size = new System.Drawing.Size(1328, 590);
            this.RentalMainTableLayoutPanel.TabIndex = 0;
            // 
            // rentalTransactionDataGridView
            // 
            this.rentalTransactionDataGridView.AllowUserToAddRows = false;
            this.rentalTransactionDataGridView.AllowUserToDeleteRows = false;
            this.rentalTransactionDataGridView.AutoGenerateColumns = false;
            this.rentalTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentedItemsID,
            this.FurnitureID,
            this.FurnitureName,
            this.EmployeeID,
            this.MemberID,
            this.DueDate,
            this.RentDate,
            this.Category,
            this.Style,
            this.Description,
            this.RentalRate,
            this.Quantity,
            this.ReturnQuantity,
            this.ReturnMe});
            this.rentalTransactionDataGridView.DataSource = this.rentalTransactionBindingSource;
            this.rentalTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalTransactionDataGridView.Location = new System.Drawing.Point(3, 253);
            this.rentalTransactionDataGridView.Name = "rentalTransactionDataGridView";
            this.rentalTransactionDataGridView.RowHeadersWidth = 51;
            this.rentalTransactionDataGridView.RowTemplate.Height = 24;
            this.rentalTransactionDataGridView.Size = new System.Drawing.Size(1322, 290);
            this.rentalTransactionDataGridView.TabIndex = 26;
            // 
            // rentalTransactionBindingSource
            // 
            this.rentalTransactionBindingSource.DataSource = typeof(RentMe.Model.RentalTransaction);
            // 
            // searchMemberLabel
            // 
            this.searchMemberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchMemberLabel.AutoSize = true;
            this.searchMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberLabel.Location = new System.Drawing.Point(559, 141);
            this.searchMemberLabel.Name = "searchMemberLabel";
            this.searchMemberLabel.Size = new System.Drawing.Size(209, 17);
            this.searchMemberLabel.TabIndex = 5;
            this.searchMemberLabel.Text = "Search for a member by their ID";
            // 
            // furnitureReturnHeaderLabel
            // 
            this.furnitureReturnHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.furnitureReturnHeaderLabel.AutoSize = true;
            this.furnitureReturnHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.furnitureReturnHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureReturnHeaderLabel.Location = new System.Drawing.Point(509, 14);
            this.furnitureReturnHeaderLabel.Name = "furnitureReturnHeaderLabel";
            this.furnitureReturnHeaderLabel.Size = new System.Drawing.Size(310, 48);
            this.furnitureReturnHeaderLabel.TabIndex = 3;
            this.furnitureReturnHeaderLabel.Text = "Furniture Return";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.searchButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchTextbox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1322, 49);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.Location = new System.Drawing.Point(752, 8);
            this.searchButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchTextbox.Location = new System.Drawing.Point(494, 12);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(230, 24);
            this.searchTextbox.TabIndex = 0;
            this.searchTextbox.TextChanged += new System.EventHandler(this.SearchTextboxTextChanged);
            // 
            // memberTabelLayoutPanel
            // 
            this.memberTabelLayoutPanel.ColumnCount = 2;
            this.memberTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.memberTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.memberTabelLayoutPanel.Controls.Add(this.memberNameLabel, 0, 0);
            this.memberTabelLayoutPanel.Controls.Add(this.memberIDLabel, 0, 0);
            this.memberTabelLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberTabelLayoutPanel.Location = new System.Drawing.Point(3, 170);
            this.memberTabelLayoutPanel.Name = "memberTabelLayoutPanel";
            this.memberTabelLayoutPanel.RowCount = 1;
            this.memberTabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memberTabelLayoutPanel.Size = new System.Drawing.Size(1322, 42);
            this.memberTabelLayoutPanel.TabIndex = 6;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.memberNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memberNameLabel.Location = new System.Drawing.Point(637, 12);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(52, 18);
            this.memberNameLabel.TabIndex = 3;
            this.memberNameLabel.Text = "Name:";
            this.memberNameLabel.Visible = false;
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.memberIDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memberIDLabel.Location = new System.Drawing.Point(546, 12);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(85, 18);
            this.memberIDLabel.TabIndex = 2;
            this.memberIDLabel.Text = "Member ID:";
            this.memberIDLabel.Visible = false;
            // 
            // statusMessageLabel
            // 
            this.statusMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusMessageLabel.AutoSize = true;
            this.statusMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.statusMessageLabel.Location = new System.Drawing.Point(618, 225);
            this.statusMessageLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.statusMessageLabel.Name = "statusMessageLabel";
            this.statusMessageLabel.Size = new System.Drawing.Size(91, 18);
            this.statusMessageLabel.TabIndex = 25;
            this.statusMessageLabel.Text = "Invalid Fields";
            this.statusMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusMessageLabel.Visible = false;
            // 
            // processButtonLayoutPanel
            // 
            this.processButtonLayoutPanel.ColumnCount = 2;
            this.processButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.processButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.processButtonLayoutPanel.Controls.Add(this.clearButton, 1, 0);
            this.processButtonLayoutPanel.Controls.Add(this.processReturnbutton, 0, 0);
            this.processButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processButtonLayoutPanel.Location = new System.Drawing.Point(3, 549);
            this.processButtonLayoutPanel.Name = "processButtonLayoutPanel";
            this.processButtonLayoutPanel.RowCount = 1;
            this.processButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.processButtonLayoutPanel.Size = new System.Drawing.Size(1322, 38);
            this.processButtonLayoutPanel.TabIndex = 26;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clearButton.Location = new System.Drawing.Point(686, 3);
            this.clearButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 32);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // processReturnbutton
            // 
            this.processReturnbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.processReturnbutton.Location = new System.Drawing.Point(482, 3);
            this.processReturnbutton.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.processReturnbutton.Name = "processReturnbutton";
            this.processReturnbutton.Size = new System.Drawing.Size(154, 32);
            this.processReturnbutton.TabIndex = 0;
            this.processReturnbutton.Text = "Process Return";
            this.processReturnbutton.UseVisualStyleBackColor = true;
            this.processReturnbutton.Click += new System.EventHandler(this.ProcessReturnButtonClick);
            // 
            // RentedItemsID
            // 
            this.RentedItemsID.DataPropertyName = "RentedItemsID";
            this.RentedItemsID.HeaderText = "RentedItemsID";
            this.RentedItemsID.MinimumWidth = 6;
            this.RentedItemsID.Name = "RentedItemsID";
            this.RentedItemsID.Visible = false;
            this.RentedItemsID.Width = 125;
            // 
            // FurnitureID
            // 
            this.FurnitureID.DataPropertyName = "FurnitureID";
            this.FurnitureID.HeaderText = "FurnitureID";
            this.FurnitureID.MinimumWidth = 6;
            this.FurnitureID.Name = "FurnitureID";
            this.FurnitureID.Width = 125;
            // 
            // FurnitureName
            // 
            this.FurnitureName.DataPropertyName = "FurnitureName";
            this.FurnitureName.HeaderText = "Furniture Name";
            this.FurnitureName.MinimumWidth = 6;
            this.FurnitureName.Name = "FurnitureName";
            this.FurnitureName.ReadOnly = true;
            this.FurnitureName.Width = 125;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Visible = false;
            this.EmployeeID.Width = 125;
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            this.MemberID.HeaderText = "MemberID";
            this.MemberID.MinimumWidth = 6;
            this.MemberID.Name = "MemberID";
            this.MemberID.Visible = false;
            this.MemberID.Width = 125;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 125;
            // 
            // RentDate
            // 
            this.RentDate.DataPropertyName = "RentDate";
            this.RentDate.HeaderText = "Rent Date";
            this.RentDate.MinimumWidth = 6;
            this.RentDate.Name = "RentDate";
            this.RentDate.ReadOnly = true;
            this.RentDate.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.MinimumWidth = 6;
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            this.Style.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // RentalRate
            // 
            this.RentalRate.DataPropertyName = "RentalRate";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.RentalRate.DefaultCellStyle = dataGridViewCellStyle1;
            this.RentalRate.HeaderText = "Rental Rate";
            this.RentalRate.MinimumWidth = 6;
            this.RentalRate.Name = "RentalRate";
            this.RentalRate.ReadOnly = true;
            this.RentalRate.Width = 130;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // ReturnQuantity
            // 
            this.ReturnQuantity.HeaderText = "Return Quantity";
            this.ReturnQuantity.MinimumWidth = 6;
            this.ReturnQuantity.Name = "ReturnQuantity";
            this.ReturnQuantity.Width = 125;
            // 
            // ReturnMe
            // 
            this.ReturnMe.HeaderText = "Return Me";
            this.ReturnMe.MinimumWidth = 6;
            this.ReturnMe.Name = "ReturnMe";
            this.ReturnMe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnMe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReturnMe.Width = 130;
            // 
            // FurnitureReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RentalMainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FurnitureReturn";
            this.Size = new System.Drawing.Size(1328, 590);
            this.RentalMainTableLayoutPanel.ResumeLayout(false);
            this.RentalMainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.memberTabelLayoutPanel.ResumeLayout(false);
            this.memberTabelLayoutPanel.PerformLayout();
            this.processButtonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RentalMainTableLayoutPanel;
        private System.Windows.Forms.Label furnitureReturnHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label searchMemberLabel;
        private System.Windows.Forms.TableLayoutPanel memberTabelLayoutPanel;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label statusMessageLabel;
        private System.Windows.Forms.TableLayoutPanel processButtonLayoutPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button processReturnbutton;
        private System.Windows.Forms.DataGridView rentalTransactionDataGridView;
        private System.Windows.Forms.BindingSource rentalTransactionBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReturnMe;
    }
}
