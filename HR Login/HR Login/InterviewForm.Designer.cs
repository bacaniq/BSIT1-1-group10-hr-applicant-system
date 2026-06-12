namespace HR_Login
{
    partial class InterviewForm
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
            this.dgvInterviews = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInterview = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPassed = new System.Windows.Forms.Button();
            this.btnFailed = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalInterviews = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.lblScheduledTitle = new System.Windows.Forms.Label();
            this.lblScheduled = new System.Windows.Forms.Label();
            this.pnlPassed = new System.Windows.Forms.Panel();
            this.lblPassedTitle = new System.Windows.Forms.Label();
            this.lblPassed = new System.Windows.Forms.Label();
            this.pnlFailed = new System.Windows.Forms.Panel();
            this.lblFailedTitle = new System.Windows.Forms.Label();
            this.lblFailed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviews)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.pnlSchedule.SuspendLayout();
            this.pnlPassed.SuspendLayout();
            this.pnlFailed.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInterviews
            // 
            this.dgvInterviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterviews.Location = new System.Drawing.Point(12, 233);
            this.dgvInterviews.Name = "dgvInterviews";
            this.dgvInterviews.Size = new System.Drawing.Size(776, 216);
            this.dgvInterviews.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(261, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnInterview
            // 
            this.btnInterview.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterview.Location = new System.Drawing.Point(42, 464);
            this.btnInterview.Name = "btnInterview";
            this.btnInterview.Size = new System.Drawing.Size(126, 23);
            this.btnInterview.TabIndex = 8;
            this.btnInterview.Text = "Schedule Interview";
            this.btnInterview.UseVisualStyleBackColor = true;
            this.btnInterview.Click += new System.EventHandler(this.btnInterview_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(432, 464);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(529, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPassed
            // 
            this.btnPassed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassed.Location = new System.Drawing.Point(194, 464);
            this.btnPassed.Name = "btnPassed";
            this.btnPassed.Size = new System.Drawing.Size(97, 23);
            this.btnPassed.TabIndex = 11;
            this.btnPassed.Text = "Mark Passed";
            this.btnPassed.UseVisualStyleBackColor = true;
            this.btnPassed.Click += new System.EventHandler(this.btnPassed_Click);
            // 
            // btnFailed
            // 
            this.btnFailed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFailed.Location = new System.Drawing.Point(317, 464);
            this.btnFailed.Name = "btnFailed";
            this.btnFailed.Size = new System.Drawing.Size(97, 23);
            this.btnFailed.TabIndex = 12;
            this.btnFailed.Text = "Mark Failed";
            this.btnFailed.UseVisualStyleBackColor = true;
            this.btnFailed.Click += new System.EventHandler(this.btnFailed_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(630, 464);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalInterviews
            // 
            this.lblTotalInterviews.AutoSize = true;
            this.lblTotalInterviews.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterviews.ForeColor = System.Drawing.Color.White;
            this.lblTotalInterviews.Location = new System.Drawing.Point(85, 44);
            this.lblTotalInterviews.Name = "lblTotalInterviews";
            this.lblTotalInterviews.Size = new System.Drawing.Size(38, 45);
            this.lblTotalInterviews.TabIndex = 14;
            this.lblTotalInterviews.Text = "0";
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTotal.Controls.Add(this.lblTotalTitle);
            this.pnlTotal.Controls.Add(this.lblTotalInterviews);
            this.pnlTotal.Location = new System.Drawing.Point(12, 72);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTotal.Size = new System.Drawing.Size(180, 100);
            this.pnlTotal.TabIndex = 14;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.Location = new System.Drawing.Point(44, 25);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(127, 17);
            this.lblTotalTitle.TabIndex = 16;
            this.lblTotalTitle.Text = "📋 Total Interviews";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlSchedule.Controls.Add(this.lblScheduledTitle);
            this.pnlSchedule.Controls.Add(this.lblScheduled);
            this.pnlSchedule.Location = new System.Drawing.Point(210, 72);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSchedule.Size = new System.Drawing.Size(180, 100);
            this.pnlSchedule.TabIndex = 15;
            // 
            // lblScheduledTitle
            // 
            this.lblScheduledTitle.AutoSize = true;
            this.lblScheduledTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledTitle.Location = new System.Drawing.Point(72, 25);
            this.lblScheduledTitle.Name = "lblScheduledTitle";
            this.lblScheduledTitle.Size = new System.Drawing.Size(94, 17);
            this.lblScheduledTitle.TabIndex = 17;
            this.lblScheduledTitle.Text = "🕒 Scheduled";
            // 
            // lblScheduled
            // 
            this.lblScheduled.AutoSize = true;
            this.lblScheduled.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduled.ForeColor = System.Drawing.Color.White;
            this.lblScheduled.Location = new System.Drawing.Point(88, 44);
            this.lblScheduled.Name = "lblScheduled";
            this.lblScheduled.Size = new System.Drawing.Size(38, 45);
            this.lblScheduled.TabIndex = 15;
            this.lblScheduled.Text = "0";
            // 
            // pnlPassed
            // 
            this.pnlPassed.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlPassed.Controls.Add(this.lblPassedTitle);
            this.pnlPassed.Controls.Add(this.lblPassed);
            this.pnlPassed.Location = new System.Drawing.Point(405, 72);
            this.pnlPassed.Name = "pnlPassed";
            this.pnlPassed.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPassed.Size = new System.Drawing.Size(180, 100);
            this.pnlPassed.TabIndex = 16;
            // 
            // lblPassedTitle
            // 
            this.lblPassedTitle.AutoSize = true;
            this.lblPassedTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassedTitle.Location = new System.Drawing.Point(78, 25);
            this.lblPassedTitle.Name = "lblPassedTitle";
            this.lblPassedTitle.Size = new System.Drawing.Size(73, 17);
            this.lblPassedTitle.TabIndex = 18;
            this.lblPassedTitle.Text = "✅ Passed";
            // 
            // lblPassed
            // 
            this.lblPassed.AutoSize = true;
            this.lblPassed.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassed.ForeColor = System.Drawing.Color.White;
            this.lblPassed.Location = new System.Drawing.Point(87, 44);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(38, 45);
            this.lblPassed.TabIndex = 16;
            this.lblPassed.Text = "0";
            // 
            // pnlFailed
            // 
            this.pnlFailed.BackColor = System.Drawing.Color.IndianRed;
            this.pnlFailed.Controls.Add(this.lblFailedTitle);
            this.pnlFailed.Controls.Add(this.lblFailed);
            this.pnlFailed.Location = new System.Drawing.Point(608, 72);
            this.pnlFailed.Name = "pnlFailed";
            this.pnlFailed.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFailed.Size = new System.Drawing.Size(180, 100);
            this.pnlFailed.TabIndex = 17;
            // 
            // lblFailedTitle
            // 
            this.lblFailedTitle.AutoSize = true;
            this.lblFailedTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailedTitle.Location = new System.Drawing.Point(77, 25);
            this.lblFailedTitle.Name = "lblFailedTitle";
            this.lblFailedTitle.Size = new System.Drawing.Size(68, 17);
            this.lblFailedTitle.TabIndex = 19;
            this.lblFailedTitle.Text = "❌ Failed";
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailed.ForeColor = System.Drawing.Color.White;
            this.lblFailed.Location = new System.Drawing.Point(81, 44);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(38, 45);
            this.lblFailed.TabIndex = 17;
            this.lblFailed.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Interview Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search Applicant:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(127, 192);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // InterviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFailed);
            this.Controls.Add(this.pnlPassed);
            this.Controls.Add(this.pnlSchedule);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFailed);
            this.Controls.Add(this.btnPassed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInterview);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvInterviews);
            this.Name = "InterviewForm";
            this.Text = "Interview Management";
            this.Load += new System.EventHandler(this.InterviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviews)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlSchedule.ResumeLayout(false);
            this.pnlSchedule.PerformLayout();
            this.pnlPassed.ResumeLayout(false);
            this.pnlPassed.PerformLayout();
            this.pnlFailed.ResumeLayout(false);
            this.pnlFailed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInterviews;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInterview;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPassed;
        private System.Windows.Forms.Button btnFailed;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalInterviews;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.Panel pnlPassed;
        private System.Windows.Forms.Panel pnlFailed;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblScheduled;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblScheduledTitle;
        private System.Windows.Forms.Label lblPassedTitle;
        private System.Windows.Forms.Label lblFailedTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
    }
}