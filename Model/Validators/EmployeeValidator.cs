using RentMe.Model;
using System;

namespace RentMe.Validators
{
    /// <summary>
    /// This class serves as a validator
    /// for Employee objects.
    /// </summary>
    public class EmployeeValidator
    {
        /// <summary>
        /// Throw exception if Employee object is null.
        /// </summary>
        /// <param name="employee"></param>
        public static void ValidateEmployeeNotNull(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentException("The employee cannot be null");
            }
        }
    }
}
