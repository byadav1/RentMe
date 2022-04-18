using RentMe.DAL;
using RentMe.Model;
using System;

namespace RentMe.Controller
{
    /// <summary>
    /// The controller class that mediates between the RentalTransactionDAL and the view.
    /// </summary>
    public class ReturnTransactionController
    {
        private ReturnTransactionDAL returnTransactionSource;

        /// <summary>
        /// Constructor that initialize ReturnTransactionDAL
        /// </summary>
        public ReturnTransactionController()
        {
            this.returnTransactionSource = new ReturnTransactionDAL();
        }

        /// <summary>
        /// Add return furniture to database
        /// </summary>
        /// <param name="returnFurniture"></param>
        public void AddReturnFurniture(ReturnTransaction returnTransaction)
        {
            if (returnTransaction == null)
            {
                throw new ArgumentException("returnTransaction can't be null");
            }

            this.returnTransactionSource.AddReturnFurniture(returnTransaction);

        }

    }
}
