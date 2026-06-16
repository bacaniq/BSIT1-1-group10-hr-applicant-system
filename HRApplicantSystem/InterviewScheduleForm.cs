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

namespace HRApplicantSystem
{
    public partial class InterviewScheduleForm : Form
    {
        string connectionString =
            "server=localhost;database=hr_applicant_system;uid=root;pwd=Babyquero22;";

        public InterviewScheduleForm()
        {
            InitializeComponent();
        }

        private void LoadApplicants()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                ApplicationID,
                CONCAT(FirstName, ' ', LastName) AS ApplicantName
            FROM applications ap
            JOIN applicants a ON ap.AccountID = a.AccountID
            WHERE ap.Status = 'Shortlisted'";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MessageBox.Show("Rows found: " + dt.Rows.Count);

                cmbApplicant.DataSource = dt;
                cmbApplicant.DisplayMember = "ApplicantName";
                cmbApplicant.ValueMember = "ApplicationID";
            }
        }

        private void InterviewScheduleForm_Load(object sender, EventArgs e)
        {
            LoadApplicants();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                if (scheduleID == 0)
                {

                    string query = @"
INSERT INTO interviewschedules
(ApplicationID, InterviewDate, Interviewer, Mode, Location, Status)
VALUES
(@ApplicationID, @InterviewDate, @Interviewer, @Mode, @Location, 'Scheduled')";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ApplicationID", cmbApplicant.SelectedValue);

                    DateTime interviewDateTime =
                        dtpInterviewDate.Value.Date +
                        dtpInterviewTime.Value.TimeOfDay;

                    cmd.Parameters.AddWithValue("@InterviewDate", interviewDateTime);
                    cmd.Parameters.AddWithValue("@Interviewer", txtInterviewer.Text);
                    cmd.Parameters.AddWithValue("@Mode", cmbMode.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Interview scheduled successfully!");
                }
                else
                {

                    string query = @"
                UPDATE interviewschedules
                SET ApplicationID=@ApplicationID,
                    InterviewDate=@InterviewDate,
                    Interviewer=@Interviewer,
                    Mode=@Mode,
                    Location=@Location
                WHERE ScheduleID=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", scheduleID);
                    cmd.Parameters.AddWithValue("@ApplicationID", cmbApplicant.SelectedValue);

                    DateTime interviewDateTime =
                        dtpInterviewDate.Value.Date +
                        dtpInterviewTime.Value.TimeOfDay;

                    cmd.Parameters.AddWithValue("@InterviewDate", interviewDateTime);
                    cmd.Parameters.AddWithValue("@Interviewer", txtInterviewer.Text);
                    cmd.Parameters.AddWithValue("@Mode", cmbMode.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Interview updated successfully!");
                }
            }

            this.Close();
        }

        private int scheduleID = 0;

        public InterviewScheduleForm(int id)
        {
            InitializeComponent();
            scheduleID = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}