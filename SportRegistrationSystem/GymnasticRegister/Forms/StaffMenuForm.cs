using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymnasticRegister.Resources;

namespace GymnasticRegister.Forms
{
    public partial class StaffMenuForm : Form
    {
        private readonly int passedStaffId;
        private readonly int passedPermission;

        public StaffMenuForm(int staffId, int permission)
        {
            passedStaffId = staffId;
            passedPermission = permission;
            InitializeComponent();
            btnStaffRegister.Text = SportRegistrationSystem.lblRegister;
            btnBack.Text = SportRegistrationSystem.lblBack;
            btnQuote.Text = SportRegistrationSystem.lblQuote;
        }

        private void btnStaffRegister_Click(object sender, EventArgs e)
        {
            StaffRegistrationForm form = new StaffRegistrationForm();
            form.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(passedStaffId, passedPermission);
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuoteManagementForm form = new QuoteManagementForm(passedStaffId, passedPermission);
            form.Show();
            this.Close();
        }
    }
}
