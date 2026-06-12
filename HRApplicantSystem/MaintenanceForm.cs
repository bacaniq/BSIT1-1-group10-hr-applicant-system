using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class MaintenanceForm : Form
    {
        private string connectionString =
            "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

        public MaintenanceForm()
        {
            InitializeComponent();
        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Load Departments
                string deptQuery = "SELECT DepartmentName FROM Departments";
                using (MySqlCommand cmd = new MySqlCommand(deptQuery, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listView1.Items.Add(
                            new ListViewItem(reader["DepartmentName"].ToString())
                        );
                    }
                }

                // Load Requirement Types
                string reqQuery = "SELECT RequirementName FROM RequirementTypes";
                using (MySqlCommand cmd = new MySqlCommand(reqQuery, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listView2.Items.Add(
                            new ListViewItem(reader["RequirementName"].ToString())
                        );
                    }
                }

                // Load Employment Types
                string empQuery = "SELECT EmploymentTypeName FROM EmploymentTypes";
                using (MySqlCommand cmd = new MySqlCommand(empQuery, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listView3.Items.Add(
                            new ListViewItem(reader["EmploymentTypeName"].ToString())
                        );
                    }
                }

                // Load Interview Types
                string intQuery = "SELECT InterviewTypeName FROM InterviewTypes";
                using (MySqlCommand cmd = new MySqlCommand(intQuery, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listView4.Items.Add(
                            new ListViewItem(reader["InterviewTypeName"].ToString())
                        );
                    }
                }

                //Load Assessment Types
                string assQuery = "SELECT AssessmentTypeName FROM AssessmentTypes";
                using (MySqlCommand cmd = new MySqlCommand(assQuery, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listView5.Items.Add(
                            new ListViewItem(reader["AssessmentTypeName"].ToString())
                        );
                    }
                }
            }
        }

        // ADD DEPARTMENT
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a department name!");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Departments (DepartmentName) VALUES (@name)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Department added successfully!");
            textBox1.Clear();
            LoadData();
        }

        // DELETE DEPARTMENT
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a department to delete!");
                return;
            }

            string selectedDepartment = listView1.SelectedItems[0].Text;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this department?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Departments WHERE DepartmentName = @name";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", selectedDepartment);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Department deleted successfully!");
            textBox1.Clear();
            LoadData();
        }


        //ADD REQUIREMENT TYPE
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a requirement name!");
                return;
            }

            using (MySql.Data.MySqlClient.MySqlConnection connection =
                new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO RequirementTypes (RequirementName) VALUES (@name)";
                using (MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", textBox2.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Requirement type added successfully!");
            textBox2.Clear();
            LoadData();
        }

        // DELETE REQUIREMENT TYPE
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a requirement type to delete!");
                return;
            }

            string selectedRequirement = listView2.SelectedItems[0].Text;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this requirement type?", "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            using (MySql.Data.MySqlClient.MySqlConnection connection =
                new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM RequirementTypes WHERE RequirementName = @name";
                using (MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", selectedRequirement);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Requirement type deleted successfully!");
            textBox2.Clear();
            LoadData();
        }

        //ADD EMPLOYMENT TYPE
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter an employment type!");
                return;
            }

            using (MySql.Data.MySqlClient.MySqlConnection connection =
                new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO EmploymentTypes (EmploymentTypeName) VALUES (@name)";
                using (MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", textBox3.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Employment type added successfully!");
            textBox3.Clear();
            LoadData();
        }

        // DELETE EMPLOYMENT TYPE
        private void button6_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employment type to delete!");
                return;
            }

            string selected = listView3.SelectedItems[0].Text;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employment type?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM EmploymentTypes WHERE EmploymentTypeName = @name";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", selected);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Employment type deleted successfully!");
            textBox3.Clear();
            LoadData();
        }

        //ADD INTERVIEW TYPE
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter an interview type!");
                return;
            }

            using (MySql.Data.MySqlClient.MySqlConnection connection =
                new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO InterviewTypes (InterviewTypeName) VALUES (@name)";
                using (MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", textBox4.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Interview type added successfully!");
            textBox4.Clear();
            LoadData();
        }

        // DELETE INTERVIEW TYPE
        private void button8_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an interview type to delete!");
                return;
            }

            string selected = listView4.SelectedItems[0].Text;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this interview type?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM InterviewTypes WHERE InterviewTypeName = @name";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", selected);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Interview type deleted successfully!");
            textBox4.Clear();
            LoadData();
        }

        //ADD ASSESSMENT TYPE
        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter an assessment type!");
                return;
            }

            using (MySql.Data.MySqlClient.MySqlConnection connection =
                new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO AssessmentTypes (AssessmentTypeName) VALUES (@name)";
                using (MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", textBox5.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Assessment type added successfully!");
            textBox5.Clear();
            LoadData();
        }

        // DELETE ASSESSMENT TYPE
        private void button10_Click(object sender, EventArgs e)
        {
            if (listView5.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an assessment type to delete!");
                return;
            }

            string selected = listView5.SelectedItems[0].Text;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this assessment type?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM AssessmentTypes WHERE AssessmentTypeName = @name";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", selected);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Assessment type deleted successfully!");
            textBox5.Clear();
            LoadData();
        }
    }
}