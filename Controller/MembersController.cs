using RentMe.DAL;
using RentMe.Model;
using RentMe.Validators;
using System;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the MembersDAL.
    /// </summary>
    public class MembersController
    {

        private readonly MembersDAL _memberDBSource;
        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public MembersController()
        {
            this._memberDBSource = new MembersDAL();
        }

        /// <summary>
        /// Gets the member details from the DAL.
        /// </summary>
        /// <returns>List of product name</returns>
        public Member SearchMember(Member memberSearch)
        {

            if (memberSearch==null)
            {
                throw new ArgumentNullException("Please enter member ID or Phone or Name to get the memeber details");
            }

            Member memberInformation = this._memberDBSource.GetMemberDetails(memberSearch);
            if (memberInformation == null )
            {
                throw new ArgumentNullException("Member deatils not found. Please proceed with Registration");

            }

            return memberInformation;
        }

        /// <summary>
        /// Update the member details from the DAL.
        /// </summary>
        /// <returns>List of product name</returns>
        public bool UpdateMemberInformation(Member oldMember, Member newMember)
        {

            if (oldMember == null && newMember== null)
            {
                throw new ArgumentNullException("Update cannot be performed with no change in data");
            }
            return  this._memberDBSource.UpdateMemberDetails(oldMember, newMember);
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
