using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using GymnasticRegister.BusinessLogicLayer;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class StudentPaymentForm : Form
    {
        private const string dateFormat = "MMM/yyyy";
        private readonly int StaffId;
        private readonly int passedPermission;
        private int tempStudentID;

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
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPayableAmt.Text != "0" || string.IsNullOrEmpty(txtPayableAmt.Text))
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
                        printDocument.PrintPage += CreateReceipt;
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
            else
            {
                MessageBox.Show(SportRegistrationSystem.lblInvalidValue);
            }
        }

        private void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Times New Roman", 15);

            int startX = 10;
            int startY = 10;
            int offset = 40;

            string companyName = "BB Gymnastic Centre\n";
            string slogan = "Be Better";
            string studentName = "Student Name : \t" + cbStudentName.SelectedItem + "\n";
            string paidAmount = "Paid Amount : \t" + txtPayableAmt.Text + "\n";
            string paidMonth = "Paid for Month : \t" + dtpDate.Value.ToString("MMMM") + " " + dtpDate.Value.Year + "\n";
            string remarks = "Remarks : \t" + txtRemark.Text + "\n";
            string StaffID = "This receipt was issued by " + StaffBll.StaffLookup(StaffId) + "\n";
            string currentDate = "This receipt was printed on " + DateTime.Now + "\n";
            string quote = QuoteBLL.GetRandomQuote() + "\n";
            string contact1 = "SH Chong - 0162773629";
            string contact2 = "SF Soo - 0133057605";
            string webPage = "WebPage : www.bbgimn.com";
            string receiptNumber = (PaymentBLL.GetReceiptNumber() + 1).ToString();


            graphic.DrawString(companyName, new Font("Times New Roman", 24), new SolidBrush(Color.Green), startX, startY);
            graphic.DrawString(receiptNumber, new Font("Times New Roman", 24), new SolidBrush(Color.Black), companyName.Length + 425, startY);
            graphic.DrawString(slogan, new Font("Times New Roman", 22), new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 5;
            graphic.DrawString("-------------------------------------------------------------------------\n\n", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 5;
            graphic.DrawString(studentName, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 8;
            graphic.DrawString(paidAmount, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 8;
            graphic.DrawString(paidMonth, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 8;
            graphic.DrawString(remarks, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 20;

            graphic.DrawString(StaffID, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 8;
            graphic.DrawString(currentDate, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 5;
            graphic.DrawString("-------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 5;
            graphic.DrawString(quote, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 5;
            graphic.DrawString("-------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 8;
            graphic.DrawString(contact1, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 8;
            graphic.DrawString(contact2, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += FontHeight + 8;
            graphic.DrawString(webPage, font, new SolidBrush(Color.Black), startX, startY + offset);
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
