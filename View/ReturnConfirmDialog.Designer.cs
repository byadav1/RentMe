
namespace RentMe.View
{
    partial class ReturnConfirmDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.confirmReturnHeaderLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.returnTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.returnTransactionDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.confirmReturnHeaderLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.memberNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1188, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // confirmReturnHeaderLabel
            // 
            this.confirmReturnHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmReturnHeaderLabel.AutoSize = true;
            this.confirmReturnHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.confirmReturnHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmReturnHeaderLabel.Location = new System.Drawing.Point(410, 4);
            this.confirmReturnHeaderLabel.Name = "confirmReturnHeaderLabel";
            this.confirmReturnHeaderLabel.Size = new System.Drawing.Size(367, 60);
            this.confirmReturnHeaderLabel.TabIndex = 2;
            this.confirmReturnHeaderLabel.Text = "Confirm Return";
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memberNameLabel.Location = new System.Drawing.Point(3, 81);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(70, 25);
            this.memberNameLabel.TabIndex = 4;
            this.memberNameLabel.Text = "Name:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CancelButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.confirmButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 456);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1182, 45);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.confirmButton.Location = new System.Drawing.Point(473, 3);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(93, 39);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(616, 3);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 39);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // returnTransactionBindingSource
            // 
            this.returnTransactionBindingSource.DataSource = typeof(RentMe.Model.ReturnTransaction);
            // 
            // returnTransactionDataGridView
            // 
            this.returnTransactionDataGridView.AutoGenerateColumns = false;
            this.returnTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FurnitureName,
            this.dataGridViewTextBoxColumn1,
            this.Quantity,
            this.Days,
            this.EmployeeID,
            this.ReturnDate,
            this.RentDate,
            this.DueDate,
            this.RentalRate,
            this.Fine,
            this.Refund,
            this.SubTotal});
            this.returnTransactionDataGridView.DataSource = this.returnTransactionBindingSource;
            this.returnTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnTransactionDataGridView.Location = new System.Drawing.Point(3, 121);
            this.returnTransactionDataGridView.Name = "returnTransactionDataGridView";
            this.returnTransactionDataGridView.RowHeadersWidth = 51;
            this.returnTransactionDataGridView.RowTemplate.Height = 24;
            this.returnTransactionDataGridView.Size = new System.Drawing.Size(1182, 329);
            this.returnTransactionDataGridView.TabIndex = 5;
            // 
            // FurnitureName
            // 
            this.FurnitureName.DataPropertyName = "FurnitureName";
            this.FurnitureName.HeaderText = "Furniture Name";
            this.FurnitureName.MinimumWidth = 6;
            this.FurnitureName.Name = "FurnitureName";
            this.FurnitureName.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RentedItemsID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RentedItemsID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Return Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Days
            // 
            this.Days.DataPropertyName = "Days";
            this.Days.HeaderText = "Days";
            this.Days.MinimumWidth = 6;
            this.Days.Name = "Days";
            this.Days.Width = 125;
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
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Visible = false;
            this.ReturnDate.Width = 125;
            // 
            // RentDate
            // 
            this.RentDate.DataPropertyName = "RentDate";
            this.RentDate.HeaderText = "RentDate";
            this.RentDate.MinimumWidth = 6;
            this.RentDate.Name = "RentDate";
            this.RentDate.Width = 125;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 125;
            // 
            // RentalRate
            // 
            this.RentalRate.DataPropertyName = "RentalRate";
            this.RentalRate.HeaderText = "RentalRate";
            this.RentalRate.MinimumWidth = 6;
            this.RentalRate.Name = "RentalRate";
            this.RentalRate.Width = 125;
            // 
            // Fine
            // 
            this.Fine.DataPropertyName = "Fine";
            this.Fine.HeaderText = "Fine";
            this.Fine.MinimumWidth = 6;
            this.Fine.Name = "Fine";
            this.Fine.Width = 125;
            // 
            // Refund
            // 
            this.Refund.DataPropertyName = "Refund";
            this.Refund.HeaderText = "Refund";
            this.Refund.MinimumWidth = 6;
            this.Refund.Name = "Refund";
            this.Refund.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 125;
            // 
            // ReturnConfirmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReturnConfirmDialog";
            this.Text = "ReturnConfirmDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label confirmReturnHeaderLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridView returnTransactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refund;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.BindingSource returnTransactionBindingSource;
    }
}