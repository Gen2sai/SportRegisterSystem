using System;
using System.Windows.Forms;
using GymnasticRegister.BusinessLogicLayer;
using GymnasticRegister.Enum;
using GymnasticRegister.Helper;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class StudentRegistrationForm : Form
    {
        private string username;
        private int permission;

        public StudentRegistrationForm(string passedUsername, int passedPermission)
        {
            InitializeComponent();
            username = passedUsername;
            permission = passedPermission;
            lblStudentName.Text = SportRegistrationSystem.lblStudentName;
            lblGrade.Text = SportRegistrationSystem.lblGrade;
            lblAge.Text = SportRegistrationSystem.lblAge;
            lblContactNumber.Text = SportRegistrationSystem.lblContactNumber;
            btnCancel.Text = SportRegistrationSystem.lblCancel;
            btnSubmit.Text = SportRegistrationSystem.lblSubmit;
            cbGrade.DataSource = System.Enum.GetValues(typeof (GradeEnum));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm(username, permission);
            form.Show();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm(username, permission);
            if (!Authenticate.Authentication(username, permission)) return;
            if (txtStudentName != null)
            {
                bool registrationStatus = StudentBLL.RegisterStudent(txtStudentName.Text,
                    (int) System.Enum.Parse(typeof (GradeEnum), cbGrade.SelectedValue.ToString()),
                    Convert.ToInt32(txtAge.Text), Convert.ToInt32(txtContactNumber.Text), username);
                MessageBox.Show(registrationStatus
                    ? SportRegistrationSystem.lblRegisterSuccess
                    : SportRegistrationSystem.lblRegisterFailed);
                if (registrationStatus)
                {
                    form.Show();
                    this.Dispose();
                }
            }
        }
    }
}
