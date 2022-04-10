using RentMe.Model;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class EmployeeServicesForm : Form
    {
        public EmployeeServicesForm(bool isUpdate, Employee employee)
        {
            InitializeComponent();
            this.employeeServices.IsUpdate = isUpdate;
            this.employeeServices.SearchedEmployee = employee;
        }

        private void EmployeeServicesFormFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
