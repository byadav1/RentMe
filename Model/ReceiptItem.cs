using System;

namespace RentMe.Model
{
    public class ReceiptItem
    {
        /// <summary>
        /// ReceiptItem attributes.
        /// </summary>
        public int FurnitureID { get; set; }
        public string Description { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalDueDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public decimal DailyRate { get; set; }
        public int NumberOfDays { get; set; }
        public decimal LateFee { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal SubTotal { get; set; }
    }
}
