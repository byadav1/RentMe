using RentMe.Model;
using RentMe.Validators;
using System;
using System.Data.SqlClient;

namespace RentMe.DAL
{   
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the cs6232-g3 DB Employees table.
    /// </summary>
    public class EmployeesDAL
    {
        /// <summary>
        /// Return true if Employee account exists.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static bool ValidEmployeeLogin(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            string selectStatement = "SELECT COUNT(e.EmployeeID) " +
                                        "FROM Employees e " +
                                        "JOIN Accounts a " +
                                        "ON e.Username = a.Username " +
                                        "WHERE a.Username = @Username " +
                                        "AND a.Password = @Password";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("Username", employee.Username);
                    selectCommand.Parameters.AddWithValue("Password", employee.Password);
                    if (!Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        throw new ArgumentException("Invalid employee username or password");
                    }

                    return true;
                }
            }
        }
    }
}
