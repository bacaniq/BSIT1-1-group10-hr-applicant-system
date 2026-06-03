using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using BCrypt.Net;

namespace ApplicantLogInFormTrue
{
    public partial class Form1 : Form
    {
        string connStr = "Server=localhost;Port=3306;Database=hr_applicant_system;User ID=root;Password=Remake07018!;";
        public Form1()
        {
            InitializeComponent();
        }

        private void tblogin_Click(object sender, EventArgs e)
        {
            string email = tbboxemail.Text.Trim();
            string password = tbboxpassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            string connectionString = connStr;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Password FROM applicantaccounts WHERE Email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Invalid email or password.");
                            return;
                        }

                        string storedHash = result.ToString();

                        bool isValid = BCrypt.Net.BCrypt.Verify(password, storedHash);

                        if (isValid)
                        {
                            MessageBox.Show("Login successful!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }  
    }
}
