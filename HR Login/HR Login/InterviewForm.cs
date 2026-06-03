using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Login
{
    public partial class InterviewForm : Form
    {
        string connectionString =
            "server=localhost;database=hr_applicant_system;uid=root;pwd=Ralph10272006.;";

        public InterviewForm()
        {
            InitializeComponent();
        }

        private void LoadInterviews()
        {
            string connectionString =
            "server=localhost;database=hr_applicant_system;uid=root;pwd=Ralph10272006.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM interviewschedules";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvInterviews.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        private int GetCount(string query)
        {
            string connectionString =
            "server=localhost;database=hr_applicant_system;uid=root;pwd=Ralph10272006.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void LoadInterviewStats()
        {
            lblTotalInterviews.Text = GetCount(
                "SELECT COUNT(*) FROM interviewschedules"
            ).ToString();

            lblScheduled.Text = GetCount(
                "SELECT COUNT(*) FROM interviewschedules WHERE Status = 'Scheduled'"
            ).ToString();

            lblPassed.Text = GetCount(
                "SELECT COUNT(*) FROM interviewschedules WHERE Status = 'Passed'"
            ).ToString();

            lblFailed.Text = GetCount(
                "SELECT COUNT(*) FROM interviewschedules WHERE Status = 'Failed'"
            ).ToString();
        }

        private void InterviewForm_Load(object sender, EventArgs e)
        {
            LoadInterviewStats();
            LoadInterviews(); 
        }
    }
}

