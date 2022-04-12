using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a RentMe Rental transaction.
    /// </summary>
    public class RentalTransaction
    {
        /// <summary>
        /// Rental attributes.
        /// </summary>
        public int TransactionID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
