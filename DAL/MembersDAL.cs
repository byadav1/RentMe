using RentMe.Model;
using RentMe.Validators;
using System;
using System.Data;
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
        public static bool MemberSearchSuccessful(Member member)
        {
            MemberValidator.ValidateMemberNotNull(member);
            return MemberIDExists(member) || MemberPhoneExists(member) || MemberNameExists(member);
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
            member.Phone = member.Phone.Replace("-", string.Empty);
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


        /// <summary>
        /// Gets the Member Details based on the search parameter from database
        /// </summary>
        /// <returns>Member</returns>
        public Member GetMemberDetails(int ID, int memberPhone, string name  )
        {
            string selectStatement = "";
            string fName = "";
            string lName = "";
            Member memberDetails = new Member();
            if (ID > 0)
            {
                 selectStatement = " SELECT * FROM Members where memberID= @ID";
            }else if (memberPhone > 0)
            {
                 selectStatement = " SELECT * FROM Members where phone= @memberPhone";
            }
            else if (!string.IsNullOrEmpty(name))
            {
                string[] nameDetails = name.Split(' ');
                fName = nameDetails[0];
                lName= nameDetails[1];
                selectStatement = " SELECT * FROM Members where fname= @fName and lname=@lName ";
            }

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.Add("@ID", SqlDbType.Int);
                    selectCommand.Parameters["@ID"].Value = ID;

                    selectCommand.Parameters.Add("@memberPhone", SqlDbType.Int);
                    selectCommand.Parameters["@memberPhone"].Value = memberPhone;

                    selectCommand.Parameters.Add("@fname", SqlDbType.VarChar);
                    selectCommand.Parameters["@fname"].Value = fName;

                    selectCommand.Parameters.Add("@lname", SqlDbType.VarChar);
                    selectCommand.Parameters["@lname"].Value = lName;
                 
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            memberDetails.FName = reader["Fname"].ToString();
                            memberDetails.LName = reader["Lname"].ToString();
                            memberDetails.DOB = (DateTime)reader["DateOFBirth"];
                            memberDetails.Phone = reader["phone"].ToString(); ;
                            memberDetails.Sex = reader["sex"].ToString(); ;
                            memberDetails.Address1 = reader["Address1"].ToString();
                            memberDetails.Address2 = reader["Address2"].ToString();
                            memberDetails.City = reader["City"].ToString();
                            memberDetails.State = reader["state"].ToString();
                            memberDetails.Zip = reader["Zipcode"].ToString();

                        }
                    }
                }
            }
            return memberDetails;
        }
    }
}
