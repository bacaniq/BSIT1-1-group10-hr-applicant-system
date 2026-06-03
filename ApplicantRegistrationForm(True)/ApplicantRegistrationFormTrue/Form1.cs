using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ApplicantRegistrationFormTrue
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void tbConRegister_Click(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Port=3306;Database=hr_applicant_system;User ID=root;Password=Remake07018!;";

            string FirstName = textBox1.Text;
            string LastName = textBox2.Text;
            string Email = textBox3.Text;
            string Password = textBox4.Text;
            string ConfirmPassword = textBox5.Text;
            if (Password != ConfirmPassword)
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
                    // Insert into applicantaccounts
                    string insertAccount = @"
                    INSERT INTO applicantaccounts (Email, Password, CreatedAt)
                    VALUES (@email, @password, @createdAt);
                    ";

                    MySqlCommand cmd1 = new MySqlCommand(insertAccount, conn, transaction);
                    cmd1.Parameters.AddWithValue("@email", Email);
                    cmd1.Parameters.AddWithValue("@password", Password);
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
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
