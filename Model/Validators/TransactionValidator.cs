using System;

namespace RentMe.Model.Validators
{
    /// <summary>
    /// This class serves as a validator
    /// for Transaction objects.
    /// </summary>
    public class TransactionValidator
    {
        /// <summary>
        /// Throw exception if Transaction object is null.
        /// </summary>
        /// <param name="transaction"></param>
        public static void ValidateTransactionNotNull(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentException("The transaction cannot be null");
            }
        }
    }
}
