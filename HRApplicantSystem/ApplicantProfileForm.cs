using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystem
{
    public partial class ApplicantProfileForm : Form
    {

        private int _accountID;
        public ApplicantProfileForm(int accountID)
        {
            InitializeComponent();
            _accountID = accountID;
        }

        private void ApplicantProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName, LastName, ContactNumber, Address, Education, Skills, WorkExperience FROM Applicants WHERE AccountID = @accountID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@accountID", _accountID);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtFirstName.Text = reader["FirstName"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    txtContact.Text = reader["ContactNumber"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtEducation.Text = reader["Education"].ToString();
                    txtSkills.Text = reader["Skills"].ToString();
                    txtWorkExp.Text = reader["WorkExperience"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("First Name, Last Name, Contact Number, and Address are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // hindi mag sasave sa database if may kulang na required fields
            }

            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

            try
            {


                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Applicants WHERE AccountID = @accountID";
                    MySql.Data.MySqlClient.MySqlCommand checkCmd = new MySql.Data.MySqlClient.MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@accountID", _accountID);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    string query;
                    if (count > 0)
                    {
                        query = "UPDATE Applicants SET FirstName=@firstName, LastName=@lastName, ContactNumber=@contact, Address=@address, Education=@education, Skills=@skills, WorkExperience=@workExp WHERE AccountID=@accountID";
                    }
                    else
                    {
                        query = "INSERT INTO Applicants (AccountID, FirstName, LastName, ContactNumber, Address, Education, Skills, WorkExperience) VALUES (@accountID, @firstName, @lastName, @contact, @address, @education, @skills, @workExp)";
                    }

                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@accountID", _accountID);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@education", txtEducation.Text.Trim());
                    cmd.Parameters.AddWithValue("@skills", txtSkills.Text.Trim());
                    cmd.Parameters.AddWithValue("@workExp", txtWorkExp.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile saved successfully!");
                }
            }

            catch (Exception ex)
            {
                // Lalabas ito kapag nagkaproblema ang koneksyon sa MySQL server
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtEducation.Clear();
            txtSkills.Clear();
            txtWorkExp.Clear();
        }
    }
}