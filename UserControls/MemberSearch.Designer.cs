
namespace RentMe.UserControls
{
    partial class MemberSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.memberSearchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.statusMessage = new System.Windows.Forms.Label();
            this.searchMemberTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchMemberLabel = new System.Windows.Forms.Label();
            this.searchMemberTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.memberSearchHeaderLabel = new System.Windows.Forms.Label();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.updateButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.viewAllMembersButton = new System.Windows.Forms.Button();
            this.memberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberSearchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.searchMemberTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberSearchTableLayoutPanel
            // 
            this.memberSearchTableLayoutPanel.ColumnCount = 2;
            this.memberSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.memberSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.memberSearchTableLayoutPanel.Controls.Add(this.memberDataGridView, 0, 2);
            this.memberSearchTableLayoutPanel.Controls.Add(this.statusMessage, 0, 3);
            this.memberSearchTableLayoutPanel.Controls.Add(this.searchMemberTableLayoutPanel, 0, 1);
            this.memberSearchTableLayoutPanel.Controls.Add(this.memberSearchHeaderLabel, 0, 0);
            this.memberSearchTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 4);
            this.memberSearchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberSearchTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.memberSearchTableLayoutPanel.Name = "memberSearchTableLayoutPanel";
            this.memberSearchTableLayoutPanel.RowCount = 5;
            this.memberSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.memberSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.memberSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.memberSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.memberSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.memberSearchTableLayoutPanel.Size = new System.Drawing.Size(1080, 720);
            this.memberSearchTableLayoutPanel.TabIndex = 0;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.memberDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.memberDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberID,
            this.fname,
            this.lname,
            this.dob,
            this.phone,
            this.sex,
            this.address1,
            this.address2,
            this.city,
            this.state,
            this.zip});
            this.memberSearchTableLayoutPanel.SetColumnSpan(this.memberDataGridView, 2);
            this.memberDataGridView.DataSource = this.memberBindingSource;
            this.memberDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberDataGridView.Location = new System.Drawing.Point(3, 183);
            this.memberDataGridView.MultiSelect = false;
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.RowHeadersWidth = 51;
            this.memberDataGridView.RowTemplate.Height = 24;
            this.memberDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberDataGridView.Size = new System.Drawing.Size(1074, 390);
            this.memberDataGridView.TabIndex = 3;
            // 
            // statusMessage
            // 
            this.statusMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusMessage.AutoSize = true;
            this.memberSearchTableLayoutPanel.SetColumnSpan(this.statusMessage, 2);
            this.statusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessage.ForeColor = System.Drawing.Color.Red;
            this.statusMessage.Location = new System.Drawing.Point(480, 602);
            this.statusMessage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(119, 24);
            this.statusMessage.TabIndex = 24;
            this.statusMessage.Text = "Invalid Fields";
            this.statusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusMessage.Visible = false;
            // 
            // searchMemberTableLayoutPanel
            // 
            this.searchMemberTableLayoutPanel.ColumnCount = 2;
            this.memberSearchTableLayoutPanel.SetColumnSpan(this.searchMemberTableLayoutPanel, 2);
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.91434F));
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.08566F));
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchMemberLabel, 0, 1);
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchMemberTextBox, 0, 0);
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchButton, 1, 0);
            this.searchMemberTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchMemberTableLayoutPanel.Location = new System.Drawing.Point(3, 111);
            this.searchMemberTableLayoutPanel.Name = "searchMemberTableLayoutPanel";
            this.searchMemberTableLayoutPanel.RowCount = 2;
            this.searchMemberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.searchMemberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchMemberTableLayoutPanel.Size = new System.Drawing.Size(1074, 66);
            this.searchMemberTableLayoutPanel.TabIndex = 3;
            // 
            // searchMemberLabel
            // 
            this.searchMemberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchMemberLabel.AutoSize = true;
            this.searchMemberTableLayoutPanel.SetColumnSpan(this.searchMemberLabel, 2);
            this.searchMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberLabel.Location = new System.Drawing.Point(348, 46);
            this.searchMemberLabel.Name = "searchMemberLabel";
            this.searchMemberLabel.Size = new System.Drawing.Size(378, 20);
            this.searchMemberLabel.TabIndex = 3;
            this.searchMemberLabel.Text = "Search for a member by their ID, Phone, or Name";
            // 
            // searchMemberTextBox
            // 
            this.searchMemberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchMemberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberTextBox.Location = new System.Drawing.Point(349, 9);
            this.searchMemberTextBox.MaxLength = 50;
            this.searchMemberTextBox.Name = "searchMemberTextBox";
            this.searchMemberTextBox.Size = new System.Drawing.Size(270, 28);
            this.searchMemberTextBox.TabIndex = 1;
            this.searchMemberTextBox.TextChanged += new System.EventHandler(this.SearchMemberTextBoxTextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.Enabled = false;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(625, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // memberSearchHeaderLabel
            // 
            this.memberSearchHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberSearchHeaderLabel.AutoSize = true;
            this.memberSearchHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.memberSearchTableLayoutPanel.SetColumnSpan(this.memberSearchHeaderLabel, 2);
            this.memberSearchHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchHeaderLabel.Location = new System.Drawing.Point(348, 24);
            this.memberSearchHeaderLabel.Name = "memberSearchHeaderLabel";
            this.memberSearchHeaderLabel.Size = new System.Drawing.Size(384, 60);
            this.memberSearchHeaderLabel.TabIndex = 2;
            this.memberSearchHeaderLabel.Text = "Member Search";
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.memberSearchTableLayoutPanel.SetColumnSpan(this.buttonsTableLayoutPanel, 2);
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonsTableLayoutPanel.Controls.Add(this.updateButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.registerButton, 2, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.viewAllMembersButton, 1, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 651);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(1074, 66);
            this.buttonsTableLayoutPanel.TabIndex = 25;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(117, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 54);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update Member";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(836, 6);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(120, 54);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Register Member";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // viewAllMembersButton
            // 
            this.viewAllMembersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewAllMembersButton.Enabled = false;
            this.viewAllMembersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllMembersButton.Location = new System.Drawing.Point(476, 6);
            this.viewAllMembersButton.Name = "viewAllMembersButton";
            this.viewAllMembersButton.Size = new System.Drawing.Size(120, 54);
            this.viewAllMembersButton.TabIndex = 19;
            this.viewAllMembersButton.Text = "View All";
            this.viewAllMembersButton.UseVisualStyleBackColor = true;
            this.viewAllMembersButton.Click += new System.EventHandler(this.ViewAllMembersButtonClick);
            // 
            // memberID
            // 
            this.memberID.DataPropertyName = "MemberID";
            this.memberID.HeaderText = "ID";
            this.memberID.MinimumWidth = 6;
            this.memberID.Name = "memberID";
            this.memberID.ReadOnly = true;
            this.memberID.Width = 50;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "FName";
            this.fname.HeaderText = "First Name";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 105;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "LName";
            this.lname.HeaderText = "Last Name";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 105;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "DOB";
            this.dob.HeaderText = "DOB";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 67;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 78;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            this.sex.HeaderText = "Sex";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 60;
            // 
            // address1
            // 
            this.address1.DataPropertyName = "Address1";
            this.address1.HeaderText = "Address1";
            this.address1.MinimumWidth = 6;
            this.address1.Name = "address1";
            this.address1.ReadOnly = true;
            this.address1.Width = 97;
            // 
            // address2
            // 
            this.address2.DataPropertyName = "Address2";
            this.address2.HeaderText = "Address2";
            this.address2.MinimumWidth = 6;
            this.address2.Name = "address2";
            this.address2.ReadOnly = true;
            this.address2.Width = 97;
            // 
            // city
            // 
            this.city.DataPropertyName = "City";
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 60;
            // 
            // state
            // 
            this.state.DataPropertyName = "State";
            this.state.HeaderText = "State";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 70;
            // 
            // zip
            // 
            this.zip.DataPropertyName = "Zip";
            this.zip.HeaderText = "Zip";
            this.zip.MinimumWidth = 6;
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            this.zip.Width = 57;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(RentMe.Model.Member);
            // 
            // MemberSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberSearchTableLayoutPanel);
            this.Name = "MemberSearch";
            this.Size = new System.Drawing.Size(1080, 720);
            this.memberSearchTableLayoutPanel.ResumeLayout(false);
            this.memberSearchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.searchMemberTableLayoutPanel.ResumeLayout(false);
            this.searchMemberTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel memberSearchTableLayoutPanel;
        private System.Windows.Forms.Label memberSearchHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel searchMemberTableLayoutPanel;
        private System.Windows.Forms.Label searchMemberLabel;
        private System.Windows.Forms.TextBox searchMemberTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button viewAllMembersButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
    }
}
