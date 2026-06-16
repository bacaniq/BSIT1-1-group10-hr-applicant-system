namespace HRApplicantSystem
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
            label1 = new Label();
            label2 = new Label();
            cmbApplicant = new ComboBox();
            label3 = new Label();
            dtpInterviewDate = new DateTimePicker();
            dtpInterviewTime = new DateTimePicker();
            label4 = new Label();
            txtInterviewer = new TextBox();
            label5 = new Label();
            cmbMode = new ComboBox();
            label6 = new Label();
            txtLocation = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 0;
            label1.Text = "Schedule Interview";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 13);
            label2.TabIndex = 1;
            label2.Text = "Applicant:";
            // 
            // cmbApplicant
            // 
            cmbApplicant.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbApplicant.FormattingEnabled = true;
            cmbApplicant.Location = new Point(183, 60);
            cmbApplicant.Margin = new Padding(4, 3, 4, 3);
            cmbApplicant.Name = "cmbApplicant";
            cmbApplicant.Size = new Size(140, 21);
            cmbApplicant.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 13);
            label3.TabIndex = 3;
            label3.Text = "Interview Date:";
            // 
            // dtpInterviewDate
            // 
            dtpInterviewDate.Format = DateTimePickerFormat.Short;
            dtpInterviewDate.Location = new Point(183, 96);
            dtpInterviewDate.Margin = new Padding(4, 3, 4, 3);
            dtpInterviewDate.Name = "dtpInterviewDate";
            dtpInterviewDate.Size = new Size(130, 22);
            dtpInterviewDate.TabIndex = 4;
            // 
            // dtpInterviewTime
            // 
            dtpInterviewTime.Format = DateTimePickerFormat.Time;
            dtpInterviewTime.Location = new Point(320, 96);
            dtpInterviewTime.Name = "dtpInterviewTime";
            dtpInterviewTime.ShowUpDown = true;
            dtpInterviewTime.Size = new Size(88, 22);
            dtpInterviewTime.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 140);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 6;
            label4.Text = "Interviewer:";
            // 
            // txtInterviewer
            // 
            txtInterviewer.Location = new Point(183, 137);
            txtInterviewer.Name = "txtInterviewer";
            txtInterviewer.Size = new Size(199, 22);
            txtInterviewer.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(127, 177);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 13);
            label5.TabIndex = 8;
            label5.Text = "Mode:";
            // 
            // cmbMode
            // 
            cmbMode.FormattingEnabled = true;
            cmbMode.Items.AddRange(new object[] { "Online", "Onsite" });
            cmbMode.Location = new Point(183, 174);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(121, 21);
            cmbMode.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(113, 218);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 13);
            label6.TabIndex = 10;
            label6.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(183, 215);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(156, 22);
            txtLocation.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 295);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(264, 295);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // InterviewScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtLocation);
            Controls.Add(label6);
            Controls.Add(cmbMode);
            Controls.Add(label5);
            Controls.Add(txtInterviewer);
            Controls.Add(label4);
            Controls.Add(dtpInterviewTime);
            Controls.Add(dtpInterviewDate);
            Controls.Add(label3);
            Controls.Add(cmbApplicant);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "InterviewScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InterviewScheduleForm";
            Load += InterviewScheduleForm_Load;
            ResumeLayout(false);
            PerformLayout();

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