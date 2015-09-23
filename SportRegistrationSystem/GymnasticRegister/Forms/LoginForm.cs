using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymnasticRegister.BusinessLogicLayer;
using GymnasticRegister.Forms;
using GymnasticRegister.Model;
using GymnasticRegister.Resources;

namespace GymnasticRegister
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            groupBox1.Text = SportRegistrationSystem.lblLogin;
            label1.Text = SportRegistrationSystem.lblUsername;
            label2.Text = SportRegistrationSystem.lblPassword;
            btnLogin.Text = SportRegistrationSystem.lblLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             if (txtUsername.Text == null)
            {
                MessageBox.Show(SportRegistrationSystem.lblInvalidLogin);
            }
            else
            {
                if (txtPassword.Text == null)
                {
                    MessageBox.Show(SportRegistrationSystem.lblInvalidPassword);
                }
                else
                {
                    List<StaffClass> loginStatus = StaffBll.Login(txtUsername.Text, txtPassword.Text);
                    
                    if (loginStatus.Count() == 1)
                    {
                        MainMenuForm form = new MainMenuForm(loginStatus);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(SportRegistrationSystem.lblLoginFailed);
                    }
                }
            }
        }
    }
}
