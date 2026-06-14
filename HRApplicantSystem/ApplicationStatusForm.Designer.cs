namespace HRApplicantSystem
{
    partial class ApplicationStatusForm
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
            Lblank4 = new Label();
            Lblank3 = new Label();
            Lblank2 = new Label();
            Lblank1 = new Label();
            label5 = new Label();
            LBHRRemark = new ListView();
            HRRemark = new ColumnHeader();
            LBSchedule = new Label();
            label4 = new Label();
            LBStatus = new Label();
            LBDateApplied = new Label();
            LBJobPosition = new Label();
            LVStatus = new ListView();
            Status = new ColumnHeader();
            AppliedDate = new ColumnHeader();
            label1 = new Label();
            JobTitle = new ColumnHeader();
            SuspendLayout();
            // 
            // Lblank4
            // 
            Lblank4.AutoSize = true;
            Lblank4.Location = new Point(187, 421);
            Lblank4.Name = "Lblank4";
            Lblank4.Size = new Size(153, 15);
            Lblank4.TabIndex = 35;
            Lblank4.Text = "No scheduled interview yet.";
            // 
            // Lblank3
            // 
            Lblank3.AutoSize = true;
            Lblank3.Location = new Point(156, 188);
            Lblank3.Name = "Lblank3";
            Lblank3.Size = new Size(105, 15);
            Lblank3.TabIndex = 34;
            Lblank3.Text = "Status unavailable.";
            // 
            // Lblank2
            // 
            Lblank2.AutoSize = true;
            Lblank2.Location = new Point(156, 137);
            Lblank2.Name = "Lblank2";
            Lblank2.Size = new Size(97, 15);
            Lblank2.TabIndex = 33;
            Lblank2.Text = "Date unavailable.";
            // 
            // Lblank1
            // 
            Lblank1.AutoSize = true;
            Lblank1.Location = new Point(156, 92);
            Lblank1.Name = "Lblank1";
            Lblank1.Size = new Size(119, 15);
            Lblank1.TabIndex = 32;
            Lblank1.Text = "Have not yet applied.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(21, 470);
            label5.Name = "label5";
            label5.Size = new Size(87, 17);
            label5.TabIndex = 31;
            label5.Text = "HR Remarks:";
            // 
            // LBHRRemark
            // 
            LBHRRemark.Columns.AddRange(new ColumnHeader[] { HRRemark });
            LBHRRemark.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBHRRemark.Location = new Point(21, 492);
            LBHRRemark.Name = "LBHRRemark";
            LBHRRemark.Size = new Size(369, 132);
            LBHRRemark.TabIndex = 30;
            LBHRRemark.UseCompatibleStateImageBehavior = false;
            LBHRRemark.View = View.Details;
            // 
            // HRRemark
            // 
            HRRemark.Text = "Remarks";
            // 
            // LBSchedule
            // 
            LBSchedule.AutoSize = true;
            LBSchedule.Font = new Font("Century Gothic", 9.75F);
            LBSchedule.Location = new Point(21, 421);
            LBSchedule.Name = "LBSchedule";
            LBSchedule.Size = new Size(133, 17);
            LBSchedule.TabIndex = 29;
            LBSchedule.Text = "Interview Schedule:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(21, 227);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 28;
            label4.Text = "Timeline:";
            // 
            // LBStatus
            // 
            LBStatus.AutoSize = true;
            LBStatus.Font = new Font("Century Gothic", 9.75F);
            LBStatus.Location = new Point(21, 186);
            LBStatus.Name = "LBStatus";
            LBStatus.Size = new Size(50, 17);
            LBStatus.TabIndex = 27;
            LBStatus.Text = "Status:";
            // 
            // LBDateApplied
            // 
            LBDateApplied.AutoSize = true;
            LBDateApplied.Font = new Font("Century Gothic", 9.75F);
            LBDateApplied.Location = new Point(21, 135);
            LBDateApplied.Name = "LBDateApplied";
            LBDateApplied.Size = new Size(98, 17);
            LBDateApplied.TabIndex = 26;
            LBDateApplied.Text = "Date Applied:";
            // 
            // LBJobPosition
            // 
            LBJobPosition.AutoSize = true;
            LBJobPosition.Font = new Font("Century Gothic", 9.75F);
            LBJobPosition.Location = new Point(21, 90);
            LBJobPosition.Name = "LBJobPosition";
            LBJobPosition.Size = new Size(90, 17);
            LBJobPosition.TabIndex = 25;
            LBJobPosition.Text = "Job Position:";
            // 
            // LVStatus
            // 
            LVStatus.Columns.AddRange(new ColumnHeader[] { JobTitle, Status, AppliedDate });
            LVStatus.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LVStatus.Location = new Point(21, 249);
            LVStatus.Name = "LVStatus";
            LVStatus.Size = new Size(369, 132);
            LVStatus.TabIndex = 24;
            LVStatus.UseCompatibleStateImageBehavior = false;
            LVStatus.View = View.Details;
            // 
            // Status
            // 
            Status.Text = "Status";
            // 
            // AppliedDate
            // 
            AppliedDate.Text = "Date Applied";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(405, 46);
            label1.TabIndex = 23;
            label1.Text = "My Application + Status";
            // 
            // JobTitle
            // 
            JobTitle.Text = "Job Title";
            // 
            // ApplicationStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 652);
            Controls.Add(Lblank4);
            Controls.Add(Lblank3);
            Controls.Add(Lblank2);
            Controls.Add(Lblank1);
            Controls.Add(label5);
            Controls.Add(LBHRRemark);
            Controls.Add(LBSchedule);
            Controls.Add(label4);
            Controls.Add(LBStatus);
            Controls.Add(LBDateApplied);
            Controls.Add(LBJobPosition);
            Controls.Add(LVStatus);
            Controls.Add(label1);
            Name = "ApplicationStatusForm";
            Text = "ApplicationStatusForm";
            Load += ApplicationStatusForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lblank4;
        private Label Lblank3;
        private Label Lblank2;
        private Label Lblank1;
        private Label label5;
        private ListView LBHRRemark;
        private ColumnHeader HRRemark;
        private Label LBSchedule;
        private Label label4;
        private Label LBStatus;
        private Label LBDateApplied;
        private Label LBJobPosition;
        private ListView LVStatus;
        private ColumnHeader Status;
        private ColumnHeader AppliedDate;
        private Label label1;
        private ColumnHeader JobTitle;
    }
}