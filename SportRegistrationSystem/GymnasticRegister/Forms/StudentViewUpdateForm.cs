using System;
using System.Data;
using System.Windows.Forms;
using GymnasticRegister.BusinessLogicLayer;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class StudentViewUpdateForm : Form
    {
        private readonly int StaffId;
        private readonly int passedPermission;

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

        public StudentViewUpdateForm(int username, int permission)
        {
            StaffId = username;
            passedPermission = permission;
            InitializeComponent();
            DataTable dt = StudentBLL.LoadStudent();
            dataGridView1.DataSource = dt;
            btnBack.Text = SportRegistrationSystem.lblBack;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMenuForm form = new StudentMenuForm(StaffId, passedPermission);
            form.Show();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            StudentBLL.UpdateStudentTable(dt);
            StudentMenuForm form = new StudentMenuForm(StaffId, passedPermission);
            form.Show();
            Close();
        }
    }
}
