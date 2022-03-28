

using RentMe.DAL;
using RentMe.Model;
using RentMe.Validators;

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
        /// 0-param constructor.
        /// </summary>
        public EmployeesController()
        {
           
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
    }
}
