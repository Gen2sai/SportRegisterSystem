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
            btnLogout.Text = SportRegistrationSystem.lblLogout;
            StaffId = loginStatus[0].StaffId;
            permission = loginStatus[0].PermissionId;
        }

        public MainMenuForm(int staffId, int passedPermission)
        {
            InitializeComponent();
            btnStaffManagement.Text = SportRegistrationSystem.lblStaffManagement;
            btnStudentManagement.Text = SportRegistrationSystem.lblStudentManagement;
            btnLogout.Text = SportRegistrationSystem.lblLogout;
            StaffId = staffId;
            permission = passedPermission;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            StaffMenuForm form = new StaffMenuForm(StaffId, permission);
            form.Show();
            this.Close();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentMenuForm form = new StudentMenuForm(StaffId, permission);
            form.Show();
            this.Close();
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
            this.Close();
        }
    }
}
