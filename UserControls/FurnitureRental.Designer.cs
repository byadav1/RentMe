﻿
namespace RentMe.UserControls
{
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
            this.furnitureRentalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.furnitureRentalHeaderLabel = new System.Windows.Forms.Label();
            this.cartButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rentAllButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.orderDetailsButton = new System.Windows.Forms.Button();
            this.viewCartButton = new System.Windows.Forms.Button();
            this.furnitureListView = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stylecolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rentalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchOptionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.categoryRadioButton = new System.Windows.Forms.RadioButton();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.furnitureIDTextBox = new System.Windows.Forms.TextBox();
            this.stylerRadiobutton = new System.Windows.Forms.RadioButton();
            this.optionTipLabel = new System.Windows.Forms.Label();
            this.furnitureSearchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.memberIDRentTextBox = new System.Windows.Forms.TextBox();
            this.memberSearchButton = new System.Windows.Forms.Button();
            this.memberInfoLabel = new System.Windows.Forms.Label();
            this.memberFirstName = new System.Windows.Forms.Label();
            this.rentalStatusLabel = new System.Windows.Forms.Label();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.memberIdRentLabel = new System.Windows.Forms.Label();
            this.furnitureRentalTableLayoutPanel.SuspendLayout();
            this.cartButtonsTableLayoutPanel.SuspendLayout();
            this.searchOptionTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // furnitureRentalTableLayoutPanel
            // 
            this.furnitureRentalTableLayoutPanel.AutoSize = true;
            this.furnitureRentalTableLayoutPanel.ColumnCount = 1;
            this.furnitureRentalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.furnitureRentalHeaderLabel, 0, 0);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.cartButtonsTableLayoutPanel, 0, 5);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.furnitureListView, 0, 4);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.searchOptionTableLayout, 0, 2);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.rentalStatusLabel, 0, 3);
            this.furnitureRentalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureRentalTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureRentalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.furnitureRentalTableLayoutPanel.Name = "furnitureRentalTableLayoutPanel";
            this.furnitureRentalTableLayoutPanel.RowCount = 6;
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.026757F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.360196F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.26714F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.193476F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.39082F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.761604F));
            this.furnitureRentalTableLayoutPanel.Size = new System.Drawing.Size(1391, 785);
            this.furnitureRentalTableLayoutPanel.TabIndex = 0;
            // 
            // furnitureRentalHeaderLabel
            // 
            this.furnitureRentalHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.furnitureRentalHeaderLabel.AutoSize = true;
            this.furnitureRentalHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.furnitureRentalHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureRentalHeaderLabel.Location = new System.Drawing.Point(502, 5);
            this.furnitureRentalHeaderLabel.Name = "furnitureRentalHeaderLabel";
            this.furnitureRentalHeaderLabel.Size = new System.Drawing.Size(387, 60);
            this.furnitureRentalHeaderLabel.TabIndex = 8;
            this.furnitureRentalHeaderLabel.Text = "Furniture Rental";
            // 
            // cartButtonsTableLayoutPanel
            // 
            this.cartButtonsTableLayoutPanel.ColumnCount = 4;
            this.cartButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cartButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cartButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cartButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cartButtonsTableLayoutPanel.Controls.Add(this.rentAllButton, 3, 0);
            this.cartButtonsTableLayoutPanel.Controls.Add(this.addToCartButton, 2, 0);
            this.cartButtonsTableLayoutPanel.Controls.Add(this.orderDetailsButton, 1, 0);
            this.cartButtonsTableLayoutPanel.Controls.Add(this.viewCartButton, 0, 0);
            this.cartButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 724);
            this.cartButtonsTableLayoutPanel.Name = "cartButtonsTableLayoutPanel";
            this.cartButtonsTableLayoutPanel.RowCount = 1;
            this.cartButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cartButtonsTableLayoutPanel.Size = new System.Drawing.Size(1385, 58);
            this.cartButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // rentAllButton
            // 
            this.rentAllButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAllButton.Location = new System.Drawing.Point(1151, 4);
            this.rentAllButton.Name = "rentAllButton";
            this.rentAllButton.Size = new System.Drawing.Size(120, 49);
            this.rentAllButton.TabIndex = 0;
            this.rentAllButton.Text = "Rent All";
            this.rentAllButton.UseVisualStyleBackColor = true;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.Location = new System.Drawing.Point(805, 4);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(120, 49);
            this.addToCartButton.TabIndex = 1;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            // 
            // orderDetailsButton
            // 
            this.orderDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.orderDetailsButton.Location = new System.Drawing.Point(459, 4);
            this.orderDetailsButton.Name = "orderDetailsButton";
            this.orderDetailsButton.Size = new System.Drawing.Size(120, 49);
            this.orderDetailsButton.TabIndex = 2;
            this.orderDetailsButton.Text = "Order Details";
            this.orderDetailsButton.UseVisualStyleBackColor = true;
            // 
            // viewCartButton
            // 
            this.viewCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCartButton.Location = new System.Drawing.Point(113, 4);
            this.viewCartButton.Name = "viewCartButton";
            this.viewCartButton.Size = new System.Drawing.Size(120, 49);
            this.viewCartButton.TabIndex = 3;
            this.viewCartButton.Text = "View Cart";
            this.viewCartButton.UseVisualStyleBackColor = true;
            // 
            // furnitureListView
            // 
            this.furnitureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.nameColumn,
            this.descriptionColumn,
            this.stylecolumn,
            this.categoryColumn,
            this.rentalColumn,
            this.quantityColumn});
            this.furnitureListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureListView.HideSelection = false;
            this.furnitureListView.Location = new System.Drawing.Point(3, 313);
            this.furnitureListView.Name = "furnitureListView";
            this.furnitureListView.Size = new System.Drawing.Size(1385, 405);
            this.furnitureListView.TabIndex = 6;
            this.furnitureListView.UseCompatibleStateImageBehavior = false;
            this.furnitureListView.View = System.Windows.Forms.View.Details;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "FurnitureID";
            this.IDColumn.Width = 318;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 213;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.Text = "Description";
            this.descriptionColumn.Width = 274;
            // 
            // stylecolumn
            // 
            this.stylecolumn.Text = "Style";
            this.stylecolumn.Width = 115;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Text = "Category";
            this.categoryColumn.Width = 137;
            // 
            // rentalColumn
            // 
            this.rentalColumn.Text = "Daily Rental";
            this.rentalColumn.Width = 157;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Quantity";
            this.quantityColumn.Width = 173;
            // 
            // searchOptionTableLayout
            // 
            this.searchOptionTableLayout.ColumnCount = 8;
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.30612F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.30612F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.searchOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.searchOptionTableLayout.Controls.Add(this.styleComboBox, 6, 0);
            this.searchOptionTableLayout.Controls.Add(this.categoryRadioButton, 2, 0);
            this.searchOptionTableLayout.Controls.Add(this.categoryComboBox, 3, 0);
            this.searchOptionTableLayout.Controls.Add(this.idRadioButton, 0, 0);
            this.searchOptionTableLayout.Controls.Add(this.furnitureIDTextBox, 1, 0);
            this.searchOptionTableLayout.Controls.Add(this.stylerRadiobutton, 5, 0);
            this.searchOptionTableLayout.Controls.Add(this.optionTipLabel, 2, 1);
            this.searchOptionTableLayout.Controls.Add(this.furnitureSearchButton, 6, 1);
            this.searchOptionTableLayout.Controls.Add(this.clearButton, 7, 1);
            this.searchOptionTableLayout.Controls.Add(this.memberIDRentTextBox, 1, 2);
            this.searchOptionTableLayout.Controls.Add(this.memberSearchButton, 2, 2);
            this.searchOptionTableLayout.Controls.Add(this.memberInfoLabel, 0, 3);
            this.searchOptionTableLayout.Controls.Add(this.memberIDLabel, 3, 3);
            this.searchOptionTableLayout.Controls.Add(this.memberFirstName, 4, 3);
            this.searchOptionTableLayout.Controls.Add(this.memberIdRentLabel, 0, 2);
            this.searchOptionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchOptionTableLayout.Location = new System.Drawing.Point(3, 83);
            this.searchOptionTableLayout.Name = "searchOptionTableLayout";
            this.searchOptionTableLayout.RowCount = 4;
            this.searchOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.25567F));
            this.searchOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.25568F));
            this.searchOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.13593F));
            this.searchOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.35272F));
            this.searchOptionTableLayout.Size = new System.Drawing.Size(1385, 184);
            this.searchOptionTableLayout.TabIndex = 1;
            // 
            // styleComboBox
            // 
            this.styleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchOptionTableLayout.SetColumnSpan(this.styleComboBox, 2);
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(1160, 7);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(220, 33);
            this.styleComboBox.TabIndex = 7;
            this.styleComboBox.VisibleChanged += new System.EventHandler(this.StyleComboBoxVisibleChanged);
            this.styleComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StyleComboBoxKeyPress);
            // 
            // categoryRadioButton
            // 
            this.categoryRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryRadioButton.AutoSize = true;
            this.categoryRadioButton.Location = new System.Drawing.Point(350, 9);
            this.categoryRadioButton.Name = "categoryRadioButton";
            this.categoryRadioButton.Size = new System.Drawing.Size(201, 29);
            this.categoryRadioButton.TabIndex = 4;
            this.categoryRadioButton.TabStop = true;
            this.categoryRadioButton.Text = "Furniture Category:";
            this.categoryRadioButton.UseVisualStyleBackColor = true;
            this.categoryRadioButton.CheckedChanged += new System.EventHandler(this.CategoryRadioButtonCheckedChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchOptionTableLayout.SetColumnSpan(this.categoryComboBox, 2);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(644, 7);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(220, 33);
            this.categoryComboBox.TabIndex = 5;
            this.categoryComboBox.VisibleChanged += new System.EventHandler(this.CategoryComboBoxVisibleChanged);
            // 
            // idRadioButton
            // 
            this.idRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idRadioButton.AutoSize = true;
            this.idRadioButton.Checked = true;
            this.idRadioButton.Location = new System.Drawing.Point(14, 9);
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
            this.furnitureIDTextBox.Location = new System.Drawing.Point(180, 9);
            this.furnitureIDTextBox.Name = "furnitureIDTextBox";
            this.furnitureIDTextBox.Size = new System.Drawing.Size(146, 30);
            this.furnitureIDTextBox.TabIndex = 3;
            this.furnitureIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stylerRadiobutton
            // 
            this.stylerRadiobutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stylerRadiobutton.AutoSize = true;
            this.stylerRadiobutton.Location = new System.Drawing.Point(967, 9);
            this.stylerRadiobutton.Name = "stylerRadiobutton";
            this.stylerRadiobutton.Size = new System.Drawing.Size(165, 29);
            this.stylerRadiobutton.TabIndex = 6;
            this.stylerRadiobutton.TabStop = true;
            this.stylerRadiobutton.Text = "Furniture Style:";
            this.stylerRadiobutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stylerRadiobutton.UseVisualStyleBackColor = true;
            this.stylerRadiobutton.CheckedChanged += new System.EventHandler(this.StylerRadiobuttonCheckedChanged);
            // 
            // optionTipLabel
            // 
            this.optionTipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optionTipLabel.AutoSize = true;
            this.searchOptionTableLayout.SetColumnSpan(this.optionTipLabel, 4);
            this.optionTipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTipLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.optionTipLabel.Location = new System.Drawing.Point(476, 48);
            this.optionTipLabel.Name = "optionTipLabel";
            this.optionTipLabel.Size = new System.Drawing.Size(540, 18);
            this.optionTipLabel.TabIndex = 7;
            this.optionTipLabel.Text = "**Please  select an option to enter furniture ID or category or style to rent fur" +
    "niture";
            this.optionTipLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.furnitureSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchButton.Location = new System.Drawing.Point(1161, 51);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new System.Drawing.Size(100, 40);
            this.furnitureSearchButton.TabIndex = 8;
            this.furnitureSearchButton.Text = "Search";
            this.furnitureSearchButton.UseVisualStyleBackColor = true;
            this.furnitureSearchButton.Click += new System.EventHandler(this.FurnitureSearchButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(1276, 51);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 40);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // memberIDRentTextBox
            // 
            this.memberIDRentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberIDRentTextBox.Enabled = false;
            this.memberIDRentTextBox.Location = new System.Drawing.Point(172, 99);
            this.memberIDRentTextBox.Name = "memberIDRentTextBox";
            this.memberIDRentTextBox.Size = new System.Drawing.Size(163, 30);
            this.memberIDRentTextBox.TabIndex = 10;
            // 
            // memberSearchButton
            // 
            this.memberSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberSearchButton.Enabled = false;
            this.memberSearchButton.Location = new System.Drawing.Point(341, 99);
            this.memberSearchButton.Name = "memberSearchButton";
            this.memberSearchButton.Size = new System.Drawing.Size(220, 47);
            this.memberSearchButton.TabIndex = 12;
            this.memberSearchButton.Text = "Submit";
            this.memberSearchButton.UseVisualStyleBackColor = true;
            this.memberSearchButton.Click += new System.EventHandler(this.MemberSearchButton_Click);
            // 
            // memberInfoLabel
            // 
            this.memberInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.memberInfoLabel.AutoSize = true;
            this.searchOptionTableLayout.SetColumnSpan(this.memberInfoLabel, 2);
            this.memberInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memberInfoLabel.Location = new System.Drawing.Point(22, 149);
            this.memberInfoLabel.Name = "memberInfoLabel";
            this.memberInfoLabel.Size = new System.Drawing.Size(293, 18);
            this.memberInfoLabel.TabIndex = 11;
            this.memberInfoLabel.Text = "**MemberID is mandatory to rent a furniture";
            // 
            // memberFirstName
            // 
            this.memberFirstName.AutoSize = true;
            this.memberFirstName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.searchOptionTableLayout.SetColumnSpan(this.memberFirstName, 2);
            this.memberFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memberFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberFirstName.Location = new System.Drawing.Point(736, 149);
            this.memberFirstName.Name = "memberFirstName";
            this.memberFirstName.Size = new System.Drawing.Size(416, 35);
            this.memberFirstName.TabIndex = 13;
            this.memberFirstName.Text = "Name :";
            this.memberFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.memberFirstName.Visible = false;
            // 
            // rentalStatusLabel
            // 
            this.rentalStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentalStatusLabel.AutoSize = true;
            this.rentalStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.rentalStatusLabel.Location = new System.Drawing.Point(669, 278);
            this.rentalStatusLabel.Name = "rentalStatusLabel";
            this.rentalStatusLabel.Size = new System.Drawing.Size(52, 24);
            this.rentalStatusLabel.TabIndex = 3;
            this.rentalStatusLabel.Text = "Error";
            this.rentalStatusLabel.Visible = false;
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.memberIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberIDLabel.Location = new System.Drawing.Point(567, 149);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(163, 35);
            this.memberIDLabel.TabIndex = 15;
            this.memberIDLabel.Text = "MemberID:";
            this.memberIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.memberIDLabel.Visible = false;
            // 
            // memberIdRentLabel
            // 
            this.memberIdRentLabel.AutoSize = true;
            this.memberIdRentLabel.Location = new System.Drawing.Point(3, 96);
            this.memberIdRentLabel.Name = "memberIdRentLabel";
            this.memberIdRentLabel.Size = new System.Drawing.Size(115, 25);
            this.memberIdRentLabel.TabIndex = 16;
            this.memberIdRentLabel.Text = "MemberID -";
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
            this.cartButtonsTableLayoutPanel.ResumeLayout(false);
            this.searchOptionTableLayout.ResumeLayout(false);
            this.searchOptionTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel furnitureRentalTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel cartButtonsTableLayoutPanel;
        private System.Windows.Forms.Button rentAllButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button orderDetailsButton;
        private System.Windows.Forms.Button viewCartButton;
        private System.Windows.Forms.ListView furnitureListView;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader descriptionColumn;
        private System.Windows.Forms.TableLayoutPanel searchOptionTableLayout;
        private System.Windows.Forms.TextBox furnitureIDTextBox;
        private System.Windows.Forms.Button furnitureSearchButton;
        private System.Windows.Forms.Label rentalStatusLabel;
        private System.Windows.Forms.ColumnHeader stylecolumn;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.ColumnHeader rentalColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.RadioButton stylerRadiobutton;
        private System.Windows.Forms.RadioButton categoryRadioButton;
        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.Label optionTipLabel;
        private System.Windows.Forms.Label furnitureRentalHeaderLabel;
        private System.Windows.Forms.TextBox memberIDRentTextBox;
        private System.Windows.Forms.Label memberInfoLabel;
        private System.Windows.Forms.Button memberSearchButton;
        private System.Windows.Forms.Label memberFirstName;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.Label memberIdRentLabel;
    }
}
