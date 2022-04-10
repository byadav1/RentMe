using RentMe.Model;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class MemberServicesForm : Form
    {
        public MemberServicesForm(bool isUpdate, Member member)
        {
            InitializeComponent();
            this.memberServices.IsUpdate = isUpdate;
            this.memberServices.SearchedMember = member;
        }

        private void ServicesFormFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
