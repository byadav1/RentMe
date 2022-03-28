
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
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
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.memberServicesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchMemberTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchMemberLabel = new System.Windows.Forms.Label();
            this.searchMemberTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.memberServicesButtonsTableLayoutPanel.SuspendLayout();
            this.memberServicesTableLayoutPanel.SuspendLayout();
            this.searchMemberTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusMessage
            // 
            this.statusMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusMessage.AutoSize = true;
            this.memberServicesTableLayoutPanel.SetColumnSpan(this.statusMessage, 2);
            this.statusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessage.ForeColor = System.Drawing.Color.Red;
            this.statusMessage.Location = new System.Drawing.Point(240, 582);
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
            this.lnameTextBox.Location = new System.Drawing.Point(213, 228);
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
            this.lnameLabel.Location = new System.Drawing.Point(103, 230);
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
            this.memberServicesHeaderLabel.Location = new System.Drawing.Point(91, 26);
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
            this.memberServicesButtonsTableLayoutPanel.Controls.Add(this.deleteButton, 0, 0);
            this.memberServicesButtonsTableLayoutPanel.Controls.Add(this.updateButton, 0, 0);
            this.memberServicesButtonsTableLayoutPanel.Controls.Add(this.registerButton, 3, 0);
            this.memberServicesButtonsTableLayoutPanel.Controls.Add(this.clearButton, 2, 0);
            this.memberServicesButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberServicesButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 635);
            this.memberServicesButtonsTableLayoutPanel.Name = "memberServicesButtonsTableLayoutPanel";
            this.memberServicesButtonsTableLayoutPanel.RowCount = 1;
            this.memberServicesButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memberServicesButtonsTableLayoutPanel.Size = new System.Drawing.Size(594, 112);
            this.memberServicesButtonsTableLayoutPanel.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(162, 26);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 60);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(14, 26);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 60);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(459, 26);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(120, 60);
            this.registerButton.TabIndex = 14;
            this.registerButton.Text = "Register Member";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(310, 26);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 60);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // fnameLabel
            // 
            this.fnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(101, 193);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(106, 24);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "First Name:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.Location = new System.Drawing.Point(213, 191);
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
            this.sexLabel.Location = new System.Drawing.Point(159, 267);
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
            this.phoneLabel.Location = new System.Drawing.Point(136, 304);
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
            this.dobLabel.Location = new System.Drawing.Point(92, 341);
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
            this.address1Label.Location = new System.Drawing.Point(107, 378);
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
            this.address2Label.Location = new System.Drawing.Point(107, 415);
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
            this.cityLabel.Location = new System.Drawing.Point(162, 452);
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
            this.stateLabel.Location = new System.Drawing.Point(151, 489);
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
            this.zipLabel.Location = new System.Drawing.Point(165, 526);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(42, 24);
            this.zipLabel.TabIndex = 13;
            this.zipLabel.Text = "Zip:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(213, 302);
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
            this.dobPicker.Location = new System.Drawing.Point(213, 339);
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
            this.address1TextBox.Location = new System.Drawing.Point(213, 376);
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
            this.address2TextBox.Location = new System.Drawing.Point(213, 413);
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
            this.cityTextBox.Location = new System.Drawing.Point(213, 450);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(212, 28);
            this.cityTextBox.TabIndex = 8;
            this.cityTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // stateTextBox
            // 
            this.stateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextBox.Location = new System.Drawing.Point(213, 487);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(212, 28);
            this.stateTextBox.TabIndex = 9;
            this.stateTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(213, 524);
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
            this.sexComboBox.Location = new System.Drawing.Point(213, 264);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(212, 30);
            this.sexComboBox.TabIndex = 3;
            this.sexComboBox.Enter += new System.EventHandler(this.FormFieldChanged);
            // 
            // memberServicesTableLayoutPanel
            // 
            this.memberServicesTableLayoutPanel.ColumnCount = 2;
            this.memberServicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.memberServicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.memberServicesTableLayoutPanel.Controls.Add(this.statusMessage, 0, 12);
            this.memberServicesTableLayoutPanel.Controls.Add(this.lnameTextBox, 1, 3);
            this.memberServicesTableLayoutPanel.Controls.Add(this.lnameLabel, 0, 3);
            this.memberServicesTableLayoutPanel.Controls.Add(this.memberServicesHeaderLabel, 0, 0);
            this.memberServicesTableLayoutPanel.Controls.Add(this.memberServicesButtonsTableLayoutPanel, 0, 13);
            this.memberServicesTableLayoutPanel.Controls.Add(this.fnameLabel, 0, 2);
            this.memberServicesTableLayoutPanel.Controls.Add(this.fnameTextBox, 1, 2);
            this.memberServicesTableLayoutPanel.Controls.Add(this.sexLabel, 0, 4);
            this.memberServicesTableLayoutPanel.Controls.Add(this.phoneLabel, 0, 5);
            this.memberServicesTableLayoutPanel.Controls.Add(this.dobLabel, 0, 6);
            this.memberServicesTableLayoutPanel.Controls.Add(this.address1Label, 0, 7);
            this.memberServicesTableLayoutPanel.Controls.Add(this.address2Label, 0, 8);
            this.memberServicesTableLayoutPanel.Controls.Add(this.cityLabel, 0, 9);
            this.memberServicesTableLayoutPanel.Controls.Add(this.stateLabel, 0, 10);
            this.memberServicesTableLayoutPanel.Controls.Add(this.zipLabel, 0, 11);
            this.memberServicesTableLayoutPanel.Controls.Add(this.phoneTextBox, 1, 5);
            this.memberServicesTableLayoutPanel.Controls.Add(this.dobPicker, 1, 6);
            this.memberServicesTableLayoutPanel.Controls.Add(this.address1TextBox, 1, 7);
            this.memberServicesTableLayoutPanel.Controls.Add(this.address2TextBox, 1, 8);
            this.memberServicesTableLayoutPanel.Controls.Add(this.cityTextBox, 1, 9);
            this.memberServicesTableLayoutPanel.Controls.Add(this.stateTextBox, 1, 10);
            this.memberServicesTableLayoutPanel.Controls.Add(this.zipTextBox, 1, 11);
            this.memberServicesTableLayoutPanel.Controls.Add(this.sexComboBox, 1, 4);
            this.memberServicesTableLayoutPanel.Controls.Add(this.searchMemberTableLayoutPanel, 0, 1);
            this.memberServicesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberServicesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.memberServicesTableLayoutPanel.Name = "memberServicesTableLayoutPanel";
            this.memberServicesTableLayoutPanel.RowCount = 14;
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.memberServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.memberServicesTableLayoutPanel.Size = new System.Drawing.Size(600, 750);
            this.memberServicesTableLayoutPanel.TabIndex = 1;
            // 
            // searchMemberTableLayoutPanel
            // 
            this.searchMemberTableLayoutPanel.ColumnCount = 2;
            this.memberServicesTableLayoutPanel.SetColumnSpan(this.searchMemberTableLayoutPanel, 2);
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.searchMemberTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchMemberLabel, 0, 1);
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchMemberTextBox, 0, 0);
            this.searchMemberTableLayoutPanel.Controls.Add(this.searchButton, 1, 0);
            this.searchMemberTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchMemberTableLayoutPanel.Location = new System.Drawing.Point(3, 115);
            this.searchMemberTableLayoutPanel.Name = "searchMemberTableLayoutPanel";
            this.searchMemberTableLayoutPanel.RowCount = 2;
            this.searchMemberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.searchMemberTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchMemberTableLayoutPanel.Size = new System.Drawing.Size(594, 69);
            this.searchMemberTableLayoutPanel.TabIndex = 24;
            // 
            // searchMemberLabel
            // 
            this.searchMemberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchMemberLabel.AutoSize = true;
            this.searchMemberTableLayoutPanel.SetColumnSpan(this.searchMemberLabel, 2);
            this.searchMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberLabel.Location = new System.Drawing.Point(108, 48);
            this.searchMemberLabel.Name = "searchMemberLabel";
            this.searchMemberLabel.Size = new System.Drawing.Size(378, 20);
            this.searchMemberLabel.TabIndex = 3;
            this.searchMemberLabel.Text = "Search for a member by their ID, Phone, or Name";
            // 
            // searchMemberTextBox
            // 
            this.searchMemberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchMemberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberTextBox.Location = new System.Drawing.Point(98, 10);
            this.searchMemberTextBox.Name = "searchMemberTextBox";
            this.searchMemberTextBox.Size = new System.Drawing.Size(314, 28);
            this.searchMemberTextBox.TabIndex = 0;
            this.searchMemberTextBox.TextChanged += new System.EventHandler(this.FormFieldChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(418, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // MemberServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberServicesTableLayoutPanel);
            this.Name = "MemberServices";
            this.Size = new System.Drawing.Size(600, 750);
            this.memberServicesButtonsTableLayoutPanel.ResumeLayout(false);
            this.memberServicesTableLayoutPanel.ResumeLayout(false);
            this.memberServicesTableLayoutPanel.PerformLayout();
            this.searchMemberTableLayoutPanel.ResumeLayout(false);
            this.searchMemberTableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.Button clearButton;
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
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TableLayoutPanel searchMemberTableLayoutPanel;
        private System.Windows.Forms.TextBox searchMemberTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label searchMemberLabel;
    }
}
