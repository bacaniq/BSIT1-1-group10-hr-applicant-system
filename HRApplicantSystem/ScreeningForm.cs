using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRApplicantSystem
{
    public partial class ScreeningForm : Form
    {
        public ScreeningForm()
        {
            InitializeComponent();
        }

        private void ScreeningForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT 
                app.ApplicationID,
                CONCAT(ap.FirstName, ' ', ap.LastName) AS ApplicantName, 
                jv.JobTitle, 
                app.Status 
              FROM Applications app
              JOIN Applicants ap ON app.AccountID = ap.AccountID
              JOIN JobVacancies jv ON app.JobID = jv.JobID
              WHERE app.Status = 'Submitted'";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ApplicantName"].ToString());

                    item.SubItems.Add(reader["JobTitle"].ToString());
                    item.SubItems.Add(reader["Status"].ToString());

                    item.Tag = reader["ApplicationID"];

                    listView1.Items.Add(item);
                }

                reader.Close();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an applicant first!");
                return;
            }

            int applicationId = Convert.ToInt32(listView1.SelectedItems[0].Tag);

            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

            using (MySql.Data.MySqlClient.MySqlConnection connection =
                   new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();


                string updateQuery = @"
UPDATE Applications
SET Status = 'Shortlisted'
WHERE ApplicationID = @id";

                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@id", applicationId);
                cmd.ExecuteNonQuery();

                string historyQuery = @"
INSERT INTO ApplicationStatusHistory (ApplicationID, Status, Remarks)
VALUES (@id, 'Shortlisted', @remarks)";

                MySqlCommand cmd2 = new MySqlCommand(historyQuery, connection);
                cmd2.Parameters.AddWithValue("@id", applicationId);
                cmd2.Parameters.AddWithValue("@remarks", textBox1.Text);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Applicant marked as Qualified and moved to Interview!");
            }

            ScreeningForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an applicant first!");
                return;
            }

            int applicationId = Convert.ToInt32(listView1.SelectedItems[0].Tag);

            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            UPDATE Applications
            SET Status = 'Rejected'
            WHERE ApplicationID = @id";

                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", applicationId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Applicant marked as Not Qualified!");
            }

            ScreeningForm_Load(sender, e);
        }
    }
}
