using System;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public class DBConnection
    {
        private static string connectionString =
            "Server=localhost;Database=HRApplicantDB;Uid=root;Pwd=Babyquero22;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}