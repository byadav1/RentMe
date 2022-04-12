using System;

namespace RentMe.Model.Validators
{
    /// <summary>
    /// This class serves as a validator
    /// for RentalTransaction objects.
    /// </summary>
    public class RentalTransactionValidator
    {
        /// <summary>
        /// Throw exception if RentalTransaction object is null.
        /// </summary>
        /// <param name="rentalTransaction"></param>
        public static void ValidateRentalTransactionNotNull(RentalTransaction rentalTransaction)
        {
            if (rentalTransaction == null)
            {
                throw new ArgumentException("The rental transaction cannot be null");
            }
        }
    }
}
