using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymnasticRegister.BusinessLogicLayer;
using GymnasticRegister.Enum;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class StudentPayment : Form
    {
        private const string dateFormat = "MMM/yyyy";
        private readonly int StaffId;
        private readonly int passedPermission;
        private int tempStudentID;
        public StudentPayment(int username, int permission)
        {
            InitializeComponent();
            StaffId = username;
            passedPermission = permission;
            lblStudentName.Text = SportRegistrationSystem.lblStudentName;
            lblGrade.Text = SportRegistrationSystem.lblGrade;
            lblAge.Text = SportRegistrationSystem.lblAge;
            lblPayableAmt.Text = SportRegistrationSystem.lblPayableAmt;
            lblDate.Text = SportRegistrationSystem.lblDate;
            lblLastPaid.Text = SportRegistrationSystem.lblLastPaid;
            lblRemark.Text = SportRegistrationSystem.lblRemark;
            dtpDate.CustomFormat = dateFormat;
            dtpDate.Format = DateTimePickerFormat.Custom;
            btnSubmit.Text = SportRegistrationSystem.lblSubmit;
            btnCancel.Text = SportRegistrationSystem.lblCancel;
            DataTable dt = StudentBLL.LoadStudent();
            List<string> studentNameList = StudentBLL.GetStudentName(dt);
            foreach (string student in studentNameList)
            {
                cbStudentName.Items.Add(student);
            }
            cbStudentName.SelectedIndex = 0;

        }

        private void txtPayableAmt_KeyPresss(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = StudentBLL.GetStudentInfo(cbStudentName.SelectedItem.ToString());

            if (dt != null)
            {
                tempStudentID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                lblStudentGrade.Text = dt.Rows[0].ItemArray[2].ToString();
                lblStudentAge.Text = dt.Rows[0].ItemArray[3].ToString();
                lblStudentLastPaid.Text = dt.Rows[0].ItemArray[4].ToString() != "" ? DateTime.Parse(dt.Rows[0].ItemArray[4].ToString()).ToString(dateFormat) : SportRegistrationSystem.lblNoLastPayment;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm(StaffId, passedPermission);
            form.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int result = StudentBLL.MakePayment(tempStudentID, float.Parse(txtPayableAmt.Text),
                DateTime.Parse(dtpDate.Value.ToString(dateFormat)), StaffId, txtRemark.Text);
            MessageBox.Show(result == 1
                        ? SportRegistrationSystem.lblRegisterSuccess
                        : SportRegistrationSystem.lblRegisterFailed);
            //result == 1? //show print page
        }
    }
}
