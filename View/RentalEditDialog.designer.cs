
namespace RentMe.View
{
    partial class RentalEditDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rentalEditTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.duedateLabel = new System.Windows.Forms.Label();
            this.rentQuantityTextBox = new System.Windows.Forms.TextBox();
            this.rentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.rentalEditTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59399F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59399F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.81203F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(634, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rentalEditTableLayout
            // 
            this.rentalEditTableLayout.ColumnCount = 2;
            this.rentalEditTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35461F));
            this.rentalEditTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64539F));
            this.rentalEditTableLayout.Controls.Add(this.quantityLabel, 0, 0);
            this.rentalEditTableLayout.Controls.Add(this.duedateLabel, 0, 1);
            this.rentalEditTableLayout.Controls.Add(this.rentQuantityTextBox, 1, 0);
            this.rentalEditTableLayout.Controls.Add(this.rentDateTimePicker, 1, 1);
            this.rentalEditTableLayout.Controls.Add(this.cancelButton, 1, 2);
            this.rentalEditTableLayout.Controls.Add(this.updateButton, 0, 2);
            this.rentalEditTableLayout.Location = new System.Drawing.Point(12, 12);
            this.rentalEditTableLayout.Name = "rentalEditTableLayout";
            this.rentalEditTableLayout.RowCount = 3;
            this.rentalEditTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentalEditTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentalEditTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.rentalEditTableLayout.Size = new System.Drawing.Size(423, 182);
            this.rentalEditTableLayout.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabel.Location = new System.Drawing.Point(3, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(207, 75);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Update Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // duedateLabel
            // 
            this.duedateLabel.AutoSize = true;
            this.duedateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duedateLabel.Location = new System.Drawing.Point(3, 75);
            this.duedateLabel.Name = "duedateLabel";
            this.duedateLabel.Size = new System.Drawing.Size(207, 75);
            this.duedateLabel.TabIndex = 1;
            this.duedateLabel.Text = "Update Due Date";
            this.duedateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentQuantityTextBox
            // 
            this.rentQuantityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentQuantityTextBox.Location = new System.Drawing.Point(216, 3);
            this.rentQuantityTextBox.Name = "rentQuantityTextBox";
            this.rentQuantityTextBox.Size = new System.Drawing.Size(204, 20);
            this.rentQuantityTextBox.TabIndex = 2;
            this.rentQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rentDateTimePicker
            // 
            this.rentDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentDateTimePicker.Location = new System.Drawing.Point(216, 78);
            this.rentDateTimePicker.Name = "rentDateTimePicker";
            this.rentDateTimePicker.Size = new System.Drawing.Size(204, 20);
            this.rentDateTimePicker.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cancelButton.Location = new System.Drawing.Point(216, 153);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(191, 26);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.updateButton.Location = new System.Drawing.Point(3, 153);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(191, 26);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RentalEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 223);
            this.Controls.Add(this.rentalEditTableLayout);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RentalEditDialog";
            this.Text = "RentalEditDialog";
            this.rentalEditTableLayout.ResumeLayout(false);
            this.rentalEditTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel rentalEditTableLayout;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label duedateLabel;
        private System.Windows.Forms.TextBox rentQuantityTextBox;
        private System.Windows.Forms.DateTimePicker rentDateTimePicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
    }
}