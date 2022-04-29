using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a Rental transaction.
    /// </summary>
    public class RentalTransaction
    {
        /// <summary>
        /// Rental transaction attributes.
        /// </summary>
        public int TransactionID { get; set; }
        public int RentedItemsID { get; set; }
        public int FurnitureID { get; set; }
        public int Quantity { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime RentDate { get; set; }
        public string FurnitureName { get; set; }
        public string Category { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }
        public float RentalRate { get; set; }
    }
}
