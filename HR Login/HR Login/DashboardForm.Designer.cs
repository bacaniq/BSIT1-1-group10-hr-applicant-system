namespace HR_Login
{
    partial class DashboardForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotalApplicants = new System.Windows.Forms.Label();
            this.lblPendingScreening = new System.Windows.Forms.Label();
            this.lblInterviews = new System.Windows.Forms.Label();
            this.lblHired = new System.Windows.Forms.Label();
            this.btnScreenings = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(387, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HR Dashboard";
            // 
            // lblTotalApplicants
            // 
            this.lblTotalApplicants.AutoSize = true;
            this.lblTotalApplicants.Location = new System.Drawing.Point(275, 46);
            this.lblTotalApplicants.Name = "lblTotalApplicants";
            this.lblTotalApplicants.Size = new System.Drawing.Size(86, 13);
            this.lblTotalApplicants.TabIndex = 1;
            this.lblTotalApplicants.Text = "Total Applicants:";
            this.lblTotalApplicants.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPendingScreening
            // 
            this.lblPendingScreening.AutoSize = true;
            this.lblPendingScreening.Location = new System.Drawing.Point(256, 73);
            this.lblPendingScreening.Name = "lblPendingScreening";
            this.lblPendingScreening.Size = new System.Drawing.Size(105, 13);
            this.lblPendingScreening.TabIndex = 2;
            this.lblPendingScreening.Text = "Pending Screenings:";
            // 
            // lblInterviews
            // 
            this.lblInterviews.AutoSize = true;
            this.lblInterviews.Location = new System.Drawing.Point(270, 98);
            this.lblInterviews.Name = "lblInterviews";
            this.lblInterviews.Size = new System.Drawing.Size(91, 13);
            this.lblInterviews.TabIndex = 3;
            this.lblInterviews.Text = "Interviews Today:";
            // 
            // lblHired
            // 
            this.lblHired.AutoSize = true;
            this.lblHired.Location = new System.Drawing.Point(274, 125);
            this.lblHired.Name = "lblHired";
            this.lblHired.Size = new System.Drawing.Size(87, 13);
            this.lblHired.TabIndex = 4;
            this.lblHired.Text = "Hired Applicants:";
            // 
            // btnScreenings
            // 
            this.btnScreenings.Location = new System.Drawing.Point(309, 181);
            this.btnScreenings.Name = "btnScreenings";
            this.btnScreenings.Size = new System.Drawing.Size(75, 23);
            this.btnScreenings.TabIndex = 5;
            this.btnScreenings.Text = "Screenings";
            this.btnScreenings.UseVisualStyleBackColor = true;
            // 
            // btnInterviews
            // 
            this.btnInterviews.Location = new System.Drawing.Point(390, 181);
            this.btnInterviews.Name = "btnInterviews";
            this.btnInterviews.Size = new System.Drawing.Size(75, 23);
            this.btnInterviews.TabIndex = 6;
            this.btnInterviews.Text = "Interviews";
            this.btnInterviews.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(471, 181);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(814, 261);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnInterviews);
            this.Controls.Add(this.btnScreenings);
            this.Controls.Add(this.lblHired);
            this.Controls.Add(this.lblInterviews);
            this.Controls.Add(this.lblPendingScreening);
            this.Controls.Add(this.lblTotalApplicants);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalApplicants;
        private System.Windows.Forms.Label lblPendingScreening;
        private System.Windows.Forms.Label lblInterviews;
        private System.Windows.Forms.Label lblHired;
        private System.Windows.Forms.Button btnScreenings;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnLogout;
    }
}