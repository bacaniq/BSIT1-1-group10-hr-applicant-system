using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystem
{
    public partial class UserManagementForm : Form
    {
        private string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

        int selectedUserID = 0;

        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRoles();
        }

        private void LoadUsers()
        {
            listView1.Items.Clear();

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
SELECT u.UserID, u.FullName, u.Email, r.RoleName, u.Status
FROM Users u
JOIN Roles r ON u.RoleID = r.RoleID";
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["UserID"].ToString());
                        item.SubItems.Add(reader["FullName"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["RoleName"].ToString());
                        item.SubItems.Add(reader["Status"].ToString());

                        listView1.Items.Add(item);
                    }
                }

            }
        }

        //ADD USER
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) ||
            string.IsNullOrWhiteSpace(textBox3.Text) ||
            comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            int roleID = Convert.ToInt32(comboBox1.SelectedValue);

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (FullName, Email, Password, RoleID) VALUES (@fullname, @email, @password, @roleID)";

                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fullname", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", textBox3.Text.Trim());

                    cmd.Parameters.AddWithValue("@roleID", Convert.ToInt32(comboBox1.SelectedValue));

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User added successfully!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            LoadUsers();
        }

        //DELETE USER
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to delete!");
                return;
            }

            string selectedEmail = listView1.SelectedItems[0].SubItems[1].Text;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Users WHERE Email = @email";
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", selectedEmail);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User deleted successfully!");
            LoadUsers();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            selectedUserID = Convert.ToInt32(listView1.SelectedItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show("Select a user first!");
                return;
            }

            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
        UPDATE Users 
        SET FullName=@fullname,
            Email=@email,
            RoleID=@roleID
        WHERE UserID=@id";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", selectedUserID);
                    cmd.Parameters.AddWithValue("@fullname", textBox1.Text);
                    cmd.Parameters.AddWithValue("@email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@roleID", comboBox1.SelectedIndex + 1);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User updated!");
            LoadUsers();
        }

        private void LoadRoles()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT RoleID, RoleName FROM Roles";

                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "RoleName";
                comboBox1.ValueMember = "RoleID";
            }
        }
    }
}