namespace HRApplicantSystem
{
    partial class ApplicantListForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.btnReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Applicant List";

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 60);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Name/Email:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(150, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 2;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(370, 60);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Filter by Status:";

            // cmbStatusFilter
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Items.AddRange(new object[] {
                "All", "Draft", "Submitted", "Under Review",
                "Shortlisted", "For Interview", "For Assessment",
                "For Final Review", "Accepted", "Rejected", "Withdrawn"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(470, 57);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(160, 23);
            this.cmbStatusFilter.TabIndex = 4;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(645, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);

            // dgvApplicants
            this.dgvApplicants.AllowUserToAddRows = false;
            this.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplicants.Location = new System.Drawing.Point(20, 95);
            this.dgvApplicants.MultiSelect = false;
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.ReadOnly = true;
            this.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicants.Size = new System.Drawing.Size(840, 400);
            this.dgvApplicants.TabIndex = 6;

            // btnReview
            this.btnReview.Location = new System.Drawing.Point(730, 510);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(130, 27);
            this.btnReview.TabIndex = 7;
            this.btnReview.Text = "Open Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.BtnReview_Click);

            // ApplicantListForm
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvApplicants);
            this.Controls.Add(this.btnReview);
            this.Name = "ApplicantListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.Button btnReview;
    }
}
