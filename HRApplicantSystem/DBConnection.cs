using System;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public class DBConnection
    {
        private static string connectionString =
            "Server=localhost;Database=HRApplicantDB;Uid=root;Pwd=root1234;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}