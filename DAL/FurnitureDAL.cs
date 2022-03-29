using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using RentMe.Model;
using RentMe.Validators;
using RentMe.Model.Validators;

namespace RentMe.DAL
{
    class FurnitureDAL
    {




        /// <summary>
        /// Return Member information based upon search.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static Member GetFurniture(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "";


            if (FurnitureIDExists(furnitureSearh))
            {
                 selectStatement = "SELECT * " +
                                         "FROM Furnitures " +
                                         "WHERE FurnitureID = @ID";
            }
            else if (FurnitureCategoryExists(furnitureSearh))
            {
                 selectStatement = "SELECT * FROM FURNITURES F" +
                                     " JOIN CATEGORIES C ON C.CATEGORYID = F.CATEGORYID WHERE C.NAME =@Category";
            }
            else if (FurnitureStyleExists(furnitureSearh))
            {
                 selectStatement = "SELECT * FROM FURNITURES F" +
                                   " JOIN STYLES S ON S.STYLEID = F.STYLEID WHERE S.NAME =@STYLE";
            }
            else
            {
                throw new ArgumentException("Must search a furniture by their ID, Category, or Style");
            }

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (FurnitureIDExists(furnitureSearh))
                    {
                        selectCommand.Parameters.AddWithValue("ID", furnitureSearh.FurnitureID);
                    }
                    else if (FurnitureCategoryExists(furnitureSearh))
                    {
                        selectCommand.Parameters.AddWithValue("Category", furnitureSearh.Category);
                    }
                    else if (FurnitureStyleExists(furnitureSearh))
                    {
                        selectCommand.Parameters.AddWithValue("STYLE", furnitureSearh.Style);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            furnitureSearh.MemberID = Convert.ToInt32(reader["MemberID"]);
                            furnitureSearh.FName = reader["Fname"].ToString();
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
        /// Return true if FurnitureID exists.
        /// </summary>
        /// <param name="furnitureSearh"></param>
        /// <returns></returns>
        private static bool FurnitureIDExists(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM Furniture " +
                                        "WHERE FurnitureID = @ID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("ID", furnitureSearh.FurnitureID);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Return true if MemberID exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool FurnitureCategoryExists(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "SELECT count(*) FROM FURNITURES F" +
                                    " JOIN CATEGORIES C ON C.CATEGORYID = F.CATEGORYID WHERE C.NAME =@Category";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("Category", furnitureSearh.Category);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Return true if MemberID exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool FurnitureStyleExists(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "SELECT count(*) FROM FURNITURES F" +
                                    " JOIN STYLES S ON S.STYLEID = F.STYLEID WHERE S.NAME =@STYLE";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("style", furnitureSearh.Style);
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
