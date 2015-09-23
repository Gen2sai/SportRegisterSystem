using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GymnasticRegister.Model;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class MainMenuForm : Form
    {
        private int StaffId;
        private int permission;

        public MainMenuForm(List<StaffClass> loginStatus)
        {
            InitializeComponent();
            btnStaffManagement.Text = SportRegistrationSystem.lblStaffManagement;
            btnStudentManagement.Text = SportRegistrationSystem.lblStudentManagement;
            btnRegister.Text = SportRegistrationSystem.lblRegister;
            btnLogout.Text = SportRegistrationSystem.lblLogout;
            StaffId = loginStatus[0].StaffId;
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
            StudentForm form = new StudentForm(StaffId, permission);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StaffRegistrationForm form = new StaffRegistrationForm();
            form.Show();
            this.Hide();
        }
    }
}
