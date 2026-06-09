using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class ReportsForm : Form
    {
        // Control fields are defined in the designer partial class (ReportsForm.Designer.cs).
        public ReportsForm()
        {

            InitializeControls();
        }

        private void InitializeControls()
        {
            this.Text = "Reports";
            this.Size = new System.Drawing.Size(1000, 620);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label()
            {
                Text = "HR Reports",
                Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(20, 15),
                AutoSize = true
            };

            pnlTop = new Panel()
            {
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(960, 50),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
            };

            lblSelectReport = new Label() { Text = "Report Type:", Location = new System.Drawing.Point(10, 14), AutoSize = true };

            cmbReportType = new ComboBox()
            {
                Location = new System.Drawing.Point(100, 11),
                Width = 250,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbReportType.Items.AddRange(new string[]
            {
                "All Applicants",
                "Pending Applications",
                "Interview Schedule Report",
                "Accepted Applicants",
                "Rejected Applicants",
                "Missing Requirements Report"
            });
            cmbReportType.SelectedIndex = 0;

            btnGenerate = new Button()
            {
                Text = "Generate Report",
                Location = new System.Drawing.Point(365, 9),
                Width = 140,
                BackColor = System.Drawing.Color.FromArgb(0, 120, 215),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnGenerate.Click += BtnGenerate_Click;

            btnPrint = new Button() { Text = "Print / Export", Location = new System.Drawing.Point(515, 9), Width = 130 };
            btnPrint.Click += BtnPrint_Click;

            pnlTop.Controls.AddRange(new Control[] { lblSelectReport, cmbReportType, btnGenerate, btnPrint });

            dgvReport = new DataGridView()
            {
                Location = new System.Drawing.Point(10, 115),
                Size = new System.Drawing.Size(960, 430),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = System.Drawing.Color.FromArgb(240, 248, 255)
                }
            };

            lblCount = new Label()
            {
                Text = "Total Records: 0",
                Location = new System.Drawing.Point(10, 112),
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Italic)
            };

            this.Controls.AddRange(new Control[] { lblTitle, pnlTop, lblCount, dgvReport });
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            switch (cmbReportType.SelectedItem.ToString())
            {
                case "All Applicants": GenerateAllApplicants(); break;
                case "Pending Applications": GeneratePendingApplications(); break;
                case "Interview Schedule Report": GenerateInterviewScheduleReport(); break;
                case "Accepted Applicants": GenerateAcceptedApplicants(); break;
                case "Rejected Applicants": GenerateRejectedApplicants(); break;
                case "Missing Requirements Report": GenerateMissingRequirements(); break;
            }
        }

        private void GenerateAllApplicants()
        {
            string query = @"
                SELECT 
                    app.ApplicationID AS 'App ID',
                    CONCAT(a.FirstName, ' ', a.LastName) AS 'Full Name',
                    acc.Email AS 'Email',
                    j.JobTitle AS 'Job Applied',
                    d.DepartmentName AS 'Department',
                    app.Status AS 'Status',
                    DATE_FORMAT(app.AppliedDate, '%b %d, %Y') AS 'Date Applied'
                FROM Applications app
                JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                JOIN Applicants a ON acc.AccountID = a.AccountID
                JOIN JobVacancies j ON app.JobID = j.JobID
                JOIN Departments d ON j.DepartmentID = d.DepartmentID
                ORDER BY app.AppliedDate DESC";

            LoadReport(query, "All Applicants");
        }

        private void GeneratePendingApplications()
        {
            string query = @"
                SELECT 
                    app.ApplicationID AS 'App ID',
                    CONCAT(a.FirstName, ' ', a.LastName) AS 'Full Name',
                    acc.Email AS 'Email',
                    j.JobTitle AS 'Job Applied',
                    app.Status AS 'Status',
                    DATE_FORMAT(app.AppliedDate, '%b %d, %Y') AS 'Date Applied'
                FROM Applications app
                JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                JOIN Applicants a ON acc.AccountID = a.AccountID
                JOIN JobVacancies j ON app.JobID = j.JobID
                WHERE app.Status IN ('Draft', 'Submitted')
                ORDER BY app.AppliedDate ASC";

            LoadReport(query, "Pending Applications");
        }

        private void GenerateInterviewScheduleReport()
        {
            string query = @"
                SELECT 
                    sch.ScheduleID AS 'Schedule ID',
                    CONCAT(a.FirstName, ' ', a.LastName) AS 'Applicant',
                    j.JobTitle AS 'Job',
                    DATE_FORMAT(sch.InterviewDate, '%b %d, %Y %h:%i %p') AS 'Interview Date',
                    u.FullName AS 'Interviewer',
                    sch.Mode AS 'Mode',
                    sch.Location AS 'Location',
                    sch.Status AS 'Status'
                FROM InterviewSchedules sch
                JOIN Applications app ON sch.ApplicationID = app.ApplicationID
                JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                JOIN Applicants a ON acc.AccountID = a.AccountID
                JOIN JobVacancies j ON app.JobID = j.JobID
                JOIN Users u ON sch.Interviewer = u.UserID
                ORDER BY sch.InterviewDate DESC";

            LoadReport(query, "Interview Schedule Report");
        }

        private void GenerateAcceptedApplicants()
        {
            string query = @"
                SELECT 
                    app.ApplicationID AS 'App ID',
                    CONCAT(a.FirstName, ' ', a.LastName) AS 'Full Name',
                    acc.Email AS 'Email',
                    a.ContactNumber AS 'Contact',
                    j.JobTitle AS 'Job',
                    d.DepartmentName AS 'Department',
                    hd.Remarks AS 'Decision Remarks',
                    u.FullName AS 'Decided By',
                    DATE_FORMAT(hd.DecidedAt, '%b %d, %Y') AS 'Decision Date'
                FROM Applications app
                JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                JOIN Applicants a ON acc.AccountID = a.AccountID
                JOIN JobVacancies j ON app.JobID = j.JobID
                JOIN Departments d ON j.DepartmentID = d.DepartmentID
                JOIN HiringDecisions hd ON app.ApplicationID = hd.ApplicationID
                JOIN Users u ON hd.DecidedBy = u.UserID
                WHERE app.Status = 'Accepted'
                ORDER BY hd.DecidedAt DESC";

            LoadReport(query, "Accepted Applicants");
        }

        private void GenerateRejectedApplicants()
        {
            string query = @"
                SELECT 
                    app.ApplicationID AS 'App ID',
                    CONCAT(a.FirstName, ' ', a.LastName) AS 'Full Name',
                    acc.Email AS 'Email',
                    j.JobTitle AS 'Job',
                    d.DepartmentName AS 'Department',
                    hd.Remarks AS 'Rejection Remarks',
                    u.FullName AS 'Decided By',
                    DATE_FORMAT(hd.DecidedAt, '%b %d, %Y') AS 'Decision Date'
                FROM Applications app
                JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                JOIN Applicants a ON acc.AccountID = a.AccountID
                JOIN JobVacancies j ON app.JobID = j.JobID
                JOIN Departments d ON j.DepartmentID = d.DepartmentID
                JOIN HiringDecisions hd ON app.ApplicationID = hd.ApplicationID
                JOIN Users u ON hd.DecidedBy = u.UserID
                WHERE app.Status = 'Rejected'
                ORDER BY hd.DecidedAt DESC";

            LoadReport(query, "Rejected Applicants");
        }

        private void GenerateMissingRequirements()
        {
            string query = @"
                SELECT 
                    app.ApplicationID AS 'App ID',
                    CONCAT(a.FirstName, ' ', a.LastName) AS 'Full Name',
                    acc.Email AS 'Email',
                    j.JobTitle AS 'Job Applied',
                    app.Status AS 'App Status',
                    rt.RequirementName AS 'Missing Document',
                    ad.Remarks AS 'Remarks'
                FROM ApplicantDocuments ad
                JOIN Applications app ON ad.ApplicationID = app.ApplicationID
                JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                JOIN Applicants a ON acc.AccountID = a.AccountID
                JOIN JobVacancies j ON app.JobID = j.JobID
                JOIN RequirementTypes rt ON ad.RequirementTypeID = rt.RequirementTypeID";

            LoadReport(query, "Missing Requirements Report");
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print feature not yet implemented.");
        }

        private void LoadReport(string query, string reportName)
        {
            MessageBox.Show(reportName);
        }
    }
}
