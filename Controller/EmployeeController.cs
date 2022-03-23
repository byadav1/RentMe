using RentMe.DAL;
using RentMe.Model;
using RentMe.Validators;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the EmloyeesDAL.
    /// </summary>
    public class EmployeeController
    {
        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public EmployeeController()
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
    }
}
