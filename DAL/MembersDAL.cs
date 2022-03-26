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
        public Member GetMemberDetails(Member member)
        {
            string selectStatement = "";

            Member memberDetails = null;
            if (member.MemberID > 0)
            {
                selectStatement = " SELECT * FROM Members where memberID= @ID";
            }
            else if (!string.IsNullOrEmpty(member.Phone))
            {
                selectStatement = " SELECT * FROM Members where phone= @memberPhone";
            }
            else if (!string.IsNullOrEmpty(member.FName) && !string.IsNullOrEmpty(member.LName))
            {

                selectStatement = " SELECT * FROM Members where fname= @fName and lname=@lName ";
            }

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (member.MemberID > 0)
                    {
                        selectCommand.Parameters.Add("@ID", SqlDbType.Int);
                        selectCommand.Parameters["@ID"].Value = member.MemberID;
                    }
                    else if (!string.IsNullOrEmpty(member.Phone))
                    {
                        selectCommand.Parameters.Add("@memberPhone", SqlDbType.VarChar);
                        selectCommand.Parameters["@memberPhone"].Value = member.Phone;
                    }
                    else if (!string.IsNullOrEmpty(member.FName) && !string.IsNullOrEmpty(member.LName))
                    {
                        selectCommand.Parameters.Add("@fname", SqlDbType.VarChar);
                        selectCommand.Parameters["@fname"].Value = member.FName;

                        selectCommand.Parameters.Add("@lname", SqlDbType.VarChar);
                        selectCommand.Parameters["@lname"].Value = member.LName;
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            memberDetails = new Member();
                            memberDetails.MemberID = (int)reader["MemberID"];
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


        /// <summary>
        /// Updates the Member Details based on the search parameter from database
        /// </summary>
        /// <returns>bool</returns>
        public bool UpdateMemberDetails(Member oldMember, Member newMember)
        {
            string selectStatement =
                  " UPDATE MEMBERS SET " +
                       " FNAME=@NewFName , LNAME=@NewLName , " +
                       " Sex=@NewSex , DateOfBirth=@NewDob , " +
                        " Phone=@NewPhone ,  City=@NewCity , " +
                       " zipcode=@NewZip , State=@NewState, " +
                       " Address1=@NewAddress1 , Address2=@NewAddress2 " +
                        "Where MEMBERID=@OldMemberID  AND FNAME=@OldFName AND " +
                       " LNAME=@OldLName AND Sex=@OldSex AND " +
                       " DateOfBirth=@OldDob AND Phone=@OldPhone AND " +
                       " City=@OldCity AND zipcode=@OldZip AND State=@OldState AND " +
                       " Address1=@OldAddress1 AND Address2=@OldAddress2 ";



            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    // Old member details Mappings
                    selectCommand.Parameters.Add("@OldMemberID", SqlDbType.VarChar);
                    selectCommand.Parameters["@OldMemberID"].Value = oldMember.MemberID;

                    selectCommand.Parameters.Add("@OldFName", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldLName", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldSex", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldDob", SqlDbType.DateTime);
                    selectCommand.Parameters.Add("@OldPhone", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldCity", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldZip", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldState", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldAddress1", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldAddress2", SqlDbType.VarChar);

                    selectCommand.Parameters["@OldFName"].Value = oldMember.FName;
                    selectCommand.Parameters["@OldLName"].Value = oldMember.LName;
                    selectCommand.Parameters["@OldSex"].Value = oldMember.Sex;
                    selectCommand.Parameters["@OldDob"].Value = oldMember.DOB;
                    selectCommand.Parameters["@OldPhone"].Value = oldMember.Phone;
                    selectCommand.Parameters["@OldCity"].Value = oldMember.City;
                    selectCommand.Parameters["@OldZip"].Value = oldMember.Zip;
                    selectCommand.Parameters["@OldState"].Value = oldMember.State;
                    selectCommand.Parameters["@OldAddress1"].Value = oldMember.Address1;
                    selectCommand.Parameters["@OldAddress2"].Value = oldMember.Address2;

                    // New member details Mappings
                    selectCommand.Parameters.Add("@NewFName", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewLName", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewSex", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewDob", SqlDbType.DateTime);
                    selectCommand.Parameters.Add("@NewPhone", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewCity", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewZip", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewState", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewAddress1", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewAddress2", SqlDbType.VarChar);
                    selectCommand.Parameters["@NewFName"].Value = newMember.FName;
                    selectCommand.Parameters["@NewLName"].Value = newMember.LName;
                    selectCommand.Parameters["@NewSex"].Value = newMember.Sex;
                    selectCommand.Parameters["@NewDob"].Value = newMember.DOB;
                    selectCommand.Parameters["@NewPhone"].Value = newMember.Phone;
                    selectCommand.Parameters["@NewCity"].Value = newMember.City;
                    selectCommand.Parameters["@NewZip"].Value = newMember.Zip;
                    selectCommand.Parameters["@NewState"].Value = newMember.State;
                    selectCommand.Parameters["@NewAddress1"].Value = newMember.Address1;
                    selectCommand.Parameters["@NewAddress2"].Value = newMember.Address2;
                    int resultCount = selectCommand.ExecuteNonQuery();
                    if (resultCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }

        }

        /// <summary>
        /// Deactivate the Member 
        /// </summary>
        /// <returns>bool</returns>
        public bool DeactivateMember(Member member)
        {
            string selectStatement =
                      " UPDATE MEMBERS SET DELETE_FLAG='Y' Where MEMBERID=@deleteMemberID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.Add("@deleteMemberID", SqlDbType.VarChar);
                    selectCommand.Parameters["@deleteMemberID"].Value = member.MemberID;

                    int resultCount = selectCommand.ExecuteNonQuery();
                    if (resultCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }

        }
    }
}

