
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchPhoneButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.servicesHeaderLabel = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.memberPhoneTextBox = new System.Windows.Forms.TextBox();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.memberPhoneLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.continueButton = new System.Windows.Forms.Button();
            this.registerMemberButton = new System.Windows.Forms.Button();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.searchIDButton = new System.Windows.Forms.Button();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.servicesTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesTableLayoutPanel
            // 
            this.servicesTableLayoutPanel.ColumnCount = 3;
            this.servicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.servicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.servicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.servicesTableLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.servicesTableLayoutPanel.Controls.Add(this.searchPhoneButton, 2, 5);
            this.servicesTableLayoutPanel.Controls.Add(this.searchNameButton, 2, 4);
            this.servicesTableLayoutPanel.Controls.Add(this.servicesHeaderLabel, 0, 1);
            this.servicesTableLayoutPanel.Controls.Add(this.errorMessage, 0, 6);
            this.servicesTableLayoutPanel.Controls.Add(this.memberIDTextBox, 1, 3);
            this.servicesTableLayoutPanel.Controls.Add(this.memberPhoneTextBox, 1, 5);
            this.servicesTableLayoutPanel.Controls.Add(this.memberIDLabel, 0, 3);
            this.servicesTableLayoutPanel.Controls.Add(this.memberPhoneLabel, 0, 5);
            this.servicesTableLayoutPanel.Controls.Add(this.memberNameLabel, 0, 4);
            this.servicesTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 7);
            this.servicesTableLayoutPanel.Controls.Add(this.memberNameTextBox, 1, 4);
            this.servicesTableLayoutPanel.Controls.Add(this.searchIDButton, 2, 3);
            this.servicesTableLayoutPanel.Controls.Add(this.logoutLink, 2, 0);
            this.servicesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.servicesTableLayoutPanel.Name = "servicesTableLayoutPanel";
            this.servicesTableLayoutPanel.RowCount = 8;
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.servicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.servicesTableLayoutPanel.Size = new System.Drawing.Size(478, 499);
            this.servicesTableLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.servicesTableLayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search a member by ID, Full Name, or Phone";
            // 
            // searchPhoneButton
            // 
            this.searchPhoneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchPhoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPhoneButton.Location = new System.Drawing.Point(353, 302);
            this.searchPhoneButton.Name = "searchPhoneButton";
            this.searchPhoneButton.Size = new System.Drawing.Size(90, 35);
            this.searchPhoneButton.TabIndex = 7;
            this.searchPhoneButton.Text = "Search";
            this.searchPhoneButton.UseVisualStyleBackColor = true;
            // 
            // searchNameButton
            // 
            this.searchNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameButton.Location = new System.Drawing.Point(353, 253);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(90, 35);
            this.searchNameButton.TabIndex = 5;
            this.searchNameButton.Text = "Search";
            this.searchNameButton.UseVisualStyleBackColor = true;
            // 
            // servicesHeaderLabel
            // 
            this.servicesHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicesHeaderLabel.AutoSize = true;
            this.servicesHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servicesTableLayoutPanel.SetColumnSpan(this.servicesHeaderLabel, 3);
            this.servicesHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesHeaderLabel.Location = new System.Drawing.Point(30, 56);
            this.servicesHeaderLabel.Name = "servicesHeaderLabel";
            this.servicesHeaderLabel.Size = new System.Drawing.Size(417, 60);
            this.servicesHeaderLabel.TabIndex = 0;
            this.servicesHeaderLabel.Text = "Member Services";
            // 
            // errorMessage
            // 
            this.errorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorMessage.AutoSize = true;
            this.servicesTableLayoutPanel.SetColumnSpan(this.errorMessage, 3);
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(42, 344);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(393, 24);
            this.errorMessage.TabIndex = 1;
            this.errorMessage.Text = "Search a member by ID, Full Name, or Phone";
            this.errorMessage.Visible = false;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDTextBox.Location = new System.Drawing.Point(160, 207);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(156, 28);
            this.memberIDTextBox.TabIndex = 2;
            // 
            // memberPhoneTextBox
            // 
            this.memberPhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberPhoneTextBox.Location = new System.Drawing.Point(160, 305);
            this.memberPhoneTextBox.Name = "memberPhoneTextBox";
            this.memberPhoneTextBox.PasswordChar = '*';
            this.memberPhoneTextBox.Size = new System.Drawing.Size(156, 28);
            this.memberPhoneTextBox.TabIndex = 6;
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDLabel.Location = new System.Drawing.Point(51, 209);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(103, 24);
            this.memberIDLabel.TabIndex = 4;
            this.memberIDLabel.Text = "MemberID:";
            // 
            // memberPhoneLabel
            // 
            this.memberPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.memberPhoneLabel.AutoSize = true;
            this.memberPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberPhoneLabel.Location = new System.Drawing.Point(83, 307);
            this.memberPhoneLabel.Name = "memberPhoneLabel";
            this.memberPhoneLabel.Size = new System.Drawing.Size(71, 24);
            this.memberPhoneLabel.TabIndex = 5;
            this.memberPhoneLabel.Text = "Phone:";
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.Location = new System.Drawing.Point(88, 258);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(66, 24);
            this.memberNameLabel.TabIndex = 6;
            this.memberNameLabel.Text = "Name:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.servicesTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.continueButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.registerMemberButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 371);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 125);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(279, 32);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(150, 60);
            this.continueButton.TabIndex = 9;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            // 
            // registerMemberButton
            // 
            this.registerMemberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerMemberButton.Location = new System.Drawing.Point(43, 32);
            this.registerMemberButton.Name = "registerMemberButton";
            this.registerMemberButton.Size = new System.Drawing.Size(150, 60);
            this.registerMemberButton.TabIndex = 8;
            this.registerMemberButton.Text = "Register New Member";
            this.registerMemberButton.UseVisualStyleBackColor = true;
            this.registerMemberButton.Click += new System.EventHandler(this.RegisterMemberButtonClick);
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameTextBox.Location = new System.Drawing.Point(160, 256);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.PasswordChar = '*';
            this.memberNameTextBox.Size = new System.Drawing.Size(156, 28);
            this.memberNameTextBox.TabIndex = 4;
            // 
            // searchIDButton
            // 
            this.searchIDButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDButton.Location = new System.Drawing.Point(353, 204);
            this.searchIDButton.Name = "searchIDButton";
            this.searchIDButton.Size = new System.Drawing.Size(90, 35);
            this.searchIDButton.TabIndex = 3;
            this.searchIDButton.Text = "Search";
            this.searchIDButton.UseVisualStyleBackColor = true;
            // 
            // logoutLink
            // 
            this.logoutLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.Location = new System.Drawing.Point(364, 0);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(68, 24);
            this.logoutLink.TabIndex = 10;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkClickedEventHandle);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 499);
            this.Controls.Add(this.servicesTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe: Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosedEventHandle);
            this.servicesTableLayoutPanel.ResumeLayout(false);
            this.servicesTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel servicesTableLayoutPanel;
        private System.Windows.Forms.Label servicesHeaderLabel;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox memberPhoneTextBox;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.Label memberPhoneLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.TextBox memberNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button searchPhoneButton;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button registerMemberButton;
        private System.Windows.Forms.Button searchIDButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel logoutLink;
    }
}