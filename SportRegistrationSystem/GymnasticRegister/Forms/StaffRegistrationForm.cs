using System;
using System.Windows.Forms;
using GymnasticRegister.BusinessLogicLayer;
using GymnasticRegister.Enum;
using GymnasticRegister.Resources;

namespace GymnasticRegister
{
    public partial class StaffRegistrationForm : Form
    {
        public StaffRegistrationForm()
        {
            InitializeComponent();
        }

        private void StaffRegistrationForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = SportRegistrationSystem.lblUsername;
            lblPassword.Text = SportRegistrationSystem.lblPassword;
            lblFullName.Text = SportRegistrationSystem.lblFullName;
            lblPermission.Text = SportRegistrationSystem.lblPermission;
            cbPermission.DataSource = System.Enum.GetValues(typeof (PermissionEnum));
            cbPermission.SelectedIndex = cbPermission.FindStringExact("Staff");
            btnRegister.Text = SportRegistrationSystem.lblRegister;
            btnCancel.Text = SportRegistrationSystem.lblCancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == null)
            {
                MessageBox.Show(SportRegistrationSystem.lblInvalidUsername);
            }
            else
            {
                if (txtPassword.Text == null || lblPassword.Text.Length < 8)
                {
                    MessageBox.Show(SportRegistrationSystem.lblInvalidPassword);
                }
                else
                {
                    if (txtFullName.Text == null)
                    {
                        MessageBox.Show(SportRegistrationSystem.lblInvalidFullName);
                    }
                    else
                    {
                        bool registrationStatus = StaffBll.RegisterStaff(txtUsername.Text, txtPassword.Text, txtFullName.Text, (int)System.Enum.Parse(typeof (PermissionEnum), cbPermission.SelectedValue.ToString()));
                        if (registrationStatus)
                        {
                            MessageBox.Show(SportRegistrationSystem.lblRegisterSuccess);
                        }
                        else
                        {
                            MessageBox.Show(SportRegistrationSystem.lblRegisterFailed);
                        }
                    }
                }
            }
        }
    }
}
