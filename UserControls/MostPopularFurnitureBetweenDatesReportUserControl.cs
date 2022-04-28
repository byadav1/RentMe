using RentMe.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// This UserControl models a viewer
    /// where the admin may generate 
    /// </summary>
    public partial class MostPopularFurnitureBetweenDatesReportUserControl : UserControl
    {
        private readonly TransactionsController transactionsController;

        /// <summary>
        /// Initialize the control.
        /// </summary>
        public MostPopularFurnitureBetweenDatesReportUserControl()
        {
            InitializeComponent();
            this.transactionsController = new TransactionsController();
            this.RefreshControl();
        }

        /// <summary>
        /// Initializes the controls.
        /// </summary>
        public void RefreshControl()
        {
            this.mostPopularFurnitureBetweenDatesReportViewer.RefreshReport();

            this.startDateTimePicker.MinDate = this.transactionsController.GetEarliestRentalTransaction();           
            this.startDateTimePicker.MaxDate = DateTime.Now;
            this.startDateTimePicker.Value = this.startDateTimePicker.MinDate;

            this.endDateTimePicker.MinDate = this.transactionsController.GetEarliestRentalTransaction();         
            this.endDateTimePicker.MaxDate = DateTime.Now;
            this.endDateTimePicker.Value = this.endDateTimePicker.MaxDate;
        }

        /// <summary>
        /// Event Handler for Generate button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateReportButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.ValidateDates();
                int results = this.spGetMostPopularFurnitureDuringDatesTableAdapter
                    .GetData(this.startDateTimePicker.Value, this.endDateTimePicker.Value).Rows.Count;
               
                if (results > 0)
                {
                    this.spGetMostPopularFurnitureDuringDatesTableAdapter.Fill(this._cs6232_g3DataSet.spGetMostPopularFurnitureDuringDates,
                        this.startDateTimePicker.Value, this.endDateTimePicker.Value);
                    this.mostPopularFurnitureBetweenDatesReportViewer.RefreshReport();
                    this.UpdateStatusMessage(results + " results found", false);
                }
                else
                {
                    this.UpdateStatusMessage("No qualified furniture found", true);
                }
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
        }

        /// <summary>
        /// Throws error if improper date parameters submitted.
        /// </summary>
        private void ValidateDates()
        {
            if (this.startDateTimePicker.Value == null || this.endDateTimePicker.Value == null)
            {
                throw new Exception("The report requires a start date and end date");
            }
            else if (this.startDateTimePicker.Value > this.endDateTimePicker.Value)
            {
                throw new Exception("The start date cannot be greater than the end date");
            }
        }

        /// <summary>
        /// Event Handler for DateTimePicker value change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePickerValueChanged(object sender, EventArgs e)
        {
            this.UpdateStatusMessage("Enter a start date and end date to generate the report", false);
        }

        /// <summary>
        /// Updates the error message to reflect 
        /// the status of the form.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isError"></param>
        private void UpdateStatusMessage(string message, bool isError)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Message cannot be null or empty");
            }

            if (isError)
            {
                this.statusMessage.ForeColor = Color.Red;
            }
            else
            {
                this.statusMessage.ForeColor = Color.Black;
            }

            this.statusMessage.Text = message;
            this.statusMessage.Visible = true;
        }
    }
}
