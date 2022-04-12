using RentMe.DAL;
using RentMe.Model;
using RentMe.Model.Validators;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the RentalTransactionsDAL.
    /// </summary>
    public class RentalTransactionsController
    {
        /// <summary>
        /// Gets all Transactions from RentalTransactions table.
        /// </summary>
        /// <returns>List of RentMe Rental Transactions</returns>
        public List<RentalTransaction> GetRentalTransactions()
        {
            return RentalTransactionsDAL.GetRentalTransactions();
        }

        /// <summary>
        /// Return true if Rental Transaction
        /// exists based on search criteria.
        /// </summary>
        /// <param name="rentalTransaction"></param>
        /// <returns>true if valid search</returns>
        public bool ValidTransactionSearch(RentalTransaction rentalTransaction)
        {
            RentalTransactionValidator.ValidateRentalTransactionNotNull(rentalTransaction);
            return RentalTransactionsDAL.ValidTransactionSearch(rentalTransaction);
        }

        /// <summary>
        /// Returns RentalTransaction list
        /// based on search input.
        /// </summary>
        /// <param name="rentalTransaction"></param>
        /// <returns>RentalTransaction list</returns>
        public List<RentalTransaction> GetRentalTransactionsFromSearch(RentalTransaction rentalTransaction)
        {
            RentalTransactionValidator.ValidateRentalTransactionNotNull(rentalTransaction);
            return RentalTransactionsDAL.GetRentalTransactionsFromSearch(rentalTransaction);
        }
    }
}
