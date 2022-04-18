
namespace RentMe.View
{

    /// <summary>
    /// Designer class to view the cart items
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class ViewCartDialog
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

        #region Windows Form Designer generated code

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
            this.cartDataGrideView = new System.Windows.Forms.DataGridView();
            this.furnitureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalItemRentalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureRentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rentFurnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentAmountlabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.cancelCartButton = new System.Windows.Forms.Button();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.emptyCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrideView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentFurnitureBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartDataGrideView
            // 
            this.cartDataGrideView.AutoGenerateColumns = false;
            this.cartDataGrideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGrideView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cartDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGrideView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.furnitureIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rentalAmountDataGridViewTextBoxColumn,
            this.totalItemRentalAmountDataGridViewTextBoxColumn,
            this.FurnitureRentQuantity,
            this.DueDate,
            this.DeleteItem});
            this.cartDataGrideView.DataSource = this.rentFurnitureBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartDataGrideView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cartDataGrideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartDataGrideView.Location = new System.Drawing.Point(3, 2);
            this.cartDataGrideView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartDataGrideView.Name = "cartDataGrideView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGrideView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cartDataGrideView.RowHeadersWidth = 51;
            this.cartDataGrideView.RowTemplate.Height = 24;
            this.cartDataGrideView.Size = new System.Drawing.Size(1327, 143);
            this.cartDataGrideView.TabIndex = 0;
            this.cartDataGrideView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGrideViewCellContentClick);
            // 
            // furnitureIDDataGridViewTextBoxColumn
            // 
            this.furnitureIDDataGridViewTextBoxColumn.DataPropertyName = "FurnitureID";
            this.furnitureIDDataGridViewTextBoxColumn.HeaderText = "FurnitureID";
            this.furnitureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.furnitureIDDataGridViewTextBoxColumn.Name = "furnitureIDDataGridViewTextBoxColumn";
            this.furnitureIDDataGridViewTextBoxColumn.Width = 107;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 94;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.Width = 68;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 108;
            // 
            // rentalAmountDataGridViewTextBoxColumn
            // 
            this.rentalAmountDataGridViewTextBoxColumn.DataPropertyName = "RentalAmount";
            this.rentalAmountDataGridViewTextBoxColumn.HeaderText = "RentalAmount";
            this.rentalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalAmountDataGridViewTextBoxColumn.Name = "rentalAmountDataGridViewTextBoxColumn";
            this.rentalAmountDataGridViewTextBoxColumn.Width = 126;
            // 
            // totalItemRentalAmountDataGridViewTextBoxColumn
            // 
            this.totalItemRentalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalItemRentalAmount";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.HeaderText = "TotalItemRentalAmount";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalItemRentalAmountDataGridViewTextBoxColumn.Name = "totalItemRentalAmountDataGridViewTextBoxColumn";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.Width = 184;
            // 
            // FurnitureRentQuantity
            // 
            this.FurnitureRentQuantity.DataPropertyName = "FurnitureRentQuantity";
            this.FurnitureRentQuantity.HeaderText = "FurnitureRentQuantity";
            this.FurnitureRentQuantity.MinimumWidth = 6;
            this.FurnitureRentQuantity.Name = "FurnitureRentQuantity";
            this.FurnitureRentQuantity.Width = 177;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 93;
            // 
            // DeleteItem
            // 
            this.DeleteItem.HeaderText = "Delete";
            this.DeleteItem.MinimumWidth = 6;
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.UseColumnTextForButtonValue = true;
            this.DeleteItem.Width = 78;
            // 
            // rentFurnitureBindingSource
            // 
            this.rentFurnitureBindingSource.DataSource = typeof(RentMe.Model.RentFurniture);
            // 
            // rentAmountlabel
            // 
            this.rentAmountlabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rentAmountlabel.AutoSize = true;
            this.rentAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAmountlabel.Location = new System.Drawing.Point(80, 14);
            this.rentAmountlabel.Name = "rentAmountlabel";
            this.rentAmountlabel.Size = new System.Drawing.Size(233, 29);
            this.rentAmountlabel.TabIndex = 1;
            this.rentAmountlabel.Text = "Total Amount to Pay:";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(319, 16);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(61, 25);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "$0.00";
            // 
            // cancelCartButton
            // 
            this.cancelCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelCartButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCartButton.Location = new System.Drawing.Point(683, 9);
            this.cancelCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelCartButton.Name = "cancelCartButton";
            this.cancelCartButton.Size = new System.Drawing.Size(124, 39);
            this.cancelCartButton.TabIndex = 3;
            this.cancelCartButton.Text = "Cancel";
            this.cancelCartButton.UseVisualStyleBackColor = true;
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitOrderButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitOrderButton.Location = new System.Drawing.Point(441, 9);
            this.submitOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(189, 39);
            this.submitOrderButton.TabIndex = 4;
            this.submitOrderButton.Text = "Submit Rent Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            this.submitOrderButton.Click += new System.EventHandler(this.SubmitOrderButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove Items";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cartDataGrideView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1333, 295);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23697F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.71386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 408F));
            this.tableLayoutPanel2.Controls.Add(this.emptyCartButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.rentAmountlabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.amountLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelCartButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.submitOrderButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 149);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1252, 58);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // emptyCartButton
            // 
            this.emptyCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emptyCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyCartButton.Location = new System.Drawing.Point(941, 9);
            this.emptyCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emptyCartButton.Name = "emptyCartButton";
            this.emptyCartButton.Size = new System.Drawing.Size(211, 39);
            this.emptyCartButton.TabIndex = 5;
            this.emptyCartButton.Text = "Empty Your Cart";
            this.emptyCartButton.UseVisualStyleBackColor = true;
            this.emptyCartButton.Click += new System.EventHandler(this.EmptyCartButtonClick);
            // 
            // ViewCartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 295);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewCartDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCartDialog";
            this.Load += new System.EventHandler(this.ViewCartDialogLoad);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrideView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentFurnitureBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cartDataGrideView;
        private System.Windows.Forms.Label rentAmountlabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button cancelCartButton;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rentFurnitureBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button emptyCartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemRentalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureRentQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteItem;
    }
}