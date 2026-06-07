using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
                string query = @"SELECT CONCAT(ap.FirstName, ' ', ap.LastName) AS ApplicantName, 
                    jv.JobTitle, app.Status 
                    FROM Applications app
                    JOIN Applicants ap ON app.AccountID = ap.AccountID
                    JOIN JobVacancies jv ON app.JobID = jv.JobID
                    WHERE app.Status = 'Submitted'";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ApplicantName"].ToString());
                    item.SubItems.Add(reader["JobTitle"].ToString());
                    item.SubItems.Add(reader["Status"].ToString());
                    listView1.Items.Add(item);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an applicant first!");
                return;
            }

            string applicantName = listView1.SelectedItems[0].Text;
            string remarks = textBox1.Text;

            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE Applications app
                    JOIN Applicants ap ON app.AccountID = ap.AccountID
                    SET app.Status = 'Shortlisted'
                    WHERE CONCAT(ap.FirstName, ' ', ap.LastName) = @name";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", applicantName);
                cmd.ExecuteNonQuery();

                MessageBox.Show(applicantName + " marked as Qualified!");
                listView1.Items.Clear();
                ScreeningForm_Load(sender, e);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an applicant first");
                return;
            }

            string applicantName = listView1.SelectedItems[0].Text;
            string remarks = textBox1.Text;

            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Applications app
                    JOIN Applicants ap ON app.AccountID = ap.AccountID
                    SET app.Status = 'Rejected'
                    WHERE CONCAT(ap.FirstName, ' ', ap.LastName) = @name";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", applicantName);
                cmd.ExecuteNonQuery();

                MessageBox.Show(applicantName + " marked as Not Qualified");
                listView1.Items.Clear();
                ScreeningForm_Load(sender, e);
            }
        }
    }
}
