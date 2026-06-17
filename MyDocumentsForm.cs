using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

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
            cmbDocType.Items.Clear();
            cmbDocType.Items.Add("Resume");
            cmbDocType.Items.Add("ID");
            cmbDocType.Items.Add("Transcript");
            cmbDocType.Items.Add("Certificate");

            LoadDocuments();
        }

        // BUG 1 FIX: restored as a separate int-returning method
        // (was incorrectly merged into LoadDocuments, causing a compile error)
        private int GetApplicationID()
        {
            try
            {
                using (var conn = DBConnection.GetConnection()) // BUG 5 FIX: using block
                {
                    conn.Open();

                    string query = @"SELECT ApplicationID FROM Applications 
                                     WHERE AccountID = @AccountID 
                                     ORDER BY ApplicationID DESC 
                                     LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccountID", ApplicantDashboardForm.ApplicantID);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving application: " + ex.Message);
                return -1;
            }
        }

        // BUG 1 FIX: LoadDocuments() is now void and actually loads docs into the ListView
        // BUG 5 FIX: connection and reader wrapped in using blocks
        private void LoadDocuments()
        {
            try
            {
                listViewDocs.Items.Clear();

                int applicationID = GetApplicationID();
                if (applicationID == -1)
                    return;

                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT DocumentID, DocumentType, FilePath, Status, Remarks 
                                     FROM applicantdocuments 
                                     WHERE ApplicationID = @ApplicationID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["DocumentType"].ToString());
                                item.SubItems.Add(reader["FilePath"].ToString());
                                item.SubItems.Add(reader["Status"].ToString());
                                item.SubItems.Add(reader["Remarks"].ToString());
                                item.Tag = reader["DocumentID"].ToString();
                                listViewDocs.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All Files (*.*)|*.*";
            openFile.Title = "Select a Document";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Tag = openFile.FileName;       // full path stored in Tag
                txtFileName.Text = Path.GetFileName(openFile.FileName); // display name only
            }
        }

        // BUG 2 FIX: now correctly calls GetApplicationID() for the int
        // BUG 3 FIX: RequirementTypeID mapped from combobox index, broken UPDATE removed
        // BUG 4 FIX: null guard on Tag, no unsafe fallback to filename-only text
        // BUG 5 FIX: connection wrapped in using block
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (cmbDocType.SelectedItem == null)
            {
                MessageBox.Show("Please select a document type!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Please select a file first!");
                return;
            }

            // BUG 4 FIX: enforce Browse button was used so we always have full path
            if (txtFileName.Tag == null)
            {
                MessageBox.Show("Please use the Browse button to select a file.");
                return;
            }

            try
            {
                // BUG 2 FIX: call GetApplicationID(), not LoadDocuments()
                int applicationID = GetApplicationID();
                if (applicationID == -1)
                {
                    MessageBox.Show("No application found. Cannot upload document.");
                    return;
                }

                string uploadFolder = Application.StartupPath + "\\UploadedDocuments\\";
                if (!Directory.Exists(uploadFolder))
                    Directory.CreateDirectory(uploadFolder);

                string fileName = txtFileName.Text;
                string sourcePath = txtFileName.Tag.ToString(); // BUG 4 FIX: Tag always has full path
                string destPath = uploadFolder + fileName;
                File.Copy(sourcePath, destPath, true);

                // BUG 3 FIX: map combobox to correct RequirementTypeID (1=Resume, 2=ID, etc.)
                int requirementTypeID = cmbDocType.SelectedIndex + 1;

                using (var conn = DBConnection.GetConnection()) // BUG 5 FIX
                {
                    conn.Open();

                    string checkQuery = @"SELECT COUNT(*) FROM applicantdocuments 
                                          WHERE ApplicationID = @ApplicationID AND DocumentType = @DocType";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        checkCmd.Parameters.AddWithValue("@DocType", cmbDocType.SelectedItem.ToString());
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Document already uploaded! Use Replace instead.");
                            return; // using block handles conn cleanup — no leak
                        }
                    }

                    // BUG 3 FIX: INSERT with correct RequirementTypeID; removed broken LAST_INSERT_ID + UPDATE
                    string uploadQuery = @"INSERT INTO applicantdocuments 
                                           (ApplicationID, DocumentType, FilePath, Status, RequirementTypeID) 
                                           VALUES (@ApplicationID, @DocType, @FilePath, 'Submitted', @RequirementTypeID)";
                    using (MySqlCommand uploadCmd = new MySqlCommand(uploadQuery, conn))
                    {
                        uploadCmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        uploadCmd.Parameters.AddWithValue("@DocType", cmbDocType.SelectedItem.ToString());
                        uploadCmd.Parameters.AddWithValue("@FilePath", fileName);
                        uploadCmd.Parameters.AddWithValue("@RequirementTypeID", requirementTypeID);
                        uploadCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Document uploaded successfully!");
                txtFileName.Text = "";
                txtFileName.Tag = null;
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading document: " + ex.Message);
            }
        }

        // BUG 2 FIX: now correctly calls GetApplicationID() for the int
        // BUG 4 FIX: null guard on Tag
        // BUG 5 FIX: connection wrapped in using block
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (listViewDocs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a document to replace!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Please select a new file first!");
                return;
            }

            // BUG 4 FIX: enforce Browse button was used
            if (txtFileName.Tag == null)
            {
                MessageBox.Show("Please use the Browse button to select a file.");
                return;
            }

            try
            {
                // BUG 2 FIX: call GetApplicationID(), not LoadDocuments()
                int applicationID = GetApplicationID();
                if (applicationID == -1)
                {
                    MessageBox.Show("No application found. Cannot replace document.");
                    return;
                }

                string uploadFolder = Application.StartupPath + "\\UploadedDocuments\\";
                if (!Directory.Exists(uploadFolder))
                    Directory.CreateDirectory(uploadFolder);

                string fileName = txtFileName.Text;
                string sourcePath = txtFileName.Tag.ToString(); // BUG 4 FIX
                string destPath = uploadFolder + fileName;
                File.Copy(sourcePath, destPath, true);

                using (var conn = DBConnection.GetConnection()) // BUG 5 FIX
                {
                    conn.Open();

                    string documentID = listViewDocs.SelectedItems[0].Tag.ToString();

                    string replaceQuery = @"UPDATE applicantdocuments 
                                            SET FilePath = @FilePath, Status = 'Submitted' 
                                            WHERE DocumentID = @DocumentID AND ApplicationID = @ApplicationID";
                    using (MySqlCommand replaceCmd = new MySqlCommand(replaceQuery, conn))
                    {
                        replaceCmd.Parameters.AddWithValue("@FilePath", fileName);
                        replaceCmd.Parameters.AddWithValue("@DocumentID", documentID);
                        replaceCmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        replaceCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Document replaced successfully!");
                txtFileName.Text = "";
                txtFileName.Tag = null;
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error replacing document: " + ex.Message);
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
            string fullPath = uploadFolder + fileName;

            if (File.Exists(fullPath))
            {
                string ext = Path.GetExtension(fullPath).ToLower();

                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png")
                {
                    Form imgForm = new Form();
                    imgForm.Text = "Document Preview - " + fileName;
                    imgForm.Size = new System.Drawing.Size(600, 500);
                    imgForm.StartPosition = FormStartPosition.CenterScreen;

                    PictureBox pic = new PictureBox();
                    pic.Dock = DockStyle.Fill;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Image = System.Drawing.Image.FromFile(fullPath);

                    imgForm.Controls.Add(pic);
                    imgForm.Show();
                }
                else
                {
                    try
                    {
                        System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = fullPath,
                            UseShellExecute = true
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not open file: " + ex.Message);
                    }
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

        private void listViewDocs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}