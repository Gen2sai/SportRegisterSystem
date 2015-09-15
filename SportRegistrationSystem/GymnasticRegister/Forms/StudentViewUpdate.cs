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
    public partial class StudentViewUpdate : Form
    {
        private readonly string passedUsername;
        private readonly int passedPermission;
        public StudentViewUpdate(string username, int permission)
        {
            passedUsername = username;
            passedPermission = permission;
            InitializeComponent();
            DataTable dt = StudentBLL.LoadStudent();
            dataGridView1.DataSource = dt;
            btnBack.Text = SportRegistrationSystem.lblBack;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm(passedUsername, passedPermission);
            form.Show();
            this.Close();
        }
    }
}
