using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class HiringDecisionForm : Form
    {
        private int _applicationID;

        //private Label lblApplicantName, lblJobTitle, lblCurrentStatus;
        //private Label valApplicantName, valJobTitle, valCurrentStatus;
        //private Label lblDecision, lblRemarks, lblTitle, lblWarning;
        //private ComboBox cmbDecision;
        //private TextBox txtRemarks;
        //private Button btnConfirm, btnCancel;
        //private Panel pnlInfo, pnlWarning;

        public HiringDecisionForm(int applicationID)
        {
            _applicationID = applicationID;
            InitializeControls();
            CheckRoleAccess();
            LoadApplicantInfo();
        }

        private void InitializeControls()
        {
            this.Text = "Final Hiring Decision";
            this.Size = new System.Drawing.Size(520, 470);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label()
            {
                Text = "Final Hiring Decision",
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(20, 15),
                AutoSize = true
            };

            pnlWarning = new Panel()
            {
                Location = new System.Drawing.Point(10, 45),
                Size = new System.Drawing.Size(480, 35),
                BackColor = System.Drawing.Color.FromArgb(255, 220, 220),
                Visible = false
            };
            lblWarning = new Label()
            {
                Text = "Access Restricted: Only HR Manager or Admin can make final hiring decisions.",
                Location = new System.Drawing.Point(5, 8),
                AutoSize = true,
                ForeColor = System.Drawing.Color.DarkRed
            };
            pnlWarning.Controls.Add(lblWarning);

            pnlInfo = new Panel()
            {
                Location = new System.Drawing.Point(10, 90),
                Size = new System.Drawing.Size(480, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.FromArgb(240, 248, 255)
            };

            int lx = 10, vx = 150, sy = 10, g = 28;
            lblApplicantName = MakeLabel("Applicant:", lx, sy); valApplicantName = MakeLabel("", vx, sy);
            lblJobTitle = MakeLabel("Job Applied:", lx, sy + g); valJobTitle = MakeLabel("", vx, sy + g);
            lblCurrentStatus = MakeLabel("Current Status:", lx, sy + g * 2); valCurrentStatus = MakeLabel("", vx, sy + g * 2);

            pnlInfo.Controls.AddRange(new Control[]
            {
                lblApplicantName, valApplicantName,
                lblJobTitle, valJobTitle,
                lblCurrentStatus, valCurrentStatus
            });

            lblDecision = new Label() { Text = "Decision:", Location = new System.Drawing.Point(20, 210), AutoSize = true };
            cmbDecision = new ComboBox()
            {
                Location = new System.Drawing.Point(150, 207),
                Width = 180,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbDecision.Items.AddRange(new string[] { "Accepted", "Rejected", "On Hold" });
            cmbDecision.SelectedIndex = 0;

            lblRemarks = new Label() { Text = "Remarks:", Location = new System.Drawing.Point(20, 248), AutoSize = true };
            txtRemarks = new TextBox()
            {
                Location = new System.Drawing.Point(150, 245),
                Width = 330,
                Height = 90,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            btnConfirm = new Button()
            {
                Text = "Confirm Decision",
                Location = new System.Drawing.Point(150, 355),
                Width = 160,
                BackColor = System.Drawing.Color.FromArgb(0, 120, 215),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnConfirm.Click += BtnConfirm_Click;

            btnCancel = new Button() { Text = "Cancel", Location = new System.Drawing.Point(325, 355), Width = 100 };
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[]
            {
                lblTitle, pnlWarning, pnlInfo,
                lblDecision, cmbDecision,
                lblRemarks, txtRemarks,
                btnConfirm, btnCancel
            });
        }

        private Label MakeLabel(string text, int x, int y)
        {
            return new Label() { Text = text, Location = new System.Drawing.Point(x, y), AutoSize = true };
        }

        private void CheckRoleAccess()
        {
            if (!Session.IsHRManager)
            {
                pnlWarning.Visible = true;
                cmbDecision.Enabled = false;
                txtRemarks.Enabled = false;
                btnConfirm.Enabled = false;
            }
        }

        private void LoadApplicantInfo()
        {
            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22;"))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            CONCAT(a.FirstName, ' ', a.LastName) AS FullName,
                            j.JobTitle,
                            app.Status
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
                            valApplicantName.Text = reader["FullName"].ToString();
                            valJobTitle.Text = reader["JobTitle"].ToString();
                            valCurrentStatus.Text = reader["Status"].ToString();

                            if (reader["Status"].ToString() != "For Final Review")
                            {
                                MessageBox.Show("This application is not yet at the Final Review stage.");
                                btnConfirm.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicant info: " + ex.Message);
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRemarks.Text))
            {
                MessageBox.Show("Please enter remarks for this decision.");
                txtRemarks.Focus();
                return;
            }

            string decision = cmbDecision.SelectedItem.ToString();

            var confirm = MessageBox.Show(
                $"Mark this applicant as '{decision}'? This cannot be undone.",
                "Confirm Hiring Decision",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            string newStatus = decision == "On Hold" ? "For Final Review" : decision;

            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22;"))
                {
                    conn.Open();

                    var cmdDecision = new MySqlCommand(@"
                        INSERT INTO HiringDecisions (ApplicationID, Decision, Remarks, DecidedBy)
                        VALUES (@appID, @decision, @remarks, @decidedBy)", conn);
                    cmdDecision.Parameters.AddWithValue("@appID", _applicationID);
                    cmdDecision.Parameters.AddWithValue("@decision", decision);
                    cmdDecision.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                    cmdDecision.Parameters.AddWithValue("@decidedBy", Session.UserID);
                    cmdDecision.ExecuteNonQuery();

                    var cmdApp = new MySqlCommand("UPDATE Applications SET Status = @status WHERE ApplicationID = @appID", conn);
                    cmdApp.Parameters.AddWithValue("@status", newStatus);
                    cmdApp.Parameters.AddWithValue("@appID", _applicationID);
                    cmdApp.ExecuteNonQuery();

                    var cmdHistory = new MySqlCommand(@"
                        INSERT INTO ApplicationStatusHistory (ApplicationID, Status, ChangedBy, Remarks)
                        VALUES (@appID, @status, @changedBy, @remarks)", conn);
                    cmdHistory.Parameters.AddWithValue("@appID", _applicationID);
                    cmdHistory.Parameters.AddWithValue("@status", newStatus);
                    cmdHistory.Parameters.AddWithValue("@changedBy", Session.FullName);
                    cmdHistory.Parameters.AddWithValue("@remarks", $"Final decision: {decision}. {txtRemarks.Text.Trim()}");
                    cmdHistory.ExecuteNonQuery();

                    var cmdAudit = new MySqlCommand(@"
                        INSERT INTO AuditTrail (UserType, UserID, Action)
                        VALUES (@userType, @userID, @action)", conn);
                    cmdAudit.Parameters.AddWithValue("@userType", Session.Role);
                    cmdAudit.Parameters.AddWithValue("@userID", Session.UserID);
                    cmdAudit.Parameters.AddWithValue("@action", $"Final decision '{decision}' for ApplicationID {_applicationID} by {Session.FullName}.");
                    cmdAudit.ExecuteNonQuery();
                }

                MessageBox.Show($"Decision saved. Status updated to: {newStatus}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving decision: " + ex.Message);
            }
        }
    }
}
