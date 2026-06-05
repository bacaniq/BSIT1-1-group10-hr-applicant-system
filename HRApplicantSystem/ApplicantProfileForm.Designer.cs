namespace HRApplicantSystem
{
    partial class ApplicantProfileForm
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
            txtFirstName = new TextBox();
            label2 = new Label();
            txtContact = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            txtEducation = new TextBox();
            label6 = new Label();
            txtSkills = new TextBox();
            label7 = new Label();
            txtWorkExp = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 97);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(351, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(172, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 160);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(383, 152);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(140, 23);
            txtContact.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 191);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(336, 183);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 23);
            txtAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 128);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(351, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(172, 23);
            txtLastName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 224);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Education:";
            // 
            // txtEducation
            // 
            txtEducation.Location = new Point(347, 216);
            txtEducation.Multiline = true;
            txtEducation.Name = "txtEducation";
            txtEducation.Size = new Size(176, 23);
            txtEducation.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 257);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "Skills:";
            // 
            // txtSkills
            // 
            txtSkills.Location = new Point(320, 249);
            txtSkills.Multiline = true;
            txtSkills.Name = "txtSkills";
            txtSkills.Size = new Size(203, 23);
            txtSkills.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 289);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 12;
            label7.Text = "Work Experience:";
            // 
            // txtWorkExp
            // 
            txtWorkExp.Location = new Point(381, 281);
            txtWorkExp.Multiline = true;
            txtWorkExp.Name = "txtWorkExp";
            txtWorkExp.Size = new Size(142, 23);
            txtWorkExp.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(448, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(278, 338);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(263, 30);
            label8.Name = "label8";
            label8.Size = new Size(281, 37);
            label8.TabIndex = 16;
            label8.Text = "Applicant Profile Form";
            // 
            // ApplicantProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtWorkExp);
            Controls.Add(label7);
            Controls.Add(txtSkills);
            Controls.Add(label6);
            Controls.Add(txtEducation);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtContact);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "ApplicantProfileForm";
            Text = "ApplicantProfileForm";
            Load += ApplicantProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtContact;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtLastName;
        private Label label5;
        private TextBox txtEducation;
        private Label label6;
        private TextBox txtSkills;
        private Label label7;
        private TextBox txtWorkExp;
        private Button btnSave;
        private Button btnClear;
        private Label label8;
    }
}