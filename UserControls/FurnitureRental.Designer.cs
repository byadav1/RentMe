
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
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.furnitureListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.styleTextBox = new System.Windows.Forms.TextBox();
            this.furnitureStyleLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.furnitureCategoryLabel = new System.Windows.Forms.Label();
            this.furnitureIDLabel = new System.Windows.Forms.Label();
            this.furnitureIDTextBox = new System.Windows.Forms.TextBox();
            this.furnitureSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rentalStatusLabel = new System.Windows.Forms.Label();
            this.furnitureRentalTableLayoutPanel.SuspendLayout();
            this.cartButtonsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // furnitureRentalTableLayoutPanel
            // 
            this.furnitureRentalTableLayoutPanel.ColumnCount = 1;
            this.furnitureRentalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.furnitureRentalHeaderLabel, 1, 0);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.cartButtonsTableLayoutPanel, 0, 5);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.memberNameLabel, 0, 0);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.furnitureListView, 0, 4);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.furnitureRentalTableLayoutPanel.Controls.Add(this.rentalStatusLabel, 0, 3);
            this.furnitureRentalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureRentalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.furnitureRentalTableLayoutPanel.Name = "furnitureRentalTableLayoutPanel";
            this.furnitureRentalTableLayoutPanel.RowCount = 6;
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.58798F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.17597F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.17597F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.88412F));
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.furnitureRentalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.17597F));
            this.furnitureRentalTableLayoutPanel.Size = new System.Drawing.Size(1204, 809);
            this.furnitureRentalTableLayoutPanel.TabIndex = 0;
            // 
            // furnitureRentalHeaderLabel
            // 
            this.furnitureRentalHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.furnitureRentalHeaderLabel.AutoSize = true;
            this.furnitureRentalHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.furnitureRentalHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureRentalHeaderLabel.Location = new System.Drawing.Point(408, 94);
            this.furnitureRentalHeaderLabel.Name = "furnitureRentalHeaderLabel";
            this.furnitureRentalHeaderLabel.Size = new System.Drawing.Size(387, 60);
            this.furnitureRentalHeaderLabel.TabIndex = 5;
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
            this.cartButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 683);
            this.cartButtonsTableLayoutPanel.Name = "cartButtonsTableLayoutPanel";
            this.cartButtonsTableLayoutPanel.RowCount = 1;
            this.cartButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cartButtonsTableLayoutPanel.Size = new System.Drawing.Size(1198, 123);
            this.cartButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // rentAllButton
            // 
            this.rentAllButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAllButton.Location = new System.Drawing.Point(997, 34);
            this.rentAllButton.Name = "rentAllButton";
            this.rentAllButton.Size = new System.Drawing.Size(100, 55);
            this.rentAllButton.TabIndex = 0;
            this.rentAllButton.Text = "Rent All";
            this.rentAllButton.UseVisualStyleBackColor = true;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.Location = new System.Drawing.Point(697, 34);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(100, 55);
            this.addToCartButton.TabIndex = 1;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            // 
            // orderDetailsButton
            // 
            this.orderDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsButton.Location = new System.Drawing.Point(398, 34);
            this.orderDetailsButton.Name = "orderDetailsButton";
            this.orderDetailsButton.Size = new System.Drawing.Size(100, 55);
            this.orderDetailsButton.TabIndex = 2;
            this.orderDetailsButton.Text = "Order Details";
            this.orderDetailsButton.UseVisualStyleBackColor = true;
            // 
            // viewCartButton
            // 
            this.viewCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCartButton.Location = new System.Drawing.Point(99, 34);
            this.viewCartButton.Name = "viewCartButton";
            this.viewCartButton.Size = new System.Drawing.Size(100, 55);
            this.viewCartButton.TabIndex = 3;
            this.viewCartButton.Text = "View Cart";
            this.viewCartButton.UseVisualStyleBackColor = true;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.Location = new System.Drawing.Point(3, 19);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(71, 24);
            this.memberNameLabel.TabIndex = 4;
            this.memberNameLabel.Text = "Name: ";
            // 
            // furnitureListView
            // 
            this.furnitureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.furnitureListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureListView.HideSelection = false;
            this.furnitureListView.Location = new System.Drawing.Point(3, 417);
            this.furnitureListView.Name = "furnitureListView";
            this.furnitureListView.Size = new System.Drawing.Size(1198, 260);
            this.furnitureListView.TabIndex = 6;
            this.furnitureListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.016394F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.10539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.65574F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33021F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.61827F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.637F));
            this.tableLayoutPanel1.Controls.Add(this.styleTextBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.furnitureStyleLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoryTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.furnitureCategoryLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.furnitureIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.furnitureIDTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.furnitureSearchButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 190);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 79);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // styleTextBox
            // 
            this.styleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.styleTextBox.Location = new System.Drawing.Point(570, 3);
            this.styleTextBox.Name = "styleTextBox";
            this.styleTextBox.Size = new System.Drawing.Size(153, 22);
            this.styleTextBox.TabIndex = 5;
            this.styleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // furnitureStyleLabel
            // 
            this.furnitureStyleLabel.AutoSize = true;
            this.furnitureStyleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureStyleLabel.Location = new System.Drawing.Point(448, 0);
            this.furnitureStyleLabel.Name = "furnitureStyleLabel";
            this.furnitureStyleLabel.Size = new System.Drawing.Size(116, 59);
            this.furnitureStyleLabel.TabIndex = 4;
            this.furnitureStyleLabel.Text = "Furniture Style :";
            this.furnitureStyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTextBox.Location = new System.Drawing.Point(300, 3);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(142, 22);
            this.categoryTextBox.TabIndex = 3;
            this.categoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // furnitureCategoryLabel
            // 
            this.furnitureCategoryLabel.AutoSize = true;
            this.furnitureCategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureCategoryLabel.Location = new System.Drawing.Point(209, 0);
            this.furnitureCategoryLabel.Name = "furnitureCategoryLabel";
            this.furnitureCategoryLabel.Size = new System.Drawing.Size(85, 59);
            this.furnitureCategoryLabel.TabIndex = 2;
            this.furnitureCategoryLabel.Text = "Furniture Category :";
            this.furnitureCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // furnitureIDLabel
            // 
            this.furnitureIDLabel.AutoSize = true;
            this.furnitureIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureIDLabel.Location = new System.Drawing.Point(3, 0);
            this.furnitureIDLabel.Name = "furnitureIDLabel";
            this.furnitureIDLabel.Size = new System.Drawing.Size(71, 59);
            this.furnitureIDLabel.TabIndex = 0;
            this.furnitureIDLabel.Text = "Furniture ID :";
            this.furnitureIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // furnitureIDTextBox
            // 
            this.furnitureIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureIDTextBox.Location = new System.Drawing.Point(80, 3);
            this.furnitureIDTextBox.Name = "furnitureIDTextBox";
            this.furnitureIDTextBox.Size = new System.Drawing.Size(123, 22);
            this.furnitureIDTextBox.TabIndex = 1;
            this.furnitureIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchButton.Location = new System.Drawing.Point(729, 3);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new System.Drawing.Size(110, 30);
            this.furnitureSearchButton.TabIndex = 6;
            this.furnitureSearchButton.Text = "Search";
            this.furnitureSearchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.furnitureSearchButton.UseVisualStyleBackColor = true;
            this.furnitureSearchButton.Click += new System.EventHandler(this.FurnitureSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(570, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "**Please  enter furniture ID or category or style to rent furniture";
            // 
            // rentalStatusLabel
            // 
            this.rentalStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentalStatusLabel.AutoSize = true;
            this.rentalStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.rentalStatusLabel.Location = new System.Drawing.Point(576, 351);
            this.rentalStatusLabel.Name = "rentalStatusLabel";
            this.rentalStatusLabel.Size = new System.Drawing.Size(52, 24);
            this.rentalStatusLabel.TabIndex = 3;
            this.rentalStatusLabel.Text = "Error";
            this.rentalStatusLabel.Visible = false;
            // 
            // FurnitureRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.furnitureRentalTableLayoutPanel);
            this.Name = "FurnitureRental";
            this.Size = new System.Drawing.Size(1204, 809);
            this.furnitureRentalTableLayoutPanel.ResumeLayout(false);
            this.furnitureRentalTableLayoutPanel.PerformLayout();
            this.cartButtonsTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel furnitureRentalTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel cartButtonsTableLayoutPanel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label furnitureRentalHeaderLabel;
        private System.Windows.Forms.Button rentAllButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button orderDetailsButton;
        private System.Windows.Forms.Button viewCartButton;
        private System.Windows.Forms.ListView furnitureListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox styleTextBox;
        private System.Windows.Forms.Label furnitureStyleLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label furnitureCategoryLabel;
        private System.Windows.Forms.Label furnitureIDLabel;
        private System.Windows.Forms.TextBox furnitureIDTextBox;
        private System.Windows.Forms.Button furnitureSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rentalStatusLabel;
    }
}
