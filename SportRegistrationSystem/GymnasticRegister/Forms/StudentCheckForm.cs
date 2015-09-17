﻿using System;
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
    public partial class StudentCheckForm : Form
    {
        private readonly int staffId;
        private readonly int passedPermission;
        public StudentCheckForm(int staffID, int permission)
        {
            InitializeComponent();
            staffId = staffID;
            passedPermission = permission;
            lblStudent.Text = SportRegistrationSystem.lblStudentName;
            DataTable dt = StudentBLL.GetLatePaymentByMonth();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbStudent.Items.Add(row["StudentName"].ToString());
                }
                cbStudent.SelectedIndex = 0;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm(staffId, passedPermission);
            form.Show();
            this.Close();
        }
    }
}