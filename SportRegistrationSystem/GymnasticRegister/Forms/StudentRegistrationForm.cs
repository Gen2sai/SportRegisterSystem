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
        private int StaffId;
        private int permission;

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } 

        public StudentRegistrationForm(int passedUsername, int passedPermission)
        {
            InitializeComponent();
            StaffId = passedUsername;
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
            StudentMenuForm form = new StudentMenuForm(StaffId, permission);
            form.Show();
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentMenuForm form = new StudentMenuForm(StaffId, permission);
            if (!Authenticate.Authentication(StaffId, permission)) return;
            if (txtStudentName != null)
            {
                bool registrationStatus = StudentBLL.RegisterStudent(txtStudentName.Text,
                    (int) System.Enum.Parse(typeof (GradeEnum), cbGrade.SelectedValue.ToString()),
                    Convert.ToInt32(txtAge.Text), Convert.ToInt32(txtContactNumber.Text), StaffId);
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

        private void KeydownHandler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }
    }
}
