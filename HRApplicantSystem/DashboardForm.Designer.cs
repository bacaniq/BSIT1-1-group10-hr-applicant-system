namespace HRApplicantSystem
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
            lblTitle = new Label();
            btnScreenings = new Button();
            btnInterviews = new Button();
            btnLogout = new Button();
            lblTotalApplicants = new Label();
            lblPendingScreenings = new Label();
            lblInterviews = new Label();
            lblHired = new Label();
            lblApplicants = new Label();
            pnlTotal = new Panel();
            lblTotalTitle = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            pnlTotal.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(331, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HR Dashboard";
            // 
            // btnScreenings
            // 
            btnScreenings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScreenings.Location = new Point(249, 171);
            btnScreenings.Name = "btnScreenings";
            btnScreenings.Size = new Size(81, 33);
            btnScreenings.TabIndex = 5;
            btnScreenings.Text = "Screenings";
            btnScreenings.UseVisualStyleBackColor = true;
            btnScreenings.Click += btnScreenings_Click;
            // 
            // btnInterviews
            // 
            btnInterviews.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInterviews.Location = new Point(457, 171);
            btnInterviews.Name = "btnInterviews";
            btnInterviews.Size = new Size(75, 33);
            btnInterviews.TabIndex = 6;
            btnInterviews.Text = "Interviews";
            btnInterviews.UseVisualStyleBackColor = true;
            btnInterviews.Click += btnInterviews_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(360, 225);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTotalApplicants
            // 
            lblTotalApplicants.AutoSize = true;
            lblTotalApplicants.Location = new Point(407, 46);
            lblTotalApplicants.Name = "lblTotalApplicants";
            lblTotalApplicants.Size = new Size(0, 15);
            lblTotalApplicants.TabIndex = 9;
            // 
            // lblPendingScreenings
            // 
            lblPendingScreenings.AutoSize = true;
            lblPendingScreenings.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingScreenings.ForeColor = Color.White;
            lblPendingScreenings.Location = new Point(124, 45);
            lblPendingScreenings.Name = "lblPendingScreenings";
            lblPendingScreenings.Size = new Size(38, 45);
            lblPendingScreenings.TabIndex = 10;
            lblPendingScreenings.Text = "0";
            // 
            // lblInterviews
            // 
            lblInterviews.AutoSize = true;
            lblInterviews.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInterviews.ForeColor = Color.White;
            lblInterviews.Location = new Point(129, 45);
            lblInterviews.Name = "lblInterviews";
            lblInterviews.Size = new Size(38, 45);
            lblInterviews.TabIndex = 11;
            lblInterviews.Text = "0";
            // 
            // lblHired
            // 
            lblHired.AutoSize = true;
            lblHired.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHired.ForeColor = Color.White;
            lblHired.Location = new Point(129, 44);
            lblHired.Name = "lblHired";
            lblHired.Size = new Size(38, 45);
            lblHired.TabIndex = 12;
            lblHired.Text = "0";
            // 
            // lblApplicants
            // 
            lblApplicants.AutoSize = true;
            lblApplicants.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicants.ForeColor = Color.White;
            lblApplicants.Location = new Point(129, 45);
            lblApplicants.Name = "lblApplicants";
            lblApplicants.Size = new Size(38, 45);
            lblApplicants.TabIndex = 14;
            lblApplicants.Text = "0";
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.SteelBlue;
            pnlTotal.Controls.Add(lblTotalTitle);
            pnlTotal.Controls.Add(lblApplicants);
            pnlTotal.Location = new Point(12, 65);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Padding = new Padding(10);
            pnlTotal.Size = new Size(180, 100);
            pnlTotal.TabIndex = 15;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTitle.Location = new Point(59, 27);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(108, 17);
            lblTotalTitle.TabIndex = 16;
            lblTotalTitle.Text = "Total Applicants";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblPendingScreenings);
            panel1.Location = new Point(204, 65);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(180, 100);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 27);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 16;
            label1.Text = "Pending Screenings";
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblInterviews);
            panel2.Location = new Point(400, 65);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(180, 100);
            panel2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 27);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 16;
            label2.Text = "Interviews Today";
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblHired);
            panel3.Location = new Point(598, 65);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(180, 100);
            panel3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 27);
            label3.Name = "label3";
            label3.Size = new Size(111, 17);
            label3.TabIndex = 16;
            label3.Text = "Hired Applicants";
            // 
            // DashboardForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(814, 261);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlTotal);
            Controls.Add(lblTotalApplicants);
            Controls.Add(btnLogout);
            Controls.Add(btnInterviews);
            Controls.Add(btnScreenings);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Dashboard";
            Load += DashboardForm_Load;
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnScreenings;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTotalApplicants;
        private System.Windows.Forms.Label lblPendingScreenings;
        private System.Windows.Forms.Label lblInterviews;
        private System.Windows.Forms.Label lblHired;
        private System.Windows.Forms.Label lblApplicants;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}