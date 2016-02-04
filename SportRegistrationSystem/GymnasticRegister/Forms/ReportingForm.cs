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
    public partial class ReportingForm : Form
    {
        int tempStaffId;
        int tempPermission;

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

        public ReportingForm(int StaffId, int permission)
        {
            InitializeComponent();
            btnLookup.Text = SportRegistrationSystem.lblLookup;
            btnBack.Text = SportRegistrationSystem.lblBack;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM/yyyy";
            tempStaffId = StaffId;
            tempPermission = permission;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(tempStaffId, tempPermission);
            form.Show();
            this.Close();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            //DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime startDate = new DateTime();
            string tempDate = dateTimePicker1.Value.ToString("MMM-yyyy");
            startDate = DateTime.Parse(tempDate);
            DataTable dt = ReportingBLL.ReportLookup(startDate);
            dataGridView1.DataSource = dt;
        }

        private void KeydownHandler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLookup_Click(this, new EventArgs());
            }
        }
    }
}
