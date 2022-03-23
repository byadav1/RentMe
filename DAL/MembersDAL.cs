using RentMe.Model;
using RentMe.Validators;
using System;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the cs6232-g3 DB Members table.
    /// </summary>
    public class MembersDAL
    {
        /// <summary>
        /// Return true if Member exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool MemberExists(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM Members ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (!Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        throw new ArgumentException("These credentials do not match a RentMe member");
                    }

                    return true;
                }
            }
        }
    }
}
