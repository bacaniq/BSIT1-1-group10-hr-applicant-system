namespace HRApplicantSystem
{
    partial class Dashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblMissing = new System.Windows.Forms.Label();
            this.lblMissingValue = new System.Windows.Forms.Label();
            this.lblInterview = new System.Windows.Forms.Label();
            this.lblInterviewValue = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblWelcome.Location = new System.Drawing.Point(29, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(154, 36);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(165, 89);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(168, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Application Status:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.ForeColor = System.Drawing.Color.Gray;
            this.lblStatusValue.Location = new System.Drawing.Point(482, 89);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(115, 16);
            this.lblStatusValue.TabIndex = 2;
            this.lblStatusValue.Text = "No application yet";
            // 
            // lblMissing
            // 
            this.lblMissing.AutoSize = true;
            this.lblMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissing.Location = new System.Drawing.Point(165, 131);
            this.lblMissing.Name = "lblMissing";
            this.lblMissing.Size = new System.Drawing.Size(181, 20);
            this.lblMissing.TabIndex = 3;
            this.lblMissing.Text = "Missing Documents:";
            // 
            // lblMissingValue
            // 
            this.lblMissingValue.AutoSize = true;
            this.lblMissingValue.ForeColor = System.Drawing.Color.Red;
            this.lblMissingValue.Location = new System.Drawing.Point(529, 131);
            this.lblMissingValue.Name = "lblMissingValue";
            this.lblMissingValue.Size = new System.Drawing.Size(11, 16);
            this.lblMissingValue.TabIndex = 4;
            this.lblMissingValue.Text = "-";
            // 
            // lblInterview
            // 
            this.lblInterview.AutoSize = true;
            this.lblInterview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterview.Location = new System.Drawing.Point(165, 177);
            this.lblInterview.Name = "lblInterview";
            this.lblInterview.Size = new System.Drawing.Size(154, 20);
            this.lblInterview.TabIndex = 5;
            this.lblInterview.Text = "Interview Schedule:";
            // 
            // lblInterviewValue
            // 
            this.lblInterviewValue.AutoSize = true;
            this.lblInterviewValue.ForeColor = System.Drawing.Color.Gray;
            this.lblInterviewValue.Location = new System.Drawing.Point(478, 177);
            this.lblInterviewValue.Name = "lblInterviewValue";
            this.lblInterviewValue.Size = new System.Drawing.Size(146, 16);
            this.lblInterviewValue.TabIndex = 6;
            this.lblInterviewValue.Text = "No interview scheduled";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(105, 242);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(175, 61);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnJobs
            // 
            this.btnJobs.BackColor = System.Drawing.Color.SteelBlue;
            this.btnJobs.ForeColor = System.Drawing.Color.White;
            this.btnJobs.Location = new System.Drawing.Point(449, 242);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(175, 61);
            this.btnJobs.TabIndex = 8;
            this.btnJobs.Text = "View Job Vacancies";
            this.btnJobs.UseVisualStyleBackColor = false;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApplication.ForeColor = System.Drawing.Color.White;
            this.btnApplication.Location = new System.Drawing.Point(105, 376);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(175, 61);
            this.btnApplication.TabIndex = 9;
            this.btnApplication.Text = "My Application";
            this.btnApplication.UseVisualStyleBackColor = false;
            // 
            // btnDocuments
            // 
            this.btnDocuments.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDocuments.ForeColor = System.Drawing.Color.White;
            this.btnDocuments.Location = new System.Drawing.Point(449, 309);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(175, 61);
            this.btnDocuments.TabIndex = 10;
            this.btnDocuments.Text = "My Documents";
            this.btnDocuments.UseVisualStyleBackColor = false;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(105, 309);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(175, 61);
            this.btnStatus.TabIndex = 11;
            this.btnStatus.Text = "Application Status";
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(663, 391);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 46);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 466);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnDocuments);
            this.Controls.Add(this.btnApplication);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblInterviewValue);
            this.Controls.Add(this.lblInterview);
            this.Controls.Add(this.lblMissingValue);
            this.Controls.Add(this.lblMissing);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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