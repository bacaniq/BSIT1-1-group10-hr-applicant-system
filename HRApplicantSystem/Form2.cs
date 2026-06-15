using BCrypt.Net;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApplicantRegistrationFormFull
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            tbRegPassword.PasswordChar = '•';
            tbConfRegPassword.PasswordChar = '•';
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private void tbConRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22;";

            string FirstName = textBox1.Text;
            string LastName = textBox2.Text;
            string Email = textBox3.Text;
            string Password = tbRegPassword.Text;
            string ConfirmPassword = tbConfRegPassword.Text;

            if (string.IsNullOrWhiteSpace(FirstName) ||
            string.IsNullOrWhiteSpace(LastName) ||
            string.IsNullOrWhiteSpace(Email) ||
            string.IsNullOrWhiteSpace(Password) ||
            string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (!Email.Contains("@"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string checkEmail = "SELECT COUNT(*) FROM applicantaccounts WHERE email = @email";

                    MySqlCommand checkCmd = new MySqlCommand(checkEmail, conn, transaction);
                    checkCmd.Parameters.AddWithValue("@email", Email);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        MessageBox.Show("Email already exists!");
                        transaction.Rollback();
                        return;
                    }

                    //Hash password
                    string hashedPassword = HashPassword(Password);

                    // Insert into applicantaccounts
                    string insertAccount = @"
                        INSERT INTO applicantaccounts (Email, Password, CreatedAt)
                        VALUES (@email, @password, @createdAt);
                        ";

                    MySqlCommand cmd1 = new MySqlCommand(insertAccount, conn, transaction);
                    cmd1.Parameters.AddWithValue("@email", Email);
                    cmd1.Parameters.AddWithValue("@password", hashedPassword);
                    cmd1.Parameters.AddWithValue("@createdAt", DateTime.Now);

                    cmd1.ExecuteNonQuery();

                    long accountId = cmd1.LastInsertedId;

                    // Insert into applicants
                    string insertApplicant = @"
                        INSERT INTO applicants (AccountID, FirstName, LastName)
                        VALUES (@accountId, @firstName, @lastName);
                        ";

                    MySqlCommand cmd2 = new MySqlCommand(insertApplicant, conn, transaction);
                    cmd2.Parameters.AddWithValue("@accountId", accountId);
                    cmd2.Parameters.AddWithValue("@firstName", FirstName);
                    cmd2.Parameters.AddWithValue("@lastName", LastName);

                    cmd2.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Registration successful!");
                    this.Close();
                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tbclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            tbRegPassword.Clear();
            tbConfRegPassword.Clear();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tbRegPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRegConfPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}