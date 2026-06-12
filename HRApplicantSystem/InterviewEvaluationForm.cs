using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class InterviewEvaluationForm : Form
    {
        private int _scheduleID;
        private int _applicationID;

        //private Label lblApplicantName, lblJobTitle, lblInterviewDate, lblInterviewStatus;
        //private Label valApplicantName, valJobTitle, valInterviewDate, valInterviewStatus;
        //private Label lblScore, lblResult, lblRemarks, lblTitle;
        //private TextBox txtScore, txtRemarks;
        //private ComboBox cmbResult;
        //private Button btnSave, btnCancel;
        //private Panel pnlInfo;

        public InterviewEvaluationForm(int scheduleID)
        {
            MessageBox.Show("Schedule ID = " + scheduleID);

            _scheduleID = scheduleID;
            InitializeControls();
            LoadInterviewInfo();
        }

        private void InitializeControls()
        {
            this.Text = "Interview Evaluation";
            this.Size = new System.Drawing.Size(550, 520);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label()
            {
                Text = "Interview Evaluation",
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(20, 15),
                AutoSize = true
            };

            pnlInfo = new Panel()
            {
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(510, 120),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
            };

            int lx = 10, vx = 160, sy = 10, g = 25;
            lblApplicantName = MakeLabel("Applicant:", lx, sy); valApplicantName = MakeLabel("", vx, sy);
            lblJobTitle = MakeLabel("Job Applied:", lx, sy + g); valJobTitle = MakeLabel("", vx, sy + g);
            lblInterviewDate = MakeLabel("Interview Date:", lx, sy + g * 2); valInterviewDate = MakeLabel("", vx, sy + g * 2);
            lblInterviewStatus = MakeLabel("Interview Status:", lx, sy + g * 3); valInterviewStatus = MakeLabel("", vx, sy + g * 3);

            pnlInfo.Controls.AddRange(new Control[]
            {
                lblApplicantName, valApplicantName,
                lblJobTitle, valJobTitle,
                lblInterviewDate, valInterviewDate,
                lblInterviewStatus, valInterviewStatus
            });

            lblScore = new Label() { Text = "Score (0-100):", Location = new System.Drawing.Point(20, 190), AutoSize = true };
            txtScore = new TextBox() { Location = new System.Drawing.Point(160, 187), Width = 100 };

            lblResult = new Label() { Text = "Result:", Location = new System.Drawing.Point(20, 225), AutoSize = true };
            cmbResult = new ComboBox()
            {
                Location = new System.Drawing.Point(160, 222),
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbResult.Items.AddRange(new string[] { "Pass", "Fail" });
            cmbResult.SelectedIndex = 0;

            lblRemarks = new Label() { Text = "Remarks:", Location = new System.Drawing.Point(20, 260), AutoSize = true };
            txtRemarks = new TextBox()
            {
                Location = new System.Drawing.Point(160, 257),
                Width = 340,
                Height = 100,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            btnSave = new Button() { Text = "Save Evaluation", Location = new System.Drawing.Point(160, 375), Width = 150 };
            btnSave.Click += BtnSave_Click;

            btnCancel = new Button() { Text = "Cancel", Location = new System.Drawing.Point(325, 375), Width = 100 };
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[]
            {
                lblTitle, pnlInfo,
                lblScore, txtScore,
                lblResult, cmbResult,
                lblRemarks, txtRemarks,
                btnSave, btnCancel
            });
        }

        private Label MakeLabel(string text, int x, int y)
        {
            return new Label() { Text = text, Location = new System.Drawing.Point(x, y), AutoSize = true };
        }

        private void LoadInterviewInfo()
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
                            sch.InterviewDate,
                            sch.Status,
                            sch.ApplicationID
                        FROM InterviewSchedules sch
                        JOIN Applications app ON sch.ApplicationID = app.ApplicationID
                        JOIN ApplicantAccounts acc ON app.AccountID = acc.AccountID
                        JOIN Applicants a ON acc.AccountID = a.AccountID
                        JOIN JobVacancies j ON app.JobID = j.JobID
                        WHERE sch.ScheduleID = @schedID";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@schedID", _scheduleID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            valApplicantName.Text = reader["FullName"].ToString();
                            valJobTitle.Text = reader["JobTitle"].ToString();
                            valInterviewDate.Text = Convert.ToDateTime(reader["InterviewDate"]).ToString("MMM dd, yyyy hh:mm tt");
                            valInterviewStatus.Text = reader["Status"].ToString();
                            _applicationID = Convert.ToInt32(reader["ApplicationID"]);

                            if (reader["Status"].ToString() != "Completed")
                            {
                                MessageBox.Show("Interview is not yet marked as Completed. Evaluation cannot be saved.");
                                btnSave.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Interview record not found.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading interview info: " + ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtScore.Text.Trim(), out decimal score) || score < 0 || score > 100)
            {
                MessageBox.Show("Please enter a valid score between 0 and 100.");
                txtScore.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRemarks.Text))
            {
                MessageBox.Show("Please enter remarks.");
                txtRemarks.Focus();
                return;
            }

            string result = cmbResult.SelectedItem.ToString();
            string newStatus = result == "Pass" ? "For Final Review" : "Rejected";

            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22"))
                {
                    conn.Open();

                    var cmdEval = new MySqlCommand(@"
                        INSERT INTO InterviewEvaluations (ScheduleID, Score, Remarks, Result, EvaluatedBy)
                        VALUES (@schedID, @score, @remarks, @result, @evalBy)", conn);
                    cmdEval.Parameters.AddWithValue("@schedID", _scheduleID);
                    cmdEval.Parameters.AddWithValue("@score", score);
                    cmdEval.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                    cmdEval.Parameters.AddWithValue("@result", result);
                    cmdEval.Parameters.AddWithValue("@evalBy", Session.UserID);
                    cmdEval.ExecuteNonQuery();

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
                    cmdHistory.Parameters.AddWithValue("@remarks", $"Interview evaluation saved. Result: {result}. Score: {score}.");
                    cmdHistory.ExecuteNonQuery();

                    var cmdAudit = new MySqlCommand(@"
                        INSERT INTO AuditTrail (UserType, UserID, Action)
                        VALUES (@userType, @userID, @action)", conn);
                    cmdAudit.Parameters.AddWithValue("@userType", Session.Role);
                    cmdAudit.Parameters.AddWithValue("@userID", Session.UserID);
                    cmdAudit.Parameters.AddWithValue("@action", $"Saved interview evaluation for ApplicationID {_applicationID}. Result: {result}.");
                    cmdAudit.ExecuteNonQuery();
                }

                MessageBox.Show($"Evaluation saved. Status updated to: {newStatus}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving evaluation: " + ex.Message);
            }
        }
    }
}