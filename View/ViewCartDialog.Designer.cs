
namespace RentMe.View
{
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
            this.cartDataGrideView = new System.Windows.Forms.DataGridView();
            this.rentAmountlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelCartButton = new System.Windows.Forms.Button();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.emptyCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // cartDataGrideView
            // 
            this.cartDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGrideView.Location = new System.Drawing.Point(12, 76);
            this.cartDataGrideView.Name = "cartDataGrideView";
            this.cartDataGrideView.RowHeadersWidth = 51;
            this.cartDataGrideView.RowTemplate.Height = 24;
            this.cartDataGrideView.Size = new System.Drawing.Size(776, 265);
            this.cartDataGrideView.TabIndex = 0;
            // 
            // rentAmountlabel
            // 
            this.rentAmountlabel.AutoSize = true;
            this.rentAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAmountlabel.Location = new System.Drawing.Point(12, 362);
            this.rentAmountlabel.Name = "rentAmountlabel";
            this.rentAmountlabel.Size = new System.Drawing.Size(241, 29);
            this.rentAmountlabel.TabIndex = 1;
            this.rentAmountlabel.Text = "Total Amount to Pay- ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "$0.00";
            // 
            // cancelCartButton
            // 
            this.cancelCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCartButton.Location = new System.Drawing.Point(647, 399);
            this.cancelCartButton.Name = "cancelCartButton";
            this.cancelCartButton.Size = new System.Drawing.Size(124, 39);
            this.cancelCartButton.TabIndex = 3;
            this.cancelCartButton.Text = "Cancel";
            this.cancelCartButton.UseVisualStyleBackColor = true;
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitOrderButton.Location = new System.Drawing.Point(415, 399);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(210, 39);
            this.submitOrderButton.TabIndex = 4;
            this.submitOrderButton.Text = "Submit Rent Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            // 
            // emptyCartButton
            // 
            this.emptyCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyCartButton.Location = new System.Drawing.Point(578, 12);
            this.emptyCartButton.Name = "emptyCartButton";
            this.emptyCartButton.Size = new System.Drawing.Size(210, 39);
            this.emptyCartButton.TabIndex = 5;
            this.emptyCartButton.Text = "Empty Your Cart";
            this.emptyCartButton.UseVisualStyleBackColor = true;
            // 
            // ViewCartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emptyCartButton);
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.cancelCartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentAmountlabel);
            this.Controls.Add(this.cartDataGrideView);
            this.Name = "ViewCartDialog";
            this.Text = "ViewCartDialog";
            this.Load += new System.EventHandler(this.ViewCartDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrideView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartDataGrideView;
        private System.Windows.Forms.Label rentAmountlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelCartButton;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.Button emptyCartButton;
    }
}