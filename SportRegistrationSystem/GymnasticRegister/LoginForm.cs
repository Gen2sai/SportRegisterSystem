using System;
using System.Windows.Forms;
using GymnasticRegister.Resources;

namespace GymnasticRegister
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.Text = SportRegistrationSystem.lblUsername;
            label2.Text = SportRegistrationSystem.lblPassword;
            btnLogin.Text = SportRegistrationSystem.lblLogin;
            btnRegister.Text = SportRegistrationSystem.lblRegister;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StaffRegistrationForm form = new StaffRegistrationForm();
            form.Show();
            this.Hide();
        }
    }
}
