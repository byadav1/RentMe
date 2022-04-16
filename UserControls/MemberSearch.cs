using RentMe.Controller;
using RentMe.Model;
using RentMe.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// This UserControl models a search form
    /// which will allow the user to view registered
    /// RentMe Members. This UserControl also directs
    /// the user to register a new Member or edit
    /// an existing Member's information.
    /// </summary>
    public partial class MemberSearch : UserControl
    {
        private readonly MembersController membersController;
        private List<Member> memberSearchResults;

        /// <summary>
        /// Initialize the UserControl.
        /// </summary>
        public MemberSearch()
        {
            InitializeComponent();
            this.membersController = new MembersController();
            this.RefreshControl();
        }

        /// <summary>
        /// Refreshes the DataGridView to display
        /// all RentMe Members.
        /// </summary>
        public void RefreshControl()
        {
            List<Member> members = this.membersController.GetMembers();
            this.DisplayMembersList(members);
            this.viewAllMembersButton.Enabled = false;
            this.searchMemberTextBox.Clear();
        }

        /// <summary>
        /// Event Handler for Search button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButtonClick(object sender, EventArgs e)
        {
            try
            {
                Member member = this.CreateMemberFromSearch();
                if (this.membersController.ValidMemberSearch(member))
                {
                    this.memberSearchResults = this.membersController.GetMembersFromSearch(member);
                    this.DisplayMembersList(this.memberSearchResults);
                    this.viewAllMembersButton.Enabled = true;
                }
            }
            catch (ArgumentException ae)
            {
                this.UpdateStatusMessage(ae.Message, true);               
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);                
            }
        }

        /// <summary>
        /// Event handler for Update button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.memberDataGridView.SelectedRows[0];
                Member member = new Member
                {
                    MemberID = Convert.ToInt32(row.Cells["memberID"].Value),
                    FName = row.Cells["fname"].Value.ToString(),
                    LName = row.Cells["lname"].Value.ToString(),
                    DOB = (DateTime)row.Cells["dob"].Value,
                    Phone = row.Cells["phone"].Value.ToString(),
                    Sex = row.Cells["sex"].Value.ToString(),
                    Address1 = row.Cells["address1"].Value.ToString(),
                    Address2 = row.Cells["address2"].Value.ToString(),
                    City = row.Cells["city"].Value.ToString(),
                    State = row.Cells["state"].Value.ToString(),
                    Zip = row.Cells["zip"].Value.ToString()
                };

                Form employeeServicesDialog = new MemberServicesDialog(true, member);
                Form owner = ((Form)this.TopLevelControl);
                owner.Hide();
                DialogResult result = employeeServicesDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    owner.Show();
                    this.RefreshControl();
                }
            }
            catch (Exception ex)
            {
                this.UpdateStatusMessage(ex.Message, true);
            }
            
        }

        /// <summary>
        /// Event Handler for Register member button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButtonClick(object sender, EventArgs e)
        {
            Form employeeServicesDialog = new MemberServicesDialog(false, new Member());
            Form owner = ((Form)this.TopLevelControl);
            owner.Hide();
            DialogResult result = employeeServicesDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                owner.Show();
                this.RefreshControl();
            }
        }

        /// <summary>
        /// Event Handler for View All Members button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAllMembersButtonClick(object sender, EventArgs e)
        {
            this.RefreshControl();
        }

        /// <summary>
        /// Display all RentMe members.
        /// </summary>
        private void DisplayMembersList(List<Member> members)
        {
            if (members == null)
            {
                throw new ArgumentException("Members list cannot be null");
            }
            if (members.Count < 1)
            {
                throw new ArgumentException("No RentMe members exist");
            }
            else
            {
                this.memberBindingSource.Clear();
                this.memberBindingSource.DataSource = members;
                this.DecorateDataGridView();
                this.updateButton.Enabled = true;
            }
        }

        /// <summary>
        /// Configures the appearance of Members DataGridView.
        /// </summary>
        private void DecorateDataGridView()
        {
            foreach (DataGridViewRow row in this.memberDataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        /// <summary>
        /// Takes input from the search field
        /// and returns a Member.
        /// </summary>
        /// <returns></returns>
        private Member CreateMemberFromSearch()
        {
            Member member = new Member();
            TextBox search = this.searchMemberTextBox;
            if (search.Text == "")
            {
                throw new ArgumentException("Member search field cannot be empty");
            }
            else if (new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$").IsMatch(search.Text))
            {
                member.Phone = search.Text;

            }
            else if (new Regex("[a-zA-Z] [a-zA-Z]").IsMatch(search.Text))
            {
                member.FName = search.Text.Substring(0, search.Text.IndexOf(" "));
                member.LName = search.Text.Substring(search.Text.IndexOf(" ") + 1);
            }
            else if (Int32.TryParse(search.Text, out int memberID))
            {
                member.MemberID = memberID;
            }

            return member;
        }

        /// <summary>
        /// Updates the error message to reflect 
        /// the status of the form.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isError"></param>
        private void UpdateStatusMessage(string message, bool isError)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("Message cannot be null or empty");
            }

            if (isError)
            {
                this.statusMessage.ForeColor = Color.Red;
            }
            else
            {
                this.statusMessage.ForeColor = Color.Black;
            }

            this.statusMessage.Text = message;
            this.statusMessage.Visible = true;
        }

        /// <summary>
        /// Event Handler for TextField text changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchMemberTextBoxTextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.searchMemberTextBox.Text))
            {
                this.searchButton.Enabled = false;
            }
            else
            {
                this.searchButton.Enabled = true;
            }
        }
    }
}
