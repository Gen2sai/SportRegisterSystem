using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GymnasticRegister.Model;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class MainMenuForm : Form
    {
        private string username;
        private int permission;

        public MainMenuForm(List<StaffClass> loginStatus)
        {
            InitializeComponent();
            btnStaffManagement.Text = SportRegistrationSystem.lblStaffManagement;
            btnStudentManagement.Text = SportRegistrationSystem.lblStudentManagement;
            username = loginStatus[0].Username;
            permission = loginStatus[0].PermissionId;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            //staff menu not implemented
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm(username, permission);
            form.Show();
            this.Hide();
        }
    }
}
