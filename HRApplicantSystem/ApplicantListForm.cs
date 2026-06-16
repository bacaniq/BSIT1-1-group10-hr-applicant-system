using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{

    public partial class ApplicantListForm : Form
    {

        //private DataGridView dgvApplicants;
        //private TextBox txtSearch;
        //private ComboBox cmbStatusFilter;
        //private Button btnSearch;
        //private Button btnReview;
        //private Label lblTitle;
        //private Label lblSearch;
        //private Label lblStatus;

        public ApplicantListForm()
        {
            InitializeComponent();
            LoadApplicants();
        }


        private void LoadApplicants(string search = "", string statusFilter = "All")
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT
                    app.ApplicationID,
                    CONCAT(a.FirstName, ' ', a.LastName) AS FullName,
                    acc.Email,
                    j.JobTitle,
                    app.Status,
                    app.AppliedDate
                FROM Applications app
                INNER JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                INNER JOIN Applicants a ON acc.AccountID = a.AccountID
                INNER JOIN JobVacancies j ON app.JobID = j.JobID
                WHERE
                (
                    @search = '' OR
                    CONCAT(a.FirstName, ' ', a.LastName) LIKE CONCAT('%', @search, '%')
                    OR acc.Email LIKE CONCAT('%', @search, '%')
                )
                AND
                (
                    @status = 'All'
                    OR app.Status = @status
                )
                ORDER BY app.ApplicationID DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@status", statusFilter);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvApplicants.AutoGenerateColumns = true;
                    dgvApplicants.DataSource = dt;
                    dgvApplicants.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadApplicants(txtSearch.Text.Trim(), cmbStatusFilter.SelectedItem.ToString());
        }

        private void BtnReview_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            // Get the ApplicationID from the hidden column
            int applicationID = Convert.ToInt32(dgvApplicants.SelectedRows[0].Cells["ApplicationID"].Value);

            var reviewForm = new ApplicantReviewForm(applicationID);
            reviewForm.ShowDialog();

            LoadApplicants();
        }
    }


    // =============================================
    // ApplicantReviewForm.cs  (Shawn's Module 1 continued)
    // HR views full applicant details and can lock
    // the application to start review (sets status
    // to "Under Review" and prevents applicant edits).
    // =============================================
    public class ApplicantReviewForm : Form
    {
        private int _applicationID;

        // Display labels
        private Label lblName, lblEmail, lblContact, lblAddress;
        private Label lblEducation, lblSkills, lblWork;
        private Label lblJob, lblStatus, lblAppliedDate;
        private Label lblDocuments;

        // Values
        private Label valName, valEmail, valContact, valAddress;
        private Label valEducation, valSkills, valWork;
        private Label valJob, valStatus, valAppliedDate;

        private DataGridView dgvDocuments;
        private Button btnLockReview;
        private Button btnClose;
        private Button btnFinalDecision;
        private Panel pnlInfo;


        public ApplicantReviewForm(int applicationID)
        {
            _applicationID = applicationID;
            InitializeControls();
            LoadApplicantDetails();
            LoadDocuments();

        }

        private void InitializeControls()
        {
            this.Text = "Applicant Review";
            this.Size = new System.Drawing.Size(750, 650);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Info panel
            pnlInfo = new Panel()
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(710, 280),
                BorderStyle = BorderStyle.FixedSingle
            };

            int labelX = 10, valX = 180, startY = 10, gap = 28;

            lblName = MakeLabel("Full Name:", labelX, startY); valName = MakeLabel("", valX, startY);
            lblEmail = MakeLabel("Email:", labelX, startY + gap); valEmail = MakeLabel("", valX, startY + gap);
            lblContact = MakeLabel("Contact:", labelX, startY + gap * 2); valContact = MakeLabel("", valX, startY + gap * 2);
            lblAddress = MakeLabel("Address:", labelX, startY + gap * 3); valAddress = MakeLabel("", valX, startY + gap * 3);
            lblEducation = MakeLabel("Education:", labelX, startY + gap * 4); valEducation = MakeLabel("", valX, startY + gap * 4);
            lblSkills = MakeLabel("Skills:", labelX, startY + gap * 5); valSkills = MakeLabel("", valX, startY + gap * 5);
            lblWork = MakeLabel("Work Exp:", labelX, startY + gap * 6); valWork = MakeLabel("", valX, startY + gap * 6);
            lblJob = MakeLabel("Applied Job:", labelX, startY + gap * 7); valJob = MakeLabel("", valX, startY + gap * 7);
            lblStatus = MakeLabel("Status:", labelX, startY + gap * 8); valStatus = MakeLabel("", valX, startY + gap * 8);
            lblAppliedDate = MakeLabel("Applied Date:", labelX, startY + gap * 9); valAppliedDate = MakeLabel("", valX, startY + gap * 9);

            pnlInfo.Controls.AddRange(new Control[]
            {
                lblName, valName, lblEmail, valEmail,
                lblContact, valContact, lblAddress, valAddress,
                lblEducation, valEducation, lblSkills, valSkills,
                lblWork, valWork, lblJob, valJob,
                lblStatus, valStatus, lblAppliedDate, valAppliedDate
            });

            lblDocuments = new Label()
            {
                Text = "Submitted Documents:",
                Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(10, 300),
                AutoSize = true
            };

            dgvDocuments = new DataGridView()
            {
                Location = new System.Drawing.Point(10, 325),
                Size = new System.Drawing.Size(710, 200),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            btnFinalDecision = new Button()
            {
                Text = "Final Hiring Decision",
                Location = new System.Drawing.Point(430, 540),
                Width = 170
            };

            btnFinalDecision.Click += BtnFinalDecision_Click;

            this.Controls.Add(btnFinalDecision);

            btnLockReview = new Button()
            {
                Text = "Start Review (Lock Application)",
                Location = new System.Drawing.Point(10, 540),
                Width = 220
            };
            btnLockReview.Click += BtnLockReview_Click;

            btnClose = new Button()
            {
                Text = "Close",
                Location = new System.Drawing.Point(620, 540),
                Width = 100
            };
            btnClose.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[]
            {
                pnlInfo, lblDocuments, dgvDocuments,
                btnLockReview, btnClose
            });


        }

        private Label MakeLabel(string text, int x, int y)
        {
            return new Label()
            {
                Text = text,
                Location = new System.Drawing.Point(x, y),
                AutoSize = true
            };
        }

        private void LoadApplicantDetails()
        {
            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22;"))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            CONCAT(a.FirstName, ' ', a.LastName) AS FullName,
                            acc.Email,
                            a.ContactNumber,
                            a.Address,
                            a.Education,
                            a.Skills,
                            a.WorkExperience,
                            j.JobTitle,
                            app.Status,
                            app.AppliedDate
                        FROM Applications app
                        JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                        JOIN Applicants a ON acc.AccountID = a.AccountID
                        JOIN JobVacancies j ON app.JobID = j.JobID
                        WHERE app.ApplicationID = @appID";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appID", _applicationID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            valName.Text = reader["FullName"].ToString();
                            valEmail.Text = reader["Email"].ToString();
                            valContact.Text = reader["ContactNumber"].ToString();
                            valAddress.Text = reader["Address"].ToString();
                            valEducation.Text = reader["Education"].ToString();
                            valSkills.Text = reader["Skills"].ToString();
                            valWork.Text = reader["WorkExperience"].ToString();
                            valJob.Text = reader["JobTitle"].ToString();
                            valStatus.Text = reader["Status"].ToString();
                            valAppliedDate.Text = Convert.ToDateTime(reader["AppliedDate"]).ToString("MMM dd, yyyy");


                            string status = reader["Status"].ToString();
                            if (status == "Rejected" || status == "Hired")
                                btnLockReview.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicant details: " + ex.Message);
            }
        }

        private void LoadDocuments()
        {
            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22;"))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            rt.RequirementName AS Document,
                            ad.Status,
                            ad.Remarks
                        FROM ApplicantDocuments ad
                        JOIN RequirementTypes rt ON ad.RequirementTypeID = rt.RequirementTypeID
                        WHERE ad.ApplicationID = @appID";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appID", _applicationID);

                    var adapter = new MySqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvDocuments.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message);
            }
        }


        private void BtnLockReview_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "This will lock the application and prevent the applicant from editing. Continue?",
                "Confirm Review Lock",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22;"))
                {
                    conn.Open();

                    // 1. Update application status
                    string updateApp = "UPDATE Applications SET Status = 'Under Review' WHERE ApplicationID = @appID";
                    var cmdUpdate = new MySqlCommand(updateApp, conn);
                    cmdUpdate.Parameters.AddWithValue("@appID", _applicationID);
                    cmdUpdate.ExecuteNonQuery();

                    // 2. Log to ApplicationStatusHistory
                    string insertHistory = @"
                        INSERT INTO ApplicationStatusHistory 
                            (ApplicationID, Status, ChangedBy, Remarks)
                        VALUES 
                            (@appID, 'Under Review', @changedBy, 'HR started review. Application locked.')";
                    var cmdHistory = new MySqlCommand(insertHistory, conn);
                    cmdHistory.Parameters.AddWithValue("@appID", _applicationID);
                    cmdHistory.Parameters.AddWithValue("@changedBy", Session.FullName);
                    cmdHistory.ExecuteNonQuery();

                    // 3. Log to AuditTrail
                    string insertAudit = @"
                        INSERT INTO AuditTrail (UserType, UserID, Action)
                        VALUES (@userType, @userID, @action)";
                    var cmdAudit = new MySqlCommand(insertAudit, conn);
                    cmdAudit.Parameters.AddWithValue("@userType", Session.Role);
                    cmdAudit.Parameters.AddWithValue("@userID", Session.UserID);
                    cmdAudit.Parameters.AddWithValue("@action", $"Locked ApplicationID {_applicationID} for review.");
                    cmdAudit.ExecuteNonQuery();
                }

                MessageBox.Show("Application is now Under Review. Applicant can no longer edit.");
                valStatus.Text = "Under Review";
                btnLockReview.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error locking application: " + ex.Message);
            }


        }
        private void BtnFinalDecision_Click(object sender, EventArgs e)
        {
            HiringDecisionForm frm = new HiringDecisionForm(_applicationID);
            frm.ShowDialog();
        }
    }
}