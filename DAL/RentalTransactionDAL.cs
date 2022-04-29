using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the rental transaction .
    /// </summary>
    public class RentalTransactionDAL
    {
        /// <summary>
        /// Return Rental transaction by member ID
        /// </summary>
        /// <param name="member"></param>
        /// <returns>RentalTransaction list </returns>
        public List<RentalTransaction> GetRentalTransactionByMemberID(int memberID)
        {
            List<RentalTransaction> rentalTransactionList = new List<RentalTransaction>();
            String selectStatement =
                "With Return_CTE ( RentedItemsID, TotalQuantity) as " +
                "( select RentedItemsID, sum(quantity) " +
                " from ReturnTransaction " +
                "group by RentedItemsID) " +
                "SELECT rt.TransactionID, Rentdate, Duedate, rt.employeeID, memberID, " +
                "ri.furnitureID, s.name as style, c.name as category, description, " +
                "CASE WHEN rtn.TotalQuantity IS NULL then ri.Quantity " +
                "ELSE ri.Quantity - rtn.TotalQuantity " +
                "END as Quantity, " +
                "Daily_rental_rate as RentalRate, " +
                "f.name, ri.RentedItemsID " +
                "FROM RentalTransactions rt " +
                "LEFT JOIN RentedItems ri ON rt.TransactionID = ri.RentalTransactionID " +
                "LEFT JOIN Return_CTE rtn ON ri.RentedItemsID = rtn.RentedItemsID " +
                "JOIN Furnitures f ON ri.furnitureID = f.furnitureID " +
                "JOIN Categories c ON f.categoryID = c.categoryID " +
                "JOIN Styles s ON f.styleID = s.styleID " +
                "WHERE memberID = @memberID AND (ri.Quantity - rtn.TotalQuantity > 0 " +
                "OR ri.Quantity - rtn.TotalQuantity IS NULL)";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", SqlDbType.Int);
                    selectCommand.Parameters["@memberID"].Value = memberID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalTransaction rentalTransaction = new RentalTransaction();
                            rentalTransaction.TransactionID = (int)reader["TransactionID"];
                            rentalTransaction.MemberID = (int)reader["MemberID"];
                            rentalTransaction.EmployeeID = (int)reader["EmployeeID"];
                            rentalTransaction.FurnitureID = (int)reader["FurnitureID"];
                            rentalTransaction.DueDate = (DateTime)reader["DueDate"];
                            rentalTransaction.RentDate = (DateTime)reader["RentDate"];
                            rentalTransaction.FurnitureName = reader["Name"].ToString();
                            rentalTransaction.Style = reader["Style"].ToString();
                            rentalTransaction.Category = reader["Category"].ToString();
                            rentalTransaction.Description = reader["Description"].ToString();
                            rentalTransaction.Quantity = (int)reader["Quantity"];
                            rentalTransaction.RentalRate = (float)(decimal)reader["RentalRate"];
                            rentalTransaction.RentedItemsID = (int)reader["RentedItemsID"];

                            rentalTransactionList.Add(rentalTransaction);
                        }
                    }
                }
            }

            return rentalTransactionList;
        }
    }
}
