using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT FirstName, LastName, ContactNumber,
                                            Address, Education, Skills, WorkExperience
                                     FROM applicants
                                     WHERE AccountID = @accountID";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@accountID", _accountID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(contact) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show(
                    "First Name, Last Name, Contact Number, and Address are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM applicants WHERE AccountID = @accountID";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@accountID", _accountID);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    string query;

                    if (count > 0)
                    {
                        query = @"UPDATE applicants
                                  SET FirstName=@firstName,
                                      LastName=@lastName,
                                      ContactNumber=@contact,
                                      Address=@address,
                                      Education=@education,
                                      Skills=@skills,
                                      WorkExperience=@workExp
                                  WHERE AccountID=@accountID";
                    }
                    else
                    {
                        query = @"INSERT INTO applicants
                                  (AccountID, FirstName, LastName, ContactNumber,
                                   Address, Education, Skills, WorkExperience)
                                  VALUES
                                  (@accountID, @firstName, @lastName, @contact,
                                   @address, @education, @skills, @workExp)";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@accountID", _accountID);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@education", txtEducation.Text.Trim());
                    cmd.Parameters.AddWithValue("@skills", txtSkills.Text.Trim());
                    cmd.Parameters.AddWithValue("@workExp", txtWorkExp.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile saved successfully!");
                }
            }
            catch (Exception ex)
            {
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