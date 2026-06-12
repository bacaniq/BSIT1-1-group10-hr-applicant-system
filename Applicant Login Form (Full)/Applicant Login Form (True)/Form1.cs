using ApplicantReg._LoginFormFull;
using ApplicantRegistrationFormFull;
using BCrypt.Net;
using MyApplicationPage;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApplicantLogInFormFull
{
    public partial class Form1 : Form
    {
        string connStr = "Server=localhost;Port=3306;Database=hr_applicant_system;User ID=root;Password=Remake07018!;";

        public Form1()
        {
            InitializeComponent();
        }

        public static class SessionManager
        {
            public static int LoggedInAccountID { get; set; }
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

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();


                    string query = "SELECT AccountID, Password, Status FROM applicantaccounts WHERE Email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid email or password.");
                                return;
                            }

                            int accountID = reader.GetInt32("AccountID");
                            string storedHash = reader.GetString("Password");

                            bool isValid = BCrypt.Net.BCrypt.Verify(password, storedHash);

                            if (isValid)
                            {
                                string status = reader.GetString("Status");

                                if (status != "Active")
                                {
                                    MessageBox.Show("Your account is inactive. Please contact HR.",
                                        "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                SessionManager.LoggedInAccountID = accountID;

                                MessageBox.Show("Login successful!");

                                this.Hide();
                                Form4 myApplicationPage = new Form4();
                                myApplicationPage.ShowDialog();
                                this.Show();
                            }

                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tbregisteraccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ApplicantRegistrationFormFull.Form2 registerformfull = new ApplicantRegistrationFormFull.Form2();
            registerformfull.ShowDialog();
            this.Show();
        }

        private void tbforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangePassowrdFormFull.Form3 forgotpassformfull = new ChangePassowrdFormFull.Form3();
            forgotpassformfull.ShowDialog();
            this.Show();
        }
    }
}