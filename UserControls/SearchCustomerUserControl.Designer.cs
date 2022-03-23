
namespace RentMe.UserControls
{
    partial class SearchCustomerUserControl
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
            this.searchCustomerLabel = new System.Windows.Forms.Label();
            this.searchCustomertextbox = new System.Windows.Forms.TextBox();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.searchinfoLabel = new System.Windows.Forms.Label();
            this.customerFirstNameLabel = new System.Windows.Forms.Label();
            this.customerLastNameLabel = new System.Windows.Forms.Label();
            this.customerSexLabel = new System.Windows.Forms.Label();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerDOBLabel = new System.Windows.Forms.Label();
            this.customerAddress1Label = new System.Windows.Forms.Label();
            this.customerAddress2Label = new System.Windows.Forms.Label();
            this.customerCityLabel = new System.Windows.Forms.Label();
            this.customerZipLabel = new System.Windows.Forms.Label();
            this.customerStateLabel = new System.Windows.Forms.Label();
            this.customerFNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLNameTextBox = new System.Windows.Forms.TextBox();
            this.customerSexTextBox = new System.Windows.Forms.TextBox();
            this.customerDobTextBox = new System.Windows.Forms.TextBox();
            this.customerAdr1TextBox = new System.Windows.Forms.TextBox();
            this.customerAdr2TextBox = new System.Windows.Forms.TextBox();
            this.customerCityTextBox = new System.Windows.Forms.TextBox();
            this.customerZipTextBox = new System.Windows.Forms.TextBox();
            this.customerStateTextBox = new System.Windows.Forms.TextBox();
            this.customerUpdateButton = new System.Windows.Forms.Button();
            this.customerDeleteButton = new System.Windows.Forms.Button();
            this.customerPhoneTextBOx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchCustomerLabel
            // 
            this.searchCustomerLabel.AutoSize = true;
            this.searchCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerLabel.Location = new System.Drawing.Point(12, 16);
            this.searchCustomerLabel.Name = "searchCustomerLabel";
            this.searchCustomerLabel.Size = new System.Drawing.Size(268, 36);
            this.searchCustomerLabel.TabIndex = 0;
            this.searchCustomerLabel.Text = "Member Services ";
            this.searchCustomerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchCustomertextbox
            // 
            this.searchCustomertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomertextbox.Location = new System.Drawing.Point(32, 80);
            this.searchCustomertextbox.Name = "searchCustomertextbox";
            this.searchCustomertextbox.Size = new System.Drawing.Size(398, 30);
            this.searchCustomertextbox.TabIndex = 1;
            this.searchCustomertextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerButton.Location = new System.Drawing.Point(459, 80);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(107, 30);
            this.searchCustomerButton.TabIndex = 2;
            this.searchCustomerButton.Text = "Search";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            // 
            // searchinfoLabel
            // 
            this.searchinfoLabel.AutoSize = true;
            this.searchinfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchinfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchinfoLabel.Location = new System.Drawing.Point(349, 113);
            this.searchinfoLabel.Name = "searchinfoLabel";
            this.searchinfoLabel.Size = new System.Drawing.Size(229, 13);
            this.searchinfoLabel.TabIndex = 3;
            this.searchinfoLabel.Text = "*Enter customerID OR phone OR  Name";
            this.searchinfoLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // customerFirstNameLabel
            // 
            this.customerFirstNameLabel.AutoSize = true;
            this.customerFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFirstNameLabel.Location = new System.Drawing.Point(26, 139);
            this.customerFirstNameLabel.Name = "customerFirstNameLabel";
            this.customerFirstNameLabel.Size = new System.Drawing.Size(117, 25);
            this.customerFirstNameLabel.TabIndex = 4;
            this.customerFirstNameLabel.Text = "First Name :";
            // 
            // customerLastNameLabel
            // 
            this.customerLastNameLabel.AutoSize = true;
            this.customerLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLastNameLabel.Location = new System.Drawing.Point(26, 175);
            this.customerLastNameLabel.Name = "customerLastNameLabel";
            this.customerLastNameLabel.Size = new System.Drawing.Size(117, 25);
            this.customerLastNameLabel.TabIndex = 5;
            this.customerLastNameLabel.Text = "Last Name :";
            // 
            // customerSexLabel
            // 
            this.customerSexLabel.AutoSize = true;
            this.customerSexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSexLabel.Location = new System.Drawing.Point(26, 212);
            this.customerSexLabel.Name = "customerSexLabel";
            this.customerSexLabel.Size = new System.Drawing.Size(58, 25);
            this.customerSexLabel.TabIndex = 6;
            this.customerSexLabel.Text = "Sex :";
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneLabel.Location = new System.Drawing.Point(26, 246);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(80, 25);
            this.customerPhoneLabel.TabIndex = 7;
            this.customerPhoneLabel.Text = "Phone :";
            // 
            // customerDOBLabel
            // 
            this.customerDOBLabel.AutoSize = true;
            this.customerDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDOBLabel.Location = new System.Drawing.Point(26, 285);
            this.customerDOBLabel.Name = "customerDOBLabel";
            this.customerDOBLabel.Size = new System.Drawing.Size(66, 25);
            this.customerDOBLabel.TabIndex = 8;
            this.customerDOBLabel.Text = "DOB :";
            // 
            // customerAddress1Label
            // 
            this.customerAddress1Label.AutoSize = true;
            this.customerAddress1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddress1Label.Location = new System.Drawing.Point(26, 316);
            this.customerAddress1Label.Name = "customerAddress1Label";
            this.customerAddress1Label.Size = new System.Drawing.Size(112, 25);
            this.customerAddress1Label.TabIndex = 9;
            this.customerAddress1Label.Text = "Address 1 :";
            // 
            // customerAddress2Label
            // 
            this.customerAddress2Label.AutoSize = true;
            this.customerAddress2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddress2Label.Location = new System.Drawing.Point(27, 350);
            this.customerAddress2Label.Name = "customerAddress2Label";
            this.customerAddress2Label.Size = new System.Drawing.Size(107, 25);
            this.customerAddress2Label.TabIndex = 10;
            this.customerAddress2Label.Text = "Address2 :";
            // 
            // customerCityLabel
            // 
            this.customerCityLabel.AutoSize = true;
            this.customerCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCityLabel.Location = new System.Drawing.Point(32, 386);
            this.customerCityLabel.Name = "customerCityLabel";
            this.customerCityLabel.Size = new System.Drawing.Size(57, 25);
            this.customerCityLabel.TabIndex = 11;
            this.customerCityLabel.Text = "City :";
            // 
            // customerZipLabel
            // 
            this.customerZipLabel.AutoSize = true;
            this.customerZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerZipLabel.Location = new System.Drawing.Point(27, 422);
            this.customerZipLabel.Name = "customerZipLabel";
            this.customerZipLabel.Size = new System.Drawing.Size(55, 25);
            this.customerZipLabel.TabIndex = 12;
            this.customerZipLabel.Text = " Zip :";
            // 
            // customerStateLabel
            // 
            this.customerStateLabel.AutoSize = true;
            this.customerStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStateLabel.Location = new System.Drawing.Point(32, 462);
            this.customerStateLabel.Name = "customerStateLabel";
            this.customerStateLabel.Size = new System.Drawing.Size(74, 25);
            this.customerStateLabel.TabIndex = 13;
            this.customerStateLabel.Text = "State : ";
            // 
            // customerFNameTextBox
            // 
            this.customerFNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFNameTextBox.Location = new System.Drawing.Point(179, 141);
            this.customerFNameTextBox.Name = "customerFNameTextBox";
            this.customerFNameTextBox.Size = new System.Drawing.Size(304, 28);
            this.customerFNameTextBox.TabIndex = 14;
            // 
            // customerLNameTextBox
            // 
            this.customerLNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLNameTextBox.Location = new System.Drawing.Point(179, 175);
            this.customerLNameTextBox.Name = "customerLNameTextBox";
            this.customerLNameTextBox.Size = new System.Drawing.Size(304, 28);
            this.customerLNameTextBox.TabIndex = 15;
            // 
            // customerSexTextBox
            // 
            this.customerSexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSexTextBox.Location = new System.Drawing.Point(179, 212);
            this.customerSexTextBox.Name = "customerSexTextBox";
            this.customerSexTextBox.Size = new System.Drawing.Size(304, 28);
            this.customerSexTextBox.TabIndex = 16;
            // 
            // customerDobTextBox
            // 
            this.customerDobTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDobTextBox.Location = new System.Drawing.Point(179, 279);
            this.customerDobTextBox.Name = "customerDobTextBox";
            this.customerDobTextBox.Size = new System.Drawing.Size(304, 28);
            this.customerDobTextBox.TabIndex = 17;
            // 
            // customerAdr1TextBox
            // 
            this.customerAdr1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAdr1TextBox.Location = new System.Drawing.Point(179, 313);
            this.customerAdr1TextBox.Name = "customerAdr1TextBox";
            this.customerAdr1TextBox.Size = new System.Drawing.Size(304, 28);
            this.customerAdr1TextBox.TabIndex = 18;
            // 
            // customerAdr2TextBox
            // 
            this.customerAdr2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAdr2TextBox.Location = new System.Drawing.Point(179, 347);
            this.customerAdr2TextBox.Name = "customerAdr2TextBox";
            this.customerAdr2TextBox.Size = new System.Drawing.Size(304, 28);
            this.customerAdr2TextBox.TabIndex = 19;
            // 
            // customerCityTextBox
            // 
            this.customerCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCityTextBox.Location = new System.Drawing.Point(179, 383);
            this.customerCityTextBox.Name = "customerCityTextBox";
            this.customerCityTextBox.Size = new System.Drawing.Size(304, 28);
            this.customerCityTextBox.TabIndex = 20;
            // 
            // customerZipTextBox
            // 
            this.customerZipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerZipTextBox.Location = new System.Drawing.Point(179, 422);
            this.customerZipTextBox.Name = "customerZipTextBox";
            this.customerZipTextBox.Size = new System.Drawing.Size(304, 28);
            this.customerZipTextBox.TabIndex = 21;
            // 
            // customerStateTextBox
            // 
            this.customerStateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStateTextBox.Location = new System.Drawing.Point(179, 462);
            this.customerStateTextBox.Name = "customerStateTextBox";
            this.customerStateTextBox.Size = new System.Drawing.Size(304, 28);
            this.customerStateTextBox.TabIndex = 22;
            // 
            // customerUpdateButton
            // 
            this.customerUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerUpdateButton.Location = new System.Drawing.Point(179, 517);
            this.customerUpdateButton.Name = "customerUpdateButton";
            this.customerUpdateButton.Size = new System.Drawing.Size(101, 43);
            this.customerUpdateButton.TabIndex = 23;
            this.customerUpdateButton.Text = "Update";
            this.customerUpdateButton.UseVisualStyleBackColor = true;
            // 
            // customerDeleteButton
            // 
            this.customerDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDeleteButton.Location = new System.Drawing.Point(301, 520);
            this.customerDeleteButton.Name = "customerDeleteButton";
            this.customerDeleteButton.Size = new System.Drawing.Size(108, 40);
            this.customerDeleteButton.TabIndex = 24;
            this.customerDeleteButton.Text = "Delete";
            this.customerDeleteButton.UseVisualStyleBackColor = true;
            // 
            // customerPhoneTextBOx
            // 
            this.customerPhoneTextBOx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneTextBOx.Location = new System.Drawing.Point(179, 243);
            this.customerPhoneTextBOx.Name = "customerPhoneTextBOx";
            this.customerPhoneTextBOx.Size = new System.Drawing.Size(304, 28);
            this.customerPhoneTextBOx.TabIndex = 25;
            // 
            // SearchCustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerPhoneTextBOx);
            this.Controls.Add(this.customerDeleteButton);
            this.Controls.Add(this.customerUpdateButton);
            this.Controls.Add(this.customerStateTextBox);
            this.Controls.Add(this.customerZipTextBox);
            this.Controls.Add(this.customerCityTextBox);
            this.Controls.Add(this.customerAdr2TextBox);
            this.Controls.Add(this.customerAdr1TextBox);
            this.Controls.Add(this.customerDobTextBox);
            this.Controls.Add(this.customerSexTextBox);
            this.Controls.Add(this.customerLNameTextBox);
            this.Controls.Add(this.customerFNameTextBox);
            this.Controls.Add(this.customerStateLabel);
            this.Controls.Add(this.customerZipLabel);
            this.Controls.Add(this.customerCityLabel);
            this.Controls.Add(this.customerAddress2Label);
            this.Controls.Add(this.customerAddress1Label);
            this.Controls.Add(this.customerDOBLabel);
            this.Controls.Add(this.customerPhoneLabel);
            this.Controls.Add(this.customerSexLabel);
            this.Controls.Add(this.customerLastNameLabel);
            this.Controls.Add(this.customerFirstNameLabel);
            this.Controls.Add(this.searchinfoLabel);
            this.Controls.Add(this.searchCustomerButton);
            this.Controls.Add(this.searchCustomertextbox);
            this.Controls.Add(this.searchCustomerLabel);
            this.Name = "SearchCustomerUserControl";
            this.Size = new System.Drawing.Size(614, 589);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchCustomerLabel;
        private System.Windows.Forms.TextBox searchCustomertextbox;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.Label searchinfoLabel;
        private System.Windows.Forms.Label customerFirstNameLabel;
        private System.Windows.Forms.Label customerLastNameLabel;
        private System.Windows.Forms.Label customerSexLabel;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.Label customerDOBLabel;
        private System.Windows.Forms.Label customerAddress1Label;
        private System.Windows.Forms.Label customerAddress2Label;
        private System.Windows.Forms.Label customerCityLabel;
        private System.Windows.Forms.Label customerZipLabel;
        private System.Windows.Forms.Label customerStateLabel;
        private System.Windows.Forms.TextBox customerFNameTextBox;
        private System.Windows.Forms.TextBox customerLNameTextBox;
        private System.Windows.Forms.TextBox customerSexTextBox;
        private System.Windows.Forms.TextBox customerDobTextBox;
        private System.Windows.Forms.TextBox customerAdr1TextBox;
        private System.Windows.Forms.TextBox customerAdr2TextBox;
        private System.Windows.Forms.TextBox customerCityTextBox;
        private System.Windows.Forms.TextBox customerZipTextBox;
        private System.Windows.Forms.TextBox customerStateTextBox;
        private System.Windows.Forms.Button customerUpdateButton;
        private System.Windows.Forms.Button customerDeleteButton;
        private System.Windows.Forms.TextBox customerPhoneTextBOx;
    }
}
