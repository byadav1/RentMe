
namespace RentMe.UserControls
{
    partial class EmployeeSearch
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
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.updateButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.viewAllEmployeesButton = new System.Windows.Forms.Button();
            this.employeeSearchHeaderLabel = new System.Windows.Forms.Label();
            this.searchMemberTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchEmployeeLabel = new System.Windows.Forms.Label();
            this.searchEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.memberSearchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.searchMemberTableLayoutPanel.SuspendLayout();
            this.memberSearchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.buttonsTableLayoutPanel.Controls.Add(this.viewAllEmployeesButton, 1, 0);
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
            this.updateButton.Text = "Update Employee";
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
            this.registerButton.Text = "Add Employee";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // viewAllEmployeesButton
            // 
            this.viewAllEmployeesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewAllEmployeesButton.Enabled = false;
            this.viewAllEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllEmployeesButton.Location = new System.Drawing.Point(476, 6);
            this.viewAllEmployeesButton.Name = "viewAllEmployeesButton";
            this.viewAllEmployeesButton.Size = new System.Drawing.Size(120, 54);
            this.viewAllEmployeesButton.TabIndex = 19;
            this.viewAllEmployeesButton.Text = "View All";
            this.viewAllEmployeesButton.UseVisualStyleBackColor = true;
            this.viewAllEmployeesButton.Click += new System.EventHandler(this.ViewAllEmployeesButtonClick);
            // 
            // employeeSearchHeaderLabel
            // 
            this.employeeSearchHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeSearchHeaderLabel.AutoSize = true;
            this.employeeSearchHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.memberSearchTableLayoutPanel.SetColumnSpan(this.employeeSearchHeaderLabel, 2);
            this.employeeSearchHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSearchHeaderLabel.Location = new System.Drawing.Point(329, 24);
            this.employeeSearchHeaderLabel.Name = "employeeSearchHeaderLabel";
            this.employeeSearchHeaderLabel.Size = new System.Drawing.Size(422, 60);
            this.employeeSearchHeaderLabel.TabIndex = 2;
            this.employeeSearchHeaderLabel.Text = "Employee Search";
            // 
            // searchMemberTableLayoutPanel
            // 
            this.searchMemberTableLayoutPanel.ColumnCount = 2;
            this.memberSearchTableLayoutPanel.SetColumnSpan(this.searchMemberTableLayoutPanel, 2);
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.91434F));
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.08566F));
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchEmployeeLabel, 0, 1);
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchEmployeeTextBox, 0, 0);
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
            // searchEmployeeLabel
            // 
            this.searchEmployeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchEmployeeLabel.AutoSize = true;
            this.searchMemberTableLayoutPanel.SetColumnSpan(this.searchEmployeeLabel, 2);
            this.searchEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeLabel.Location = new System.Drawing.Point(338, 46);
            this.searchEmployeeLabel.Name = "searchEmployeeLabel";
            this.searchEmployeeLabel.Size = new System.Drawing.Size(397, 20);
            this.searchEmployeeLabel.TabIndex = 3;
            this.searchEmployeeLabel.Text = "Search for an employee by their ID, Phone, or Name";
            // 
            // searchEmployeeTextBox
            // 
            this.searchEmployeeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeTextBox.Location = new System.Drawing.Point(349, 9);
            this.searchEmployeeTextBox.MaxLength = 50;
            this.searchEmployeeTextBox.Name = "searchEmployeeTextBox";
            this.searchEmployeeTextBox.Size = new System.Drawing.Size(270, 28);
            this.searchEmployeeTextBox.TabIndex = 1;
            this.searchEmployeeTextBox.TextChanged += new System.EventHandler(this.SearchEmployeeTextBoxTextChanged);
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
            // memberSearchTableLayoutPanel
            // 
            this.memberSearchTableLayoutPanel.ColumnCount = 2;
            this.memberSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.memberSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.memberSearchTableLayoutPanel.Controls.Add(this.statusMessage, 0, 3);
            this.memberSearchTableLayoutPanel.Controls.Add(this.searchMemberTableLayoutPanel, 0, 1);
            this.memberSearchTableLayoutPanel.Controls.Add(this.employeeSearchHeaderLabel, 0, 0);
            this.memberSearchTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 4);
            this.memberSearchTableLayoutPanel.Controls.Add(this.employeeDataGridView, 0, 2);
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
            this.memberSearchTableLayoutPanel.TabIndex = 1;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeeDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.active,
            this.employeeID,
            this.type,
            this.fname,
            this.lname,
            this.username,
            this.dob,
            this.phone,
            this.sex,
            this.address1,
            this.address2,
            this.city,
            this.state,
            this.zip});
            this.memberSearchTableLayoutPanel.SetColumnSpan(this.employeeDataGridView, 2);
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGridView.Location = new System.Drawing.Point(3, 183);
            this.employeeDataGridView.MultiSelect = false;
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(1074, 390);
            this.employeeDataGridView.TabIndex = 26;
            // 
            // active
            // 
            this.active.DataPropertyName = "Active";
            this.active.HeaderText = "Active";
            this.active.MinimumWidth = 6;
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.Width = 52;
            // 
            // employeeID
            // 
            this.employeeID.DataPropertyName = "EmployeeID";
            this.employeeID.HeaderText = "ID";
            this.employeeID.MinimumWidth = 6;
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Width = 50;
            // 
            // type
            // 
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 69;
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
            // username
            // 
            this.username.DataPropertyName = "Username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 102;
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
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(RentMe.Model.Employee);
            // 
            // EmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberSearchTableLayoutPanel);
            this.Name = "EmployeeSearch";
            this.Size = new System.Drawing.Size(1080, 720);
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.searchMemberTableLayoutPanel.ResumeLayout(false);
            this.searchMemberTableLayoutPanel.PerformLayout();
            this.memberSearchTableLayoutPanel.ResumeLayout(false);
            this.memberSearchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel memberSearchTableLayoutPanel;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.TableLayoutPanel searchMemberTableLayoutPanel;
        private System.Windows.Forms.Label searchEmployeeLabel;
        private System.Windows.Forms.TextBox searchEmployeeTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label employeeSearchHeaderLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button viewAllEmployeesButton;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
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
