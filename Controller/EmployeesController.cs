

using RentMe.DAL;
using RentMe.Model;
using RentMe.Validators;
using System;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the EmployeesDAL.
    /// </summary>
    public class EmployeesController
    {
        private readonly EmployeesDAL employee_DBresource;
        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public EmployeesController()
        {
            this.employee_DBresource = new EmployeesDAL();
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
        public Employee GetEmployeeFromSearch(Employee employee)
        {
            EmployeeValidator.ValidateEmployeeNotNull(employee);
            return EmployeesDAL.GetEmployeeFromSearch(employee);
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
        /// Deletes the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Delete cannot be performed</exception>
        public bool DeleteEmployee(Employee employee)
        {

            if (employee == null)
            {
                throw new ArgumentNullException("Delete cannot be performed ");
            }
            return this.employee_DBresource.DeactivateEmployee(employee);
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
                throw new ArgumentNullException("Update cannot be performed with no change in data");
            }
            return this.employee_DBresource.UpdateEmployeeDetails(oldEmployee, newEmployee);
        }

    }
}
