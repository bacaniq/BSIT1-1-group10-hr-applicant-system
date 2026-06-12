using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class MyDocumentsForm : Form
    {
        public MyDocumentsForm()
        {
            InitializeComponent();
        }

        private void MyDocuments_Load(object sender, EventArgs e)
        {
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            try
            {
                listViewDocs.Items.Clear();

                var conn = DBConnection.GetConnection();
                conn.Open();

                string query = "SELECT RequirementTypeID, FilePath, Status, Remarks FROM ApplicantDocuments";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["RequirementTypeID"].ToString());
                    item.SubItems.Add(reader["FilePath"].ToString());
                    item.SubItems.Add(reader["Status"].ToString());
                    item.SubItems.Add(reader["Remarks"].ToString());
                    listViewDocs.Items.Add(item);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var conn = DBConnection.GetConnection();
            conn.Open();

            string uploadQuery =
            "INSERT INTO ApplicantDocuments (ApplicationID, RequirementTypeID, FilePath, Status) " +
            "VALUES (1, 1, '" + txtFileName.Text + "', 'Submitted')";

            MySqlCommand uploadCmd = new MySqlCommand(uploadQuery, conn);
            uploadCmd.ExecuteNonQuery();

            MessageBox.Show("Document uploaded successfully!");

            conn.Close();
            LoadDocuments();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (listViewDocs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a document!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Please enter a file name!");
                return;
            }

            try
            {
                var conn = DBConnection.GetConnection();
                conn.Open();

                string oldPath = listViewDocs.SelectedItems[0].SubItems[1].Text;

                string query =
                "UPDATE ApplicantDocuments " +
                "SET FilePath = @newPath, Status = 'Submitted' " +
                "WHERE FilePath = @oldPath";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newPath", txtFileName.Text);
                cmd.Parameters.AddWithValue("@oldPath", oldPath);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Document replaced successfully!");

                conn.Close();
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}