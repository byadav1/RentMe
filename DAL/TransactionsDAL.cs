using RentMe.Model;
using RentMe.Model.Validators;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the cs6232-g3 DB RentalTransactions table.
    /// </summary>
    public class TransactionsDAL
    {
        /// <summary>
        /// Gets all RentMe Transactions.
        /// </summary>
        /// <returns>List of RentMe Transactions</returns>
        public static List<Transaction> GetTransactions()
        {          
            List<Transaction> transactions = new List<Transaction>();
            string selectStatement = "SELECT rt.TransactionID, rt.EmployeeID, rt.MemberID, f.Name AS Furniture, " +
                                     "c.Name AS Category, s.Name AS Style, ri.Quantity, rt.RentDate, rt.DueDate, rtrn.ReturnDate " +
                                     "FROM RentalTransactions rt " +
                                     "JOIN RentedItems ri " +
                                     "ON rt.TransactionID = ri.RentalTransactionID " +
                                     "JOIN ReturnTransaction rtrn " +
                                     "ON rt.TransactionID = rtrn.TransactionID " +
                                     "JOIN Furnitures f " +
                                     "ON ri.FurnitureID = f.FurnitureID " +
                                     "JOIN Categories c " +
                                     "ON f.CategoryID = c.CategoryID " +
                                     "JOIN Styles s " +
                                     "ON f.StyleID = s.StyleID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction
                            {
                                TransactionID = Convert.ToInt32(reader["TransactionID"]),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                MemberID = Convert.ToInt32(reader["MemberID"]),
                                FurnitureName = reader["Furniture"].ToString(),
                                FurnitureCategory = reader["Category"].ToString(),
                                FurnitureStyle = reader["Style"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                RentalDate = (DateTime)reader["RentDate"],
                                DueDate = (DateTime)reader["DueDate"],
                                ReturnDate = (DateTime)reader["ReturnDate"]
                            };

                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        /// <summary>
        /// Return true if Rental Transaction
        /// exists based on search criteria.
        /// </summary>
        /// <param name="rentalTransaction"></param>
        /// <returns>true if valid search</returns>
        public static bool ValidTransactionSearch(Transaction rentalTransaction)
        {
            TransactionValidator.ValidateTransactionNotNull(rentalTransaction);
            if (TransactionIDExists(rentalTransaction) || EmployeeIDExists(rentalTransaction) || MemberIDExists(rentalTransaction))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("No search results");
            }
        }

        /// <summary>
        /// Returns Transaction list
        /// based on search input.
        /// </summary>
        /// <param name="rentalTransaction"></param>
        /// <returns>RentalTransaction list</returns>
        public static List<Transaction> GetTransactionsFromSearch(Transaction transaction, bool getActiveTransactions)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);           
            List<Transaction> transactions = new List<Transaction>();
            string selectStatement = "SELECT rt.TransactionID, rt.EmployeeID, rt.MemberID, f.Name AS Furniture, " +
                                     "c.Name AS Category, s.Name AS Style, ri.Quantity, rt.RentDate, rt.DueDate, rtrn.ReturnDate " +
                                     "FROM RentalTransactions rt " +
                                     "JOIN RentedItems ri " +
                                     "ON rt.TransactionID = ri.RentalTransactionID " +
                                     "JOIN ReturnTransaction rtrn " +
                                     "ON rt.TransactionID = rtrn.TransactionID " +
                                     "JOIN Furnitures f " +
                                     "ON ri.FurnitureID = f.FurnitureID " +
                                     "JOIN Categories c " +
                                     "ON f.CategoryID = c.CategoryID " +
                                     "JOIN Styles s " +
                                     "ON f.StyleID = s.StyleID " +
                                     "WHERE ";
            if (TransactionIDExists(transaction))
            {
                selectStatement += "rt.TransactionID = @TransactionID";
            }
            else if (EmployeeIDExists(transaction))
            {
                selectStatement += "rt.EmployeeID = @EmployeeID";
            }
            else if (MemberIDExists(transaction))
            {
                selectStatement += "rt.MemberID = @MemberID";
            }
            else
            {
                throw new ArgumentException("Must search a rental transaction by ID of either transaction, employee, or member");
            }

            if (getActiveTransactions)
            {
                selectStatement += " AND rtrn.ReturnDate IS NULL";
            }

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (TransactionIDExists(transaction))
                    {
                        selectCommand.Parameters.AddWithValue("TransactionID", transaction.TransactionID);
                    }
                    else if (EmployeeIDExists(transaction))
                    {
                        selectCommand.Parameters.AddWithValue("EmployeeID", transaction.EmployeeID);
                    }
                    else if (MemberIDExists(transaction))
                    {
                        selectCommand.Parameters.AddWithValue("MemberID", transaction.MemberID);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transaction = new Transaction
                            {
                                TransactionID = Convert.ToInt32(reader["TransactionID"]),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                MemberID = Convert.ToInt32(reader["MemberID"]),
                                FurnitureName = reader["Furniture"].ToString(),
                                FurnitureCategory = reader["Category"].ToString(),
                                FurnitureStyle = reader["Style"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                RentalDate = (DateTime)reader["RentDate"],
                                DueDate = (DateTime)reader["DueDate"],
                                ReturnDate = (DateTime)reader["ReturnDate"]
                            };

                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        /// <summary>
        /// Return true if TransactionID exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool TransactionIDExists(Transaction transaction)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM RentalTransactions " +
                                        "WHERE TransactionID = @TransactionID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("TransactionID", transaction.TransactionID);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Return true if EmployeeID exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool EmployeeIDExists(Transaction transaction)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM RentalTransactions " +
                                        "WHERE EmployeeID = @EmployeeID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("EmployeeID", transaction.EmployeeID);
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
        private static bool MemberIDExists(Transaction transaction)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM RentalTransactions " +
                                        "WHERE MemberID = @MemberID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("MemberID", transaction.MemberID);
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
