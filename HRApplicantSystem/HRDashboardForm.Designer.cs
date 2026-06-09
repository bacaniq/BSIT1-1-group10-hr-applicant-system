namespace HRApplicantSystem
{
    partial class HRDashboardForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnScreenings = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lblTotalApplicants = new System.Windows.Forms.Label();
            this.lblPendingScreenings = new System.Windows.Forms.Label();
            this.lblInterviews = new System.Windows.Forms.Label();
            this.lblHired = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblApplicants = new System.Windows.Forms.Label();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pending Screenings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Interviews Today:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hired Applicants:";
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
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(368, 210);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(111, 23);
            this.btnTestConnection.TabIndex = 8;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // lblTotalApplicants
            // 
            this.lblTotalApplicants.AutoSize = true;
            this.lblTotalApplicants.Location = new System.Drawing.Point(407, 46);
            this.lblTotalApplicants.Name = "lblTotalApplicants";
            this.lblTotalApplicants.Size = new System.Drawing.Size(0, 13);
            this.lblTotalApplicants.TabIndex = 9;
            // 
            // lblPendingScreenings
            // 
            this.lblPendingScreenings.AutoSize = true;
            this.lblPendingScreenings.Location = new System.Drawing.Point(407, 73);
            this.lblPendingScreenings.Name = "lblPendingScreenings";
            this.lblPendingScreenings.Size = new System.Drawing.Size(35, 13);
            this.lblPendingScreenings.TabIndex = 10;
            this.lblPendingScreenings.Text = "label2";
            // 
            // lblInterviews
            // 
            this.lblInterviews.AutoSize = true;
            this.lblInterviews.Location = new System.Drawing.Point(407, 98);
            this.lblInterviews.Name = "lblInterviews";
            this.lblInterviews.Size = new System.Drawing.Size(35, 13);
            this.lblInterviews.TabIndex = 11;
            this.lblInterviews.Text = "label3";
            // 
            // lblHired
            // 
            this.lblHired.AutoSize = true;
            this.lblHired.Location = new System.Drawing.Point(407, 125);
            this.lblHired.Name = "lblHired";
            this.lblHired.Size = new System.Drawing.Size(35, 13);
            this.lblHired.TabIndex = 12;
            this.lblHired.Text = "label4";
            // 
            // label
            // 
            this.label.AutoEllipsis = true;
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(275, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 13);
            this.label.TabIndex = 13;
            this.label.Text = "Total Applicants:";
            // 
            // lblApplicants
            // 
            this.lblApplicants.AutoSize = true;
            this.lblApplicants.Location = new System.Drawing.Point(407, 46);
            this.lblApplicants.Name = "lblApplicants";
            this.lblApplicants.Size = new System.Drawing.Size(35, 13);
            this.lblApplicants.TabIndex = 14;
            this.lblApplicants.Text = "label1";
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(814, 261);
            this.Controls.Add(this.lblApplicants);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblHired);
            this.Controls.Add(this.lblInterviews);
            this.Controls.Add(this.lblPendingScreenings);
            this.Controls.Add(this.lblTotalApplicants);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnInterviews);
            this.Controls.Add(this.btnScreenings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnScreenings;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblTotalApplicants;
        private System.Windows.Forms.Label lblPendingScreenings;
        private System.Windows.Forms.Label lblInterviews;
        private System.Windows.Forms.Label lblHired;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblApplicants;
    }
}