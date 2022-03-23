using RentMe.DAL;
using RentMe.Model;
using RentMe.Validators;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the MembersDAL.
    /// </summary>
    public class MembersController
    {
        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public MembersController()
        {

        }

        /// <summary>
        /// Return true if member account exists
        /// based on search criteria.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public bool MemberSearchSuccessful(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            return MembersDAL.MemberSearchSuccessful(member);
        }
    }
}
