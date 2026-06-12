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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnScreenings = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lblTotalApplicants = new System.Windows.Forms.Label();
            this.lblPendingScreenings = new System.Windows.Forms.Label();
            this.lblInterviews = new System.Windows.Forms.Label();
            this.lblHired = new System.Windows.Forms.Label();
            this.lblApplicants = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(331, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HR Dashboard";
            // 
            // btnScreenings
            // 
            this.btnScreenings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenings.Location = new System.Drawing.Point(249, 171);
            this.btnScreenings.Name = "btnScreenings";
            this.btnScreenings.Size = new System.Drawing.Size(81, 33);
            this.btnScreenings.TabIndex = 5;
            this.btnScreenings.Text = "Screenings";
            this.btnScreenings.UseVisualStyleBackColor = true;
            this.btnScreenings.Click += new System.EventHandler(this.btnScreenings_Click);
            // 
            // btnInterviews
            // 
            this.btnInterviews.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterviews.Location = new System.Drawing.Point(457, 171);
            this.btnInterviews.Name = "btnInterviews";
            this.btnInterviews.Size = new System.Drawing.Size(75, 33);
            this.btnInterviews.TabIndex = 6;
            this.btnInterviews.Text = "Interviews";
            this.btnInterviews.UseVisualStyleBackColor = true;
            this.btnInterviews.Click += new System.EventHandler(this.btnInterviews_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(360, 225);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(81, 225);
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
            this.lblPendingScreenings.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingScreenings.ForeColor = System.Drawing.Color.White;
            this.lblPendingScreenings.Location = new System.Drawing.Point(124, 45);
            this.lblPendingScreenings.Name = "lblPendingScreenings";
            this.lblPendingScreenings.Size = new System.Drawing.Size(38, 45);
            this.lblPendingScreenings.TabIndex = 10;
            this.lblPendingScreenings.Text = "0";
            // 
            // lblInterviews
            // 
            this.lblInterviews.AutoSize = true;
            this.lblInterviews.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviews.ForeColor = System.Drawing.Color.White;
            this.lblInterviews.Location = new System.Drawing.Point(129, 45);
            this.lblInterviews.Name = "lblInterviews";
            this.lblInterviews.Size = new System.Drawing.Size(38, 45);
            this.lblInterviews.TabIndex = 11;
            this.lblInterviews.Text = "0";
            // 
            // lblHired
            // 
            this.lblHired.AutoSize = true;
            this.lblHired.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHired.ForeColor = System.Drawing.Color.White;
            this.lblHired.Location = new System.Drawing.Point(129, 44);
            this.lblHired.Name = "lblHired";
            this.lblHired.Size = new System.Drawing.Size(38, 45);
            this.lblHired.TabIndex = 12;
            this.lblHired.Text = "0";
            // 
            // lblApplicants
            // 
            this.lblApplicants.AutoSize = true;
            this.lblApplicants.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicants.ForeColor = System.Drawing.Color.White;
            this.lblApplicants.Location = new System.Drawing.Point(129, 45);
            this.lblApplicants.Name = "lblApplicants";
            this.lblApplicants.Size = new System.Drawing.Size(38, 45);
            this.lblApplicants.TabIndex = 14;
            this.lblApplicants.Text = "0";
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTotal.Controls.Add(this.lblTotalTitle);
            this.pnlTotal.Controls.Add(this.lblApplicants);
            this.pnlTotal.Location = new System.Drawing.Point(12, 65);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTotal.Size = new System.Drawing.Size(180, 100);
            this.pnlTotal.TabIndex = 15;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.Location = new System.Drawing.Point(59, 27);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(108, 17);
            this.lblTotalTitle.TabIndex = 16;
            this.lblTotalTitle.Text = "Total Applicants";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPendingScreenings);
            this.panel1.Location = new System.Drawing.Point(204, 65);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(180, 100);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pending Screenings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblInterviews);
            this.panel2.Location = new System.Drawing.Point(400, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(180, 100);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Interviews Today";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblHired);
            this.panel3.Location = new System.Drawing.Point(598, 65);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(180, 100);
            this.panel3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hired Applicants";
            // 
            // DashboardForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 261);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.lblTotalApplicants);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnInterviews);
            this.Controls.Add(this.btnScreenings);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnScreenings;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTestConnection;
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