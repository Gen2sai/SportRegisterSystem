using System.ComponentModel;
using System.Windows.Forms;

namespace GymnasticRegister.Forms
{
    partial class StudentPaymentForm
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPayableAmt = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.cbStudentName = new System.Windows.Forms.ComboBox();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.txtPayableAmt = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLastPaid = new System.Windows.Forms.Label();
            this.lblStudentLastPaid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(15, 19);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(35, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "label1";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(15, 41);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(35, 13);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "label1";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 63);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "label1";
            // 
            // lblPayableAmt
            // 
            this.lblPayableAmt.AutoSize = true;
            this.lblPayableAmt.Location = new System.Drawing.Point(15, 85);
            this.lblPayableAmt.Name = "lblPayableAmt";
            this.lblPayableAmt.Size = new System.Drawing.Size(35, 13);
            this.lblPayableAmt.TabIndex = 3;
            this.lblPayableAmt.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 107);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(15, 151);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(35, 13);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "label1";
            // 
            // cbStudentName
            // 
            this.cbStudentName.FormattingEnabled = true;
            this.cbStudentName.Location = new System.Drawing.Point(115, 16);
            this.cbStudentName.Name = "cbStudentName";
            this.cbStudentName.Size = new System.Drawing.Size(200, 21);
            this.cbStudentName.TabIndex = 0;
            this.cbStudentName.SelectedIndexChanged += new System.EventHandler(this.cbStudentName_SelectedIndexChanged);
            this.cbStudentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeydownHandler_KeyDown);
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Location = new System.Drawing.Point(112, 42);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(35, 13);
            this.lblStudentGrade.TabIndex = 7;
            this.lblStudentGrade.Text = "label1";
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.Location = new System.Drawing.Point(112, 60);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(35, 13);
            this.lblStudentAge.TabIndex = 8;
            this.lblStudentAge.Text = "label1";
            // 
            // txtPayableAmt
            // 
            this.txtPayableAmt.Location = new System.Drawing.Point(115, 78);
            this.txtPayableAmt.Name = "txtPayableAmt";
            this.txtPayableAmt.Size = new System.Drawing.Size(200, 20);
            this.txtPayableAmt.TabIndex = 1;
            this.txtPayableAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeydownHandler_KeyDown);
            this.txtPayableAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayableAmt_KeyPresss);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(115, 103);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowUpDown = true;
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeydownHandler_KeyDown);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(115, 146);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 60);
            this.txtRemark.TabIndex = 3;
            this.txtRemark.Text = "";
            this.txtRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeydownHandler_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(240, 214);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "button1";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "button1";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLastPaid
            // 
            this.lblLastPaid.AutoSize = true;
            this.lblLastPaid.Location = new System.Drawing.Point(15, 129);
            this.lblLastPaid.Name = "lblLastPaid";
            this.lblLastPaid.Size = new System.Drawing.Size(35, 13);
            this.lblLastPaid.TabIndex = 14;
            this.lblLastPaid.Text = "label1";
            // 
            // lblStudentLastPaid
            // 
            this.lblStudentLastPaid.AutoSize = true;
            this.lblStudentLastPaid.Location = new System.Drawing.Point(112, 128);
            this.lblStudentLastPaid.Name = "lblStudentLastPaid";
            this.lblStudentLastPaid.Size = new System.Drawing.Size(35, 13);
            this.lblStudentLastPaid.TabIndex = 15;
            this.lblStudentLastPaid.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.lblStudentLastPaid);
            this.groupBox1.Controls.Add(this.lblGrade);
            this.groupBox1.Controls.Add(this.lblLastPaid);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.lblPayableAmt);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.lblRemark);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.cbStudentName);
            this.groupBox1.Controls.Add(this.txtPayableAmt);
            this.groupBox1.Controls.Add(this.lblStudentGrade);
            this.groupBox1.Controls.Add(this.lblStudentAge);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 242);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Payment";
            // 
            // StudentPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentPaymentForm";
            this.Text = "StudentPayment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblStudentName;
        private Label lblGrade;
        private Label lblAge;
        private Label lblPayableAmt;
        private Label lblDate;
        private Label lblRemark;
        private ComboBox cbStudentName;
        private Label lblStudentGrade;
        private Label lblStudentAge;
        private TextBox txtPayableAmt;
        private DateTimePicker dtpDate;
        private RichTextBox txtRemark;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblLastPaid;
        private Label lblStudentLastPaid;
        private GroupBox groupBox1;
    }
}