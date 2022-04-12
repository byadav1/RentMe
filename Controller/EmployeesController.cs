using RentMe.DAL;
using RentMe.Model;
using RentMe.Validators;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the EmployeesDAL.
    /// </summary>
    public class EmployeesController
    {
        /// <summary>
        /// Gets all RentMe Employees from Employees table.
        /// </summary>
        /// <returns>List of RentMe members</returns>
        public List<Employee> GetEmployees()
        {
            return EmployeesDAL.GetEmployees();
        }

        /// <summary>
        /// Return true if employee account exists.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool ValidEmployeeLogin(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            return EmployeesDAL.ValidEmployeeLogin(employee);
        }

        /// <summary>
        /// Return true if employee password exists.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool Checkpassword(Employee employee,Employee updateEmployee)
        {          
            return EmployeesDAL.IsPasswordChange(employee, updateEmployee);
        }

        /// <summary>
        /// Return true if employee account exists
        /// based on search criteria.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Valid employee search</returns>
        public bool ValidEmployeeSearch(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            return EmployeesDAL.ValidEmployeeSearch(employee);
        }

        /// <summary>
        /// Return employee using search input.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Searched employee</returns>
        public List<Employee> GetEmployeesFromSearch(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            return EmployeesDAL.GetEmployeesFromSearch(employee);
        }

        /// <summary>
        /// Register a new RentMe employee.
        /// </summary>
        /// <param name="employee"></param>
        public void RegisterNewEmployee(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            EmployeesDAL.RegisterNewEmployee(employee);
        }

        /// <summary>
        /// Deletes  or restore employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Delete cannot be performed</exception>
        public bool DeleteOrRestoreEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Delete or restore cannot be performed ");
            }

            return EmployeesDAL.DeactivateORActivateEmployee(employee);
        }

        /// <summary>
        /// Get the login employee data
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Employee</returns>
        /// <exception cref="ArgumentNullException">Employee username cannot be null</exception>
        public Employee GetCurrentEmployeeData(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee username cannot be null ");
            }

            return EmployeesDAL.GetLoginEmployeeData(employee);
        }

        /// <summary>
        /// Updates the employee information.
        /// </summary>
        /// <param name="oldEmployee">The old employee.</param>
        /// <param name="newEmployee">The new employe.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Update cannot be performed with no change in data</exception>
        public bool UpdateEmployeeInformation(Employee oldEmployee, Employee newEmployee)
        {
            if (oldEmployee == null && newEmployee == null)
            {
                throw new ArgumentNullException("Update cannot be performed as there is no change in data");
            }

            return EmployeesDAL.UpdateEmployeeDetails(oldEmployee, newEmployee);
        }

        /// <summary>
        /// Updates the employee password.
        /// </summary>
        /// <param name="oldEmployee">The old employee.</param>
        /// <param name="newEmployee">The new employee.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Update cannot be performed as there is no change in data</exception>
       public bool UpdateEmployeeUserNameORPassword(Employee oldEmployee, Employee newEmployee)
        {
            if (oldEmployee == null && newEmployee == null)
            {
                throw new ArgumentNullException("Update cannot be performed as there is no change in data");
            }

            return EmployeesDAL.UpdateEmployeeUserNameORPassword(oldEmployee, newEmployee);
        }
    }
}
