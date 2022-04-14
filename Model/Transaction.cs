using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a RentMe transaction.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Rental attributes.
        /// </summary>
        public int TransactionID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public string FurnitureName { get; set; }
        public string FurnitureCategory { get; set; }
        public string FurnitureStyle { get; set; }
        public int Quantity { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public float RentalCharge { get; set; }
    }
}
