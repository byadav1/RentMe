using System;

namespace RentMe.Model.Validators
{
    /// <summary>
    /// This class serves as a validator
    /// for Receipt objects.
    /// </summary>
    public class ReceiptItemValidator
    {
        /// <summary>
        /// Throw exception if ReceiptItem is null.
        /// </summary>
        /// <param name="receiptItem"></param>
        public static void ValidateReceiptItemNotNull(ReceiptItem receiptItem)
        {
            if (receiptItem == null)
            {
                throw new ArgumentException("Receipt item cannot be null");
            }
        }
    }
}
