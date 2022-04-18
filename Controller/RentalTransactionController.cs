using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// The controller class that mediates between the RentalTransactionDAL and the view.
    /// </summary>
    public class RentalTransactionController
    {
        private RentalTransactionDAL rentalTransactionDAL;

        /// <summary>
        /// Constructor that initialize RentalTransactionDAL
        /// </summary>
        public RentalTransactionController()
        {
            this.rentalTransactionDAL = new RentalTransactionDAL();
        }

        /// <summary>
        /// Return Rental transaction by member ID
        /// </summary>
        /// <param name="member"></param>
        /// <returns>RentalTransaction list </returns>
        public List<RentalTransaction> GetRetalTransactionByMemberID(int memberID)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("customerID must be a numerical value greater than 0");
            }
            return this.rentalTransactionDAL.GetRentalTransactionByMemberID(memberID);
        }

    }
}
