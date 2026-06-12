using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace HR_Login
{
    public partial class DashboardForm : Form
    {
        string connectionString = 
            "server=localhost;database=hr_applicant_system;uid=root;pwd=Ralph10272006.;";
        public DashboardForm()
        {
            InitializeComponent();
        }

        private int GetCount(MySqlConnection conn, string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void LoadApplicantStats()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Total Applicants
                lblApplicants.Text = GetCount(conn, "SELECT COUNT(*) FROM applicants").ToString();

                // Pending Screening
                lblPendingScreenings.Text = GetCount(conn,
                    "SELECT COUNT(*) FROM applications WHERE status = 'Pending Screening'").ToString();

                // Interview
                lblInterviews.Text = GetCount(conn,
                    "SELECT COUNT(*) FROM applications WHERE status = 'Interview'").ToString();

                // Hired
                lblHired.Text = GetCount(conn,
                    "SELECT COUNT(*) FROM applications WHERE status = 'Hired'").ToString();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Connected to hrapplicant database!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadApplicantStats();
        }

        private ScreeningForm screeningForm;

        private void btnScreenings_Click(object sender, EventArgs e)
        {
            if (screeningForm == null || screeningForm.IsDisposed)
            {
                screeningForm = new ScreeningForm();
            }

            screeningForm.Show();
            screeningForm.BringToFront();
        }

        private InterviewForm interviewForm;
        private void btnInterviews_Click_1(object sender, EventArgs e)
        {
            if (interviewForm == null || interviewForm.IsDisposed)
            {
                interviewForm = new InterviewForm();
            }

            interviewForm.Show();
            interviewForm.BringToFront();
        }
    }
}

