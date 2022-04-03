

using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a RentMe employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Employee properties.
        /// </summary>
        public int EmployeeID { get; set; }
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
        public string Username { get; set; }
        public string Type { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public Employee()
        {

        }
    }
}
