using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
    public partial class StudentPaymentForm : Form
    {
        private const string dateFormat = "MMM/yyyy";
        private readonly int StaffId;
        private readonly int passedPermission;
        private int tempStudentID;

        public StudentPaymentForm(int username, int permission)
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

        public StudentPaymentForm(int username, int permission, string studentName)
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
            DataTable dt = StudentBLL.LoadStudent(studentName);
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
            StudentMenuForm form = new StudentMenuForm(StaffId, passedPermission);
            form.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int result = StudentBLL.MakePayment(tempStudentID, float.Parse(txtPayableAmt.Text),
                DateTime.Parse(dtpDate.Value.ToString(dateFormat)), StaffId, txtRemark.Text);
            MessageBox.Show(result == 1
                        ? SportRegistrationSystem.lblPaymentSuccess
                        : SportRegistrationSystem.lblPaymentFailed);
            if (result == 1)
            {
            DialogResult dialogResult = MessageBox.Show("Print Receipt?", "Print Receipt Prompt", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt);
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            }
            StudentMenuForm form = new StudentMenuForm(StaffId, passedPermission);
            form.Show();
            this.Close();
        }

        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Times New Roman", 15);

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("BB Gymnastic Centre", new Font("Times New Roman", 24), new SolidBrush(Color.Green), startX, startY);
            graphic.DrawString("-------------------------------------------------------------------------\n\n", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 5;
            string studentName = "Student Name : \t" + cbStudentName.SelectedItem.ToString() + "\n";
            graphic.DrawString(studentName, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 8;
            string paidAmount = "Paid Amount : \t" + txtPayableAmt.Text + "\n";
            graphic.DrawString(paidAmount, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 8;
            string paidMonth = "Paid for Month : \t" + dtpDate.Value.ToString("MMMM") + " " + dtpDate.Value.Year + "\n";
            graphic.DrawString(paidMonth, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 8;
            string remarks = "Remarks : \t" + txtRemark.Text + "\n";
            graphic.DrawString(remarks, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 20;

            string StaffID = "This receipt was issued by " + StaffBll.StaffLookup(StaffId) + "\n";
            graphic.DrawString(StaffID, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 8;
            string currentDate = "This receipt was printed on " + DateTime.Now + "\n";
            graphic.DrawString(currentDate, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 5;
            graphic.DrawString("-------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 5;
            string quote = "QUOTE WILL BE INSERTED HERE\n";
            graphic.DrawString(quote, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)FontHeight + 5;
            graphic.DrawString("-------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
}
