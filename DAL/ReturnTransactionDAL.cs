using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
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
