namespace HR_Login
{
    partial class InterviewScheduleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbApplicant = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInterviewDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInterviewTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterviewer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Interview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applicant:";
            // 
            // cmbApplicant
            // 
            this.cmbApplicant.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApplicant.FormattingEnabled = true;
            this.cmbApplicant.Location = new System.Drawing.Point(183, 60);
            this.cmbApplicant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbApplicant.Name = "cmbApplicant";
            this.cmbApplicant.Size = new System.Drawing.Size(140, 21);
            this.cmbApplicant.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interview Date:";
            // 
            // dtpInterviewDate
            // 
            this.dtpInterviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInterviewDate.Location = new System.Drawing.Point(183, 96);
            this.dtpInterviewDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpInterviewDate.Name = "dtpInterviewDate";
            this.dtpInterviewDate.Size = new System.Drawing.Size(130, 22);
            this.dtpInterviewDate.TabIndex = 4;
            // 
            // dtpInterviewTime
            // 
            this.dtpInterviewTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInterviewTime.Location = new System.Drawing.Point(320, 96);
            this.dtpInterviewTime.Name = "dtpInterviewTime";
            this.dtpInterviewTime.ShowUpDown = true;
            this.dtpInterviewTime.Size = new System.Drawing.Size(88, 22);
            this.dtpInterviewTime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interviewer:";
            // 
            // txtInterviewer
            // 
            this.txtInterviewer.Location = new System.Drawing.Point(183, 137);
            this.txtInterviewer.Name = "txtInterviewer";
            this.txtInterviewer.Size = new System.Drawing.Size(199, 22);
            this.txtInterviewer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mode:";
            // 
            // cmbMode
            // 
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Online",
            "Onsite"});
            this.cmbMode.Location = new System.Drawing.Point(183, 174);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(121, 21);
            this.cmbMode.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(183, 215);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(156, 22);
            this.txtLocation.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InterviewScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInterviewer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpInterviewTime);
            this.Controls.Add(this.dtpInterviewDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbApplicant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InterviewScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InterviewScheduleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbApplicant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInterviewDate;
        private System.Windows.Forms.DateTimePicker dtpInterviewTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterviewer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}