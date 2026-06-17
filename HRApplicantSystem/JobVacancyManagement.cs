using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystem
{
    public partial class JobVacancyManagement : Form
    {
        public JobVacancyManagement()
        {
            InitializeComponent();
        }

        string connectionString =
    "server=localhost;database=hr_applicant_system;uid=root;pwd=Babyquero22;";
        private void LoadDepartments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT DepartmentID, DepartmentName FROM Departments";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDepartment.DataSource = dt;
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentID";
            }
        }

        private void JobVacancyManagement_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Open");
            cmbStatus.Items.Add("Closed");

            LoadDepartments();
            LoadJobs();
        }

        private void LoadJobs()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
SELECT 
    j.JobID,
    j.JobTitle,
    d.DepartmentName,
    j.Status,
    j.Description,
    j.Qualifications,
    j.PostedDate
FROM JobVacancies j
JOIN Departments d ON j.DepartmentID = d.DepartmentID
ORDER BY j.PostedDate DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvJobs.DataSource = dt;
            }
        }

        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvJobs.Rows[e.RowIndex];

            selectedJobID = Convert.ToInt32(row.Cells["JobID"].Value);

            txtJobTitle.Text = row.Cells["JobTitle"].Value.ToString();
            cmbDepartment.Text = row.Cells["DepartmentName"].Value.ToString();
            cmbStatus.Text = row.Cells["Status"].Value.ToString();

            txtDescription.Text = row.Cells["Description"].Value.ToString();
            txtQualifications.Text = row.Cells["Qualifications"].Value.ToString();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
        INSERT INTO JobVacancies
        (JobTitle, DepartmentID, Description, Qualifications, Status)
        VALUES
        (@title, @dept, @desc, @qual, @status)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@title", txtJobTitle.Text);
                cmd.Parameters.AddWithValue("@dept", cmbDepartment.SelectedValue);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@qual", txtQualifications.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Job added successfully!");
            LoadJobs();
            ClearFields();
        }

        int selectedJobID = 0;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedJobID == 0)
            {
                MessageBox.Show("Select a job first.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM JobVacancies WHERE JobID=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedJobID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Job deleted!");
            LoadJobs();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedJobID == 0)
            {
                MessageBox.Show("Select a job first.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
        UPDATE JobVacancies
        SET JobTitle=@title,
            DepartmentID=@dept,
            Description=@desc,
            Qualifications=@qual,
            Status=@status
        WHERE JobID=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", selectedJobID);
                cmd.Parameters.AddWithValue("@title", txtJobTitle.Text);
                cmd.Parameters.AddWithValue("@dept", cmbDepartment.SelectedValue);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@qual", txtQualifications.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Job updated!");
            LoadJobs();
        }

        private void ClearFields()
        {
            txtJobTitle.Clear();
            txtDescription.Clear();
            txtQualifications.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            selectedJobID = 0;
        }
    }
}
