using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public partial class MyDocuments : Form
    {
        public MyDocuments()
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

                string query = "SELECT DocumentType, FileName, Status, Remarks FROM ApplicantDocuments WHERE ApplicantID = " + Dashboard.ApplicantID;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["DocumentType"].ToString());
                    item.SubItems.Add(reader["FileName"].ToString());
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
            if (cmbDocType.SelectedItem == null)
            {
                MessageBox.Show("Please select a document type!");
                return;
            }

            if (txtFileName.Text == "")
            {
                MessageBox.Show("Please enter a file name!");
                return;
            }

            try
            {
                var conn = DBConnection.GetConnection();
                conn.Open();

                // Check if document already exists
                string checkQuery = "SELECT COUNT(*) FROM ApplicantDocuments WHERE ApplicantID = " + Dashboard.ApplicantID + " AND DocumentType = '" + cmbDocType.SelectedItem.ToString() + "'";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Document already uploaded! Use Replace instead.");
                    conn.Close();
                    return;
                }

                string uploadQuery = "INSERT INTO ApplicantDocuments (ApplicantID, DocumentType, FileName, Status) VALUES (" + Dashboard.ApplicantID + ", '" + cmbDocType.SelectedItem.ToString() + "', '" + txtFileName.Text + "', 'Submitted')";
                MySqlCommand uploadCmd = new MySqlCommand(uploadQuery, conn);
                uploadCmd.ExecuteNonQuery();

                MessageBox.Show("Document uploaded successfully!");
                txtFileName.Text = "";
                conn.Close();
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (listViewDocs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a document to replace!");
                return;
            }

            if (txtFileName.Text == "")
            {
                MessageBox.Show("Please enter a new file name!");
                return;
            }

            try
            {
                var conn = DBConnection.GetConnection();
                conn.Open();

                string docType = listViewDocs.SelectedItems[0].Text;
                string replaceQuery = "UPDATE ApplicantDocuments SET FileName = '" + txtFileName.Text + "', Status = 'Submitted' WHERE ApplicantID = " + Dashboard.ApplicantID + " AND DocumentType = '" + docType + "'";
                MySqlCommand replaceCmd = new MySqlCommand(replaceQuery, conn);
                replaceCmd.ExecuteNonQuery();

                MessageBox.Show("Document replaced successfully!");
                txtFileName.Text = "";
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