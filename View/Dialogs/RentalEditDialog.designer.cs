
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
            this.availableLabel = new System.Windows.Forms.Label();
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
            this.rentalEditTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentalEditTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentalEditTableLayout.Controls.Add(this.quantityLabel, 0, 0);
            this.rentalEditTableLayout.Controls.Add(this.rentQuantityTextBox, 1, 0);
            this.rentalEditTableLayout.Controls.Add(this.updateButton, 0, 3);
            this.rentalEditTableLayout.Controls.Add(this.cancelButton, 1, 3);
            this.rentalEditTableLayout.Controls.Add(this.duedateLabel, 0, 2);
            this.rentalEditTableLayout.Controls.Add(this.rentDateTimePicker, 1, 2);
            this.rentalEditTableLayout.Controls.Add(this.availableLabel, 1, 1);
            this.rentalEditTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentalEditTableLayout.Location = new System.Drawing.Point(0, 0);
            this.rentalEditTableLayout.Name = "rentalEditTableLayout";
            this.rentalEditTableLayout.RowCount = 4;
            this.rentalEditTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.18518F));
            this.rentalEditTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.rentalEditTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.58621F));
            this.rentalEditTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.rentalEditTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rentalEditTableLayout.Size = new System.Drawing.Size(367, 130);
            this.rentalEditTableLayout.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityLabel.Location = new System.Drawing.Point(35, 6);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(113, 18);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Update Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // duedateLabel
            // 
            this.duedateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.duedateLabel.AutoSize = true;
            this.duedateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.duedateLabel.Location = new System.Drawing.Point(31, 55);
            this.duedateLabel.Name = "duedateLabel";
            this.duedateLabel.Size = new System.Drawing.Size(121, 18);
            this.duedateLabel.TabIndex = 1;
            this.duedateLabel.Text = "Update Due Date";
            this.duedateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentQuantityTextBox
            // 
            this.rentQuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rentQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rentQuantityTextBox.Location = new System.Drawing.Point(186, 3);
            this.rentQuantityTextBox.Name = "rentQuantityTextBox";
            this.rentQuantityTextBox.Size = new System.Drawing.Size(176, 24);
            this.rentQuantityTextBox.TabIndex = 2;
            this.rentQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rentDateTimePicker
            // 
            this.rentDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rentDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rentDateTimePicker.Location = new System.Drawing.Point(186, 52);
            this.rentDateTimePicker.Name = "rentDateTimePicker";
            this.rentDateTimePicker.Size = new System.Drawing.Size(176, 24);
            this.rentDateTimePicker.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cancelButton.Location = new System.Drawing.Point(215, 91);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 32);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.updateButton.Location = new System.Drawing.Point(31, 91);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 32);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.availableLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.availableLabel.Location = new System.Drawing.Point(186, 30);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(113, 14);
            this.availableLabel.TabIndex = 6;
            this.availableLabel.Text = "** Available Quanity is ";
            // 
            // RentalEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 130);
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
        private System.Windows.Forms.Label availableLabel;
    }
}