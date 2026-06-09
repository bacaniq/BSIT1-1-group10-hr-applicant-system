namespace HRApplicantSystem
{
    partial class ApplicantDashboardForm
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
            lblWelcome = new Label();
            lblStatus = new Label();
            lblStatusValue = new Label();
            lblMissing = new Label();
            lblMissingValue = new Label();
            lblInterview = new Label();
            lblInterviewValue = new Label();
            btnProfile = new Button();
            btnJobs = new Button();
            btnApplication = new Button();
            btnDocuments = new Button();
            btnStatus = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.SteelBlue;
            lblWelcome.Location = new Point(25, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(129, 29);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(144, 82);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(144, 17);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Application Status:";
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.ForeColor = Color.Gray;
            lblStatusValue.Location = new Point(422, 83);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(104, 15);
            lblStatusValue.TabIndex = 2;
            lblStatusValue.Text = "No application yet";
            // 
            // lblMissing
            // 
            lblMissing.AutoSize = true;
            lblMissing.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMissing.Location = new Point(144, 123);
            lblMissing.Name = "lblMissing";
            lblMissing.Size = new Size(152, 17);
            lblMissing.TabIndex = 3;
            lblMissing.Text = "Missing Documents:";
            // 
            // lblMissingValue
            // 
            lblMissingValue.AutoSize = true;
            lblMissingValue.ForeColor = Color.Red;
            lblMissingValue.Location = new Point(463, 123);
            lblMissingValue.Name = "lblMissingValue";
            lblMissingValue.Size = new Size(12, 15);
            lblMissingValue.TabIndex = 4;
            lblMissingValue.Text = "-";
            // 
            // lblInterview
            // 
            lblInterview.AutoSize = true;
            lblInterview.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterview.Location = new Point(144, 164);
            lblInterview.Name = "lblInterview";
            lblInterview.Size = new Size(130, 17);
            lblInterview.TabIndex = 5;
            lblInterview.Text = "Interview Schedule:";
            // 
            // lblInterviewValue
            // 
            lblInterviewValue.AutoSize = true;
            lblInterviewValue.ForeColor = Color.Gray;
            lblInterviewValue.Location = new Point(418, 166);
            lblInterviewValue.Name = "lblInterviewValue";
            lblInterviewValue.Size = new Size(131, 15);
            lblInterviewValue.TabIndex = 6;
            lblInterviewValue.Text = "No interview scheduled";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.SteelBlue;
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(92, 227);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(153, 57);
            btnProfile.TabIndex = 7;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click_1;
            // 
            // btnJobs
            // 
            btnJobs.BackColor = Color.SteelBlue;
            btnJobs.ForeColor = Color.White;
            btnJobs.Location = new Point(393, 227);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(153, 57);
            btnJobs.TabIndex = 8;
            btnJobs.Text = "View Job Vacancies";
            btnJobs.UseVisualStyleBackColor = false;
            btnJobs.Click += btnJobs_Click;
            // 
            // btnApplication
            // 
            btnApplication.BackColor = Color.SteelBlue;
            btnApplication.ForeColor = Color.White;
            btnApplication.Location = new Point(92, 352);
            btnApplication.Name = "btnApplication";
            btnApplication.Size = new Size(153, 57);
            btnApplication.TabIndex = 9;
            btnApplication.Text = "My Application";
            btnApplication.UseVisualStyleBackColor = false;
            btnApplication.Click += btnApplication_Click_1;
            // 
            // btnDocuments
            // 
            btnDocuments.BackColor = Color.SteelBlue;
            btnDocuments.ForeColor = Color.White;
            btnDocuments.Location = new Point(393, 290);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(153, 57);
            btnDocuments.TabIndex = 10;
            btnDocuments.Text = "My Documents";
            btnDocuments.UseVisualStyleBackColor = false;
            btnDocuments.Click += btnDocuments_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.SteelBlue;
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(92, 290);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(153, 57);
            btnStatus.TabIndex = 11;
            btnStatus.Text = "Application Status";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(580, 367);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 43);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // ApplicantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 437);
            Controls.Add(btnLogout);
            Controls.Add(btnStatus);
            Controls.Add(btnDocuments);
            Controls.Add(btnApplication);
            Controls.Add(btnJobs);
            Controls.Add(btnProfile);
            Controls.Add(lblInterviewValue);
            Controls.Add(lblInterview);
            Controls.Add(lblMissingValue);
            Controls.Add(lblMissing);
            Controls.Add(lblStatusValue);
            Controls.Add(lblStatus);
            Controls.Add(lblWelcome);
            Name = "ApplicantDashboardForm";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblMissing;
        private System.Windows.Forms.Label lblMissingValue;
        private System.Windows.Forms.Label lblInterview;
        private System.Windows.Forms.Label lblInterviewValue;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnLogout;
    }
}