using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a RentMe transaction.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Transaction attributes.
        /// </summary>        
        public string TransactionType { get; set; }
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
        public decimal RentalCharge { get; set; }
    }
}
