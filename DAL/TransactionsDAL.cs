using RentMe.Model;
using RentMe.Model.Validators;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RentMe.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the cs6232-g3 DB RentalTransactions table.
    /// </summary>
    public class TransactionsDAL
    {
        /// <summary>
        /// Gets all RentMe transactions
        /// </summary>
        /// <returns>RentMe Transaction list</returns>
        public static List<Transaction> GetTransactions()
        {
            List<Transaction> rentals = GetRentalTransactions();
            List<Transaction> returns = GetReturnTransactions();
            List<Transaction> transactions = rentals.Concat(returns).ToList();
            transactions = transactions.OrderBy(transaction => transaction.TransactionID)
                .ThenBy(transaction => transaction.TransactionType).ToList();

            return transactions;
        }

        /// <summary>
        /// Gets all RentMe Rental Transactions.
        /// </summary>
        /// <returns>List of RentMe Rental Transactions</returns>
        public static List<Transaction> GetRentalTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            string selectStatement = "SELECT rt.TransactionID, rt.EmployeeID, rt.MemberID, f.Name AS Furniture, " +
                                        "c.Name AS Category, s.Name AS Style, ri.Quantity, rt.RentDate, rt.DueDate, " +
                                        "(f.Daily_rental_rate * ri.Quantity) AS RentalCharge " +
                                        "FROM RentalTransactions rt " +
                                        "JOIN RentedItems ri " +
                                        "ON rt.TransactionID = ri.RentalTransactionID " +
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
                                TransactionType = "Rental",
                                TransactionID = Convert.ToInt32(reader["TransactionID"]),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                MemberID = Convert.ToInt32(reader["MemberID"]),
                                FurnitureName = reader["Furniture"].ToString(),
                                FurnitureCategory = reader["Category"].ToString(),
                                FurnitureStyle = reader["Style"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                RentalDate = (DateTime)reader["RentDate"],
                                DueDate = (DateTime)reader["DueDate"],
                                RentalCharge = decimal.Round(Convert.ToDecimal(reader["RentalCharge"].ToString()), 2, MidpointRounding.AwayFromZero)
                            };

                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        /// <summary>
        /// Gets all active RentMe Rental Transactions.
        /// </summary>
        /// <returns>List of active RentMe Rental Transactions</returns>
        public static List<Transaction> GetActiveRentalTransactions()
        {
            List<Transaction> rentals = GetRentalTransactions();
            List<Transaction> activeRentalTransactions = new List<Transaction>();

            foreach (Transaction transaction in rentals)
            {
                if (IsActiveRental(transaction))
                {
                    activeRentalTransactions.Add(transaction);
                }
            }

            return activeRentalTransactions;
        }

        /// <summary>
        /// Gets all RentMe Return Transactions.
        /// </summary>
        /// <returns>List of RentMe Return Transactions</returns>
        public static List<Transaction> GetReturnTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            string selectStatement = "SELECT rt.TransactionID, rtrn.EmployeeID, rt.MemberID, f.Name AS Furniture, " +
                                        "c.Name AS Category, s.Name AS Style, rtrn.Quantity, rt.RentDate, rt.DueDate, rtrn.ReturnDate, " +
                                        "(f.Daily_rental_rate * ri.Quantity) AS RentalCharge " +
                                        "FROM ReturnTransaction rtrn " +
                                        "JOIN RentedItems ri " +
                                        "ON rtrn.RentedItemsID = ri.RentedItemsID " +
                                        "JOIN RentalTransactions rt " +
                                        "ON ri.RentalTransactionID = rt.TransactionID " +
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
                                TransactionType = "Return",
                                TransactionID = Convert.ToInt32(reader["TransactionID"]),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                MemberID = Convert.ToInt32(reader["MemberID"]),
                                FurnitureName = reader["Furniture"].ToString(),
                                FurnitureCategory = reader["Category"].ToString(),
                                FurnitureStyle = reader["Style"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                RentalDate = (DateTime)reader["RentDate"],
                                DueDate = (DateTime)reader["DueDate"],
                                ReturnDate = (DateTime)reader["ReturnDate"],
                                RentalCharge = decimal.Round(Convert.ToDecimal(reader["RentalCharge"].ToString()), 2, MidpointRounding.AwayFromZero)
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
        /// Performs a search over RentMe transactions.
        /// </summary>
        /// <param name="transaction"></param>
        /// <param name="searchFilter"></param>
        /// <returns></returns>
        public static List<Transaction> SearchTransactions(Transaction transaction, string searchFilter)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            if (string.IsNullOrWhiteSpace(searchFilter))
            {
                throw new ArgumentException("Invalid search criteria");
            }

            _ = new List<Transaction>();
            List<Transaction> searchResults;
            switch (searchFilter)
            {
                case "All Transactions":
                    searchResults = GetTransactionsFromSearch(transaction);
                    break;
                case "Rentals":
                    searchResults = GetRentalsFromSearch(transaction, false);
                    break;
                case "Returns":
                    searchResults = GetReturnsFromSearch(transaction);
                    break;
                case "Active Rentals":
                    searchResults = GetRentalsFromSearch(transaction, true);
                    break;
                default:
                    throw new ArgumentException("No results");
            }

            return searchResults;
        }

        /// <summary>
        /// Returns Transaction list
        /// based on search input.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static List<Transaction> GetTransactionsFromSearch(Transaction transaction)
        {
            List<Transaction> rentals = GetRentalsFromSearch(transaction, false);
            List<Transaction> returns = GetReturnsFromSearch(transaction);
            List<Transaction> transactions = rentals.Concat(returns).ToList();
            transactions = transactions.OrderBy(t => t.TransactionID)
                .ThenBy(t => t.TransactionType).ToList();

            return transactions;
        }

        /// <summary>
        /// Returns Transaction list
        /// based on search input.
        /// </summary>
        /// <param name="rentalTransaction"></param>
        /// <returns>RentalTransaction list</returns>
        public static List<Transaction> GetRentalsFromSearch(Transaction transaction, bool activeOnly)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            List<Transaction> transactions = new List<Transaction>();
            string selectStatement = "SELECT rt.TransactionID, rt.EmployeeID, rt.MemberID, f.Name AS Furniture, " +
                                     "c.Name AS Category, s.Name AS Style, ri.Quantity, rt.RentDate, rt.DueDate, " +
                                     "(f.Daily_rental_rate * ri.Quantity) AS RentalCharge " +
                                     "FROM RentalTransactions rt " +
                                     "JOIN RentedItems ri " +
                                     "ON rt.TransactionID = ri.RentalTransactionID " +
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
                                TransactionType = "Rental",
                                TransactionID = Convert.ToInt32(reader["TransactionID"]),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                MemberID = Convert.ToInt32(reader["MemberID"]),
                                FurnitureName = reader["Furniture"].ToString(),
                                FurnitureCategory = reader["Category"].ToString(),
                                FurnitureStyle = reader["Style"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                RentalDate = (DateTime)reader["RentDate"],
                                DueDate = (DateTime)reader["DueDate"],
                                RentalCharge = decimal.Round(Convert.ToDecimal(reader["RentalCharge"].ToString()), 2, MidpointRounding.AwayFromZero)
                            };
                            if ((activeOnly && IsActiveRental(transaction)) || !activeOnly)
                            {
                                Console.WriteLine(IsActiveRental(transaction));
                                transactions.Add(transaction);
                            }
                        }
                    }
                }
            }

            return transactions;
        }

        /// <summary>
        /// Returns Transaction list
        /// based on search input.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns>Transaction returns list</returns>
        public static List<Transaction> GetReturnsFromSearch(Transaction transaction)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            List<Transaction> transactions = new List<Transaction>();
            string selectStatement = "SELECT rt.TransactionID, rtrn.EmployeeID, rt.MemberID, f.Name AS Furniture, " +
                                        "c.Name AS Category, s.Name AS Style, rtrn.Quantity, rt.RentDate, rt.DueDate, rtrn.ReturnDate, " +
                                        "(f.Daily_rental_rate * ri.Quantity) AS RentalCharge " +
                                        "FROM ReturnTransaction rtrn " +
                                        "JOIN RentedItems ri " +
                                        "ON rtrn.RentedItemsID = ri.RentedItemsID " +
                                        "JOIN RentalTransactions rt " +
                                        "ON ri.RentalTransactionID = rt.TransactionID " +
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
                selectStatement += "rtrn.EmployeeID = @EmployeeID";
            }
            else if (MemberIDExists(transaction))
            {
                selectStatement += "rt.MemberID = @MemberID";
            }
            else
            {
                throw new ArgumentException("Must search a return transaction by ID of either transaction, employee, or member");
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
                                TransactionType = "Return",
                                TransactionID = Convert.ToInt32(reader["TransactionID"]),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                MemberID = Convert.ToInt32(reader["MemberID"]),
                                FurnitureName = reader["Furniture"].ToString(),
                                FurnitureCategory = reader["Category"].ToString(),
                                FurnitureStyle = reader["Style"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                RentalDate = (DateTime)reader["RentDate"],
                                DueDate = (DateTime)reader["DueDate"],
                                ReturnDate = (DateTime)reader["ReturnDate"],
                                RentalCharge = decimal.Round(Convert.ToDecimal(reader["RentalCharge"].ToString()), 2, MidpointRounding.AwayFromZero)
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

        /// <summary>
        /// Returns true if rental is still active.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        private static bool IsActiveRental(Transaction transaction)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            string selectStatement = "SELECT ri.RentalTransactionID, ri.RentedItemsID, ri.FurnitureID, ri.Quantity, SUM(rtrn.Quantity) " +
                                        "FROM RentedItems ri " +
                                        "JOIN ReturnTransaction rtrn " +
                                        "ON ri.RentedItemsID = rtrn.RentedItemsID " +
                                        "WHERE ri.RentalTransactionID = @TransactionID " +
                                        "GROUP BY ri.RentalTransactionID, ri.RentedItemsID, ri.FurnitureID, ri.Quantity " +
                                        "HAVING ri.Quantity - SUM(rtrn.Quantity) = 0";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("TransactionID", transaction.TransactionID);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return false;
                    }

                    return true;
                }
            }
        }
    }
}
