using BCrypt.Net;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRApplicantSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private void tbpasswordchange_Click(object sender, EventArgs e)
        {

            string connStr = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

            string email = tbstoredemail.Text.Trim();
            string newPassword = tbNewPass.Text.Trim();
            string confirmPassword = tbConfirmNewPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //checks if email exists in the database
                    string checkEmail = "SELECT COUNT(*) FROM applicantaccounts WHERE Email = @email";

                    MySqlCommand checkCmd = new MySqlCommand(checkEmail, conn, transaction);
                    checkCmd.Parameters.AddWithValue("@email", email);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists == 0)
                    {
                        MessageBox.Show("Email not found in the system.");
                        transaction.Rollback();
                        return;
                    }

                    string hashedPassword = HashPassword(newPassword);

                    string updatePassword = "UPDATE applicantaccounts SET Password = @newPassword WHERE Email = @email";

                    MySqlCommand updateCmd = new MySqlCommand(updatePassword, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@newPassword", hashedPassword);
                    updateCmd.Parameters.AddWithValue("@email", email);

                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Password changed successfully!");
                    this.Close();
                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tbstoredemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConfirmNewPass_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}