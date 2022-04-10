
namespace RentMe.UserControls
{
    partial class MemberServices
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
            this.statusMessage = new System.Windows.Forms.Label();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.memberServicesHeaderLabel = new System.Windows.Forms.Label();
            this.memberServicesButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.memberServicesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.memberServicesButtonsTableLayoutPanel.SuspendLayout();
            this.memberServicesTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusMessage
            // 
            this.statusMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusMessage.AutoSize = true;
            this.memberServicesTableLayoutPanel.SetColumnSpan(this.statusMessage, 2);
            this.statusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessage.ForeColor = System.Drawing.Color.Red;
            this.statusMessage.Location = new System.Drawing.Point(315, 606);
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
            this.lnameTextBox.Location = new System.Drawing.Point(303, 165);
            this.lnameTextBox.MaxLength = 50;
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(212, 28);
            this.lnameTextBox.TabIndex = 5;
            this.lnameTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // lnameLabel
            // 
            this.lnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(193, 167);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(104, 24);
            this.lnameLabel.TabIndex = 5;
            this.lnameLabel.Text = "Last Name:";
            // 
            // memberServicesHeaderLabel
            // 
            this.memberServicesHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberServicesHeaderLabel.AutoSize = true;
            this.memberServicesHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.memberServicesTableLayoutPanel.SetColumnSpan(this.memberServicesHeaderLabel, 2);
            this.memberServicesHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberServicesHeaderLabel.Location = new System.Drawing.Point(166, 26);
            this.memberServicesHeaderLabel.Name = "memberServicesHeaderLabel";
            this.memberServicesHeaderLabel.Size = new System.Drawing.Size(417, 60);
            this.memberServicesHeaderLabel.TabIndex = 1;
            this.memberServicesHeaderLabel.Text = "Member Services";
            // 
            // memberServicesButtonsTableLayoutPanel
            // 
            this.memberServicesButtonsTableLayoutPanel.ColumnCount = 4;
            this.memberServicesTableLayoutPanel.SetColumnSpan(this.memberServicesButtonsTableLayoutPanel, 3);
            this.memberServicesButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.memberServicesButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.memberServicesButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.memberServicesButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.memberServicesButtonsTableLayoutPanel.Controls.Add(this.clearButton, 0, 0);
            this.memberServicesButtonsTableLayoutPanel.Controls.Add(this.updateButton, 0, 0);
            this.memberServicesButtonsTableLayoutPanel.Controls.Add(this.registerButton, 3, 0);
            this.memberServicesButtonsTableLayoutPanel.Controls.Add(this.closeButton, 2, 0);
            this.memberServicesButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberServicesButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 677);
            this.memberServicesButtonsTableLayoutPanel.Name = "memberServicesButtonsTableLayoutPanel";
            this.memberServicesButtonsTableLayoutPanel.RowCount = 1;
            this.memberServicesButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memberServicesButtonsTableLayoutPanel.Size = new System.Drawing.Size(744, 70);
            this.memberServicesButtonsTableLayoutPanel.TabIndex = 14;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(219, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 60);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear Fields";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(33, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 60);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(591, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(120, 60);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "Register Member";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(405, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 60);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // fnameLabel
            // 
            this.fnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(191, 122);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(106, 24);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "First Name:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.Location = new System.Drawing.Point(303, 120);
            this.fnameTextBox.MaxLength = 50;
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(212, 28);
            this.fnameTextBox.TabIndex = 4;
            this.fnameTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // sexLabel
            // 
            this.sexLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(249, 212);
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
            this.phoneLabel.Location = new System.Drawing.Point(226, 257);
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
            this.dobLabel.Location = new System.Drawing.Point(182, 302);
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
            this.address1Label.Location = new System.Drawing.Point(197, 347);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(100, 24);
            this.address1Label.TabIndex = 9;
            this.address1Label.Text = "Address 1:";
            // 
            // address2Label
            // 
            this.address2Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(197, 392);
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
            this.cityLabel.Location = new System.Drawing.Point(252, 437);
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
            this.stateLabel.Location = new System.Drawing.Point(241, 482);
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
            this.zipLabel.Location = new System.Drawing.Point(255, 527);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(42, 24);
            this.zipLabel.TabIndex = 13;
            this.zipLabel.Text = "Zip:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(303, 255);
            this.phoneTextBox.MaxLength = 12;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(212, 28);
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // dobPicker
            // 
            this.dobPicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dobPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(303, 300);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(212, 28);
            this.dobPicker.TabIndex = 8;
            this.dobPicker.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dobPicker.Enter += new System.EventHandler(this.FormFieldChanged);
            // 
            // address1TextBox
            // 
            this.address1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.address1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1TextBox.Location = new System.Drawing.Point(303, 345);
            this.address1TextBox.MaxLength = 50;
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(212, 28);
            this.address1TextBox.TabIndex = 9;
            this.address1TextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(303, 390);
            this.address2TextBox.MaxLength = 50;
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(212, 28);
            this.address2TextBox.TabIndex = 10;
            this.address2TextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(303, 525);
            this.zipTextBox.MaxLength = 5;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(212, 28);
            this.zipTextBox.TabIndex = 13;
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
            this.sexComboBox.Location = new System.Drawing.Point(303, 209);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(212, 30);
            this.sexComboBox.TabIndex = 6;
            this.sexComboBox.Enter += new System.EventHandler(this.FormFieldChanged);
            // 
            // memberServicesTableLayoutPanel
            // 
            this.memberServicesTableLayoutPanel.ColumnCount = 2;
            this.memberServicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.memberServicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.memberServicesTableLayoutPanel.Controls.Add(this.statusMessage, 0, 11);
            this.memberServicesTableLayoutPanel.Controls.Add(this.lnameTextBox, 1, 2);
            this.memberServicesTableLayoutPanel.Controls.Add(this.lnameLabel, 0, 2);
            this.memberServicesTableLayoutPanel.Controls.Add(this.memberServicesHeaderLabel, 0, 0);
            this.memberServicesTableLayoutPanel.Controls.Add(this.memberServicesButtonsTableLayoutPanel, 0, 12);
            this.memberServicesTableLayoutPanel.Controls.Add(this.fnameLabel, 0, 1);
            this.memberServicesTableLayoutPanel.Controls.Add(this.fnameTextBox, 1, 1);
            this.memberServicesTableLayoutPanel.Controls.Add(this.sexLabel, 0, 3);
            this.memberServicesTableLayoutPanel.Controls.Add(this.phoneLabel, 0, 4);
            this.memberServicesTableLayoutPanel.Controls.Add(this.dobLabel, 0, 5);
            this.memberServicesTableLayoutPanel.Controls.Add(this.address1Label, 0, 6);
            this.memberServicesTableLayoutPanel.Controls.Add(this.address2Label, 0, 7);
            this.memberServicesTableLayoutPanel.Controls.Add(this.cityLabel, 0, 8);
            this.memberServicesTableLayoutPanel.Controls.Add(this.stateLabel, 0, 9);
            this.memberServicesTableLayoutPanel.Controls.Add(this.zipLabel, 0, 10);
            this.memberServicesTableLayoutPanel.Controls.Add(this.phoneTextBox, 1, 4);
            this.memberServicesTableLayoutPanel.Controls.Add(this.dobPicker, 1, 5);
            this.memberServicesTableLayoutPanel.Controls.Add(this.address1TextBox, 1, 6);
            this.memberServicesTableLayoutPanel.Controls.Add(this.address2TextBox, 1, 7);
            this.memberServicesTableLayoutPanel.Controls.Add(this.zipTextBox, 1, 10);
            this.memberServicesTableLayoutPanel.Controls.Add(this.sexComboBox, 1, 3);
            this.memberServicesTableLayoutPanel.Controls.Add(this.stateComboBox, 1, 9);
            this.memberServicesTableLayoutPanel.Controls.Add(this.cityTextBox, 1, 8);
            this.memberServicesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberServicesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.memberServicesTableLayoutPanel.Name = "memberServicesTableLayoutPanel";
            this.memberServicesTableLayoutPanel.RowCount = 13;
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.memberServicesTableLayoutPanel.Size = new System.Drawing.Size(750, 750);
            this.memberServicesTableLayoutPanel.TabIndex = 1;
            // 
            // stateComboBox
            // 
            this.stateComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stateComboBox.DropDownHeight = 100;
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.IntegralHeight = false;
            this.stateComboBox.Location = new System.Drawing.Point(303, 479);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(212, 30);
            this.stateComboBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(303, 435);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(212, 28);
            this.cityTextBox.TabIndex = 11;
            // 
            // MemberServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberServicesTableLayoutPanel);
            this.Name = "MemberServices";
            this.Size = new System.Drawing.Size(750, 750);
            this.Load += new System.EventHandler(this.MemberServicesLoad);
            this.memberServicesButtonsTableLayoutPanel.ResumeLayout(false);
            this.memberServicesTableLayoutPanel.ResumeLayout(false);
            this.memberServicesTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.TableLayoutPanel memberServicesTableLayoutPanel;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label memberServicesHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel memberServicesButtonsTableLayoutPanel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button registerButton;
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
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
    }
}
