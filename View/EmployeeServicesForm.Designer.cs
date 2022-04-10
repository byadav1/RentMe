
namespace RentMe.View
{
    partial class EmployeeServicesForm
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
            this.employeeServicesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.employeeServices = new RentMe.UserControls.EmployeeServices();
            this.employeeServicesTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeServicesTableLayoutPanel
            // 
            this.employeeServicesTableLayoutPanel.ColumnCount = 1;
            this.employeeServicesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.employeeServicesTableLayoutPanel.Controls.Add(this.employeeServices, 0, 0);
            this.employeeServicesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeServicesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.employeeServicesTableLayoutPanel.Name = "employeeServicesTableLayoutPanel";
            this.employeeServicesTableLayoutPanel.RowCount = 1;
            this.employeeServicesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.employeeServicesTableLayoutPanel.Size = new System.Drawing.Size(782, 753);
            this.employeeServicesTableLayoutPanel.TabIndex = 0;
            // 
            // employeeServices
            // 
            this.employeeServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeServices.IsUpdate = false;
            this.employeeServices.Location = new System.Drawing.Point(3, 3);
            this.employeeServices.Name = "employeeServices";
            this.employeeServices.SearchedEmployee = null;
            this.employeeServices.Size = new System.Drawing.Size(776, 747);
            this.employeeServices.TabIndex = 0;
            // 
            // EmployeeServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.employeeServicesTableLayoutPanel);
            this.Name = "EmployeeServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMe: Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeServicesFormFormClosed);
            this.employeeServicesTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel employeeServicesTableLayoutPanel;
        private UserControls.EmployeeServices employeeServices;
    }
}