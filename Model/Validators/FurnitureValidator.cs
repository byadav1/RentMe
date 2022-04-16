using System;
namespace RentMe.Model.Validators
{
    /// <summary>
    /// This class serves as a validator
    /// for Furniture objects.
    /// </summary>
    public class FurnitureValidator
    {

        /// <summary>
        /// Throw exception if Furniture object is null.
        /// </summary>
        /// <param name="furniture"></param>
        public static void ValidateFurnitureNotNull(Furniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentException("The Furniture cannot be null");
            }
        }
    }
}

