using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ApplicantLogInFormFull.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyApplicationPage
{
    public partial class Form4 : Form
    {
        string connStr = "Server=localhost;Port=3306;Database=hr_applicant_system;User ID=root;Password=Remake07018!;";
        public Form4()
        {
            InitializeComponent();
            dtfname_CellContentClick(null, null);
            dtlname_CellContentClick(null, null);
            dtShowEmail_CellContentClick(null, null);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dtfname_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                    SELECT a.FirstName
                    FROM applicants a
                    WHERE a.AccountID = @AccountID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", SessionManager.LoggedInAccountID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dt.Columns["FirstName"].ColumnName = "First Name";

                            dtfname.DataSource = dt;
                            dtfname.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dtfname.AllowUserToAddRows = false;
                            dtfname.ReadOnly = true;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading First Name: " + ex.Message);
            }
        }

        private void dtlname_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                    SELECT a.LastName
                    FROM applicants a
                    WHERE a.AccountID = @AccountID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", SessionManager.LoggedInAccountID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dt.Columns["LastName"].ColumnName = "Last Name";

                            dtlname.DataSource = dt;
                            dtlname.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dtlname.AllowUserToAddRows = false;
                            dtlname.ReadOnly = true;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading Last Name: " + ex.Message);
            }
        }

        private void dtShowEmail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                    SELECT aa.Email
                    FROM applicantaccounts aa
                    WHERE aa.AccountID = @AccountID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", SessionManager.LoggedInAccountID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dt.Columns["Email"].ColumnName = "Email";

                            dtemail.DataSource = dt;
                            dtemail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dtemail.AllowUserToAddRows = false;
                            dtemail.ReadOnly = true;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading Email: " + ex.Message);
            }
        }

        private void dtShowApplicationStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    Status       AS 'Status'
                FROM jobvacancies";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dtShowApplicationStatus.DataSource = dt;
                        dtShowApplicationStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtShowApplicationStatus.AllowUserToAddRows = false;
                        dtShowApplicationStatus.ReadOnly = true;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading Job Status: " + ex.Message);
            }
        }

        private void dtShowJobApplication_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    JobID        AS 'Job ID',
                    JobTitle     AS 'Job Title',
                    DepartmentID AS 'Department ID'

                FROM jobvacancies";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dtShowJobApplication.DataSource = dt;
                        dtShowJobApplication.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtShowJobApplication.AllowUserToAddRows = false;
                        dtShowJobApplication.ReadOnly = true;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading Job Vacancies: " + ex.Message);
            }
        }

        private void tbEditApplication_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            dtShowJobApplication_CellContentClick(null, null);
            dtShowApplicationStatus_CellContentClick(null, null);
        }


    }
}
