using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Login
{
    public partial class ScreeningForm : Form
    {
        public ScreeningForm()
        {
            InitializeComponent();
        }

        private void LoadScreenings()
        {
            string connectionString =
            "server=localhost;database=hr_applicant_system;uid=root;pwd=Ralph10272006.;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                sr.ScreeningID,
                sr.ApplicationID,
                a.FirstName,
                a.LastName,
                sr.ScreenedBy,
                sr.ScreenedAt,
                sr.Result,
                sr.Remarks
            FROM screeningresults sr
            JOIN applications app ON sr.ApplicationID = app.ApplicationID
            JOIN applicants a ON app.AccountID = a.AccountID
            ORDER BY sr.ScreenedAt DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvScreenings.DataSource = dt;
            }
        }

        private void ScreeningForm_Load(object sender, EventArgs e)
        {
            LoadScreenings();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
