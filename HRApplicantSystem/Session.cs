using System;
using System.Collections.Generic;
using System.Text;

namespace HRApplicantSystem
{
    public static class Session
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }
        public static string Role { get; set; }
        public static bool IsHRManager { get; set; }
    }
}