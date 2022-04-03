using System;
using System.Data.SqlClient;
using RentMe.Model;
using RentMe.Model.Validators;
using System.Collections.Generic;

namespace RentMe.DAL
{
    /// <summary>
    /// Database class for furniture database trnasaction on update/delete/search of  furniture
    /// </summary>
    public class FurnitureDAL
    {
        /// <summary>
        /// Return Furniture information based upon search.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public List<Furniture> GetFurniture(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            List<Furniture> furnitureList = new List<Furniture>();
            string selectStatement;
            if (furnitureSearh.FurnitureID > 0 && FurnitureIDExists(furnitureSearh))
            {
                selectStatement = "SELECT F.*,C.NAME AS CATEGORY ,S.NAME AS STYLE " +
                                        "FROM Furnitures F" +
                                        " JOIN CATEGORIES C ON C.CATEGORYID = F.CATEGORYID " +
                                    " JOIN STYLES S ON S.STYLEID=F.STYLEID" +
                                        " WHERE F.FurnitureID = @ID";
            }
            else if (!string.IsNullOrEmpty(furnitureSearh.Category) && FurnitureCategoryExists(furnitureSearh))
            {
                selectStatement = "SELECT F.*,C.NAME AS CATEGORY ,S.NAME AS STYLE FROM Furnitures F " +
                                    " JOIN CATEGORIES C ON C.CATEGORYID = F.CATEGORYID " +
                                    " JOIN STYLES S ON S.STYLEID=F.STYLEID" +
                                    " WHERE C.NAME =@Category";
            }
            else if (!string.IsNullOrEmpty(furnitureSearh.Style) && FurnitureStyleExists(furnitureSearh))
            {
                selectStatement = "SELECT F.*,C.NAME AS CATEGORY ,S.NAME AS STYLE FROM Furnitures F " +
                                   " JOIN CATEGORIES C ON C.CATEGORYID = F.CATEGORYID " +
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
                    if (furnitureSearh.FurnitureID > 0 && FurnitureIDExists(furnitureSearh))
                    {
                        selectCommand.Parameters.AddWithValue("ID", furnitureSearh.FurnitureID);

                    }
                    else if (!string.IsNullOrEmpty(furnitureSearh.Category) && FurnitureCategoryExists(furnitureSearh))
                    {
                        selectCommand.Parameters.AddWithValue("Category", furnitureSearh.Category);
                    }
                    else if (!string.IsNullOrEmpty(furnitureSearh.Style) && FurnitureStyleExists(furnitureSearh))
                    {
                        selectCommand.Parameters.AddWithValue("STYLE", furnitureSearh.Style);
                    }
                    Furniture furniturefound = null;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            furniturefound = new Furniture
                            {
                                FurnitureID = Convert.ToInt32(reader["FurnitureID"]),
                                Category = reader["CATEGORY"].ToString(),
                                Style = reader["STYLE"].ToString(),
                                Description = reader["DESCRIPTION"].ToString(),
                                Name = reader["NAME"].ToString(),
                                DailyRentalRate = (float)Convert.ToDouble(reader["Daily_rental_rate"]),
                                Quantity = Convert.ToInt32(reader["Quantity"])
                            };
                            furnitureList.Add(furniturefound);

                        }
                    }
                }
            }

            return furnitureList;
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
                                        "FROM Furnitures " +
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
        /// Return true if Furniture Category exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool FurnitureCategoryExists(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "SELECT count(*) FROM CATEGORIES C WHERE C.NAME =@Category";

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
        /// Return true if Furniture Style exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool FurnitureStyleExists(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "SELECT count(*) FROM STYLES S WHERE S.NAME =@STYLE";

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


        /// <summary>
        /// Gets the list of all style name from database
        /// </summary>
        /// <returns>furniture style list</returns>
        public List<String> GetFurnitureStyles()
        {
            List<String> styleList = new List<String>();
            string selectStatement =
                  " SELECT NAME FROM Styles ";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        String styleName = "";
                        while (reader.Read())
                        {
                            styleName = reader["Name"].ToString();
                            styleList.Add(styleName);
                        }
                    }
                }
            }

            return styleList;
        }

        /// <summary>
        /// Gets the list of all category name from database
        /// </summary>
        /// <returns>furniture category list</returns>
        public List<String> GetFurnitureCategories()
        {
            List<String> categoryList = new List<String>();

            string selectStatement =
                  " SELECT NAME FROM Categories ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        String categoryName = "";
                        while (reader.Read())
                        {
                            categoryName = reader["Name"].ToString();
                            categoryList.Add(categoryName);
                        }
                    }
                }
            }

            return categoryList;
        }

    }
}
