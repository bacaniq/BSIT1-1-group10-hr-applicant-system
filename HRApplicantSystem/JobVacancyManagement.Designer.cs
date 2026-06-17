namespace HRApplicantSystem
{
    partial class JobVacancyManagement
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
            label1 = new Label();
            txtJobTitle = new TextBox();
            label2 = new Label();
            cmbDepartment = new ComboBox();
            label3 = new Label();
            cmbStatus = new ComboBox();
            label4 = new Label();
            txtDescription = new RichTextBox();
            label5 = new Label();
            txtQualifications = new RichTextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvJobs = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 57);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Job Title:";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(306, 54);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(171, 23);
            txtJobTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 94);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Department:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(306, 91);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(121, 23);
            cmbDepartment.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 127);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(306, 127);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 167);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Decription:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(306, 167);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(236, 96);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 276);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 8;
            label5.Text = "Qualification:";
            // 
            // txtQualifications
            // 
            txtQualifications.Location = new Point(306, 276);
            txtQualifications.Name = "txtQualifications";
            txtQualifications.Size = new Size(236, 96);
            txtQualifications.TabIndex = 9;
            txtQualifications.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(246, 402);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Job";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(352, 402);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(450, 402);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(0, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 16;
            // 
            // dgvJobs
            // 
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(548, 167);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.Size = new Size(240, 150);
            dgvJobs.TabIndex = 14;
            dgvJobs.CellClick += dgvJobs_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(299, 9);
            label6.Name = "label6";
            label6.Size = new Size(244, 25);
            label6.TabIndex = 15;
            label6.Text = "Job Vacancy Management";
            // 
            // JobVacancyManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(dgvJobs);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtQualifications);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(cmbDepartment);
            Controls.Add(label2);
            Controls.Add(txtJobTitle);
            Controls.Add(label1);
            Name = "JobVacancyManagement";
            Text = "JobVacancyManagement";
            Load += JobVacancyManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtJobTitle;
        private Label label2;
        private ComboBox cmbDepartment;
        private Label label3;
        private ComboBox cmbStatus;
        private Label label4;
        private RichTextBox txtDescription;
        private Label label5;
        private RichTextBox txtQualifications;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvJobs;
        private Label label6;
    }
}