
namespace RentMe.View
{
    partial class ReceiptDialog
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
            this.receiptTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.receiptHeaderLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.receiptDateLabel = new System.Windows.Forms.Label();
            this.receiptListView = new System.Windows.Forms.ListView();
            this.closeButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.receiptTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // receiptTableLayoutPanel
            // 
            this.receiptTableLayoutPanel.ColumnCount = 2;
            this.receiptTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receiptTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receiptTableLayoutPanel.Controls.Add(this.receiptHeaderLabel, 0, 0);
            this.receiptTableLayoutPanel.Controls.Add(this.memberNameLabel, 0, 1);
            this.receiptTableLayoutPanel.Controls.Add(this.receiptDateLabel, 1, 1);
            this.receiptTableLayoutPanel.Controls.Add(this.receiptListView, 0, 2);
            this.receiptTableLayoutPanel.Controls.Add(this.closeButton, 0, 4);
            this.receiptTableLayoutPanel.Controls.Add(this.totalLabel, 1, 3);
            this.receiptTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.receiptTableLayoutPanel.Name = "receiptTableLayoutPanel";
            this.receiptTableLayoutPanel.RowCount = 5;
            this.receiptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.receiptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.receiptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.receiptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.receiptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.receiptTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.receiptTableLayoutPanel.TabIndex = 1;
            // 
            // receiptHeaderLabel
            // 
            this.receiptHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.receiptHeaderLabel.AutoSize = true;
            this.receiptHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.receiptTableLayoutPanel.SetColumnSpan(this.receiptHeaderLabel, 2);
            this.receiptHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptHeaderLabel.Location = new System.Drawing.Point(301, 3);
            this.receiptHeaderLabel.Name = "receiptHeaderLabel";
            this.receiptHeaderLabel.Size = new System.Drawing.Size(197, 60);
            this.receiptHeaderLabel.TabIndex = 2;
            this.receiptHeaderLabel.Text = "Receipt";
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.memberNameLabel.Location = new System.Drawing.Point(3, 73);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(71, 24);
            this.memberNameLabel.TabIndex = 3;
            this.memberNameLabel.Text = "Name: ";
            // 
            // receiptDateLabel
            // 
            this.receiptDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.receiptDateLabel.AutoSize = true;
            this.receiptDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.receiptDateLabel.Location = new System.Drawing.Point(739, 73);
            this.receiptDateLabel.Name = "receiptDateLabel";
            this.receiptDateLabel.Size = new System.Drawing.Size(58, 24);
            this.receiptDateLabel.TabIndex = 4;
            this.receiptDateLabel.Text = "Date: ";
            // 
            // receiptListView
            // 
            this.receiptTableLayoutPanel.SetColumnSpan(this.receiptListView, 2);
            this.receiptListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.receiptListView.HideSelection = false;
            this.receiptListView.Location = new System.Drawing.Point(3, 106);
            this.receiptListView.Name = "receiptListView";
            this.receiptListView.Size = new System.Drawing.Size(794, 241);
            this.receiptListView.TabIndex = 5;
            this.receiptListView.UseCompatibleStateImageBehavior = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.receiptTableLayoutPanel.SetColumnSpan(this.closeButton, 2);
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.closeButton.Location = new System.Drawing.Point(350, 393);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 50);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Location = new System.Drawing.Point(566, 356);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(68, 24);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total: ";
            // 
            // ReceiptDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiptTableLayoutPanel);
            this.Name = "ReceiptDialog";
            this.Text = "RentMe: Receipt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceiptDialogFormClosed);
            this.receiptTableLayoutPanel.ResumeLayout(false);
            this.receiptTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel receiptTableLayoutPanel;
        private System.Windows.Forms.Label receiptHeaderLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label receiptDateLabel;
        private System.Windows.Forms.ListView receiptListView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label totalLabel;
    }
}