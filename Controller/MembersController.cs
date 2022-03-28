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
        /// Update the member details from the DAL.
        /// </summary>
        /// <returns>List of product name</returns>
        public bool DeleteMember(Member member)
        {

            if (member == null)
            {
                throw new ArgumentNullException("Delete cannot be performed ");
            }
            return this._memberDBSource.DeactivateMember(member);
        }


        /// <summary>
        /// Return true if member account exists
        /// based on search criteria.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public bool ValidMemberSearch(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            return MembersDAL.ValidMemberSearch(member);
        }

        /// <summary>
        /// Return member using search input.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public Member GetMemberFromSearch(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            return MembersDAL.GetMemberFromSearch(member);
        }

        /// <summary>
        /// Register a new RentMe Member.
        /// </summary>
        /// <param name="member"></param>
        public void RegisterNewMember(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            MembersDAL.RegisterNewMember(member);
        }
    }
}
