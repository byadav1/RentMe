using System;

namespace RentMe.Model
{
    public class ReceiptItem
    {
        public int FurnitureID { get; set; }
        public string Description { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalDueDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public int Quantity { get; set; }
        public float DailyRate { get; set; }
        public int NumberOfDays { get; set; }
        public float LateFee { get; set; }
        public float SubTotal { get; set; }
    }
}
