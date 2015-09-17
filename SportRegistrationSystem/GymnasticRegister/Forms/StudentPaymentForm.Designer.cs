namespace GymnasticRegister.Forms
{
    partial class StudentPaymentForm
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
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(31, 35);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(35, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "label1";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(31, 60);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(35, 13);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "label1";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(31, 84);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "label1";
            // 
            // lblPayableAmt
            // 
            this.lblPayableAmt.AutoSize = true;
            this.lblPayableAmt.Location = new System.Drawing.Point(31, 106);
            this.lblPayableAmt.Name = "lblPayableAmt";
            this.lblPayableAmt.Size = new System.Drawing.Size(35, 13);
            this.lblPayableAmt.TabIndex = 3;
            this.lblPayableAmt.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 129);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(31, 174);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(35, 13);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "label1";
            // 
            // cbStudentName
            // 
            this.cbStudentName.FormattingEnabled = true;
            this.cbStudentName.Location = new System.Drawing.Point(72, 27);
            this.cbStudentName.Name = "cbStudentName";
            this.cbStudentName.Size = new System.Drawing.Size(121, 21);
            this.cbStudentName.TabIndex = 6;
            this.cbStudentName.SelectedIndexChanged += new System.EventHandler(this.cbStudentName_SelectedIndexChanged);
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Location = new System.Drawing.Point(72, 60);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(35, 13);
            this.lblStudentGrade.TabIndex = 7;
            this.lblStudentGrade.Text = "label1";
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.Location = new System.Drawing.Point(72, 84);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(35, 13);
            this.lblStudentAge.TabIndex = 8;
            this.lblStudentAge.Text = "label1";
            // 
            // txtPayableAmt
            // 
            this.txtPayableAmt.Location = new System.Drawing.Point(72, 99);
            this.txtPayableAmt.Name = "txtPayableAmt";
            this.txtPayableAmt.Size = new System.Drawing.Size(100, 20);
            this.txtPayableAmt.TabIndex = 9;
            this.txtPayableAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayableAmt_KeyPresss);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(72, 125);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowUpDown = true;
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 10;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(75, 174);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 60);
            this.txtRemark.TabIndex = 11;
            this.txtRemark.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(196, 247);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "button1";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(115, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "button1";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLastPaid
            // 
            this.lblLastPaid.AutoSize = true;
            this.lblLastPaid.Location = new System.Drawing.Point(31, 152);
            this.lblLastPaid.Name = "lblLastPaid";
            this.lblLastPaid.Size = new System.Drawing.Size(35, 13);
            this.lblLastPaid.TabIndex = 14;
            this.lblLastPaid.Text = "label1";
            // 
            // lblStudentLastPaid
            // 
            this.lblStudentLastPaid.AutoSize = true;
            this.lblStudentLastPaid.Location = new System.Drawing.Point(69, 152);
            this.lblStudentLastPaid.Name = "lblStudentLastPaid";
            this.lblStudentLastPaid.Size = new System.Drawing.Size(35, 13);
            this.lblStudentLastPaid.TabIndex = 15;
            this.lblStudentLastPaid.Text = "label1";
            // 
            // StudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.lblStudentLastPaid);
            this.Controls.Add(this.lblLastPaid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPayableAmt);
            this.Controls.Add(this.lblStudentAge);
            this.Controls.Add(this.lblStudentGrade);
            this.Controls.Add(this.cbStudentName);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPayableAmt);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblStudentName);
            this.Name = "StudentPayment";
            this.Text = "StudentPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPayableAmt;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.ComboBox cbStudentName;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.TextBox txtPayableAmt;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLastPaid;
        private System.Windows.Forms.Label lblStudentLastPaid;
    }
}