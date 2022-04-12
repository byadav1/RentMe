
namespace RentMe.View
{
    partial class MainForm
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
            this.servicesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.searchMemberTabPage = new System.Windows.Forms.TabPage();
            this.memberSearch = new RentMe.UserControls.MemberSearch();
            this.searchEmployeeTabPage = new System.Windows.Forms.TabPage();
            this.employeeSearch = new RentMe.UserControls.EmployeeSearch();
            this.furnitureSearchTabPage = new System.Windows.Forms.TabPage();
            this.furnitureRental = new RentMe.UserControls.FurnitureRental();
            this.viewRentalTransactionsTabPage = new System.Windows.Forms.TabPage();
            this.viewRentalTransactions = new RentMe.UserControls.ViewRentalTransactions();
            this.servicesTableLayoutPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.searchMemberTabPage.SuspendLayout();
            this.searchEmployeeTabPage.SuspendLayout();
            this.furnitureSearchTabPage.SuspendLayout();
            this.viewRentalTransactionsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesTableLayoutPanel
            // 
            this.servicesTableLayoutPanel.ColumnCount = 3;
            this.servicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.servicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.servicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.servicesTableLayoutPanel.Controls.Add(this.logoutLink, 2, 0);
            this.servicesTableLayoutPanel.Controls.Add(this.currentUserLabel, 0, 0);
            this.servicesTableLayoutPanel.Controls.Add(this.mainTabControl, 0, 1);
            this.servicesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.servicesTableLayoutPanel.Name = "servicesTableLayoutPanel";
            this.servicesTableLayoutPanel.RowCount = 2;
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.servicesTableLayoutPanel.Size = new System.Drawing.Size(1433, 998);
            this.servicesTableLayoutPanel.TabIndex = 1;
            // 
            // logoutLink
            // 
            this.logoutLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.Location = new System.Drawing.Point(1355, 12);
            this.logoutLink.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(68, 24);
            this.logoutLink.TabIndex = 10;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkClickedEventHandle);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.servicesTableLayoutPanel.SetColumnSpan(this.currentUserLabel, 2);
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(3, 0);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(108, 20);
            this.currentUserLabel.TabIndex = 11;
            this.currentUserLabel.Text = "Current user:";
            // 
            // mainTabControl
            // 
            this.servicesTableLayoutPanel.SetColumnSpan(this.mainTabControl, 3);
            this.mainTabControl.Controls.Add(this.searchMemberTabPage);
            this.mainTabControl.Controls.Add(this.searchEmployeeTabPage);
            this.mainTabControl.Controls.Add(this.furnitureSearchTabPage);
            this.mainTabControl.Controls.Add(this.viewRentalTransactionsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(3, 52);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1427, 943);
            this.mainTabControl.TabIndex = 12;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControlSelectedIndexChanged);
            // 
            // searchMemberTabPage
            // 
            this.searchMemberTabPage.Controls.Add(this.memberSearch);
            this.searchMemberTabPage.Location = new System.Drawing.Point(4, 38);
            this.searchMemberTabPage.Name = "searchMemberTabPage";
            this.searchMemberTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchMemberTabPage.Size = new System.Drawing.Size(1419, 901);
            this.searchMemberTabPage.TabIndex = 3;
            this.searchMemberTabPage.Text = "Search Member";
            this.searchMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // memberSearch
            // 
            this.memberSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberSearch.Location = new System.Drawing.Point(3, 3);
            this.memberSearch.Margin = new System.Windows.Forms.Padding(5);
            this.memberSearch.Name = "memberSearch";
            this.memberSearch.Size = new System.Drawing.Size(1413, 895);
            this.memberSearch.TabIndex = 0;
            // 
            // searchEmployeeTabPage
            // 
            this.searchEmployeeTabPage.Controls.Add(this.employeeSearch);
            this.searchEmployeeTabPage.Location = new System.Drawing.Point(4, 38);
            this.searchEmployeeTabPage.Name = "searchEmployeeTabPage";
            this.searchEmployeeTabPage.Size = new System.Drawing.Size(1419, 901);
            this.searchEmployeeTabPage.TabIndex = 4;
            this.searchEmployeeTabPage.Text = "Search Employee";
            this.searchEmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // employeeSearch
            // 
            this.employeeSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSearch.Location = new System.Drawing.Point(0, 0);
            this.employeeSearch.Margin = new System.Windows.Forms.Padding(5);
            this.employeeSearch.Name = "employeeSearch";
            this.employeeSearch.Size = new System.Drawing.Size(1419, 901);
            this.employeeSearch.TabIndex = 0;
            // 
            // furnitureSearchTabPage
            // 
            this.furnitureSearchTabPage.Controls.Add(this.furnitureRental);
            this.furnitureSearchTabPage.Location = new System.Drawing.Point(4, 38);
            this.furnitureSearchTabPage.Name = "furnitureSearchTabPage";
            this.furnitureSearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.furnitureSearchTabPage.Size = new System.Drawing.Size(1419, 901);
            this.furnitureSearchTabPage.TabIndex = 1;
            this.furnitureSearchTabPage.Text = "Search Furniture";
            this.furnitureSearchTabPage.UseVisualStyleBackColor = true;
            // 
            // furnitureRental
            // 
            this.furnitureRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureRental.Location = new System.Drawing.Point(3, 3);
            this.furnitureRental.Margin = new System.Windows.Forms.Padding(5);
            this.furnitureRental.Name = "furnitureRental";
            this.furnitureRental.Size = new System.Drawing.Size(1413, 895);
            this.furnitureRental.TabIndex = 0;
            // 
            // viewRentalTransactionsTabPage
            // 
            this.viewRentalTransactionsTabPage.Controls.Add(this.viewRentalTransactions);
            this.viewRentalTransactionsTabPage.Location = new System.Drawing.Point(4, 38);
            this.viewRentalTransactionsTabPage.Name = "viewRentalTransactionsTabPage";
            this.viewRentalTransactionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewRentalTransactionsTabPage.Size = new System.Drawing.Size(1419, 901);
            this.viewRentalTransactionsTabPage.TabIndex = 5;
            this.viewRentalTransactionsTabPage.Text = "View Rentals";
            this.viewRentalTransactionsTabPage.UseVisualStyleBackColor = true;
            // 
            // viewRentalTransactions
            // 
            this.viewRentalTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewRentalTransactions.Location = new System.Drawing.Point(3, 3);
            this.viewRentalTransactions.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.viewRentalTransactions.Name = "viewRentalTransactions";
            this.viewRentalTransactions.Size = new System.Drawing.Size(1413, 895);
            this.viewRentalTransactions.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 998);
            this.Controls.Add(this.servicesTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe: Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosedEventHandle);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.servicesTableLayoutPanel.ResumeLayout(false);
            this.servicesTableLayoutPanel.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.searchMemberTabPage.ResumeLayout(false);
            this.searchEmployeeTabPage.ResumeLayout(false);
            this.furnitureSearchTabPage.ResumeLayout(false);
            this.viewRentalTransactionsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel servicesTableLayoutPanel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage furnitureSearchTabPage;
        private UserControls.FurnitureRental furnitureRental;
        private System.Windows.Forms.TabPage searchMemberTabPage;
        private UserControls.MemberSearch memberSearch;
        private System.Windows.Forms.TabPage searchEmployeeTabPage;
        private UserControls.EmployeeSearch employeeSearch;
        private System.Windows.Forms.TabPage viewRentalTransactionsTabPage;
        private UserControls.ViewRentalTransactions viewRentalTransactions;
    }
}