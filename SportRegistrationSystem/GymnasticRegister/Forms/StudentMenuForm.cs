using System;
using System.Windows.Forms;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class StudentMenuForm : Form
    {
        private int StaffId;
        private int permission;

        public StudentMenuForm(int passedStaffId, int passedPermission)
        {
            InitializeComponent();
            StaffId = passedStaffId;
            permission = passedPermission;
            btnAddStudent.Text = SportRegistrationSystem.lblAddStudent;
            btnStudentManagement.Text = SportRegistrationSystem.lblStudentManagement;
            btnCheckPayment.Text = SportRegistrationSystem.lblCheckPayment;
            btnPayment.Text = SportRegistrationSystem.lblPayment;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentRegistrationForm form = new StudentRegistrationForm(StaffId, permission);
            form.Show();
            this.Hide();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentViewUpdateForm form = new StudentViewUpdateForm(StaffId, permission);
            form.Show();
            this.Hide();
        }

        private void btnCheckPayment_Click(object sender, EventArgs e)
        {
            StudentCheckForm form = new StudentCheckForm(StaffId, permission);
            form.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            StudentPaymentForm form = new StudentPaymentForm(StaffId, permission);
            form.Show();
            this.Hide();
        }
    }
}
