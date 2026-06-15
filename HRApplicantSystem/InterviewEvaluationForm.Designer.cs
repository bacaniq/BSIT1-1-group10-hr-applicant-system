namespace HRApplicantSystem
{
    partial class InterviewEvaluationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            pnlInfo = new Panel();
            lblApplicantName = new Label();
            valApplicantName = new Label();
            lblJobTitle = new Label();
            valJobTitle = new Label();
            lblInterviewDate = new Label();
            valInterviewDate = new Label();
            lblInterviewStatus = new Label();
            valInterviewStatus = new Label();
            lblScore = new Label();
            txtScore = new TextBox();
            lblResult = new Label();
            cmbResult = new ComboBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Interview Evaluation";
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(240, 240, 240);
            pnlInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlInfo.Controls.Add(lblApplicantName);
            pnlInfo.Controls.Add(valApplicantName);
            pnlInfo.Controls.Add(lblJobTitle);
            pnlInfo.Controls.Add(valJobTitle);
            pnlInfo.Controls.Add(lblInterviewDate);
            pnlInfo.Controls.Add(valInterviewDate);
            pnlInfo.Controls.Add(lblInterviewStatus);
            pnlInfo.Controls.Add(valInterviewStatus);
            pnlInfo.Location = new Point(10, 50);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(510, 120);
            pnlInfo.TabIndex = 1;
            // 
            // lblApplicantName
            // 
            lblApplicantName.AutoSize = true;
            lblApplicantName.Location = new Point(10, 10);
            lblApplicantName.Name = "lblApplicantName";
            lblApplicantName.Size = new Size(61, 15);
            lblApplicantName.TabIndex = 0;
            lblApplicantName.Text = "Applicant:";
            // 
            // valApplicantName
            // 
            valApplicantName.AutoSize = true;
            valApplicantName.Location = new Point(160, 10);
            valApplicantName.Name = "valApplicantName";
            valApplicantName.Size = new Size(0, 15);
            valApplicantName.TabIndex = 1;
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(10, 35);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(72, 15);
            lblJobTitle.TabIndex = 2;
            lblJobTitle.Text = "Job Applied:";
            // 
            // valJobTitle
            // 
            valJobTitle.AutoSize = true;
            valJobTitle.Location = new Point(160, 35);
            valJobTitle.Name = "valJobTitle";
            valJobTitle.Size = new Size(0, 15);
            valJobTitle.TabIndex = 3;
            // 
            // lblInterviewDate
            // 
            lblInterviewDate.AutoSize = true;
            lblInterviewDate.Location = new Point(10, 60);
            lblInterviewDate.Name = "lblInterviewDate";
            lblInterviewDate.Size = new Size(85, 15);
            lblInterviewDate.TabIndex = 4;
            lblInterviewDate.Text = "Interview Date:";
            // 
            // valInterviewDate
            // 
            valInterviewDate.AutoSize = true;
            valInterviewDate.Location = new Point(160, 60);
            valInterviewDate.Name = "valInterviewDate";
            valInterviewDate.Size = new Size(0, 15);
            valInterviewDate.TabIndex = 5;
            // 
            // lblInterviewStatus
            // 
            lblInterviewStatus.AutoSize = true;
            lblInterviewStatus.Location = new Point(10, 85);
            lblInterviewStatus.Name = "lblInterviewStatus";
            lblInterviewStatus.Size = new Size(93, 15);
            lblInterviewStatus.TabIndex = 6;
            lblInterviewStatus.Text = "Interview Status:";
            // 
            // valInterviewStatus
            // 
            valInterviewStatus.AutoSize = true;
            valInterviewStatus.Location = new Point(160, 85);
            valInterviewStatus.Name = "valInterviewStatus";
            valInterviewStatus.Size = new Size(0, 15);
            valInterviewStatus.TabIndex = 7;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(20, 190);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(79, 15);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score (0-100):";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(160, 187);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(20, 225);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result:";
            // 
            // cmbResult
            // 
            cmbResult.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResult.Items.AddRange(new object[] { "Pass", "Fail" });
            cmbResult.Location = new Point(160, 222);
            cmbResult.Name = "cmbResult";
            cmbResult.Size = new Size(150, 23);
            cmbResult.TabIndex = 5;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(20, 260);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(55, 15);
            lblRemarks.TabIndex = 6;
            lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(160, 257);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.ScrollBars = ScrollBars.Vertical;
            txtRemarks.Size = new Size(340, 100);
            txtRemarks.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(160, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 27);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Evaluation";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(325, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 27);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // InterviewEvaluationForm
            // 
            ClientSize = new Size(550, 520);
            Controls.Add(lblTitle);
            Controls.Add(pnlInfo);
            Controls.Add(lblScore);
            Controls.Add(txtScore);
            Controls.Add(lblResult);
            Controls.Add(cmbResult);
            Controls.Add(lblRemarks);
            Controls.Add(txtRemarks);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "InterviewEvaluationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interview Evaluation";
            Load += InterviewEvaluationForm_Load;
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label valApplicantName;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label valJobTitle;
        private System.Windows.Forms.Label lblInterviewDate;
        private System.Windows.Forms.Label valInterviewDate;
        private System.Windows.Forms.Label lblInterviewStatus;
        private System.Windows.Forms.Label valInterviewStatus;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
