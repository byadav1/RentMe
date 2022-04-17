﻿
namespace RentMe.UserControls
{
    /// <summary>
    /// Designer class to rent a furniture
    /// </summary>
    partial class FurnitureRental
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
            this.furnitureRentalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureDateGridView = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyRentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rentme = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.searchOptionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.categoryRadioButton = new System.Windows.Forms.RadioButton();
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.furnitureIDTextBox = new System.Windows.Forms.TextBox();
            this.optionTipLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.stylerRadiobutton = new System.Windows.Forms.RadioButton();
            this.furnitureSearchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rentAllButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rentalStatusLabel = new System.Windows.Forms.Label();
            this.furnitureRentalHeaderLableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureRentalHeaderLabel = new System.Windows.Forms.Label();
            this.memberFirstName = new System.Windows.Forms.Label();
            this.viewCartLinkLabel = new System.Windows.Forms.LinkLabel();
            this.memberSearchButton = new System.Windows.Forms.Button();
            this.memberIDRentTextBox = new System.Windows.Forms.TextBox();
            this.memberInfoLabel = new System.Windows.Forms.Label();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.furnitureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentFurnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureRentalTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDateGridView)).BeginInit();
            this.searchOptionTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.furnitureRentalHeaderLableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentFurnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // furnitureRentalTableLayoutPanel
            // 
            this.furnitureRentalTableLayoutPanel.AutoSize = true;
            this.furnitureRentalTableLayoutPanel.ColumnCount = 1;
            this.furnitureRentalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.furnitureDateGridView, 0, 3);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.searchOptionTableLayout, 0, 1);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.rentalStatusLabel, 0, 2);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.furnitureRentalHeaderLableLayoutPanel, 0, 0);
            this.furnitureRentalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureRentalTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureRentalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.furnitureRentalTableLayoutPanel.Name = "furnitureRentalTableLayoutPanel";
            this.furnitureRentalTableLayoutPanel.RowCount = 6;
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.11808F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.86723F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.312572F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.69394F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.00817F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.furnitureRentalTableLayoutPanel.Size = new System.Drawing.Size(1391, 785);
            this.furnitureRentalTableLayoutPanel.TabIndex = 0;
            // 
            // furnitureDateGridView
            // 
            this.furnitureDateGridView.AllowUserToDeleteRows = false;
            this.furnitureDateGridView.AllowUserToOrderColumns = true;
            this.furnitureDateGridView.AutoGenerateColumns = false;
            this.furnitureDateGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.furnitureDateGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.furnitureDateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureDateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.furnitureIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.Quantity,
            this.DailyRentalRate,
            this.AddQuantity,
            this.DueDate,
            this.Rentme});
            this.furnitureDateGridView.DataSource = this.furnitureBindingSource;
            this.furnitureDateGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureDateGridView.EnableHeadersVisualStyles = false;
            this.furnitureDateGridView.Location = new System.Drawing.Point(3, 401);
            this.furnitureDateGridView.Name = "furnitureDateGridView";
            this.furnitureDateGridView.RowHeadersWidth = 51;
            this.furnitureDateGridView.RowTemplate.Height = 24;
            this.furnitureDateGridView.Size = new System.Drawing.Size(1385, 274);
            this.furnitureDateGridView.TabIndex = 10;
            this.furnitureDateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FurnitureDateGridView_CellContentClick);
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "AvailableQuantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 194;
            // 
            // DailyRentalRate
            // 
            this.DailyRentalRate.DataPropertyName = "DailyRentalRate";
            this.DailyRentalRate.HeaderText = "DailyRentalRate";
            this.DailyRentalRate.MinimumWidth = 6;
            this.DailyRentalRate.Name = "DailyRentalRate";
            this.DailyRentalRate.ReadOnly = true;
            this.DailyRentalRate.Width = 179;
            // 
            // AddQuantity
            // 
            this.AddQuantity.HeaderText = "RentQuantity";
            this.AddQuantity.MinimumWidth = 6;
            this.AddQuantity.Name = "AddQuantity";
            this.AddQuantity.Width = 154;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "ReturnDate";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 139;
            // 
            // Rentme
            // 
            this.Rentme.HeaderText = "Rent Me";
            this.Rentme.MinimumWidth = 6;
            this.Rentme.Name = "Rentme";
            this.Rentme.Width = 91;
            // 
            // searchOptionTableLayout
            // 
            this.searchOptionTableLayout.ColumnCount = 8;
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90083F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.86778F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90083F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.87604F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.87604F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.15467F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.42381F));
            this.searchOptionTableLayout.Controls.Add(this.categoryRadioButton, 2, 0);
            this.searchOptionTableLayout.Controls.Add(this.idRadioButton, 0, 0);
            this.searchOptionTableLayout.Controls.Add(this.furnitureIDTextBox, 1, 0);
            this.searchOptionTableLayout.Controls.Add(this.optionTipLabel, 2, 1);
            this.searchOptionTableLayout.Controls.Add(this.categoryComboBox, 3, 0);
            this.searchOptionTableLayout.Controls.Add(this.styleComboBox, 5, 0);
            this.searchOptionTableLayout.Controls.Add(this.stylerRadiobutton, 4, 0);
            this.searchOptionTableLayout.Controls.Add(this.clearButton, 7, 0);
            this.searchOptionTableLayout.Controls.Add(this.furnitureSearchButton, 6, 0);
            this.searchOptionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchOptionTableLayout.Location = new System.Drawing.Point(3, 187);
            this.searchOptionTableLayout.Name = "searchOptionTableLayout";
            this.searchOptionTableLayout.RowCount = 2;
            this.searchOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.searchOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.searchOptionTableLayout.Size = new System.Drawing.Size(1385, 176);
            this.searchOptionTableLayout.TabIndex = 1;
            // 
            // categoryRadioButton
            // 
            this.categoryRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryRadioButton.AutoSize = true;
            this.categoryRadioButton.Location = new System.Drawing.Point(296, 48);
            this.categoryRadioButton.Name = "categoryRadioButton";
            this.categoryRadioButton.Size = new System.Drawing.Size(190, 29);
            this.categoryRadioButton.TabIndex = 4;
            this.categoryRadioButton.TabStop = true;
            this.categoryRadioButton.Text = "Furniture Category:";
            this.categoryRadioButton.UseVisualStyleBackColor = true;
            this.categoryRadioButton.CheckedChanged += new System.EventHandler(this.CategoryRadioButtonCheckedChanged);
            // 
            // idRadioButton
            // 
            this.idRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idRadioButton.AutoSize = true;
            this.idRadioButton.Checked = true;
            this.idRadioButton.Location = new System.Drawing.Point(3, 48);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(140, 29);
            this.idRadioButton.TabIndex = 2;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "Furniture ID:";
            this.idRadioButton.UseVisualStyleBackColor = true;
            this.idRadioButton.CheckedChanged += new System.EventHandler(this.IdRadioButtonCheckedChanged);
            // 
            // furnitureIDTextBox
            // 
            this.furnitureIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.furnitureIDTextBox.Location = new System.Drawing.Point(149, 47);
            this.furnitureIDTextBox.Name = "furnitureIDTextBox";
            this.furnitureIDTextBox.Size = new System.Drawing.Size(141, 30);
            this.furnitureIDTextBox.TabIndex = 3;
            this.furnitureIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // optionTipLabel
            // 
            this.optionTipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optionTipLabel.AutoSize = true;
            this.searchOptionTableLayout.SetColumnSpan(this.optionTipLabel, 4);
            this.optionTipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTipLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.optionTipLabel.Location = new System.Drawing.Point(378, 125);
            this.optionTipLabel.Name = "optionTipLabel";
            this.optionTipLabel.Size = new System.Drawing.Size(540, 18);
            this.optionTipLabel.TabIndex = 7;
            this.optionTipLabel.Text = "**Please  select an option to enter furniture ID or category or style to rent fur" +
    "niture";
            this.optionTipLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(515, 46);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(95, 33);
            this.categoryComboBox.TabIndex = 5;
            this.categoryComboBox.VisibleChanged += new System.EventHandler(this.CategoryComboBoxVisibleChanged);
            // 
            // styleComboBox
            // 
            this.styleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(829, 46);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(165, 33);
            this.styleComboBox.TabIndex = 7;
            this.styleComboBox.VisibleChanged += new System.EventHandler(this.StyleComboBoxVisibleChanged);
            this.styleComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StyleComboBoxKeyPress);
            // 
            // stylerRadiobutton
            // 
            this.stylerRadiobutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stylerRadiobutton.AutoSize = true;
            this.stylerRadiobutton.Location = new System.Drawing.Point(645, 48);
            this.stylerRadiobutton.Name = "stylerRadiobutton";
            this.stylerRadiobutton.Size = new System.Drawing.Size(165, 29);
            this.stylerRadiobutton.TabIndex = 6;
            this.stylerRadiobutton.TabStop = true;
            this.stylerRadiobutton.Text = "Furniture Style:";
            this.stylerRadiobutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stylerRadiobutton.UseVisualStyleBackColor = true;
            this.stylerRadiobutton.CheckedChanged += new System.EventHandler(this.StylerRadiobuttonCheckedChanged);
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.furnitureSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchButton.Location = new System.Drawing.Point(1047, 3);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new System.Drawing.Size(113, 40);
            this.furnitureSearchButton.TabIndex = 8;
            this.furnitureSearchButton.Text = "Search";
            this.furnitureSearchButton.UseVisualStyleBackColor = true;
            this.furnitureSearchButton.Click += new System.EventHandler(this.FurnitureSearchButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(1244, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 40);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rentAllButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addToCartButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 681);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1380, 78);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // rentAllButton
            // 
            this.rentAllButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAllButton.Location = new System.Drawing.Point(975, 14);
            this.rentAllButton.Name = "rentAllButton";
            this.rentAllButton.Size = new System.Drawing.Size(120, 49);
            this.rentAllButton.TabIndex = 0;
            this.rentAllButton.Text = "Rent All";
            this.rentAllButton.UseVisualStyleBackColor = true;
            this.rentAllButton.Click += new System.EventHandler(this.RentAllButton_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.Location = new System.Drawing.Point(285, 14);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(120, 49);
            this.addToCartButton.TabIndex = 1;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 765);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 16);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // rentalStatusLabel
            // 
            this.rentalStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentalStatusLabel.AutoSize = true;
            this.rentalStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.rentalStatusLabel.Location = new System.Drawing.Point(669, 370);
            this.rentalStatusLabel.Name = "rentalStatusLabel";
            this.rentalStatusLabel.Size = new System.Drawing.Size(52, 24);
            this.rentalStatusLabel.TabIndex = 3;
            this.rentalStatusLabel.Text = "Error";
            this.rentalStatusLabel.Visible = false;
            // 
            // furnitureRentalHeaderLableLayoutPanel
            // 
            this.furnitureRentalHeaderLableLayoutPanel.ColumnCount = 6;
            this.furnitureRentalHeaderLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77777F));
            this.furnitureRentalHeaderLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88889F));
            this.furnitureRentalHeaderLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88889F));
            this.furnitureRentalHeaderLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88889F));
            this.furnitureRentalHeaderLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88889F));
            this.furnitureRentalHeaderLableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.furnitureRentalHeaderLableLayoutPanel.Controls.Add(this.furnitureRentalHeaderLabel, 0, 0);
            this.furnitureRentalHeaderLableLayoutPanel.Controls.Add(this.memberInfoLabel, 3, 1);
            this.furnitureRentalHeaderLableLayoutPanel.Controls.Add(this.viewCartLinkLabel, 5, 0);
            this.furnitureRentalHeaderLableLayoutPanel.Controls.Add(this.memberSearchButton, 4, 0);
            this.furnitureRentalHeaderLableLayoutPanel.Controls.Add(this.memberIDRentTextBox, 3, 0);
            this.furnitureRentalHeaderLableLayoutPanel.Controls.Add(this.memberFirstName, 1, 1);
            this.furnitureRentalHeaderLableLayoutPanel.Controls.Add(this.memberIDLabel, 2, 1);
            this.furnitureRentalHeaderLableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureRentalHeaderLableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.furnitureRentalHeaderLableLayoutPanel.Name = "furnitureRentalHeaderLableLayoutPanel";
            this.furnitureRentalHeaderLableLayoutPanel.RowCount = 2;
            this.furnitureRentalHeaderLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.3553F));
            this.furnitureRentalHeaderLableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.64471F));
            this.furnitureRentalHeaderLableLayoutPanel.Size = new System.Drawing.Size(1385, 178);
            this.furnitureRentalHeaderLableLayoutPanel.TabIndex = 13;
            // 
            // furnitureRentalHeaderLabel
            // 
            this.furnitureRentalHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.furnitureRentalHeaderLabel.AutoSize = true;
            this.furnitureRentalHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.furnitureRentalHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureRentalHeaderLabel.Location = new System.Drawing.Point(71, 0);
            this.furnitureRentalHeaderLabel.Name = "furnitureRentalHeaderLabel";
            this.furnitureRentalHeaderLabel.Size = new System.Drawing.Size(242, 118);
            this.furnitureRentalHeaderLabel.TabIndex = 8;
            this.furnitureRentalHeaderLabel.Text = "Furniture Rental";
            // 
            // memberFirstName
            // 
            this.memberFirstName.AutoSize = true;
            this.memberFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.memberFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memberFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberFirstName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.memberFirstName.Location = new System.Drawing.Point(387, 118);
            this.memberFirstName.Name = "memberFirstName";
            this.memberFirstName.Size = new System.Drawing.Size(186, 60);
            this.memberFirstName.TabIndex = 13;
            this.memberFirstName.Text = "Name :";
            this.memberFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memberFirstName.Visible = false;
            // 
            // viewCartLinkLabel
            // 
            this.viewCartLinkLabel.AutoSize = true;
            this.viewCartLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCartLinkLabel.Location = new System.Drawing.Point(1155, 0);
            this.viewCartLinkLabel.Name = "viewCartLinkLabel";
            this.viewCartLinkLabel.Size = new System.Drawing.Size(227, 118);
            this.viewCartLinkLabel.TabIndex = 17;
            this.viewCartLinkLabel.TabStop = true;
            this.viewCartLinkLabel.Text = "View Cart";
            this.viewCartLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewCartLinkLabel_LinkClicked);
            // 
            // memberSearchButton
            // 
            this.memberSearchButton.Enabled = false;
            this.memberSearchButton.Location = new System.Drawing.Point(963, 3);
            this.memberSearchButton.Name = "memberSearchButton";
            this.memberSearchButton.Size = new System.Drawing.Size(124, 30);
            this.memberSearchButton.TabIndex = 12;
            this.memberSearchButton.Text = "Search";
            this.memberSearchButton.UseVisualStyleBackColor = true;
            this.memberSearchButton.Click += new System.EventHandler(this.MemberSearchButton_Click);
            // 
            // memberIDRentTextBox
            // 
            this.memberIDRentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberIDRentTextBox.Enabled = false;
            this.memberIDRentTextBox.Location = new System.Drawing.Point(771, 3);
            this.memberIDRentTextBox.Name = "memberIDRentTextBox";
            this.memberIDRentTextBox.Size = new System.Drawing.Size(186, 30);
            this.memberIDRentTextBox.TabIndex = 10;
            this.memberIDRentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // memberInfoLabel
            // 
            this.memberInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.memberInfoLabel.AutoSize = true;
            this.furnitureRentalHeaderLableLayoutPanel.SetColumnSpan(this.memberInfoLabel, 3);
            this.memberInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memberInfoLabel.Location = new System.Drawing.Point(801, 118);
            this.memberInfoLabel.Name = "memberInfoLabel";
            this.memberInfoLabel.Size = new System.Drawing.Size(550, 18);
            this.memberInfoLabel.TabIndex = 11;
            this.memberInfoLabel.Text = "**Member details are mandatory.Search for a member by their ID, Phone, or Name";
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.BackColor = System.Drawing.SystemColors.Control;
            this.memberIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.memberIDLabel.Location = new System.Drawing.Point(579, 118);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(186, 60);
            this.memberIDLabel.TabIndex = 15;
            this.memberIDLabel.Text = "MemberID:";
            this.memberIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memberIDLabel.Visible = false;
            // 
            // furnitureIDDataGridViewTextBoxColumn
            // 
            this.furnitureIDDataGridViewTextBoxColumn.DataPropertyName = "FurnitureID";
            this.furnitureIDDataGridViewTextBoxColumn.HeaderText = "FurnitureID";
            this.furnitureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.furnitureIDDataGridViewTextBoxColumn.Name = "furnitureIDDataGridViewTextBoxColumn";
            this.furnitureIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.furnitureIDDataGridViewTextBoxColumn.Width = 137;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 93;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 138;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 121;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.ReadOnly = true;
            this.styleDataGridViewTextBoxColumn.Width = 85;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(RentMe.Model.Furniture);
            // 
            // rentFurnitureBindingSource
            // 
            this.rentFurnitureBindingSource.DataSource = typeof(RentMe.Model.RentFurniture);
            // 
            // FurnitureRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.furnitureRentalTableLayoutPanel);
            this.Name = "FurnitureRental";
            this.Size = new System.Drawing.Size(1391, 785);
            this.Load += new System.EventHandler(this.FurnitureRentalLoad);
            this.VisibleChanged += new System.EventHandler(this.FurnitureRentalVisibleChanged);
            this.furnitureRentalTableLayoutPanel.ResumeLayout(false);
            this.furnitureRentalTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDateGridView)).EndInit();
            this.searchOptionTableLayout.ResumeLayout(false);
            this.searchOptionTableLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.furnitureRentalHeaderLableLayoutPanel.ResumeLayout(false);
            this.furnitureRentalHeaderLableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentFurnitureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel furnitureRentalTableLayoutPanel;
        private System.Windows.Forms.Button rentAllButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.TableLayoutPanel searchOptionTableLayout;
        private System.Windows.Forms.TextBox furnitureIDTextBox;
        private System.Windows.Forms.Label rentalStatusLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.RadioButton stylerRadiobutton;
        private System.Windows.Forms.RadioButton categoryRadioButton;
        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.Label furnitureRentalHeaderLabel;
        private System.Windows.Forms.Label memberInfoLabel;
        private System.Windows.Forms.Button memberSearchButton;
        private System.Windows.Forms.Label memberFirstName;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.DataGridView furnitureDateGridView;
        private System.Windows.Forms.LinkLabel viewCartLinkLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource rentFurnitureBindingSource;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyRentalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rentme;
        private System.Windows.Forms.TextBox memberIDRentTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel furnitureRentalHeaderLableLayoutPanel;
        private System.Windows.Forms.Label optionTipLabel;
        private System.Windows.Forms.Button furnitureSearchButton;
        private System.Windows.Forms.Button clearButton;
    }
}
