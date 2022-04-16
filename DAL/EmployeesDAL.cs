using RentMe.Model;
using RentMe.Validators;
using System;
using System.Collections.Generic;
using System.Data;
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
        /// Gets all RentMe Members from Members table.
        /// </summary>
        /// <returns>List of RentMe employees</returns>
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string selectStatement = "SELECT e.EmployeeID, e.Fname, e.Lname, e.DateOfBirth, e.Phone, " +
                                     "e.Sex, e.Address1, e.Address2, e.City, e.State, e.ZipCode, a.Username, " +
                                     "e.Employee_type, e.Active " +
                                     "FROM Employees e " +
                                     "JOIN Accounts a " +
                                     "ON e.AccountID = a.AccountID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                FName = reader["Fname"].ToString(),
                                LName = reader["Lname"].ToString(),
                                DOB = (DateTime)reader["DateOfBirth"],
                                Phone = reader["Phone"].ToString(),
                                Sex = reader["Sex"].ToString(),
                                Address1 = reader["Address1"].ToString(),
                                City = reader["City"].ToString(),
                                State = reader["State"].ToString(),
                                Zip = reader["ZipCode"].ToString(),
                                Username = reader["Username"].ToString(),
                                Type = reader["Employee_type"].ToString(),
                                Active = Convert.ToBoolean(Convert.ToInt32(reader["Active"]))
                        };
                            if (!reader.IsDBNull(8))
                            {
                                employee.Address2 = reader["Address2"].ToString();
                            }

                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

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
                                        "ON e.AccountID = a.AccountID " +
                                        "WHERE a.Username = @Username " +
                                        "AND a.Password = @Password " +
                                        "AND e.Active = 1";
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
        public static List<Employee> GetEmployeesFromSearch(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            List<Employee> employees = new List<Employee>();
            string selectStatement = "SELECT * " +
                                     "FROM Employees e " +
                                     "JOIN Accounts a " +
                                     "ON e.AccountID = a.AccountID " +
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
                            employee = new Employee
                            {
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                                FName = reader["Fname"].ToString(),
                                LName = reader["Lname"].ToString(),
                                DOB = (DateTime)reader["DateOfBirth"],
                                Phone = reader["Phone"].ToString(),
                                Sex = reader["Sex"].ToString(),
                                Address1 = reader["Address1"].ToString(),
                                City = reader["City"].ToString(),
                                State = reader["State"].ToString(),
                                Zip = reader["ZipCode"].ToString(),
                                Username = reader["Username"].ToString(),
                                Type = reader["Employee_type"].ToString(),
                                Active = Convert.ToBoolean(Convert.ToInt32(reader["Active"])),
                            };
                            if (!reader.IsDBNull(8))
                            {
                                employee.Address2 = reader["Address2"].ToString();
                            }

                            employees.Add(employee);
                            }
                    }
                }
            }

            return employees;
        }

        /// <summary>
        /// Gets the login employee data.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public static Employee GetLoginEmployeeData(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            string selectStatement = "SELECT * " +
                                        "FROM Employees e " +
                                        "JOIN Accounts a " +
                                        "ON a.AccountID = e.AccountID " +
                                        "WHERE a.Username = @Username";


            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("Username", employee.Username);
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
                            employee.Type = reader["Employee_type"].ToString();
                            employee.Active = Convert.ToBoolean(Convert.ToInt32(reader["Active"]));
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
                                     "@Sex, @Address1, @Address2, @City, @State, @Zip, (SELECT SCOPE_IDENTITY()), @Type, 1) " +
                                     "SELECT SCOPE_IDENTITY()";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {                
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {                    
                    using (SqlCommand selectCommand = new SqlCommand(insertStatement, connection, transaction))
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
                        transaction.Commit();
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw new ArgumentException("An employee account with that username already exists");
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

        /// <summary>
        /// Deactivates  or activate employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public static bool DeactivateORActivateEmployee(Employee employee)
        {
            string selectStatement;
            bool active;

            if (employee.Active) {
                selectStatement= "UPDATE Employees " +
                                 "SET ACTIVE = 0 " +
                                 "WHERE EmployeeID = @ID " +
                                 "AND ACTIVE = @flag";
                active = false;
            }
            else 
            {
                selectStatement = "UPDATE Employees " +
                                  "SET Active = 1 WHERE " +
                                  "EmployeeID = @ID " +
                                  "AND Active = @flag";
                active = true;
            }
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    
                    
                    selectCommand.Parameters.AddWithValue("ID", employee.EmployeeID);
                    selectCommand.Parameters.AddWithValue("flag", employee.Active);
                    if (selectCommand.ExecuteNonQuery() > 0)
                    {
                        employee.Active = active;
                        return true;
                    }
                    else
                    {
                        throw new ArgumentException("Employee deletion failed at database transaction");
                    }
                }
            }
        }

        /// <summary>
        /// Updates the employee details.
        /// </summary>
        /// <param name="oldEmployee">The old employee.</param>
        /// <param name="newEmployee">The new employee.</param>
        /// <returns>bool on successful or failed updates</returns>
        public static bool UpdateEmployeeDetails(Employee oldEmployee, Employee newEmployee)
        {
            string selectStatement =
                 " UPDATE Employees SET " +
                      " FNAME=@NewFName , LNAME=@NewLName , " +
                      " Sex=@NewSex , DateOfBirth=@NewDob , " +
                       " Phone=@NewPhone ,  City=@NewCity , " +
                      " zipcode=@NewZip , State=@NewState, " +
                      " Address1=@NewAddress1 , Address2=@NewAddress2, " +
                     
                      "EMPLOYEE_TYPE=@Newtype  " +
                       "Where EmployeeID=@oldEmployeeID  AND FNAME=@OldFName AND " +
                      " LNAME=@OldLName AND Sex=@OldSex AND " +
                      " DateOfBirth=@OldDob AND Phone=@OldPhone AND " +
                      " City=@OldCity AND zipcode=@OldZip AND State=@OldState AND " +
                      " (Address1=@OldAddress1 OR Address1 IS NULL) AND (Address2=@OldAddress2 OR Address2 IS NULL) AND " +
                      " EMPLOYEE_TYPE= @Oldtype";
           
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    // Old Employee details Mappings
                    selectCommand.Parameters.Add("@oldEmployeeID", SqlDbType.VarChar);
                    selectCommand.Parameters["@oldEmployeeID"].Value = oldEmployee.EmployeeID;

                    selectCommand.Parameters.Add("@OldFName", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldLName", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldSex", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldDob", SqlDbType.DateTime);
                    selectCommand.Parameters.Add("@OldPhone", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldCity", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldZip", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldState", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldAddress1", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@OldAddress2", SqlDbType.VarChar);
                    
                    selectCommand.Parameters.Add("@Oldtype", SqlDbType.VarChar);

                    selectCommand.Parameters["@OldFName"].Value = oldEmployee.FName;
                    selectCommand.Parameters["@OldLName"].Value = oldEmployee.LName;
                    selectCommand.Parameters["@OldSex"].Value = oldEmployee.Sex;
                    selectCommand.Parameters["@OldDob"].Value = oldEmployee.DOB;
                    selectCommand.Parameters["@OldPhone"].Value = oldEmployee.Phone;
                    selectCommand.Parameters["@OldCity"].Value = oldEmployee.City;
                    selectCommand.Parameters["@OldZip"].Value = oldEmployee.Zip;
                    selectCommand.Parameters["@OldState"].Value = oldEmployee.State;
                    selectCommand.Parameters["@OldAddress1"].Value = oldEmployee.Address1;
                    selectCommand.Parameters["@OldAddress2"].Value = oldEmployee.Address2;
                   
                    selectCommand.Parameters["@Oldtype"].Value = oldEmployee.Type;

                    // New Employee details Mappings
                    selectCommand.Parameters.Add("@NewFName", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewLName", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewSex", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewDob", SqlDbType.DateTime);
                    selectCommand.Parameters.Add("@NewPhone", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewCity", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewZip", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewState", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewAddress1", SqlDbType.VarChar);
                    selectCommand.Parameters.Add("@NewAddress2", SqlDbType.VarChar);

                   
                    selectCommand.Parameters.Add("@Newtype", SqlDbType.VarChar);

                    selectCommand.Parameters["@NewFName"].Value = newEmployee.FName;
                    selectCommand.Parameters["@NewLName"].Value = newEmployee.LName;
                    selectCommand.Parameters["@NewSex"].Value = newEmployee.Sex;
                    selectCommand.Parameters["@NewDob"].Value = newEmployee.DOB;
                    selectCommand.Parameters["@NewPhone"].Value = newEmployee.Phone;
                    selectCommand.Parameters["@NewCity"].Value = newEmployee.City;
                    selectCommand.Parameters["@NewZip"].Value = newEmployee.Zip;
                    selectCommand.Parameters["@NewState"].Value = newEmployee.State;
                    selectCommand.Parameters["@NewAddress1"].Value = newEmployee.Address1;
                    selectCommand.Parameters["@NewAddress2"].Value = newEmployee.Address2;
                 
                    selectCommand.Parameters["@Newtype"].Value = newEmployee.Type;
                    int resultCount = selectCommand.ExecuteNonQuery();
                    if (resultCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Determines whether [is password change] [the specified old employee].
        /// </summary>
        /// <param name="oldEmployee">The old employee.</param>
        /// <param name="newEmployee">The new employee.</param>
        /// <returns>
        ///   <c>true</c> if [is password change] [the specified old employee]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPasswordChange(Employee oldEmployee, Employee newEmployee)
        {

            string selectStatement=
                  "select count(*) from employees e join accounts a on a.AccountID = e.AccountID " +
                    "WHERE e.EmployeeID = @ID and a.username=@user AND a.Password <> @changedPassword";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("ID", oldEmployee.EmployeeID);
                    selectCommand.Parameters.AddWithValue("user", oldEmployee.Username);
                    selectCommand.Parameters.AddWithValue("changedPassword", newEmployee.Password);
                    //No change in password
                    return Convert.ToBoolean(selectCommand.ExecuteScalar());
                }
            }
        }


        /// <summary>
        /// Updates the password.
        /// </summary>
        /// <param name="oldEmployee">The old employee.</param>
        /// <param name="newEmployee">The new employee.</param>
        /// <returns></returns>
        public static bool UpdateEmployeeUserNameORPassword(Employee oldEmployee, Employee newEmployee)
        {
            string selectStatement = "";
            if (!string.IsNullOrEmpty(newEmployee.Username ) && !string.IsNullOrEmpty(newEmployee.Password) && newEmployee.Username != oldEmployee.Username) {
                selectStatement =
                     "UPDATE Accounts  set Accounts.Password = @newPassword , Accounts.username=@newUser from Employees e ,accounts a " +
                       "where a.username =@oldUser  and e.EmployeeID = @oldEmployee ";
            }
            else if (!string.IsNullOrEmpty(newEmployee.Username) && newEmployee.Username != oldEmployee.Username) {

                selectStatement =
                    "UPDATE Accounts  set  Accounts.username=@newUser from Employees e ,accounts a " +
                      "where a.username =@oldUser  and e.EmployeeID = @oldEmployee ";
            }
            else if (!string.IsNullOrEmpty(newEmployee.Password))
            {
                selectStatement =
                 "UPDATE Accounts  set Accounts.Password = @newPassword  from Employees e ,accounts a " +
                   "where a.username =@oldUser  and e.EmployeeID = @oldEmployee ";

            }

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("oldEmployee", oldEmployee.EmployeeID);
                    selectCommand.Parameters.AddWithValue("oldUser", oldEmployee.Username);
                    selectCommand.Parameters.AddWithValue("newPassword", newEmployee.Password);
                    selectCommand.Parameters.AddWithValue("newUser", newEmployee.Username);

                    int resultCount = selectCommand.ExecuteNonQuery();
                    if (resultCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
