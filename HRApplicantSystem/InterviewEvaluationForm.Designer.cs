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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.valApplicantName = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.valJobTitle = new System.Windows.Forms.Label();
            this.lblInterviewDate = new System.Windows.Forms.Label();
            this.valInterviewDate = new System.Windows.Forms.Label();
            this.lblInterviewStatus = new System.Windows.Forms.Label();
            this.valInterviewStatus = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Interview Evaluation";

            // pnlInfo
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblApplicantName);
            this.pnlInfo.Controls.Add(this.valApplicantName);
            this.pnlInfo.Controls.Add(this.lblJobTitle);
            this.pnlInfo.Controls.Add(this.valJobTitle);
            this.pnlInfo.Controls.Add(this.lblInterviewDate);
            this.pnlInfo.Controls.Add(this.valInterviewDate);
            this.pnlInfo.Controls.Add(this.lblInterviewStatus);
            this.pnlInfo.Controls.Add(this.valInterviewStatus);
            this.pnlInfo.Location = new System.Drawing.Point(10, 50);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(510, 120);
            this.pnlInfo.TabIndex = 1;

            // lblApplicantName
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Location = new System.Drawing.Point(10, 10);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.TabIndex = 0;
            this.lblApplicantName.Text = "Applicant:";

            // valApplicantName
            this.valApplicantName.AutoSize = true;
            this.valApplicantName.Location = new System.Drawing.Point(160, 10);
            this.valApplicantName.Name = "valApplicantName";
            this.valApplicantName.TabIndex = 1;

            // lblJobTitle
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(10, 35);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.TabIndex = 2;
            this.lblJobTitle.Text = "Job Applied:";

            // valJobTitle
            this.valJobTitle.AutoSize = true;
            this.valJobTitle.Location = new System.Drawing.Point(160, 35);
            this.valJobTitle.Name = "valJobTitle";
            this.valJobTitle.TabIndex = 3;

            // lblInterviewDate
            this.lblInterviewDate.AutoSize = true;
            this.lblInterviewDate.Location = new System.Drawing.Point(10, 60);
            this.lblInterviewDate.Name = "lblInterviewDate";
            this.lblInterviewDate.TabIndex = 4;
            this.lblInterviewDate.Text = "Interview Date:";

            // valInterviewDate
            this.valInterviewDate.AutoSize = true;
            this.valInterviewDate.Location = new System.Drawing.Point(160, 60);
            this.valInterviewDate.Name = "valInterviewDate";
            this.valInterviewDate.TabIndex = 5;

            // lblInterviewStatus
            this.lblInterviewStatus.AutoSize = true;
            this.lblInterviewStatus.Location = new System.Drawing.Point(10, 85);
            this.lblInterviewStatus.Name = "lblInterviewStatus";
            this.lblInterviewStatus.TabIndex = 6;
            this.lblInterviewStatus.Text = "Interview Status:";

            // valInterviewStatus
            this.valInterviewStatus.AutoSize = true;
            this.valInterviewStatus.Location = new System.Drawing.Point(160, 85);
            this.valInterviewStatus.Name = "valInterviewStatus";
            this.valInterviewStatus.TabIndex = 7;

            // lblScore
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(20, 190);
            this.lblScore.Name = "lblScore";
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score (0-100):";

            // txtScore
            this.txtScore.Location = new System.Drawing.Point(160, 187);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 23);
            this.txtScore.TabIndex = 3;

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 225);
            this.lblResult.Name = "lblResult";
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";

            // cmbResult
            this.cmbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResult.Items.AddRange(new object[] { "Pass", "Fail" });
            this.cmbResult.Location = new System.Drawing.Point(160, 222);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(150, 23);
            this.cmbResult.TabIndex = 5;

            // lblRemarks
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(20, 260);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.TabIndex = 6;
            this.lblRemarks.Text = "Remarks:";

            // txtRemarks
            this.txtRemarks.Location = new System.Drawing.Point(160, 257);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(340, 100);
            this.txtRemarks.TabIndex = 7;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(160, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Evaluation";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(325, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;

            // InterviewEvaluationForm
            this.ClientSize = new System.Drawing.Size(550, 520);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbResult);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "InterviewEvaluationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interview Evaluation";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
