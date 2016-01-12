using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymnasticRegister.BusinessLogicLayer;
using GymnasticRegister.Resources;


namespace GymnasticRegister.Forms
{
    public partial class QuoteManagementForm : Form
    {
        private int refStaffId;
        private int refpermission;

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

        public QuoteManagementForm(int StaffId, int Permission)
        {
            refStaffId = StaffId;
            refpermission = Permission;
            InitializeComponent();
            DataTable dt = QuoteBLL.LoadQuotes();
            dataGridView1.DataSource = dt;
            lblAddQuote.Text = SportRegistrationSystem.lblAddQuote;
            lblQuoteList.Text = SportRegistrationSystem.lblQuoteList;
            btnCancel.Text = SportRegistrationSystem.lblCancel;
            btnSubmit.Text = SportRegistrationSystem.lblSubmit;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StaffMenuForm form = new StaffMenuForm(refStaffId, refpermission);
            form.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Quote = richTextBox1.Text;
            if(!string.IsNullOrEmpty(Quote))
            {
                QuoteBLL.AddQuotes(Quote);
                DataTable dt = QuoteBLL.LoadQuotes();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
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
