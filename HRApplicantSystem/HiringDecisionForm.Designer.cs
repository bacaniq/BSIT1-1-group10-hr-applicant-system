namespace HRApplicantSystem
{
    partial class HiringDecisionForm
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
            this.pnlWarning = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.valApplicantName = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.valJobTitle = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.valCurrentStatus = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.cmbDecision = new System.Windows.Forms.ComboBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlWarning.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Final Hiring Decision";

            // pnlWarning
            this.pnlWarning.BackColor = System.Drawing.Color.FromArgb(255, 220, 220);
            this.pnlWarning.Controls.Add(this.lblWarning);
            this.pnlWarning.Location = new System.Drawing.Point(10, 45);
            this.pnlWarning.Name = "pnlWarning";
            this.pnlWarning.Size = new System.Drawing.Size(480, 35);
            this.pnlWarning.TabIndex = 1;
            this.pnlWarning.Visible = false;

            // lblWarning
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarning.Location = new System.Drawing.Point(5, 8);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Access Restricted: Only HR Manager or Admin can make final hiring decisions.";

            // pnlInfo
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblApplicantName);
            this.pnlInfo.Controls.Add(this.valApplicantName);
            this.pnlInfo.Controls.Add(this.lblJobTitle);
            this.pnlInfo.Controls.Add(this.valJobTitle);
            this.pnlInfo.Controls.Add(this.lblCurrentStatus);
            this.pnlInfo.Controls.Add(this.valCurrentStatus);
            this.pnlInfo.Location = new System.Drawing.Point(10, 90);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(480, 100);
            this.pnlInfo.TabIndex = 2;

            // lblApplicantName
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Location = new System.Drawing.Point(10, 10);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.TabIndex = 0;
            this.lblApplicantName.Text = "Applicant:";

            // valApplicantName
            this.valApplicantName.AutoSize = true;
            this.valApplicantName.Location = new System.Drawing.Point(150, 10);
            this.valApplicantName.Name = "valApplicantName";
            this.valApplicantName.TabIndex = 1;

            // lblJobTitle
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(10, 38);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.TabIndex = 2;
            this.lblJobTitle.Text = "Job Applied:";

            // valJobTitle
            this.valJobTitle.AutoSize = true;
            this.valJobTitle.Location = new System.Drawing.Point(150, 38);
            this.valJobTitle.Name = "valJobTitle";
            this.valJobTitle.TabIndex = 3;

            // lblCurrentStatus
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(10, 66);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.TabIndex = 4;
            this.lblCurrentStatus.Text = "Current Status:";

            // valCurrentStatus
            this.valCurrentStatus.AutoSize = true;
            this.valCurrentStatus.Location = new System.Drawing.Point(150, 66);
            this.valCurrentStatus.Name = "valCurrentStatus";
            this.valCurrentStatus.TabIndex = 5;

            // lblDecision
            this.lblDecision.AutoSize = true;
            this.lblDecision.Location = new System.Drawing.Point(20, 210);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.TabIndex = 3;
            this.lblDecision.Text = "Decision:";

            // cmbDecision
            this.cmbDecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecision.Items.AddRange(new object[] { "Accepted", "Rejected", "On Hold" });
            this.cmbDecision.Location = new System.Drawing.Point(150, 207);
            this.cmbDecision.Name = "cmbDecision";
            this.cmbDecision.Size = new System.Drawing.Size(180, 23);
            this.cmbDecision.TabIndex = 4;

            // lblRemarks
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(20, 248);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "Remarks:";

            // txtRemarks
            this.txtRemarks.Location = new System.Drawing.Point(150, 245);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(330, 90);
            this.txtRemarks.TabIndex = 6;

            // btnConfirm
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(150, 355);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 27);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm Decision";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(325, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 27);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;

            // HiringDecisionForm
            this.ClientSize = new System.Drawing.Size(520, 470);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlWarning);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.cmbDecision);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Name = "HiringDecisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Hiring Decision";
            this.pnlWarning.ResumeLayout(false);
            this.pnlWarning.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label valApplicantName;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label valJobTitle;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label valCurrentStatus;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.ComboBox cmbDecision;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}
