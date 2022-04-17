using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a Return transaction.
    /// </summary>
    public class ReturnTransaction
    {
        /// <summary>
        /// Return transaction properties
        /// </summary>
        public int RentedItemsID { get; set; }
        public int Quantity { get; set; }
        public double Days { get; set; }
        public int EmployeeID { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public string FurnitureName { get; set; }
        public float RentalRate { get; set; }
        public float SubTotal { get; set; }
        public float Fine { get; set; }
        public float Refund { get; set; }
    }
}
