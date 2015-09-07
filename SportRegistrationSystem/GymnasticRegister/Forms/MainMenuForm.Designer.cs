namespace GymnasticRegister.Forms
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.SuspendLayout();
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.Location = new System.Drawing.Point(61, 41);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(75, 23);
            this.btnStaffManagement.TabIndex = 0;
            this.btnStaffManagement.Text = "button1";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.Location = new System.Drawing.Point(61, 83);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(75, 23);
            this.btnStudentManagement.TabIndex = 1;
            this.btnStudentManagement.Text = "button2";
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnStudentManagement);
            this.Controls.Add(this.btnStaffManagement);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnStudentManagement;
    }
}