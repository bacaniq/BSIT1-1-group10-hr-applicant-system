using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HRApplicantSystem
{
    public partial class ApplicationStatusForm : Form
    {
        public ApplicationStatusForm()
        {
            InitializeComponent();
        }

        private void ApplicationStatusForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=hr_applicant_system;Uid=root;Pwd=Babyquero22";
            
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Status, ChangedAt, Remarks FROM ApplicationStatusHistory ORDER BY ChangedAt ASC";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection);
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Status"].ToString());
                    item.SubItems.Add(reader["ChangedAt"].ToString());
                    item.SubItems.Add(reader["Remarks"].ToString());
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
