
namespace RentMe.UserControls
{
    partial class EmployeeServices
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
            this.searchButton = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.employeeServicesHeaderLabel = new System.Windows.Forms.Label();
            this.employeeServicesButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.toggleActiveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchEmployeeLabel = new System.Windows.Forms.Label();
            this.searchEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.employeeServicesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.searchEmployeeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.checkBoxTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.isAdministratorCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.employeeServicesButtonsTableLayoutPanel.SuspendLayout();
            this.employeeServicesTableLayoutPanel.SuspendLayout();
            this.searchEmployeeTableLayoutPanel.SuspendLayout();
            this.checkBoxTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(359, 7);
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
            this.employeeServicesTableLayoutPanel.SetColumnSpan(this.statusMessage, 2);
            this.statusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessage.ForeColor = System.Drawing.Color.Red;
            this.statusMessage.Location = new System.Drawing.Point(240, 657);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(119, 24);
            this.statusMessage.TabIndex = 23;
            this.statusMessage.Text = "Invalid Fields";
            this.statusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusMessage.Visible = false;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTextBox.Location = new System.Drawing.Point(243, 183);
            this.lnameTextBox.MaxLength = 50;
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(212, 28);
            this.lnameTextBox.TabIndex = 2;
            this.lnameTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // lnameLabel
            // 
            this.lnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(133, 185);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(104, 24);
            this.lnameLabel.TabIndex = 5;
            this.lnameLabel.Text = "Last Name:";
            // 
            // employeeServicesHeaderLabel
            // 
            this.employeeServicesHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeServicesHeaderLabel.AutoSize = true;
            this.employeeServicesHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeServicesTableLayoutPanel.SetColumnSpan(this.employeeServicesHeaderLabel, 2);
            this.employeeServicesHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeServicesHeaderLabel.Location = new System.Drawing.Point(72, 5);
            this.employeeServicesHeaderLabel.Name = "employeeServicesHeaderLabel";
            this.employeeServicesHeaderLabel.Size = new System.Drawing.Size(455, 60);
            this.employeeServicesHeaderLabel.TabIndex = 1;
            this.employeeServicesHeaderLabel.Text = "Employee Services";
            // 
            // employeeServicesButtonsTableLayoutPanel
            // 
            this.employeeServicesButtonsTableLayoutPanel.ColumnCount = 4;
            this.employeeServicesTableLayoutPanel.SetColumnSpan(this.employeeServicesButtonsTableLayoutPanel, 3);
            this.employeeServicesButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.employeeServicesButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.employeeServicesButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.employeeServicesButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.employeeServicesButtonsTableLayoutPanel.Controls.Add(this.toggleActiveButton, 0, 0);
            this.employeeServicesButtonsTableLayoutPanel.Controls.Add(this.updateButton, 0, 0);
            this.employeeServicesButtonsTableLayoutPanel.Controls.Add(this.registerButton, 3, 0);
            this.employeeServicesButtonsTableLayoutPanel.Controls.Add(this.clearButton, 2, 0);
            this.employeeServicesButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeServicesButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 699);
            this.employeeServicesButtonsTableLayoutPanel.Name = "employeeServicesButtonsTableLayoutPanel";
            this.employeeServicesButtonsTableLayoutPanel.RowCount = 1;
            this.employeeServicesButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.employeeServicesButtonsTableLayoutPanel.Size = new System.Drawing.Size(594, 68);
            this.employeeServicesButtonsTableLayoutPanel.TabIndex = 11;
            // 
            // toggleActiveButton
            // 
            this.toggleActiveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toggleActiveButton.Enabled = false;
            this.toggleActiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleActiveButton.Location = new System.Drawing.Point(162, 4);
            this.toggleActiveButton.Name = "toggleActiveButton";
            this.toggleActiveButton.Size = new System.Drawing.Size(120, 60);
            this.toggleActiveButton.TabIndex = 15;
            this.toggleActiveButton.Text = "Mark Inactive";
            this.toggleActiveButton.UseVisualStyleBackColor = true;
            this.toggleActiveButton.Click += new System.EventHandler(this.ToggleActiveButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(14, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 60);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(459, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(120, 60);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "Add Employee";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(310, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 60);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // searchEmployeeLabel
            // 
            this.searchEmployeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchEmployeeLabel.AutoSize = true;
            this.searchEmployeeTableLayoutPanel.SetColumnSpan(this.searchEmployeeLabel, 2);
            this.searchEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeLabel.Location = new System.Drawing.Point(98, 44);
            this.searchEmployeeLabel.Name = "searchEmployeeLabel";
            this.searchEmployeeLabel.Size = new System.Drawing.Size(397, 20);
            this.searchEmployeeLabel.TabIndex = 3;
            this.searchEmployeeLabel.Text = "Search for an employee by their ID, Phone, or Name";
            // 
            // searchEmployeeTextBox
            // 
            this.searchEmployeeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeTextBox.Location = new System.Drawing.Point(83, 8);
            this.searchEmployeeTextBox.Name = "searchEmployeeTextBox";
            this.searchEmployeeTextBox.Size = new System.Drawing.Size(270, 28);
            this.searchEmployeeTextBox.TabIndex = 0;
            this.searchEmployeeTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // fnameLabel
            // 
            this.fnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(131, 147);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(106, 24);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "First Name:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.Location = new System.Drawing.Point(243, 145);
            this.fnameTextBox.MaxLength = 50;
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(212, 28);
            this.fnameTextBox.TabIndex = 1;
            this.fnameTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // sexLabel
            // 
            this.sexLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(189, 223);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(48, 24);
            this.sexLabel.TabIndex = 6;
            this.sexLabel.Text = "Sex:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(166, 261);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(71, 24);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "Phone:";
            // 
            // dobLabel
            // 
            this.dobLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(122, 299);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(115, 24);
            this.dobLabel.TabIndex = 8;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // address1Label
            // 
            this.address1Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.address1Label.AutoSize = true;
            this.address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Label.Location = new System.Drawing.Point(137, 337);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(100, 24);
            this.address1Label.TabIndex = 9;
            this.address1Label.Text = "Address 1:";
            // 
            // employeeServicesTableLayoutPanel
            // 
            this.employeeServicesTableLayoutPanel.ColumnCount = 2;
            this.employeeServicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.employeeServicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.employeeServicesTableLayoutPanel.Controls.Add(this.usernameTextBox, 1, 12);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.statusMessage, 0, 15);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.lnameTextBox, 1, 3);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.lnameLabel, 0, 3);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.usernameLabel, 0, 12);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.employeeServicesHeaderLabel, 0, 0);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.employeeServicesButtonsTableLayoutPanel, 0, 16);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.fnameLabel, 0, 2);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.fnameTextBox, 1, 2);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.sexLabel, 0, 4);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.phoneLabel, 0, 5);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.dobLabel, 0, 6);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.address1Label, 0, 7);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.address2Label, 0, 8);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.cityLabel, 0, 9);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.stateLabel, 0, 10);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.zipLabel, 0, 11);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.phoneTextBox, 1, 5);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.dobPicker, 1, 6);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.address1TextBox, 1, 7);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.address2TextBox, 1, 8);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.cityTextBox, 1, 9);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.zipTextBox, 1, 11);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.sexComboBox, 1, 4);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.searchEmployeeTableLayoutPanel, 0, 1);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.stateComboBox, 1, 10);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.passwordTextBox, 1, 13);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.passwordLabel, 0, 13);
            this.employeeServicesTableLayoutPanel.Controls.Add(this.checkBoxTableLayoutPanel, 0, 14);
            this.employeeServicesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeServicesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.employeeServicesTableLayoutPanel.Name = "employeeServicesTableLayoutPanel";
            this.employeeServicesTableLayoutPanel.RowCount = 17;
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.103782F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.103782F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.057657F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.008496F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.080719F));
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.011329F));
            this.employeeServicesTableLayoutPanel.Size = new System.Drawing.Size(600, 770);
            this.employeeServicesTableLayoutPanel.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(243, 525);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(212, 28);
            this.usernameTextBox.TabIndex = 11;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(135, 527);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 24);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username:";
            // 
            // address2Label
            // 
            this.address2Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(137, 375);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(100, 24);
            this.address2Label.TabIndex = 10;
            this.address2Label.Text = "Address 2:";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(192, 413);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(45, 24);
            this.cityLabel.TabIndex = 11;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(181, 451);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(56, 24);
            this.stateLabel.TabIndex = 12;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(195, 489);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(42, 24);
            this.zipLabel.TabIndex = 13;
            this.zipLabel.Text = "Zip:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(243, 259);
            this.phoneTextBox.MaxLength = 12;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(212, 28);
            this.phoneTextBox.TabIndex = 4;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // dobPicker
            // 
            this.dobPicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dobPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(243, 297);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(212, 28);
            this.dobPicker.TabIndex = 5;
            this.dobPicker.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dobPicker.Enter += new System.EventHandler(this.FormFieldChanged);
            // 
            // address1TextBox
            // 
            this.address1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.address1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1TextBox.Location = new System.Drawing.Point(243, 335);
            this.address1TextBox.MaxLength = 50;
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(212, 28);
            this.address1TextBox.TabIndex = 6;
            this.address1TextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(243, 373);
            this.address2TextBox.MaxLength = 50;
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(212, 28);
            this.address2TextBox.TabIndex = 7;
            this.address2TextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(243, 411);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(212, 28);
            this.cityTextBox.TabIndex = 8;
            this.cityTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(243, 487);
            this.zipTextBox.MaxLength = 5;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(212, 28);
            this.zipTextBox.TabIndex = 10;
            this.zipTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // sexComboBox
            // 
            this.sexComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(243, 219);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(212, 30);
            this.sexComboBox.TabIndex = 3;
            this.sexComboBox.Enter += new System.EventHandler(this.FormFieldChanged);
            // 
            // searchEmployeeTableLayoutPanel
            // 
            this.searchEmployeeTableLayoutPanel.ColumnCount = 2;
            this.employeeServicesTableLayoutPanel.SetColumnSpan(this.searchEmployeeTableLayoutPanel, 2);
            this.searchEmployeeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.searchEmployeeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.searchEmployeeTableLayoutPanel.Controls.Add(this.searchEmployeeLabel, 0, 1);
            this.searchEmployeeTableLayoutPanel.Controls.Add(this.searchEmployeeTextBox, 0, 0);
            this.searchEmployeeTableLayoutPanel.Controls.Add(this.searchButton, 1, 0);
            this.searchEmployeeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchEmployeeTableLayoutPanel.Location = new System.Drawing.Point(3, 73);
            this.searchEmployeeTableLayoutPanel.Name = "searchEmployeeTableLayoutPanel";
            this.searchEmployeeTableLayoutPanel.RowCount = 2;
            this.searchEmployeeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.searchEmployeeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchEmployeeTableLayoutPanel.Size = new System.Drawing.Size(594, 64);
            this.searchEmployeeTableLayoutPanel.TabIndex = 24;
            // 
            // stateComboBox
            // 
            this.stateComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stateComboBox.DropDownHeight = 100;
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.IntegralHeight = false;
            this.stateComboBox.Location = new System.Drawing.Point(243, 447);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(212, 30);
            this.stateComboBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(243, 563);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(212, 28);
            this.passwordTextBox.TabIndex = 12;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(140, 565);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 24);
            this.passwordLabel.TabIndex = 25;
            this.passwordLabel.Text = "Password:";
            // 
            // checkBoxTableLayoutPanel
            // 
            this.checkBoxTableLayoutPanel.ColumnCount = 2;
            this.employeeServicesTableLayoutPanel.SetColumnSpan(this.checkBoxTableLayoutPanel, 2);
            this.checkBoxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.checkBoxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.checkBoxTableLayoutPanel.Controls.Add(this.isAdministratorCheckBox, 0, 0);
            this.checkBoxTableLayoutPanel.Controls.Add(this.activeCheckBox, 1, 0);
            this.checkBoxTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxTableLayoutPanel.Location = new System.Drawing.Point(3, 599);
            this.checkBoxTableLayoutPanel.Name = "checkBoxTableLayoutPanel";
            this.checkBoxTableLayoutPanel.RowCount = 1;
            this.checkBoxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.checkBoxTableLayoutPanel.Size = new System.Drawing.Size(594, 40);
            this.checkBoxTableLayoutPanel.TabIndex = 27;
            // 
            // isAdministratorCheckBox
            // 
            this.isAdministratorCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.isAdministratorCheckBox.AutoSize = true;
            this.isAdministratorCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdministratorCheckBox.Location = new System.Drawing.Point(69, 6);
            this.isAdministratorCheckBox.Name = "isAdministratorCheckBox";
            this.isAdministratorCheckBox.Size = new System.Drawing.Size(225, 28);
            this.isAdministratorCheckBox.TabIndex = 13;
            this.isAdministratorCheckBox.Text = "Is this an administrator?";
            this.isAdministratorCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isAdministratorCheckBox.UseVisualStyleBackColor = true;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCheckBox.Location = new System.Drawing.Point(300, 6);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(199, 28);
            this.activeCheckBox.TabIndex = 15;
            this.activeCheckBox.TabStop = false;
            this.activeCheckBox.Text = "Employee is active?";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            this.activeCheckBox.Click += new System.EventHandler(this.ActiveCheckBoxCheckedChanged);
            // 
            // EmployeeServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeServicesTableLayoutPanel);
            this.Name = "EmployeeServices";
            this.Size = new System.Drawing.Size(600, 770);
            this.VisibleChanged += new System.EventHandler(this.EmployeeServicesVisibleChanged);
            this.employeeServicesButtonsTableLayoutPanel.ResumeLayout(false);
            this.employeeServicesTableLayoutPanel.ResumeLayout(false);
            this.employeeServicesTableLayoutPanel.PerformLayout();
            this.searchEmployeeTableLayoutPanel.ResumeLayout(false);
            this.searchEmployeeTableLayoutPanel.PerformLayout();
            this.checkBoxTableLayoutPanel.ResumeLayout(false);
            this.checkBoxTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.TableLayoutPanel employeeServicesTableLayoutPanel;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label employeeServicesHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel employeeServicesButtonsTableLayoutPanel;
        private System.Windows.Forms.Button toggleActiveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TableLayoutPanel searchEmployeeTableLayoutPanel;
        private System.Windows.Forms.Label searchEmployeeLabel;
        private System.Windows.Forms.TextBox searchEmployeeTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TableLayoutPanel checkBoxTableLayoutPanel;
        private System.Windows.Forms.CheckBox isAdministratorCheckBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
    }
}
