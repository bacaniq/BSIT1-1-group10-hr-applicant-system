using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HRApplicantSystem;

namespace HRApplicantSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                // Check HR Users table
                string hrQuery = "SELECT * FROM Users WHERE Email = @email AND Password = @password";
                MySql.Data.MySqlClient.MySqlCommand hrCmd = new MySql.Data.MySqlClient.MySqlCommand(hrQuery, connection);
                hrCmd.Parameters.AddWithValue("@email", txtUsername.Text);
                hrCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                MySql.Data.MySqlClient.MySqlDataReader hrReader = hrCmd.ExecuteReader();

                if (hrReader.Read())
                {
                    Session.UserID = Convert.ToInt32(hrReader["UserID"]);
                    Session.FullName = hrReader["FullName"].ToString();

                    int roleID = Convert.ToInt32(hrReader["RoleID"]);

                    if (roleID == 1)
                        Session.Role = "Admin";
                    else if (roleID == 2)
                        Session.Role = "HR Manager";
                    else
                        Session.Role = "HR Staff";

                    Session.IsHRManager =
                        roleID == 1 ||
                        roleID == 2;

                    MessageBox.Show(
                    $"Welcome {Session.FullName}!\n\nYou are logged in as: {Session.Role}",
                    "HR Applicant System",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    hrReader.Close();

                    DashboardForm dash = new DashboardForm();
                    dash.Show();
                    this.Hide();
                    return;
                }
                hrReader.Close();

                // Check Applicant table
                string appQuery = "SELECT * FROM ApplicantAccounts WHERE Email = @email AND Password = @password";
                MySql.Data.MySqlClient.MySqlCommand appCmd = new MySql.Data.MySqlClient.MySqlCommand(appQuery, connection);
                appCmd.Parameters.AddWithValue("@email", txtUsername.Text);
                appCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                MySql.Data.MySqlClient.MySqlDataReader appReader = appCmd.ExecuteReader();

                if (appReader.Read())
                {
                    MessageBox.Show("Welcome Applicant!");
                    appReader.Close();
                    this.Hide();
                    return;
                }
                appReader.Close();

                MessageBox.Show("Invalid email or password!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            ApplicantLogInFormFull.Form1 hrLogin = new ApplicantLogInFormFull.Form1();
            hrLogin.ShowDialog();

            this.Show();
        }
    }
}