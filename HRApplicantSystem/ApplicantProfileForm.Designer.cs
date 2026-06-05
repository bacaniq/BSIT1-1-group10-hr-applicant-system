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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 103);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(111, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(172, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 166);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(143, 158);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(140, 23);
            txtContact.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 197);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(96, 189);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 23);
            txtAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 134);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(111, 126);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(172, 23);
            txtLastName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 230);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Education:";
            // 
            // txtEducation
            // 
            txtEducation.Location = new Point(107, 222);
            txtEducation.Multiline = true;
            txtEducation.Name = "txtEducation";
            txtEducation.Size = new Size(176, 23);
            txtEducation.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 263);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "Skills:";
            // 
            // txtSkills
            // 
            txtSkills.Location = new Point(80, 255);
            txtSkills.Multiline = true;
            txtSkills.Name = "txtSkills";
            txtSkills.Size = new Size(203, 23);
            txtSkills.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 295);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 12;
            label7.Text = "Work Experience:";
            // 
            // txtWorkExp
            // 
            txtWorkExp.Location = new Point(141, 287);
            txtWorkExp.Multiline = true;
            txtWorkExp.Name = "txtWorkExp";
            txtWorkExp.Size = new Size(142, 23);
            txtWorkExp.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(208, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(38, 344);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ApplicantProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}