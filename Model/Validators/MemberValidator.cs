using RentMe.Model;
using System;

namespace RentMe.Validators
{
    /// <summary>
    /// This class serves as a validator
    /// for Member objects.
    /// </summary>
    public class MemberValidator
    {
        /// <summary>
        /// Throw exception if Member object is null.
        /// </summary>
        /// <param name="member"></param>
        public static void ValidateMemberNotNull(Member member)
        {
            if (member == null)
            {
                throw new ArgumentException("The member cannot be null");
            }
        }
    }
}
