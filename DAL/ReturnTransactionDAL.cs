using RentMe.Model;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the cs6232-g3 DB Employees Return Table.
    /// </summary>
    public class ReturnTransactionDAL
    {

        /// <summary>
        /// Add return furnitures to database
        /// </summary>
        /// <param name="returnTransaction"></param>
        public void AddReturnFurniture(ReturnTransaction returnTransaction)
        {
            string insertStatement =
                "INSERT ReturnTransaction " +
                "(RentedItemsID, Quantity, EmployeeID, ReturnDate) " +
                "VALUES(@RentedItemsID, @Quantity, @EmployeeID, @ReturnDate)";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@RentedItemsID", returnTransaction.RentedItemsID);
                    insertCommand.Parameters.AddWithValue("@Quantity", returnTransaction.Quantity);
                    insertCommand.Parameters.AddWithValue("@EmployeeID", returnTransaction.EmployeeID);
                    insertCommand.Parameters.AddWithValue("@ReturnDate", returnTransaction.ReturnDate);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
