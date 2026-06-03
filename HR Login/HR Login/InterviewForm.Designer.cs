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
            this.lblTotalInterviews = new System.Windows.Forms.Label();
            this.lblScheduled = new System.Windows.Forms.Label();
            this.lblPassed = new System.Windows.Forms.Label();
            this.lblFailed = new System.Windows.Forms.Label();
            this.dgvInterviews = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInterview = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPassed = new System.Windows.Forms.Button();
            this.btnFailed = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviews)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalInterviews
            // 
            this.lblTotalInterviews.AutoSize = true;
            this.lblTotalInterviews.Location = new System.Drawing.Point(103, 13);
            this.lblTotalInterviews.Name = "lblTotalInterviews";
            this.lblTotalInterviews.Size = new System.Drawing.Size(17, 13);
            this.lblTotalInterviews.TabIndex = 0;
            this.lblTotalInterviews.Text = "\"\"";
            // 
            // lblScheduled
            // 
            this.lblScheduled.AutoSize = true;
            this.lblScheduled.Location = new System.Drawing.Point(79, 45);
            this.lblScheduled.Name = "lblScheduled";
            this.lblScheduled.Size = new System.Drawing.Size(17, 13);
            this.lblScheduled.TabIndex = 1;
            this.lblScheduled.Text = "\"\"";
            // 
            // lblPassed
            // 
            this.lblPassed.AutoSize = true;
            this.lblPassed.Location = new System.Drawing.Point(200, 13);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(17, 13);
            this.lblPassed.TabIndex = 2;
            this.lblPassed.Text = "\"\"";
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Location = new System.Drawing.Point(193, 45);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(17, 13);
            this.lblFailed.TabIndex = 3;
            this.lblFailed.Text = "\"\"";
            // 
            // dgvInterviews
            // 
            this.dgvInterviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterviews.Location = new System.Drawing.Point(12, 106);
            this.dgvInterviews.Name = "dgvInterviews";
            this.dgvInterviews.Size = new System.Drawing.Size(776, 216);
            this.dgvInterviews.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPassed);
            this.panel1.Controls.Add(this.lblTotalInterviews);
            this.panel1.Controls.Add(this.lblFailed);
            this.panel1.Controls.Add(this.lblScheduled);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(443, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 88);
            this.panel1.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(114, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Search Applicant: ____________________";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(343, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnInterview
            // 
            this.btnInterview.Location = new System.Drawing.Point(64, 328);
            this.btnInterview.Name = "btnInterview";
            this.btnInterview.Size = new System.Drawing.Size(126, 23);
            this.btnInterview.TabIndex = 8;
            this.btnInterview.Text = "Schedule Interview";
            this.btnInterview.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(41, 357);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPassed
            // 
            this.btnPassed.Location = new System.Drawing.Point(122, 357);
            this.btnPassed.Name = "btnPassed";
            this.btnPassed.Size = new System.Drawing.Size(97, 23);
            this.btnPassed.TabIndex = 11;
            this.btnPassed.Text = "Mark Passed";
            this.btnPassed.UseVisualStyleBackColor = true;
            // 
            // btnFailed
            // 
            this.btnFailed.Location = new System.Drawing.Point(122, 386);
            this.btnFailed.Name = "btnFailed";
            this.btnFailed.Size = new System.Drawing.Size(97, 23);
            this.btnFailed.TabIndex = 12;
            this.btnFailed.Text = "Mark Failed";
            this.btnFailed.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(79, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Interviews:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Scheduled:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Passed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Failed:";
            // 
            // InterviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFailed);
            this.Controls.Add(this.btnPassed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInterview);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvInterviews);
            this.Name = "InterviewForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviews)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalInterviews;
        private System.Windows.Forms.Label lblScheduled;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.DataGridView dgvInterviews;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInterview;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPassed;
        private System.Windows.Forms.Button btnFailed;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}