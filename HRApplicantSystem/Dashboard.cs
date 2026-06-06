using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class Dashboard : Form
    {
        public static int ApplicantID = 1;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                var conn = DBConnection.GetConnection();
                conn.Open();

                string nameQuery = "SELECT FirstName, LastName FROM Applicants WHERE ApplicantID = " + ApplicantID;
                MySqlCommand nameCmd = new MySqlCommand(nameQuery, conn);
                MySqlDataReader nameReader = nameCmd.ExecuteReader();
                if (nameReader.Read())
                {
                    lblWelcome.Text = "Welcome, " + nameReader["FirstName"] + "!";
                }
                nameReader.Close();

                string statusQuery = "SELECT Status FROM Applications WHERE ApplicantID = " + ApplicantID;
                MySqlCommand statusCmd = new MySqlCommand(statusQuery, conn);
                MySqlDataReader statusReader = statusCmd.ExecuteReader();
                if (statusReader.Read())
                {
                    lblStatusValue.Text = statusReader["Status"].ToString();
                }
                else
                {
                    lblStatusValue.Text = "No application yet";
                }
                statusReader.Close();

                string docQuery = "SELECT COUNT(*) FROM ApplicantDocuments WHERE ApplicantID = " + ApplicantID + " AND Status = 'Missing'";
                MySqlCommand docCmd = new MySqlCommand(docQuery, conn);
                int missingCount = Convert.ToInt32(docCmd.ExecuteScalar());
                lblMissingValue.Text = missingCount.ToString();

                string intQuery = "SELECT i.ScheduledDate, i.Mode FROM InterviewSchedules i " +
                                  "JOIN Applications a ON i.ApplicationID = a.ApplicationID " +
                                  "WHERE a.ApplicantID = " + ApplicantID;
                MySqlCommand intCmd = new MySqlCommand(intQuery, conn);
                MySqlDataReader intReader = intCmd.ExecuteReader();
                if (intReader.Read())
                {
                    lblInterviewValue.Text = intReader["ScheduledDate"] + " - " + intReader["Mode"];
                }
                else
                {
                    lblInterviewValue.Text = "No interview scheduled";
                }
                intReader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Profile - Coming Soon!");
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            JobVacancies jobForm = new JobVacancies();
            jobForm.Show();
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Application - Coming Soon!");
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            MyDocuments docsForm = new MyDocuments();
            docsForm.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Status - Coming Soon!");
        }
    }
}