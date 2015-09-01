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
            string username = loginStatus[0].Username;
            int permission = loginStatus[0].PermissionId;
        }
    }
}
