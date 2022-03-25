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
        /// Return true if Member matches search criteria
        /// MemberID, Phone, or Full Name.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static bool ValidMemberSearch(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            if (MemberIDExists(member) || MemberPhoneExists(member) || MemberNameExists(member))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("No search results");
            }
        }

        /// <summary>
        /// Return Member information based upon search.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static Member GetMemberFromSearch(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            string selectStatement = "SELECT * " +
                                        "FROM Members " +
                                        "WHERE ";
            if (MemberIDExists(member))
            {
                selectStatement += "MemberID = @MemberID";
            }
            else if (MemberPhoneExists(member))
            {
                selectStatement += "Phone = @Phone";               
            }
            else if (MemberNameExists(member))
            {
                selectStatement += "Fname = @FName AND Lname = @LName";
            }
            else
            {
                throw new ArgumentException("Must search a member by their ID, Phone, or Name");
            }

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (MemberIDExists(member))
                    {
                        selectCommand.Parameters.AddWithValue("MemberID", member.MemberID);
                    }
                    else if (MemberPhoneExists(member))
                    {
                        selectCommand.Parameters.AddWithValue("Phone", member.Phone);
                    }
                    else if (MemberNameExists(member))
                    {
                        selectCommand.Parameters.AddWithValue("FName", member.FName);
                        selectCommand.Parameters.AddWithValue("LName", member.LName);
                    }                  
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            member.MemberID = Convert.ToInt32(reader["MemberID"]);
                            member.FName = reader["Fname"].ToString();
                            member.LName = reader["Lname"].ToString();
                            member.DOB = (DateTime)reader["DateOfBirth"];
                            member.Phone = reader["Phone"].ToString();
                            member.Sex = reader["Sex"].ToString();
                            member.Address1 = reader["Address1"].ToString();
                            if (!reader.IsDBNull(8))
                            {
                                member.Address2 = reader["Address2"].ToString();
                            }
                            member.City = reader["City"].ToString();
                            member.State = reader["State"].ToString();
                            member.Zip = reader["ZipCode"].ToString();
                        }
                    }
                }
            }

            return member;
        }

        /// <summary>
        /// Register and return a new RentMe Member.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static void RegisterNewMember(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            string insertStatement = "INSERT INTO Members " +
                                     "VALUES(@FName, @LName, @DOB, @Phone, " +
                                     "@Sex, @Address1, @Address2, @City, @State, @Zip) " +
                                     "SELECT SCOPE_IDENTITY()";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(insertStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("FName", member.FName);
                    selectCommand.Parameters.AddWithValue("LName", member.LName);
                    selectCommand.Parameters.AddWithValue("DOB", member.DOB);
                    selectCommand.Parameters.AddWithValue("Phone", member.Phone);
                    selectCommand.Parameters.AddWithValue("Sex", member.Sex);
                    selectCommand.Parameters.AddWithValue("Address1", member.Address1);
                    if (string.IsNullOrEmpty(member.Address2))
                    {
                        selectCommand.Parameters.AddWithValue("Address2", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("Address2", member.Address2);
                    }
                    selectCommand.Parameters.AddWithValue("City", member.City);
                    selectCommand.Parameters.AddWithValue("State", member.State);
                    selectCommand.Parameters.AddWithValue("Zip", member.Zip);
                    member.MemberID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Return true if MemberID exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool MemberIDExists(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM Members " +
                                        "WHERE MemberID = @MemberID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("MemberID", member.MemberID);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Return true if Phone exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool MemberPhoneExists(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            if (member.Phone == null)
            {
                return false;
            }
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM Members " +
                                        "WHERE Phone = @Phone";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("Phone", member.Phone);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Return true if FName and LName exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool MemberNameExists(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            if (member.FName == null || member.LName == null)
            {
                return false;
            }
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM Members " +
                                        "WHERE Fname = @FName AND Lname = @LName";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("FName", member.FName);
                    selectCommand.Parameters.AddWithValue("LName", member.LName);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }
    }
}
