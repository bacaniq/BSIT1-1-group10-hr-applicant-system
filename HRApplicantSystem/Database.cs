using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using static HRApplicantSystem.DashboardForm;

namespace HRApplicantSystem
{
    public static class DatabaseHelper
    {
        private const string ConnStr =
            "Server=localhost;Port=3306;Database=hr_applicant_system;" +
            "Uid=root;Pwd=Ralph10272006.;";

        private static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();
            return conn;
        }

        private static int ExecuteCount(MySqlConnection conn, string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }


        public static int GetTotalApplicants()
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM applicants;", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int GetTotalScreenings()
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM screeningresults;", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int GetPendingScreenings()
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM screeningresults WHERE Result = 'Pending';", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int GetTotalInterviews()
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM interviewschedules;", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int GetTodayInterviewCount()
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM interviewschedules " +
                    "WHERE DATE(InterviewDate) = CURDATE();", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int GetOpenPositions()
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM jobvacancies WHERE Status = 'Open';", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int GetNewApplicantsThisWeek()
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM applications " +
                    "WHERE YEARWEEK(AppliedDate, 1) = YEARWEEK(CURDATE(), 1);", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static Dictionary<string, int> GetPipelineCounts()
        {
            Dictionary<string, int> result = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT Status, COUNT(*) AS cnt " +
                    "FROM applications " +
                    "GROUP BY Status;", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        result[reader.GetString("Status")] = reader.GetInt32("cnt");
                }
            }
            return result;
        }

        public static List<ApplicantRow> GetRecentApplicants(int limit)
        {
            List<ApplicantRow> list = new List<ApplicantRow>();
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT ap.ApplicantID, ap.FirstName, ap.LastName, " +
                    "       jv.JobTitle, app.Status, app.AppliedDate " +
                    "FROM applications app " +
                    "JOIN applicants ap   ON app.AccountID = ap.AccountID " +
                    "JOIN jobvacancies jv ON app.JobID     = jv.JobID " +
                    "ORDER BY app.AppliedDate DESC " +
                    "LIMIT " + limit + ";", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ApplicantRow row = new ApplicantRow();
                        row.ApplicantID = reader.GetInt32("ApplicantID");
                        row.FullName = reader.GetString("FirstName") + " " + reader.GetString("LastName");
                        row.JobTitle = reader.GetString("JobTitle");
                        row.Status = reader.GetString("Status");
                        row.AppliedDate = reader.GetDateTime("AppliedDate");
                        list.Add(row);
                    }
                }
            }
            return list;
        }


        public static List<InterviewRow> GetTodayInterviews()
        {
            List<InterviewRow> list = new List<InterviewRow>();
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT isch.ScheduleID, " +
                    "       ap.FirstName, ap.LastName, " +
                    "       jv.JobTitle, " +
                    "       isch.InterviewDate, " +
                    "       isch.Interviewer, " +
                    "       isch.Mode, " +
                    "       isch.Location, " +
                    "       isch.Status " +
                    "FROM interviewschedules isch " +
                    "JOIN applications app ON isch.ApplicationID = app.ApplicationID " +
                    "JOIN applicants   ap  ON app.AccountID      = ap.AccountID " +
                    "JOIN jobvacancies jv  ON app.JobID          = jv.JobID " +
                    "WHERE DATE(isch.InterviewDate) = CURDATE() " +
                    "ORDER BY isch.InterviewDate ASC;", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InterviewRow row = new InterviewRow();
                        row.ScheduleID = reader.GetInt32("ScheduleID");
                        row.FullName = reader.GetString("FirstName") + " " + reader.GetString("LastName");
                        row.JobTitle = reader.GetString("JobTitle");
                        row.InterviewDate = reader.GetDateTime("InterviewDate");
                        row.Interviewer = reader.IsDBNull(reader.GetOrdinal("Interviewer")) ? "" : reader.GetString("Interviewer");
                        row.Mode = reader.IsDBNull(reader.GetOrdinal("Mode")) ? "" : reader.GetString("Mode");
                        row.Location = reader.IsDBNull(reader.GetOrdinal("Location")) ? "" : reader.GetString("Location");
                        row.Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "" : reader.GetString("Status");
                        list.Add(row);
                    }
                }
            }
            return list;
        }


        public static List<JobRow> GetOpenJobs()
        {
            List<JobRow> list = new List<JobRow>();
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT jv.JobID, jv.JobTitle, jv.Status, jv.PostedDate, " +
                    "       d.DepartmentName, " +
                    "       COUNT(app.ApplicationID) AS ApplicantCount, " +
                    "       COALESCE( " +
                    "           (SELECT app2.Status " +
                    "            FROM applications app2 " +
                    "            WHERE app2.JobID = jv.JobID " +
                    "            GROUP BY app2.Status " +
                    "            ORDER BY COUNT(*) DESC LIMIT 1), " +
                    "       'Applied') AS TopStage " +
                    "FROM jobvacancies jv " +
                    "LEFT JOIN departments d    ON jv.DepartmentID = d.DepartmentID " +
                    "LEFT JOIN applications app ON app.JobID       = jv.JobID " +
                    "WHERE jv.Status = 'Open' " +
                    "GROUP BY jv.JobID, jv.JobTitle, jv.Status, jv.PostedDate, d.DepartmentName " +
                    "ORDER BY jv.PostedDate DESC;", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JobRow row = new JobRow();
                        row.JobID = reader.GetInt32("JobID");
                        row.JobTitle = reader.GetString("JobTitle");
                        row.Department = reader.IsDBNull(reader.GetOrdinal("DepartmentName")) ? "—" : reader.GetString("DepartmentName");
                        row.ApplicantCount = reader.GetInt32("ApplicantCount");
                        row.TopStage = reader.GetString("TopStage");
                        row.Status = reader.GetString("Status");
                        row.PostedDate = reader.GetDateTime("PostedDate");
                        list.Add(row);
                    }
                }
            }
            return list;
        }
    }


    public class ApplicantRow
    {
        public int ApplicantID { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Status { get; set; }
        public DateTime AppliedDate { get; set; }
    }

    public class InterviewRow
    {
        public int ScheduleID { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Interviewer { get; set; }
        public string Mode { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
    }

    public class JobRow
    {
        public int JobID { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public int ApplicantCount { get; set; }
        public string TopStage { get; set; }
        public string Status { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
