
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
            this.rentAmountlabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.cancelCartButton = new System.Windows.Forms.Button();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cartTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.emptyCartButton = new System.Windows.Forms.Button();
            this.FurnitureRentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.furnitureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalItemRentalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentFurnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrideView)).BeginInit();
            this.cartTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentFurnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartDataGrideView
            // 
            this.cartDataGrideView.AutoGenerateColumns = false;
            this.cartDataGrideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cartDataGrideView.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.FurnitureRentQuantity,
            this.DueDate,
            this.totalItemRentalAmountDataGridViewTextBoxColumn,
            this.EditItem,
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
            this.cartDataGrideView.Location = new System.Drawing.Point(2, 2);
            this.cartDataGrideView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.cartDataGrideView.Size = new System.Drawing.Size(996, 164);
            this.cartDataGrideView.TabIndex = 0;
            this.cartDataGrideView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGrideViewCellContentClick);
            // 
            // rentAmountlabel
            // 
            this.rentAmountlabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rentAmountlabel.AutoSize = true;
            this.rentAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAmountlabel.Location = new System.Drawing.Point(50, 22);
            this.rentAmountlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rentAmountlabel.Name = "rentAmountlabel";
            this.rentAmountlabel.Size = new System.Drawing.Size(183, 24);
            this.rentAmountlabel.TabIndex = 1;
            this.rentAmountlabel.Text = "Total Amount to Pay:";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(237, 24);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(49, 20);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "$0.00";
            // 
            // cancelCartButton
            // 
            this.cancelCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelCartButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCartButton.Location = new System.Drawing.Point(508, 18);
            this.cancelCartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelCartButton.Name = "cancelCartButton";
            this.cancelCartButton.Size = new System.Drawing.Size(93, 32);
            this.cancelCartButton.TabIndex = 3;
            this.cancelCartButton.Text = "Cancel";
            this.cancelCartButton.UseVisualStyleBackColor = true;
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitOrderButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitOrderButton.Location = new System.Drawing.Point(327, 18);
            this.submitOrderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(142, 32);
            this.submitOrderButton.TabIndex = 4;
            this.submitOrderButton.Text = "Submit Rent Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            this.submitOrderButton.Click += new System.EventHandler(this.SubmitOrderButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove Items";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cartTableLayoutPanel
            // 
            this.cartTableLayoutPanel.ColumnCount = 1;
            this.cartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cartTableLayoutPanel.Controls.Add(this.cartDataGrideView, 0, 0);
            this.cartTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 1);
            this.cartTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.cartTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartTableLayoutPanel.Name = "cartTableLayoutPanel";
            this.cartTableLayoutPanel.RowCount = 2;
            this.cartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.cartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.cartTableLayoutPanel.Size = new System.Drawing.Size(1000, 240);
            this.cartTableLayoutPanel.TabIndex = 7;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 5;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23697F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.71386F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.buttonsTableLayoutPanel.Controls.Add(this.emptyCartButton, 4, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.rentAmountlabel, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.amountLabel, 1, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.cancelCartButton, 3, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.submitOrderButton, 2, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(2, 170);
            this.buttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(996, 68);
            this.buttonsTableLayoutPanel.TabIndex = 6;
            // 
            // emptyCartButton
            // 
            this.emptyCartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emptyCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyCartButton.Location = new System.Drawing.Point(732, 18);
            this.emptyCartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emptyCartButton.Name = "emptyCartButton";
            this.emptyCartButton.Size = new System.Drawing.Size(158, 32);
            this.emptyCartButton.TabIndex = 5;
            this.emptyCartButton.Text = "Empty Your Cart";
            this.emptyCartButton.UseVisualStyleBackColor = true;
            this.emptyCartButton.Click += new System.EventHandler(this.EmptyCartButtonClick);
            // 
            // FurnitureRentQuantity
            // 
            this.FurnitureRentQuantity.DataPropertyName = "FurnitureRentQuantity";
            this.FurnitureRentQuantity.HeaderText = "Rent Quantity";
            this.FurnitureRentQuantity.MinimumWidth = 6;
            this.FurnitureRentQuantity.Name = "FurnitureRentQuantity";
            this.FurnitureRentQuantity.Width = 89;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "Return DueDate";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 101;
            // 
            // EditItem
            // 
            this.EditItem.HeaderText = "Edit";
            this.EditItem.Name = "EditItem";
            this.EditItem.Text = "Edit";
            this.EditItem.Width = 31;
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
            this.DeleteItem.Width = 63;
            // 
            // furnitureIDDataGridViewTextBoxColumn
            // 
            this.furnitureIDDataGridViewTextBoxColumn.DataPropertyName = "FurnitureID";
            this.furnitureIDDataGridViewTextBoxColumn.HeaderText = "FurnitureID";
            this.furnitureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.furnitureIDDataGridViewTextBoxColumn.Name = "furnitureIDDataGridViewTextBoxColumn";
            this.furnitureIDDataGridViewTextBoxColumn.Width = 84;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 74;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.Width = 55;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // rentalAmountDataGridViewTextBoxColumn
            // 
            this.rentalAmountDataGridViewTextBoxColumn.DataPropertyName = "RentalAmount";
            this.rentalAmountDataGridViewTextBoxColumn.HeaderText = "Rent Per day";
            this.rentalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalAmountDataGridViewTextBoxColumn.Name = "rentalAmountDataGridViewTextBoxColumn";
            this.rentalAmountDataGridViewTextBoxColumn.Width = 71;
            // 
            // totalItemRentalAmountDataGridViewTextBoxColumn
            // 
            this.totalItemRentalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalItemRentalAmount";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.HeaderText = "TotalItemRentalAmount";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalItemRentalAmountDataGridViewTextBoxColumn.Name = "totalItemRentalAmountDataGridViewTextBoxColumn";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.Width = 143;
            // 
            // rentFurnitureBindingSource
            // 
            this.rentFurnitureBindingSource.DataSource = typeof(RentMe.Model.RentFurniture);
            // 
            // ViewCartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 240);
            this.Controls.Add(this.cartTableLayoutPanel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewCartDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCartDialog";
            this.Load += new System.EventHandler(this.ViewCartDialogLoad);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrideView)).EndInit();
            this.cartTableLayoutPanel.ResumeLayout(false);
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.buttonsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentFurnitureBindingSource)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel cartTableLayoutPanel;
        private System.Windows.Forms.Button emptyCartButton;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureRentQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemRentalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditItem;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteItem;
    }
}