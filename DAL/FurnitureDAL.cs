using RentMe.Model;
using RentMe.Model.Validators;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        /// <returns>List of RentMe Furniture</returns>
        public static List<Furniture> GetFurniture(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            List<Furniture> furnitureList = new List<Furniture>();
            string selectStatement;
            if (furnitureSearh.FurnitureID > 0 && FurnitureIDExists(furnitureSearh))
            {
                selectStatement = "SELECT f.*, c.Name AS Category, s.Name AS Style " +
                                  "FROM Furnitures f " +
                                  "JOIN Categories c ON c.CategoryID = f.CategoryID " +
                                  "JOIN Styles s ON s.StyleID = f.StyleID " +
                                  "WHERE F.FurnitureID = @FurnitureID ";
            }
            else if (!string.IsNullOrEmpty(furnitureSearh.Category) && FurnitureCategoryExists(furnitureSearh))
            {
                selectStatement = "SELECT f.*, c.Name AS Category, s.Name AS Style " +
                                  "FROM Furnitures f " +
                                  "JOIN Categories c ON c.CategoryID = f.CategoryID " +
                                  "JOIN Styles s ON s.StyleID = f.StyleID " +
                                  "WHERE c.Name = @Category ";
            }
            else if (!string.IsNullOrEmpty(furnitureSearh.Style) && FurnitureStyleExists(furnitureSearh))
            {
                selectStatement = "SELECT f.*, c.Name AS Category, s.Name AS Style " +
                                  "FROM Furnitures f " +
                                  "JOIN Categories c ON c.CategoryID = f.CategoryID " +
                                  "JOIN Styles s ON s.StyleID = f.StyleID " +
                                  "WHERE s.Name = @Style ";
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
                        selectCommand.Parameters.AddWithValue("FurnitureID", furnitureSearh.FurnitureID);

                    }
                    else if (!string.IsNullOrEmpty(furnitureSearh.Category) && FurnitureCategoryExists(furnitureSearh))
                    {
                        selectCommand.Parameters.AddWithValue("Category", furnitureSearh.Category);
                    }
                    else if (!string.IsNullOrEmpty(furnitureSearh.Style) && FurnitureStyleExists(furnitureSearh))
                    {
                        selectCommand.Parameters.AddWithValue("Style", furnitureSearh.Style);
                    }
                    Furniture furniturefound = null;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            furniturefound = new Furniture
                            {
                                FurnitureID = Convert.ToInt32(reader["FurnitureID"]),
                                Category = reader["Category"].ToString(),
                                Style = reader["Style"].ToString(),
                                Description = reader["Description"].ToString(),
                                Name = reader["Name"].ToString(),
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
        /// <returns>True if FurnitureID exists</returns>
        private static bool FurnitureIDExists(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "SELECT COUNT(*) " +
                                     "FROM Furnitures " +
                                     "WHERE FurnitureID = @FurnitureID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("FurnitureID", furnitureSearh.FurnitureID);
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
        /// <returns>True if Furniture Category exists</returns>
        private static bool FurnitureCategoryExists(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "SELECT COUNT(*) " +
                                     "FROM Categories c " +
                                     "WHERE c.Name = @Category";

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
        /// <returns>True if Furniture Style exists</returns>
        private static bool FurnitureStyleExists(Furniture furnitureSearh)
        {
            FurnitureValidator.ValidateFurnitureNotNull(furnitureSearh);
            string selectStatement = "SELECT COUNT(*) " +
                                     "FROM Styles s " +
                                     "WHERE s.Name = @Style";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("Style", furnitureSearh.Style);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Gets the list of all style names from database.
        /// </summary>
        /// <returns>List of Furniture styles</returns>
        public static List<String> GetFurnitureStyles()
        {
            List<String> styleList = new List<String>();
            string selectStatement = "SELECT Name FROM Styles";

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
        /// Gets the list of all category names from database
        /// </summary>
        /// <returns>List of Furniture categories</returns>
        public static List<String> GetFurnitureCategories()
        {
            List<String> categoryList = new List<String>();
            string selectStatement = "SELECT Name FROM Categories ";

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
