
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
            this.searchMemberTab = new System.Windows.Forms.TabPage();
            this.memberServices = new RentMe.UserControls.MemberServices();
            this.employeeTabPage = new System.Windows.Forms.TabPage();
            this.employeeServices1 = new RentMe.UserControls.EmployeeServices();
            this.furnitureSearchTabPage = new System.Windows.Forms.TabPage();
            this.furnitureRental1 = new RentMe.UserControls.FurnitureRental();
            this.servicesTableLayoutPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.searchMemberTab.SuspendLayout();
            this.employeeTabPage.SuspendLayout();
            this.furnitureSearchTabPage.SuspendLayout();
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
            this.logoutLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.Location = new System.Drawing.Point(1162, 12);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(68, 24);
            this.logoutLink.TabIndex = 10;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkClickedEventHandle);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentUserLabel.AutoSize = true;
            this.servicesTableLayoutPanel.SetColumnSpan(this.currentUserLabel, 2);
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(3, 14);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(108, 20);
            this.currentUserLabel.TabIndex = 11;
            this.currentUserLabel.Text = "Current user:";
            // 
            // mainTabControl
            // 
            this.servicesTableLayoutPanel.SetColumnSpan(this.mainTabControl, 3);
            this.mainTabControl.Controls.Add(this.searchMemberTab);
            this.mainTabControl.Controls.Add(this.employeeTabPage);
            this.mainTabControl.Controls.Add(this.furnitureSearchTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(3, 52);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1427, 943);
            this.mainTabControl.TabIndex = 12;
            // 
            // searchMemberTab
            // 
            this.searchMemberTab.Controls.Add(this.memberServices);
            this.searchMemberTab.Location = new System.Drawing.Point(4, 38);
            this.searchMemberTab.Name = "searchMemberTab";
            this.searchMemberTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchMemberTab.Size = new System.Drawing.Size(1419, 901);
            this.searchMemberTab.TabIndex = 0;
            this.searchMemberTab.Text = "Member Services";
            this.searchMemberTab.UseVisualStyleBackColor = true;
            // 
            // memberServices
            // 
            this.memberServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberServices.Location = new System.Drawing.Point(3, 3);
            this.memberServices.Name = "memberServices";
            this.memberServices.Size = new System.Drawing.Size(1413, 895);
            this.memberServices.TabIndex = 0;
            // 
            // employeeTabPage
            // 
            this.employeeTabPage.Controls.Add(this.employeeServices1);
            this.employeeTabPage.Location = new System.Drawing.Point(4, 38);
            this.employeeTabPage.Name = "employeeTabPage";
            this.employeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTabPage.Size = new System.Drawing.Size(1419, 901);
            this.employeeTabPage.TabIndex = 2;
            this.employeeTabPage.Text = "Employee Services";
            this.employeeTabPage.UseVisualStyleBackColor = true;
            // 
            // employeeServices1
            // 
            this.employeeServices1.Location = new System.Drawing.Point(78, 23);
            this.employeeServices1.Margin = new System.Windows.Forms.Padding(5);
            this.employeeServices1.Name = "employeeServices1";
            this.employeeServices1.Size = new System.Drawing.Size(1151, 856);
            this.employeeServices1.TabIndex = 0;
            // 
            // furnitureSearchTabPage
            // 
            this.furnitureSearchTabPage.Controls.Add(this.furnitureRental1);
            this.furnitureSearchTabPage.Location = new System.Drawing.Point(4, 38);
            this.furnitureSearchTabPage.Name = "furnitureSearchTabPage";
            this.furnitureSearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.furnitureSearchTabPage.Size = new System.Drawing.Size(1419, 901);
            this.furnitureSearchTabPage.TabIndex = 1;
            this.furnitureSearchTabPage.Text = "Search Furniture";
            this.furnitureSearchTabPage.UseVisualStyleBackColor = true;
            // 
            // furnitureRental1
            // 
            this.furnitureRental1.Location = new System.Drawing.Point(7, 8);
            this.furnitureRental1.Margin = new System.Windows.Forms.Padding(5);
            this.furnitureRental1.Name = "furnitureRental1";
            this.furnitureRental1.Size = new System.Drawing.Size(1391, 785);
            this.furnitureRental1.TabIndex = 0;
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
            this.Text = "RentMe: Member Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosedEventHandle);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.servicesTableLayoutPanel.ResumeLayout(false);
            this.servicesTableLayoutPanel.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.searchMemberTab.ResumeLayout(false);
            this.employeeTabPage.ResumeLayout(false);
            this.furnitureSearchTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel servicesTableLayoutPanel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage searchMemberTab;
        private UserControls.MemberServices memberServices;
        private System.Windows.Forms.TabPage furnitureSearchTabPage;
        private UserControls.FurnitureRental furnitureRental1;
        private System.Windows.Forms.TabPage employeeTabPage;
        private UserControls.EmployeeServices employeeServices1;
    }
}