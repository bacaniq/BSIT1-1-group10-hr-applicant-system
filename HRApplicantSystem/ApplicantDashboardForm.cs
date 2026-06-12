using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace HRApplicantSystem
{
    public partial class ApplicantDashboardForm : Form
    {
        public static int ApplicantID
        {
            get
            {
                return ApplicantLogInFormFull.Form1.SessionManager.LoggedInAccountID;
            }
        }

        public ApplicantDashboardForm()
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
                var connectionString = DBConnection.GetConnection();
                connectionString.Open();

                string nameQuery = "SELECT FirstName, LastName FROM applicants WHERE AccountID = " + ApplicantID;
                MySqlCommand nameCmd = new MySqlCommand(nameQuery, connectionString);
                MySqlDataReader nameReader = nameCmd.ExecuteReader();
                if (nameReader.Read())
                {
                    lblWelcome.Text = "Welcome, " + nameReader["FirstName"] + "!";
                }
                nameReader.Close();

                string statusQuery = "SELECT Status FROM Applications WHERE AccountID = " + ApplicantID;
                MySqlCommand statusCmd = new MySqlCommand(statusQuery, connectionString);
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

                lblMissingValue.Text = "0";

                string intQuery = "SELECT i.InterviewDate, i.Mode FROM InterviewSchedules i " +
                  "JOIN Applications a ON i.ApplicationID = a.ApplicationID " +
                  "WHERE a.AccountID = " + ApplicantID;
                MySqlCommand intCmd = new MySqlCommand(intQuery, connectionString);
                MySqlDataReader intReader = intCmd.ExecuteReader();
                if (intReader.Read())
                {
                    lblInterviewValue.Text = intReader["InterviewDate"] + " - " + intReader["Mode"];
                }
                else
                {
                    lblInterviewValue.Text = "No interview scheduled";
                }
                intReader.Close();

                connectionString.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            JobVacancies jobForm = new JobVacancies();
            jobForm.Show();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            MyDocumentsForm docsForm = new MyDocumentsForm();
            docsForm.Show();
        }

        private void btnApplication_Click_1(object sender, EventArgs e)
        {
            MyApplicationPage.Form4 myApplicationPage = new MyApplicationPage.Form4();
            myApplicationPage.ShowDialog();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            ApplicantProfileForm profile = new ApplicantProfileForm(ApplicantLogInFormFull.Form1.SessionManager.LoggedInAccountID);

            profile.ShowDialog();
        }

        private void btnStatus_Click_1(object sender, EventArgs e)
        {
            ApplicationStatusForm statusForm = new ApplicationStatusForm();
            statusForm.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}