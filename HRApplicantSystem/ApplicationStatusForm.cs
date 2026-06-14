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

        private const string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

        public ApplicationStatusForm()
        {
            InitializeComponent();
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
                SELECT jv.JobTitle, a.Status, a.AppliedDate
                FROM Applications a
                INNER JOIN JobVacancies jv ON a.JobID = jv.JobID
                WHERE a.AccountID = @ApplicantID
                ORDER BY a.ApplicationID DESC
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
                                Lblank1.Text = reader["JobTitle"].ToString();
                                Lblank2.Text = reader["AppliedDate"].ToString();
                                Lblank3.Text = reader["Status"].ToString();
                            }
                            else
                            {
                                Lblank1.Text = "Have not yet applied.";
                                Lblank2.Text = "Date unavailable.";
                                Lblank3.Text = "Status unavailable.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application info: " + ex.Message);
            }
        }

        private void LoadStatusHistory()
        {
            string query = @"
                SELECT jv.JobTitle, a.Status, a.AppliedDate
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

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["JobTitle"].ToString());
                                item.SubItems.Add(reader["Status"].ToString());
                                item.SubItems.Add(reader["AppliedDate"].ToString());
                                LVStatus.Items.Add(item);
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
    }
}