using System;
using System.Data;
using System.Windows.Forms;
using GymnasticRegister.BusinessLogicLayer;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class StudentCheckForm : Form
    {
        private readonly int staffId;
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

        public StudentCheckForm(int staffID, int permission)
        {
            InitializeComponent();
            staffId = staffID;
            passedPermission = permission;
            lblStudent.Text = SportRegistrationSystem.lblStudentName;
            lblDesc.Text = SportRegistrationSystem.lblCheckFormDesc;
            btnCancel.Text = SportRegistrationSystem.lblCancel;
            btnSubmit.Text = SportRegistrationSystem.lblSubmit;
            DataTable dt = StudentBLL.GetLatePaymentByMonth();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbStudent.Items.Add(row["StudentName"].ToString());
                }
            }
            else
            {
                cbStudent.Items.Add(SportRegistrationSystem.lblClearedPayment);
            }
            cbStudent.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbStudent.Items[0] != SportRegistrationSystem.lblClearedPayment)
            {
                StudentPaymentForm form = new StudentPaymentForm(staffId, passedPermission, cbStudent.Text);
                form.Show();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentMenuForm form = new StudentMenuForm(staffId, passedPermission);
            form.Show();
            Close();
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
