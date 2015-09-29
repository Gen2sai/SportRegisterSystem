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
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentMenuForm form = new StudentMenuForm(staffId, passedPermission);
            form.Show();
            this.Close();
        }
    }
}
