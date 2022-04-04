using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a RentMe Member.
    /// </summary>
    public class Member
    {
        /// <summary>
        /// Member properties.
        /// </summary>
        public int MemberID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
