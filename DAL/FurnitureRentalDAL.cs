using System;
using System.Data.SqlClient;
using RentMe.Model;
using RentMe.Model.Validators;
using System.Collections.Generic;
using System.Data;

namespace RentMe.DAL
{
    /// <summary>
    /// Database class for furniture rental database transaction to rent a furniture
    /// </summary>
    public class FurnitureRentalDAL
    {
        public static void AddRentalItems(List <RentFurniture> itemList)
        {
            int count = 1;
            foreach (RentFurniture rentItem in itemList) {
                using (SqlConnection connection = RentMeDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand("spCreateFurnitureRental", connection))                  {
  

                        selectCommand.CommandType = CommandType.StoredProcedure;
                        selectCommand.Parameters.Add("@MemberID", SqlDbType.Int).Value = rentItem.FurnitureRentMemberID;
                        selectCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = rentItem.FurnitureRentQuantity;
                        selectCommand.Parameters.Add("@FurnitureID", SqlDbType.Int).Value = rentItem.FurnitureID;
                        selectCommand.Parameters.Add("@SequenceID ", SqlDbType.Int).Value = count;
                        selectCommand.Parameters.Add("@DueDate ", SqlDbType.DateTime).Value = "2022-01-01";
                        selectCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = rentItem.FurnitureRentEmployeeID;
                        selectCommand.ExecuteNonQuery();
                        count++;

                    }
                }
            }
        }
    }
}
