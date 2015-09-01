using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymnasticRegister.Model;

namespace GymnasticRegister.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm(List<StaffClass> loginStatus)
        {
            InitializeComponent();
            string Username = loginStatus[0].Username;
            int Permission = loginStatus[0].PermissionID;
        }
    }
}
