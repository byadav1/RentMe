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
    public class RentalTransactionsDAL
    {
        /// <summary>
        /// Gets all Transactions from RentalTransactions table.
        /// </summary>
        /// <returns>List of RentMe Rental Transactions</returns>
        public static List<RentalTransaction> GetRentalTransactions()
        {          
            List<RentalTransaction> rentalTransactions = new List<RentalTransaction>();
            string selectStatement = "SELECT TransactionID, RentDate, DueDate, EmployeeID, MemberID " +
                                        "FROM RentalTransactions";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalTransaction rentalTransaction = new RentalTransaction
                            {
                                TransactionID = Convert.ToInt32(reader["TransactionID"]),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                MemberID = Convert.ToInt32(reader["MemberID"]),
                                RentalDate = (DateTime)reader["RentDate"],
                                DueDate = (DateTime)reader["DueDate"]
                            };

                            rentalTransactions.Add(rentalTransaction);
                        }
                    }
                }
            }

            return rentalTransactions;
        }

        /// <summary>
        /// Return true if Rental Transaction
        /// exists based on search criteria.
        /// </summary>
        /// <param name="rentalTransaction"></param>
        /// <returns>true if valid search</returns>
        public static bool ValidTransactionSearch(RentalTransaction rentalTransaction)
        {
            RentalTransactionValidator.ValidateRentalTransactionNotNull(rentalTransaction);
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
        /// Returns RentalTransaction list
        /// based on search input.
        /// </summary>
        /// <param name="rentalTransaction"></param>
        /// <returns>RentalTransaction list</returns>
        public static List<RentalTransaction> GetRentalTransactionsFromSearch(RentalTransaction rentalTransaction)
        {
            RentalTransactionValidator.ValidateRentalTransactionNotNull(rentalTransaction);           
            List<RentalTransaction> rentalTransactions = new List<RentalTransaction>();
            string selectStatement = "SELECT * " +
                                        "FROM RentalTransactions " +
                                        "WHERE ";
            if (TransactionIDExists(rentalTransaction))
            {
                selectStatement += "TransactionID = @TransactionID";
            }
            else if (EmployeeIDExists(rentalTransaction))
            {
                selectStatement += "EmployeeID = @EmployeeID";
            }
            else if (MemberIDExists(rentalTransaction))
            {
                selectStatement += "MemberID = @MemberID";
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
                    if (TransactionIDExists(rentalTransaction))
                    {
                        selectCommand.Parameters.AddWithValue("TransactionID", rentalTransaction.TransactionID);
                    }
                    else if (EmployeeIDExists(rentalTransaction))
                    {
                        selectCommand.Parameters.AddWithValue("EmployeeID", rentalTransaction.EmployeeID);
                    }
                    else if (MemberIDExists(rentalTransaction))
                    {
                        selectCommand.Parameters.AddWithValue("MemberID", rentalTransaction.MemberID);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentalTransaction = new RentalTransaction
                            {
                                TransactionID = Convert.ToInt32(reader["TransactionID"]),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                MemberID = Convert.ToInt32(reader["MemberID"]),
                                RentalDate = (DateTime)reader["RentDate"],
                                DueDate = (DateTime)reader["DueDate"]
                            };

                            rentalTransactions.Add(rentalTransaction);
                        }
                    }
                }
            }

            return rentalTransactions;
        }

        /// <summary>
        /// Return true if TransactionID exists.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private static bool TransactionIDExists(RentalTransaction rentalTransaction)
        {
            RentalTransactionValidator.ValidateRentalTransactionNotNull(rentalTransaction);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM RentalTransactions " +
                                        "WHERE TransactionID = @TransactionID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("TransactionID", rentalTransaction.TransactionID);
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
        private static bool EmployeeIDExists(RentalTransaction rentalTransaction)
        {
            RentalTransactionValidator.ValidateRentalTransactionNotNull(rentalTransaction);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM RentalTransactions " +
                                        "WHERE EmployeeID = @EmployeeID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("EmployeeID", rentalTransaction.EmployeeID);
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
        private static bool MemberIDExists(RentalTransaction rentalTransaction)
        {
            RentalTransactionValidator.ValidateRentalTransactionNotNull(rentalTransaction);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM RentalTransactions " +
                                        "WHERE MemberID = @MemberID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("MemberID", rentalTransaction.MemberID);
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
