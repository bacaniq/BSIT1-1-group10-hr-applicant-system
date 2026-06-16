namespace HRApplicantSystem
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
            dgvInterviews = new DataGridView();
            btnSearch = new Button();
            btnInterview = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnPassed = new Button();
            btnFailed = new Button();
            btnBack = new Button();
            lblTotalInterviews = new Label();
            pnlTotal = new Panel();
            lblTotalTitle = new Label();
            pnlSchedule = new Panel();
            lblScheduledTitle = new Label();
            lblScheduled = new Label();
            pnlPassed = new Panel();
            lblPassedTitle = new Label();
            lblPassed = new Label();
            pnlFailed = new Panel();
            lblFailedTitle = new Label();
            lblFailed = new Label();
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).BeginInit();
            pnlTotal.SuspendLayout();
            pnlSchedule.SuspendLayout();
            pnlPassed.SuspendLayout();
            pnlFailed.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInterviews
            // 
            dgvInterviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInterviews.Location = new Point(14, 269);
            dgvInterviews.Margin = new Padding(4, 3, 4, 3);
            dgvInterviews.Name = "dgvInterviews";
            dgvInterviews.Size = new Size(905, 249);
            dgvInterviews.TabIndex = 4;
            dgvInterviews.CellClick += dgvInterviews_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(304, 222);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnInterview
            // 
            btnInterview.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInterview.Location = new Point(49, 535);
            btnInterview.Margin = new Padding(4, 3, 4, 3);
            btnInterview.Name = "btnInterview";
            btnInterview.Size = new Size(147, 27);
            btnInterview.TabIndex = 8;
            btnInterview.Text = "Schedule Interview";
            btnInterview.UseVisualStyleBackColor = true;
            btnInterview.Click += btnInterview_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(504, 535);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 27);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(617, 535);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPassed
            // 
            btnPassed.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPassed.Location = new Point(226, 535);
            btnPassed.Margin = new Padding(4, 3, 4, 3);
            btnPassed.Name = "btnPassed";
            btnPassed.Size = new Size(113, 27);
            btnPassed.TabIndex = 11;
            btnPassed.Text = "Mark Passed";
            btnPassed.UseVisualStyleBackColor = true;
            btnPassed.Click += btnPassed_Click;
            // 
            // btnFailed
            // 
            btnFailed.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFailed.Location = new Point(370, 535);
            btnFailed.Margin = new Padding(4, 3, 4, 3);
            btnFailed.Name = "btnFailed";
            btnFailed.Size = new Size(113, 27);
            btnFailed.TabIndex = 12;
            btnFailed.Text = "Mark Failed";
            btnFailed.UseVisualStyleBackColor = true;
            btnFailed.Click += btnFailed_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(735, 535);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 27);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTotalInterviews
            // 
            lblTotalInterviews.AutoSize = true;
            lblTotalInterviews.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInterviews.ForeColor = Color.White;
            lblTotalInterviews.Location = new Point(99, 51);
            lblTotalInterviews.Margin = new Padding(4, 0, 4, 0);
            lblTotalInterviews.Name = "lblTotalInterviews";
            lblTotalInterviews.Size = new Size(38, 45);
            lblTotalInterviews.TabIndex = 14;
            lblTotalInterviews.Text = "0";
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.SteelBlue;
            pnlTotal.Controls.Add(lblTotalTitle);
            pnlTotal.Controls.Add(lblTotalInterviews);
            pnlTotal.Location = new Point(14, 83);
            pnlTotal.Margin = new Padding(4, 3, 4, 3);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Padding = new Padding(12, 12, 12, 12);
            pnlTotal.Size = new Size(210, 115);
            pnlTotal.TabIndex = 14;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTitle.Location = new Point(51, 29);
            lblTotalTitle.Margin = new Padding(4, 0, 4, 0);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(127, 17);
            lblTotalTitle.TabIndex = 16;
            lblTotalTitle.Text = "📋 Total Interviews";
            // 
            // pnlSchedule
            // 
            pnlSchedule.BackColor = Color.Goldenrod;
            pnlSchedule.Controls.Add(lblScheduledTitle);
            pnlSchedule.Controls.Add(lblScheduled);
            pnlSchedule.Location = new Point(245, 83);
            pnlSchedule.Margin = new Padding(4, 3, 4, 3);
            pnlSchedule.Name = "pnlSchedule";
            pnlSchedule.Padding = new Padding(12, 12, 12, 12);
            pnlSchedule.Size = new Size(210, 115);
            pnlSchedule.TabIndex = 15;
            // 
            // lblScheduledTitle
            // 
            lblScheduledTitle.AutoSize = true;
            lblScheduledTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScheduledTitle.Location = new Point(84, 29);
            lblScheduledTitle.Margin = new Padding(4, 0, 4, 0);
            lblScheduledTitle.Name = "lblScheduledTitle";
            lblScheduledTitle.Size = new Size(94, 17);
            lblScheduledTitle.TabIndex = 17;
            lblScheduledTitle.Text = "🕒 Scheduled";
            // 
            // lblScheduled
            // 
            lblScheduled.AutoSize = true;
            lblScheduled.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScheduled.ForeColor = Color.White;
            lblScheduled.Location = new Point(103, 51);
            lblScheduled.Margin = new Padding(4, 0, 4, 0);
            lblScheduled.Name = "lblScheduled";
            lblScheduled.Size = new Size(38, 45);
            lblScheduled.TabIndex = 15;
            lblScheduled.Text = "0";
            // 
            // pnlPassed
            // 
            pnlPassed.BackColor = Color.ForestGreen;
            pnlPassed.Controls.Add(lblPassedTitle);
            pnlPassed.Controls.Add(lblPassed);
            pnlPassed.Location = new Point(472, 83);
            pnlPassed.Margin = new Padding(4, 3, 4, 3);
            pnlPassed.Name = "pnlPassed";
            pnlPassed.Padding = new Padding(12, 12, 12, 12);
            pnlPassed.Size = new Size(210, 115);
            pnlPassed.TabIndex = 16;
            // 
            // lblPassedTitle
            // 
            lblPassedTitle.AutoSize = true;
            lblPassedTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassedTitle.Location = new Point(91, 29);
            lblPassedTitle.Margin = new Padding(4, 0, 4, 0);
            lblPassedTitle.Name = "lblPassedTitle";
            lblPassedTitle.Size = new Size(73, 17);
            lblPassedTitle.TabIndex = 18;
            lblPassedTitle.Text = "✅ Passed";
            // 
            // lblPassed
            // 
            lblPassed.AutoSize = true;
            lblPassed.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassed.ForeColor = Color.White;
            lblPassed.Location = new Point(102, 51);
            lblPassed.Margin = new Padding(4, 0, 4, 0);
            lblPassed.Name = "lblPassed";
            lblPassed.Size = new Size(38, 45);
            lblPassed.TabIndex = 16;
            lblPassed.Text = "0";
            // 
            // pnlFailed
            // 
            pnlFailed.BackColor = Color.IndianRed;
            pnlFailed.Controls.Add(lblFailedTitle);
            pnlFailed.Controls.Add(lblFailed);
            pnlFailed.Location = new Point(709, 83);
            pnlFailed.Margin = new Padding(4, 3, 4, 3);
            pnlFailed.Name = "pnlFailed";
            pnlFailed.Padding = new Padding(12, 12, 12, 12);
            pnlFailed.Size = new Size(210, 115);
            pnlFailed.TabIndex = 17;
            // 
            // lblFailedTitle
            // 
            lblFailedTitle.AutoSize = true;
            lblFailedTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFailedTitle.Location = new Point(90, 29);
            lblFailedTitle.Margin = new Padding(4, 0, 4, 0);
            lblFailedTitle.Name = "lblFailedTitle";
            lblFailedTitle.Size = new Size(68, 17);
            lblFailedTitle.TabIndex = 19;
            lblFailedTitle.Text = "❌ Failed";
            // 
            // lblFailed
            // 
            lblFailed.AutoSize = true;
            lblFailed.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFailed.ForeColor = Color.White;
            lblFailed.Location = new Point(94, 51);
            lblFailed.Margin = new Padding(4, 0, 4, 0);
            lblFailed.Name = "lblFailed";
            lblFailed.Size = new Size(38, 45);
            lblFailed.TabIndex = 17;
            lblFailed.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 30);
            label1.TabIndex = 18;
            label1.Text = "Interview Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 225);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 13);
            label2.TabIndex = 19;
            label2.Text = "Search Applicant:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(148, 222);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(148, 23);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // InterviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 582);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlFailed);
            Controls.Add(pnlPassed);
            Controls.Add(pnlSchedule);
            Controls.Add(pnlTotal);
            Controls.Add(btnBack);
            Controls.Add(btnFailed);
            Controls.Add(btnPassed);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInterview);
            Controls.Add(btnSearch);
            Controls.Add(dgvInterviews);
            Margin = new Padding(4, 3, 4, 3);
            Name = "InterviewForm";
            Text = "Interview Management";
            Load += InterviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInterviews).EndInit();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            pnlSchedule.ResumeLayout(false);
            pnlSchedule.PerformLayout();
            pnlPassed.ResumeLayout(false);
            pnlPassed.PerformLayout();
            pnlFailed.ResumeLayout(false);
            pnlFailed.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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