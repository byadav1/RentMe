
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
            this.viewTransactionsTabPage = new System.Windows.Forms.TabPage();
            this.viewTransactions = new RentMe.UserControls.ViewTransactions();
            this.furnitureReturnTabPage = new System.Windows.Forms.TabPage();
            this.furnitureReturn = new RentMe.UserControls.FurnitureReturn();
            this.servicesTableLayoutPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.searchMemberTabPage.SuspendLayout();
            this.searchEmployeeTabPage.SuspendLayout();
            this.furnitureSearchTabPage.SuspendLayout();
            this.viewTransactionsTabPage.SuspendLayout();
            this.furnitureReturnTabPage.SuspendLayout();
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
            this.servicesTableLayoutPanel.Size = new System.Drawing.Size(1578, 901);
            this.servicesTableLayoutPanel.TabIndex = 1;
            // 
            // logoutLink
            // 
            this.logoutLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.Location = new System.Drawing.Point(1500, 10);
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
            this.mainTabControl.Controls.Add(this.furnitureReturnTabPage);
            this.mainTabControl.Controls.Add(this.viewTransactionsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(3, 48);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1572, 850);
            this.mainTabControl.TabIndex = 12;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControlSelectedIndexChanged);
            // 
            // searchMemberTabPage
            // 
            this.searchMemberTabPage.Controls.Add(this.memberSearch);
            this.searchMemberTabPage.Location = new System.Drawing.Point(4, 38);
            this.searchMemberTabPage.Name = "searchMemberTabPage";
            this.searchMemberTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchMemberTabPage.Size = new System.Drawing.Size(1564, 808);
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
            this.memberSearch.Size = new System.Drawing.Size(1558, 802);
            this.memberSearch.TabIndex = 0;
            // 
            // searchEmployeeTabPage
            // 
            this.searchEmployeeTabPage.Controls.Add(this.employeeSearch);
            this.searchEmployeeTabPage.Location = new System.Drawing.Point(4, 38);
            this.searchEmployeeTabPage.Name = "searchEmployeeTabPage";
            this.searchEmployeeTabPage.Size = new System.Drawing.Size(1564, 808);
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
            this.employeeSearch.Size = new System.Drawing.Size(1564, 808);
            this.employeeSearch.TabIndex = 0;
            // 
            // furnitureSearchTabPage
            // 
            this.furnitureSearchTabPage.Controls.Add(this.furnitureRental);
            this.furnitureSearchTabPage.Location = new System.Drawing.Point(4, 38);
            this.furnitureSearchTabPage.Name = "furnitureSearchTabPage";
            this.furnitureSearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.furnitureSearchTabPage.Size = new System.Drawing.Size(1564, 808);
            this.furnitureSearchTabPage.TabIndex = 1;
            this.furnitureSearchTabPage.Text = "Search/Rent Furniture";
            this.furnitureSearchTabPage.UseVisualStyleBackColor = true;
            // 
            // furnitureRental
            // 
            this.furnitureRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureRental.Location = new System.Drawing.Point(3, 3);
            this.furnitureRental.Margin = new System.Windows.Forms.Padding(5);
            this.furnitureRental.Name = "furnitureRental";
            this.furnitureRental.Size = new System.Drawing.Size(1558, 802);
            this.furnitureRental.TabIndex = 0;
            // 
            // viewTransactionsTabPage
            // 
            this.viewTransactionsTabPage.Controls.Add(this.viewTransactions);
            this.viewTransactionsTabPage.Location = new System.Drawing.Point(4, 38);
            this.viewTransactionsTabPage.Name = "viewTransactionsTabPage";
            this.viewTransactionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewTransactionsTabPage.Size = new System.Drawing.Size(1564, 808);
            this.viewTransactionsTabPage.TabIndex = 5;
            this.viewTransactionsTabPage.Text = "View Transactions";
            this.viewTransactionsTabPage.UseVisualStyleBackColor = true;
            // 
            // viewTransactions
            // 
            this.viewTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTransactions.Location = new System.Drawing.Point(3, 3);
            this.viewTransactions.Margin = new System.Windows.Forms.Padding(5);
            this.viewTransactions.Name = "viewTransactions";
            this.viewTransactions.Size = new System.Drawing.Size(1558, 802);
            this.viewTransactions.TabIndex = 0;
            // 
            // furnitureReturnTabPage
            // 
            this.furnitureReturnTabPage.Controls.Add(this.furnitureReturn);
            this.furnitureReturnTabPage.Location = new System.Drawing.Point(4, 38);
            this.furnitureReturnTabPage.Name = "furnitureReturnTabPage";
            this.furnitureReturnTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.furnitureReturnTabPage.Size = new System.Drawing.Size(1564, 808);
            this.furnitureReturnTabPage.TabIndex = 6;
            this.furnitureReturnTabPage.Text = "Furniture Return";
            this.furnitureReturnTabPage.UseVisualStyleBackColor = true;
            // 
            // furnitureReturn
            // 
            this.furnitureReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureReturn.Location = new System.Drawing.Point(3, 3);
            this.furnitureReturn.Name = "furnitureReturn";
            this.furnitureReturn.Size = new System.Drawing.Size(1558, 802);
            this.furnitureReturn.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 901);
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
            this.viewTransactionsTabPage.ResumeLayout(false);
            this.furnitureReturnTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel servicesTableLayoutPanel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage furnitureSearchTabPage;
        private System.Windows.Forms.TabPage searchMemberTabPage;
        private UserControls.MemberSearch memberSearch;
        private System.Windows.Forms.TabPage searchEmployeeTabPage;
        private UserControls.EmployeeSearch employeeSearch;
        private System.Windows.Forms.TabPage viewTransactionsTabPage;
        private UserControls.ViewTransactions viewTransactions;
        private UserControls.FurnitureRental furnitureRental;
        private System.Windows.Forms.TabPage furnitureReturnTabPage;
        private UserControls.FurnitureReturn furnitureReturn;
    }
}