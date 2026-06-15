using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class ApplicationStatusForm : Form
    {
        private int ApplicantID => ApplicantDashboardForm.ApplicantID;

        private const string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22;";

        private int currentApplicationID = -1;
        private string currentStatus = "";

        private int selectedApplicationID = -1;
        private string selectedStatus = "";

        private bool hasSubmittedApplication = false;

        public ApplicationStatusForm()
        {
            InitializeComponent();

            LVStatus.FullRowSelect = true;
            LVStatus.MultiSelect = false;
            LVStatus.HideSelection = false;
            LVStatus.SelectedIndexChanged += LVStatus_SelectedIndexChanged;
        }

        private void ApplicationStatusForm_Load(object sender, EventArgs e)
        {
            LoadApplicationInfo();
            LoadStatusHistory();
            LoadInterviewSchedule();
            LoadHRRemarks();
        }

        private void LoadApplicationInfo()
        {
            string query = @"
                SELECT a.ApplicationID, jv.JobTitle, a.Status, a.AppliedDate
                FROM Applications a
                INNER JOIN JobVacancies jv ON a.JobID = jv.JobID
                WHERE a.AccountID = @ApplicantID
                ORDER BY 
                CASE WHEN a.Status = 'Submitted' THEN 0 ELSE 1 END ASC,
                a.ApplicationID DESC
                LIMIT 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", ApplicantID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                                currentStatus = reader["Status"].ToString();

                                Lblank1.Text = reader["JobTitle"].ToString();
                                Lblank2.Text = reader["AppliedDate"].ToString();
                                Lblank3.Text = currentStatus;
                            }
                            else
                            {
                                currentApplicationID = -1;
                                currentStatus = "";

                                Lblank1.Text = "Have not yet applied.";
                                Lblank2.Text = "Date unavailable.";
                                Lblank3.Text = "Status unavailable.";
                            }
                        }
                    }
                }

                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application info: " + ex.Message);
            }
        }

        private void LVStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVStatus.SelectedItems.Count == 0)
            {
                selectedApplicationID = -1;
                selectedStatus = "";
                UpdateButtonStates();
                return;
            }

            ListViewItem selected = LVStatus.SelectedItems[0];

            selectedApplicationID = (int)selected.Tag;
            selectedStatus = selected.SubItems[1].Text;

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            if (hasSubmittedApplication)
            {
                btSubmit.Enabled = false;

                if (selectedApplicationID != -1 && selectedStatus.Trim() == "Submitted")
                    btWithdraw.Enabled = true;
                else
                    btWithdraw.Enabled = false;

                return;
            }

            if (selectedApplicationID == -1)
            {
                btSubmit.Enabled = false;
                btWithdraw.Enabled = false;
                return;
            }

            string status = selectedStatus.Trim();

            if (status == "Applied" || status == "Rejected" || status == "Unqualified")
            {
                btSubmit.Enabled = true;
                btWithdraw.Enabled = false;
            }
            else if (status == "Submitted")
            {
                btSubmit.Enabled = false;
                btWithdraw.Enabled = true;
            }
            else
            {
                btSubmit.Enabled = false;
                btWithdraw.Enabled = false;
            }
        }

        private void LoadStatusHistory()
        {
            string query = @"
                SELECT a.ApplicationID, jv.JobTitle, a.Status, a.AppliedDate
                FROM Applications a
                INNER JOIN JobVacancies jv ON a.JobID = jv.JobID
                WHERE a.AccountID = @ApplicantID
                ORDER BY a.AppliedDate ASC";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", ApplicantID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            LVStatus.Items.Clear();
                            hasSubmittedApplication = false;

                            while (reader.Read())
                            {
                                string rowStatus = reader["Status"].ToString();

                                ListViewItem item = new ListViewItem(reader["JobTitle"].ToString());
                                item.SubItems.Add(rowStatus);
                                item.SubItems.Add(reader["AppliedDate"].ToString());
                                item.Tag = Convert.ToInt32(reader["ApplicationID"]);

                                LVStatus.Items.Add(item);

                                if (rowStatus == "Submitted" ||
                                    (rowStatus != "Applied" && rowStatus != "Rejected" &&
                                     rowStatus != "Unqualified" && rowStatus != ""))
                                {
                                    hasSubmittedApplication = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading status history: " + ex.Message);
            }
        }

        private void LoadInterviewSchedule()
        {
            string query = @"
                SELECT isch.InterviewDate
                FROM InterviewSchedules isch
                INNER JOIN Applications a ON isch.ApplicationID = a.ApplicationID
                WHERE a.AccountID = @ApplicantID
                ORDER BY isch.InterviewDate DESC
                LIMIT 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", ApplicantID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LBSchedule.Text = Convert.ToDateTime(reader["InterviewDate"])
                                    .ToString("MMM dd, yyyy hh:mm tt");
                            }
                            else
                            {
                                Lblank4.Text = "No scheduled interview yet.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading interview schedule: " + ex.Message);
            }
        }

        private void LoadHRRemarks()
        {
            string query = @"
                SELECT ie.Remarks
                FROM InterviewEvaluations ie
                INNER JOIN InterviewSchedules isch ON ie.ScheduleID = isch.ScheduleID
                INNER JOIN Applications a ON isch.ApplicationID = a.ApplicationID
                WHERE a.AccountID = @ApplicantID
                ORDER BY ie.ScheduleID DESC
                LIMIT 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", ApplicantID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            LBHRRemark.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["Remarks"].ToString());
                                LBHRRemark.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading HR remarks: " + ex.Message);
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (selectedApplicationID == -1)
            {
                MessageBox.Show("Please select a job application from the Timeline first.");
                return;
            }

            string query = @"
                UPDATE Applications
                SET Status = 'Submitted'
                WHERE ApplicationID = @ApplicationID AND AccountID = @ApplicantID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", selectedApplicationID);
                        cmd.Parameters.AddWithValue("@ApplicantID", ApplicantID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            selectedStatus = "Submitted";
                            hasSubmittedApplication = true;

                            LVStatus.SelectedItems[0].SubItems[1].Text = "Submitted";

                            currentApplicationID = selectedApplicationID;
                            currentStatus = "Submitted";
                            Lblank1.Text = LVStatus.SelectedItems[0].SubItems[0].Text;
                            Lblank2.Text = LVStatus.SelectedItems[0].SubItems[2].Text;
                            Lblank3.Text = "Submitted";

                            MessageBox.Show("Your application has been submitted successfully.");
                            UpdateButtonStates();
                        }

                        else
                        {
                            MessageBox.Show("Failed to submit the application. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting application: " + ex.Message);
            }
        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {
            if (selectedApplicationID == -1)
            {
                MessageBox.Show("Please select a job application from the Timeline first.");
                return;
            }

            string query = @"
                UPDATE Applications
                SET Status = 'Applied'
                WHERE ApplicationID = @ApplicationID AND AccountID = @ApplicantID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", selectedApplicationID);
                        cmd.Parameters.AddWithValue("@ApplicantID", ApplicantID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            selectedStatus = "Applied";
                            hasSubmittedApplication = false;

                            LVStatus.SelectedItems[0].SubItems[1].Text = "Applied";

                            MessageBox.Show("Your application has been withdrawn successfully.");
                            LoadApplicationInfo();
                            UpdateButtonStates();
                        }

                        else
                        {
                            MessageBox.Show("Failed to withdraw the application. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error withdrawing application: " + ex.Message);
            }
        }
    }
}