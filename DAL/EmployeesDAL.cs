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

        /// <summary>
        /// Return true if Employee matches search criteria
        /// EmployeeID, Phone, or Full Name.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static bool ValidEmployeeSearch(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            if (EmployeeIDExists(employee) || EmployeePhoneExists(employee) || EmployeeNameExists(employee))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("No search results");
            }
        }

        /// <summary>
        /// Return Employee information based upon search.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Searched employee</returns>
        public static Employee GetEmployeeFromSearch(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            string selectStatement = "SELECT * " +
                                        "FROM Employees " +
                                        "WHERE ";
            if (EmployeeIDExists(employee))
            {
                selectStatement += "EmployeeID = @EmployeeID";
            }
            else if (EmployeePhoneExists(employee))
            {
                selectStatement += "Phone = @Phone";
            }
            else if (EmployeeNameExists(employee))
            {
                selectStatement += "Fname = @FName AND Lname = @LName";
            }
            else
            {
                throw new ArgumentException("Must search an employee by their ID, Phone, or Name");
            }

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (EmployeeIDExists(employee))
                    {
                        selectCommand.Parameters.AddWithValue("EmployeeID", employee.EmployeeID);
                    }
                    else if (EmployeePhoneExists(employee))
                    {
                        selectCommand.Parameters.AddWithValue("Phone", employee.Phone);
                    }
                    else if (EmployeeNameExists(employee))
                    {
                        selectCommand.Parameters.AddWithValue("FName", employee.FName);
                        selectCommand.Parameters.AddWithValue("LName", employee.LName);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                            employee.FName = reader["Fname"].ToString();
                            employee.LName = reader["Lname"].ToString();
                            employee.DOB = (DateTime)reader["DateOfBirth"];
                            employee.Phone = reader["Phone"].ToString();
                            employee.Sex = reader["Sex"].ToString();
                            employee.Address1 = reader["Address1"].ToString();
                            if (!reader.IsDBNull(8))
                            {
                                employee.Address2 = reader["Address2"].ToString();
                            }
                            employee.City = reader["City"].ToString();
                            employee.State = reader["State"].ToString();
                            employee.Zip = reader["ZipCode"].ToString();
                            employee.Username = reader["Username"].ToString();
                        }
                    }
                }
            }

            return employee;
        }

        /// <summary>
        /// Register and return a new RentMe Employee.
        /// </summary>
        /// <param name="employee"></param>
        public static void RegisterNewEmployee(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            string insertStatement = "INSERT INTO Accounts " +
                                     "VALUES(@Username, @Password)" +
                                     "INSERT INTO Employees " +
                                     "VALUES(@FName, @LName, @DOB, @Phone, " +
                                     "@Sex, @Address1, @Address2, @City, @State, @Zip, @Username, @Type) " +
                                     "SELECT SCOPE_IDENTITY()";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(insertStatement, connection))
                {
                    try
                    {
                    selectCommand.Parameters.AddWithValue("Username", employee.Username);
                    selectCommand.Parameters.AddWithValue("Password", employee.Password);
                    selectCommand.Parameters.AddWithValue("FName", employee.FName);
                    selectCommand.Parameters.AddWithValue("LName", employee.LName);
                    selectCommand.Parameters.AddWithValue("DOB", employee.DOB);
                    selectCommand.Parameters.AddWithValue("Phone", employee.Phone);
                    selectCommand.Parameters.AddWithValue("Sex", employee.Sex);
                    selectCommand.Parameters.AddWithValue("Address1", employee.Address1);
                    if (string.IsNullOrEmpty(employee.Address2))
                    {
                        selectCommand.Parameters.AddWithValue("Address2", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("Address2", employee.Address2);
                    }
                    selectCommand.Parameters.AddWithValue("City", employee.City);
                    selectCommand.Parameters.AddWithValue("State", employee.State);
                    selectCommand.Parameters.AddWithValue("Zip", employee.Zip);
                    selectCommand.Parameters.AddWithValue("Type", employee.Type);
                    
                    employee.EmployeeID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("An employee account with that username already exists");
                    }
                    
                }
            }
        }

        /// <summary>
        /// Return true if EmployeeID exists.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        private static bool EmployeeIDExists(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM Employees " +
                                        "WHERE EmployeeID = @EmployeeID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("EmployeeID", employee.EmployeeID);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Return true if Phone exists.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        private static bool EmployeePhoneExists(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            if (string.IsNullOrEmpty(employee.Phone))
            {
                return false;
            }
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM Employees " +
                                        "WHERE Phone = @Phone";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("Phone", employee.Phone);
                    if (Convert.ToBoolean(selectCommand.ExecuteScalar()))
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Return true if FName and LName exists.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        private static bool EmployeeNameExists(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            if (string.IsNullOrEmpty(employee.FName) || string.IsNullOrEmpty(employee.LName))
            {
                return false;
            }
            string selectStatement = "SELECT COUNT(*) " +
                                        "FROM Employees " +
                                        "WHERE Fname = @FName AND Lname = @LName";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("FName", employee.FName);
                    selectCommand.Parameters.AddWithValue("LName", employee.LName);
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
