using System.ComponentModel;
using System.Windows.Forms;

namespace GymnasticRegister.Forms
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReporting = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.Location = new System.Drawing.Point(6, 19);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(75, 23);
            this.btnStaffManagement.TabIndex = 0;
            this.btnStaffManagement.Text = "button1";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.Location = new System.Drawing.Point(6, 48);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(75, 23);
            this.btnStudentManagement.TabIndex = 1;
            this.btnStudentManagement.Text = "button2";
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(6, 105);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "button1";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReporting);
            this.groupBox1.Controls.Add(this.btnStaffManagement);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnStudentManagement);
            this.groupBox1.Location = new System.Drawing.Point(74, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MainMenu";
            // 
            // btnReporting
            // 
            this.btnReporting.Location = new System.Drawing.Point(6, 76);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(75, 23);
            this.btnReporting.TabIndex = 2;
            this.btnReporting.Text = "button1";
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 158);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStaffManagement;
        private Button btnStudentManagement;
        private Button btnLogout;
        private GroupBox groupBox1;
        private Button btnReporting;
    }
}