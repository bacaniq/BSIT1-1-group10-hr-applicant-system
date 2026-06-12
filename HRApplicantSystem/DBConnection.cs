using System;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public class DBConnection
    {
        private static string connectionString =
           "server=localhost;database=hr_applicant_system;uid=root;pwd=Babyquero22;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}