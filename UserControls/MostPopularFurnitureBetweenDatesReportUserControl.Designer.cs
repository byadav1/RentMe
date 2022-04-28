
namespace RentMe.UserControls
{
    partial class MostPopularFurnitureBetweenDatesReportUserControl
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.reportHeaderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.mostPopularFurnitureBetweenDatesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this._cs6232_g3DataSet = new RentMe._cs6232_g3DataSet();
            this.spGetMostPopularFurnitureDuringDatesTableAdapter = new RentMe._cs6232_g3DataSetTableAdapters.spGetMostPopularFurnitureDuringDatesTableAdapter();
            this.spGetMostPopularFurnitureDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetMostPopularFurnitureDuringDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerTableLayoutPanel
            // 
            this.reportViewerTableLayoutPanel.ColumnCount = 2;
            this.reportViewerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reportViewerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reportViewerTableLayoutPanel.Controls.Add(this.reportHeaderLabel, 0, 0);
            this.reportViewerTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.reportViewerTableLayoutPanel.Controls.Add(this.statusMessage, 0, 3);
            this.reportViewerTableLayoutPanel.Controls.Add(this.mostPopularFurnitureBetweenDatesReportViewer, 0, 2);
            this.reportViewerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.reportViewerTableLayoutPanel.Name = "reportViewerTableLayoutPanel";
            this.reportViewerTableLayoutPanel.RowCount = 4;
            this.reportViewerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.reportViewerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reportViewerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.reportViewerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reportViewerTableLayoutPanel.Size = new System.Drawing.Size(1400, 600);
            this.reportViewerTableLayoutPanel.TabIndex = 0;
            // 
            // reportHeaderLabel
            // 
            this.reportHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportHeaderLabel.AutoSize = true;
            this.reportHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewerTableLayoutPanel.SetColumnSpan(this.reportHeaderLabel, 2);
            this.reportHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportHeaderLabel.Location = new System.Drawing.Point(173, 15);
            this.reportHeaderLabel.Name = "reportHeaderLabel";
            this.reportHeaderLabel.Size = new System.Drawing.Size(1053, 60);
            this.reportHeaderLabel.TabIndex = 3;
            this.reportHeaderLabel.Text = "Most Popular Furniture Between Dates Report";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.reportViewerTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.startDateLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.endDateLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.startDateTimePicker, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.endDateTimePicker, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.generateReportButton, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1394, 54);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startDateLabel.Location = new System.Drawing.Point(217, 15);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(94, 24);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.endDateLabel.Location = new System.Drawing.Point(607, 15);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(93, 24);
            this.endDateLabel.TabIndex = 1;
            this.endDateLabel.Text = "End Date:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(359, 13);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.startDateTimePicker.TabIndex = 2;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePickerValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(748, 13);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.endDateTimePicker.TabIndex = 3;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePickerValueChanged);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.generateReportButton.Location = new System.Drawing.Point(1027, 7);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(100, 40);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Generate";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButtonClick);
            // 
            // statusMessage
            // 
            this.statusMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusMessage.AutoSize = true;
            this.reportViewerTableLayoutPanel.SetColumnSpan(this.statusMessage, 2);
            this.statusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.statusMessage.Location = new System.Drawing.Point(475, 558);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(450, 24);
            this.statusMessage.TabIndex = 5;
            this.statusMessage.Text = "Enter a start date and end date to generate the report";
            // 
            // mostPopularFurnitureBetweenDatesReportViewer
            // 
            this.reportViewerTableLayoutPanel.SetColumnSpan(this.mostPopularFurnitureBetweenDatesReportViewer, 2);
            this.mostPopularFurnitureBetweenDatesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MostPopularFurnitureBetweenDates";
            reportDataSource1.Value = this.spGetMostPopularFurnitureDuringDatesBindingSource;
            this.mostPopularFurnitureBetweenDatesReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.mostPopularFurnitureBetweenDatesReportViewer.LocalReport.ReportEmbeddedResource = "RentMe.Reports.MostPopularFurnitureBetweenDates.rdlc";
            this.mostPopularFurnitureBetweenDatesReportViewer.Location = new System.Drawing.Point(3, 153);
            this.mostPopularFurnitureBetweenDatesReportViewer.Name = "mostPopularFurnitureBetweenDatesReportViewer";
            this.mostPopularFurnitureBetweenDatesReportViewer.ServerReport.BearerToken = null;
            this.mostPopularFurnitureBetweenDatesReportViewer.ShowToolBar = false;
            this.mostPopularFurnitureBetweenDatesReportViewer.Size = new System.Drawing.Size(1394, 384);
            this.mostPopularFurnitureBetweenDatesReportViewer.TabIndex = 6;
            // 
            // _cs6232_g3DataSet
            // 
            this._cs6232_g3DataSet.DataSetName = "_cs6232_g3DataSet";
            this._cs6232_g3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetMostPopularFurnitureDuringDatesTableAdapter
            // 
            this.spGetMostPopularFurnitureDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetMostPopularFurnitureDuringDatesBindingSource
            // 
            this.spGetMostPopularFurnitureDuringDatesBindingSource.DataMember = "spGetMostPopularFurnitureDuringDates";
            this.spGetMostPopularFurnitureDuringDatesBindingSource.DataSource = this._cs6232_g3DataSet;
            // 
            // MostPopularFurnitureBetweenDatesReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewerTableLayoutPanel);
            this.Name = "MostPopularFurnitureBetweenDatesReportUserControl";
            this.Size = new System.Drawing.Size(1400, 600);
            this.reportViewerTableLayoutPanel.ResumeLayout(false);
            this.reportViewerTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetMostPopularFurnitureDuringDatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel reportViewerTableLayoutPanel;
        private System.Windows.Forms.Label reportHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label statusMessage;
        private Microsoft.Reporting.WinForms.ReportViewer mostPopularFurnitureBetweenDatesReportViewer;
        private _cs6232_g3DataSet _cs6232_g3DataSet;
        private _cs6232_g3DataSetTableAdapters.spGetMostPopularFurnitureDuringDatesTableAdapter spGetMostPopularFurnitureDuringDatesTableAdapter;
        private System.Windows.Forms.BindingSource spGetMostPopularFurnitureDuringDatesBindingSource;
    }
}
