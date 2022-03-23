
namespace RentMe.View
{
    partial class MainRentMeFormUserControl
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
            this.rentMeUserTabControl = new System.Windows.Forms.TabControl();
            this.customerSearchTabPage = new System.Windows.Forms.TabPage();
            this.customerRegisterTab = new System.Windows.Forms.TabPage();
            this.searchCustomerUserControl1 = new RentMe.UserControls.SearchCustomerUserControl();
            this.rentMeUserTabControl.SuspendLayout();
            this.customerSearchTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentMeUserTabControl
            // 
            this.rentMeUserTabControl.Controls.Add(this.customerSearchTabPage);
            this.rentMeUserTabControl.Controls.Add(this.customerRegisterTab);
            this.rentMeUserTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentMeUserTabControl.Location = new System.Drawing.Point(12, 29);
            this.rentMeUserTabControl.Name = "rentMeUserTabControl";
            this.rentMeUserTabControl.SelectedIndex = 0;
            this.rentMeUserTabControl.Size = new System.Drawing.Size(1040, 1034);
            this.rentMeUserTabControl.TabIndex = 0;
            // 
            // customerSearchTabPage
            // 
            this.customerSearchTabPage.Controls.Add(this.searchCustomerUserControl1);
            this.customerSearchTabPage.Location = new System.Drawing.Point(4, 34);
            this.customerSearchTabPage.Name = "customerSearchTabPage";
            this.customerSearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerSearchTabPage.Size = new System.Drawing.Size(1032, 996);
            this.customerSearchTabPage.TabIndex = 0;
            this.customerSearchTabPage.Text = "Find Customer";
            this.customerSearchTabPage.UseVisualStyleBackColor = true;
            // 
            // customerRegisterTab
            // 
            this.customerRegisterTab.Location = new System.Drawing.Point(4, 34);
            this.customerRegisterTab.Name = "customerRegisterTab";
            this.customerRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerRegisterTab.Size = new System.Drawing.Size(993, 826);
            this.customerRegisterTab.TabIndex = 1;
            this.customerRegisterTab.Text = "Register Customer";
            this.customerRegisterTab.UseVisualStyleBackColor = true;
            // 
            // searchCustomerUserControl1
            // 
            this.searchCustomerUserControl1.Location = new System.Drawing.Point(7, 5);
            this.searchCustomerUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchCustomerUserControl1.Name = "searchCustomerUserControl1";
            this.searchCustomerUserControl1.Size = new System.Drawing.Size(898, 892);
            this.searchCustomerUserControl1.TabIndex = 0;
            // 
            // MainRentMeFormUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 1112);
            this.Controls.Add(this.rentMeUserTabControl);
            this.Name = "MainRentMeFormUserControl";
            this.Text = "MainRentMeFormUserControl";
            this.rentMeUserTabControl.ResumeLayout(false);
            this.customerSearchTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl rentMeUserTabControl;
        private System.Windows.Forms.TabPage customerSearchTabPage;
        private System.Windows.Forms.TabPage customerRegisterTab;
        private UserControls.SearchCustomerUserControl searchCustomerUserControl1;
    }
}