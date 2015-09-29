using System.ComponentModel;
using System.Windows.Forms;

namespace GymnasticRegister.Forms
{
    partial class StudentMenuForm
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.btnCheckPayment = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(6, 13);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "button1";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.Location = new System.Drawing.Point(6, 42);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(75, 23);
            this.btnStudentManagement.TabIndex = 1;
            this.btnStudentManagement.Text = "button1";
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
            // 
            // btnCheckPayment
            // 
            this.btnCheckPayment.Location = new System.Drawing.Point(6, 71);
            this.btnCheckPayment.Name = "btnCheckPayment";
            this.btnCheckPayment.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPayment.TabIndex = 2;
            this.btnCheckPayment.Text = "button2";
            this.btnCheckPayment.UseVisualStyleBackColor = true;
            this.btnCheckPayment.Click += new System.EventHandler(this.btnCheckPayment_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(6, 101);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "button1";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnCheckPayment);
            this.groupBox1.Controls.Add(this.btnPayment);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.btnStudentManagement);
            this.groupBox1.Location = new System.Drawing.Point(74, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StudentMenu";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 130);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "button1";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StudentMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 183);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentMenuForm";
            this.Text = "StudentForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddStudent;
        private Button btnStudentManagement;
        private Button btnCheckPayment;
        private Button btnPayment;
        private GroupBox groupBox1;
        private Button btnBack;
    }
}