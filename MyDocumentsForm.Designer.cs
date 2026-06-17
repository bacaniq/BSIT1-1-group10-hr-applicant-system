namespace HRApplicantSystem
{
    partial class MyDocuments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            listViewDocs = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lblDocType = new Label();
            cmbDocType = new ComboBox();
            lblFileName = new Label();
            txtFileName = new TextBox();
            btnUpload = new Button();
            btnReplace = new Button();
            btnBack = new Button();
            btnBrowse = new Button();
            btnViewFile = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(248, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Documents";
            // 
            // listViewDocs
            // 
            listViewDocs.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewDocs.FullRowSelect = true;
            listViewDocs.GridLines = true;
            listViewDocs.Location = new Point(112, 93);
            listViewDocs.MultiSelect = false;
            listViewDocs.Name = "listViewDocs";
            listViewDocs.Size = new Size(442, 91);
            listViewDocs.TabIndex = 1;
            listViewDocs.UseCompatibleStateImageBehavior = false;
            listViewDocs.View = View.Details;
            listViewDocs.SelectedIndexChanged += listViewDocs_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Document Type";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "File Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Remarks";
            columnHeader4.Width = 150;
            // 
            // lblDocType
            // 
            lblDocType.AutoSize = true;
            lblDocType.Location = new Point(129, 237);
            lblDocType.Name = "lblDocType";
            lblDocType.Size = new Size(94, 15);
            lblDocType.TabIndex = 2;
            lblDocType.Text = "Document Type:";
            // 
            // cmbDocType
            // 
            cmbDocType.FormattingEnabled = true;
            cmbDocType.Items.AddRange(new object[] { "Resume", "ID", "Transcript", "Certificate", "Birth Certificate", "Diploma", "Medical Clearance", "Police Clearance" });
            cmbDocType.Location = new Point(253, 237);
            cmbDocType.Name = "cmbDocType";
            cmbDocType.Size = new Size(106, 23);
            cmbDocType.TabIndex = 3;
            cmbDocType.SelectedIndexChanged += cmbDocType_SelectedIndexChanged;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(158, 276);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(63, 15);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(253, 273);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(106, 23);
            txtFileName.TabIndex = 5;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Green;
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(31, 343);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(118, 41);
            btnUpload.TabIndex = 6;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnReplace
            // 
            btnReplace.BackColor = Color.SteelBlue;
            btnReplace.ForeColor = Color.White;
            btnReplace.Location = new Point(188, 343);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(118, 41);
            btnReplace.TabIndex = 7;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = false;
            btnReplace.Click += btnReplace_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(542, 343);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 41);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.SteelBlue;
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(397, 267);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(130, 32);
            btnBrowse.TabIndex = 9;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnViewFile
            // 
            btnViewFile.BackColor = Color.SteelBlue;
            btnViewFile.ForeColor = Color.White;
            btnViewFile.Location = new Point(340, 343);
            btnViewFile.Name = "btnViewFile";
            btnViewFile.Size = new Size(110, 40);
            btnViewFile.TabIndex = 10;
            btnViewFile.Text = "View File";
            btnViewFile.UseVisualStyleBackColor = false;
            btnViewFile.Click += btnViewFile_Click;
            // 
            // MyDocuments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 425);
            Controls.Add(btnViewFile);
            Controls.Add(btnBrowse);
            Controls.Add(btnBack);
            Controls.Add(btnReplace);
            Controls.Add(btnUpload);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            Controls.Add(cmbDocType);
            Controls.Add(lblDocType);
            Controls.Add(listViewDocs);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MyDocuments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Documents";
            Load += MyDocuments_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView listViewDocs;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.ComboBox cmbDocType;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnViewFile;
    }
}