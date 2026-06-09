using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class JobVacancies : Form
    {
        public JobVacancies()
        {
            InitializeComponent();
        }

        private void JobVacancies_Load(object sender, EventArgs e)
        {
            LoadJobs("");
        }

        private void LoadJobs(string search)
        {
            try
            {
                listViewJobs.Items.Clear();

                var conn = DBConnection.GetConnection();
                conn.Open();

                string query = "SELECT JobID, JobTitle, Department, Status FROM JobVacancies WHERE Status = 'Open' AND JobTitle LIKE '%" + search + "%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["JobID"].ToString());
                    item.SubItems.Add(reader["JobTitle"].ToString());
                    item.SubItems.Add(reader["Department"].ToString());
                    item.SubItems.Add(reader["Status"].ToString());
                    listViewJobs.Items.Add(item);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadJobs(txtSearch.Text);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (listViewJobs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a job first!");
                return;
            }

            string jobTitle = listViewJobs.SelectedItems[0].SubItems[1].Text;
            string department = listViewJobs.SelectedItems[0].SubItems[2].Text;
            string status = listViewJobs.SelectedItems[0].SubItems[3].Text;

            MessageBox.Show("Job Title: " + jobTitle + "\nDepartment: " + department + "\nStatus: " + status);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void btnViewDetails_Click_1(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (listViewJobs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a job first!");
                return;
            }

            int jobID = Convert.ToInt32(listViewJobs.SelectedItems[0].Text);
            int accountID = ApplicantDashboardForm.ApplicantID;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery =
                        "SELECT COUNT(*) FROM Applications " +
                        "WHERE AccountID=@AccountID AND JobID=@JobID";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@AccountID", accountID);
                    checkCmd.Parameters.AddWithValue("@JobID", jobID);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("You already applied for this job!");
                        return;
                    }

                    string applyQuery =
                        "INSERT INTO Applications " +
                        "(AccountID, JobID, Status) " +
                        "VALUES (@AccountID, @JobID, 'Submitted')";

                    MySqlCommand applyCmd = new MySqlCommand(applyQuery, conn);

                    applyCmd.Parameters.AddWithValue("@AccountID", accountID);
                    applyCmd.Parameters.AddWithValue("@JobID", jobID);

                    applyCmd.ExecuteNonQuery();

                    MessageBox.Show("Application submitted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //private void btnBack_Click_1(object sender, EventArgs e)
        //{
        //    this.Close;
        //}
    }
}