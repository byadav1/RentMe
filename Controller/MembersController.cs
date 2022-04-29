using RentMe.DAL;
using RentMe.Model;
using RentMe.Validators;
using System.Collections.Generic;

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
        /// Gets all RentMe Members from Members table.
        /// </summary>
        /// <returns>List of RentMe members</returns>
        public List<Member> GetMembers()
        {
            return MembersDAL.GetMembers();
        }

        /// <summary>
        /// Update the member details from the DAL.
        /// </summary>
        /// <returns>True for successful member profile update</returns>
        public bool UpdateMemberInformation(Member oldMember, Member newMember)
        {
            MemberValidator.ValidateMemberNotNull(oldMember);
            MemberValidator.ValidateMemberNotNull(newMember);
            return MembersDAL.UpdateMemberDetails(oldMember, newMember);
        }

        /// <summary>
        /// Return true if member account exists
        /// based on search criteria.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>True if member exists</returns>
        public bool ValidMemberSearch(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            return MembersDAL.ValidMemberSearch(member);
        }

        /// <summary>
        /// Return member using search input.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>Searched Member</returns>
        public Member GetMemberFromSearch(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            return MembersDAL.GetMemberFromSearch(member);
        }

        /// <summary>
        /// Return members using search input.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>Searched members</returns>
        public List<Member> GetMembersFromSearch(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            return MembersDAL.GetMembersFromSearch(member);
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
