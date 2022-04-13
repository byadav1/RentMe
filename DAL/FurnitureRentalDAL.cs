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
        private static List<RentFurniture> _rentCartItems = new List<RentFurniture>();


        public static void AddRentalItems(List<RentFurniture> itemList)
        {
            int count = 1;
            foreach (RentFurniture rentItem in itemList)
            {
                using (SqlConnection connection = RentMeDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand("spCreateFurnitureRental", connection))
                    {


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


        public static List<RentFurniture> GetCartItems(Member rentMember)
        {

            List<RentFurniture> cartItems = new List<RentFurniture>();

            string selectStatement = "select ri.FurnitureID,f.Name, f.Description,c.Name as categoryName, " +
                "   s.name as styleName," +
                "   ri.Quantity as Number_of_Items," +
                "    ri.Quantity* f.Daily_rental_rate * 10 as RentalAmount" +
                "   from RentedItems ri join RentalTransactions rt on rt.TransactionID = ri.RentalTransactionID" +
                "   join Furnitures f on f.furnitureID = ri.furnitureID " +
                "   join Categories c on c.CategoryID = f.CategoryID" +
                "    join Styles s on s.StyleID = f.StyleID" +
                "    join Employees e on e.EmployeeID = rt.EmployeeID" +
                "   join Members m on m.MemberID = rt.MemberID" +
                "    where rt.MemberID = @ID order by furnitureID";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.Add("@ID", SqlDbType.Int);
                    selectCommand.Parameters["@ID"].Value = rentMember.MemberID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            RentFurniture cartDetails = new RentFurniture();

                            cartDetails.FurnitureID = (int)reader["FurnitureID"];
                            cartDetails.Name = reader["Name"].ToString();
                            cartDetails.Description = reader["Description"].ToString();
                            cartDetails.Category = reader["categoryName"].ToString();
                            cartDetails.Style = reader["styleName"].ToString();
                            cartDetails.FurnitureRentQuantity = (int)reader["Number_of_Items"];
                            decimal Price = Convert.ToDecimal(reader["RentalAmount"]);
                            cartDetails.RentalAmount = (float)Price;

                            cartItems.Add(cartDetails);
                        }
                    }
                }
            }
            return cartItems;

        }
    }
}
