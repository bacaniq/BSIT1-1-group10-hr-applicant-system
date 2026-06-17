using System;
using System.IO;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files (*.*)|*.*";
            openFile.Title = "Select a Document";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Tag = openFile.FileName;
                txtFileName.Text = Path.GetFileName(openFile.FileName);
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
                MessageBox.Show("Please select a file first!");
                return;
            }

            try
            {
                string uploadFolder = Application.StartupPath + "\\UploadedDocuments\\";
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                string fileName = txtFileName.Text;
                string sourcePath = txtFileName.Tag != null ? txtFileName.Tag.ToString() : txtFileName.Text;
                string destPath = uploadFolder + fileName;
                File.Copy(sourcePath, destPath, true);

                var conn = DBConnection.GetConnection();
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM ApplicantDocuments WHERE ApplicantID = " + Dashboard.ApplicantID + " AND DocumentType = '" + cmbDocType.SelectedItem.ToString() + "'";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Document already uploaded! Use Replace instead.");
                    conn.Close();
                    return;
                }

                string uploadQuery = "INSERT INTO ApplicantDocuments (ApplicantID, DocumentType, FileName, Status) VALUES (" + Dashboard.ApplicantID + ", '" + cmbDocType.SelectedItem.ToString() + "', '" + fileName + "', 'Submitted')";
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
                MessageBox.Show("Please select a new file first!");
                return;
            }

            try
            {
                string uploadFolder = Application.StartupPath + "\\UploadedDocuments\\";
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                string fileName = txtFileName.Text;
                string sourcePath = txtFileName.Tag != null ? txtFileName.Tag.ToString() : txtFileName.Text;
                string destPath = uploadFolder + fileName;
                File.Copy(sourcePath, destPath, true);

                var conn = DBConnection.GetConnection();
                conn.Open();

                string docType = listViewDocs.SelectedItems[0].Text;
                string replaceQuery = "UPDATE ApplicantDocuments SET FileName = '" + fileName + "', Status = 'Submitted' WHERE ApplicantID = " + Dashboard.ApplicantID + " AND DocumentType = '" + docType + "'";
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

        private void btnViewFile_Click(object sender, EventArgs e)
        {
            if (listViewDocs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a document first!");
                return;
            }

            string fileName = listViewDocs.SelectedItems[0].SubItems[1].Text;
            string uploadFolder = Application.StartupPath + "\\UploadedDocuments\\";
            string filePath = uploadFolder + fileName;

            if (File.Exists(filePath))
            {
                string ext = Path.GetExtension(fileName).ToLower();

                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png")
                {
                    // Show image in popup
                    Form imgForm = new Form();
                    imgForm.Text = "Document Preview - " + fileName;
                    imgForm.Size = new System.Drawing.Size(600, 500);
                    imgForm.StartPosition = FormStartPosition.CenterScreen;

                    PictureBox pic = new PictureBox();
                    pic.Dock = DockStyle.Fill;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Image = System.Drawing.Image.FromFile(filePath);

                    imgForm.Controls.Add(pic);
                    imgForm.Show();
                }
                else if (ext == ".pdf")
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                else
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            else
            {
                MessageBox.Show("File not found! It may have been moved or deleted.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}