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

namespace GymnasticRegister.Forms
{
    public partial class StudentViewUpdate : Form
    {
        public StudentViewUpdate(string username, int permission)
        {
            InitializeComponent();
            DataTable dt = StudentBLL.LoadStudent();
            dataGridView1.DataSource = dt;
        }
    }
}
