namespace ApplicantRegistrationFormFull
{
    partial class Form2
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
            tbclear = new Button();
            tbConRegister = new Button();
            tbConfRegPassword = new TextBox();
            tbRegPassword = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tbConpassword = new Label();
            tbpassword = new Label();
            tbemail = new Label();
            tblname = new Label();
            tbfname = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbclear
            // 
            tbclear.BackColor = SystemColors.Info;
            tbclear.Location = new Point(252, 434);
            tbclear.Margin = new Padding(4, 3, 4, 3);
            tbclear.Name = "tbclear";
            tbclear.Size = new Size(132, 27);
            tbclear.TabIndex = 38;
            tbclear.Text = "Clear";
            tbclear.UseVisualStyleBackColor = false;
            // 
            // tbConRegister
            // 
            tbConRegister.BackColor = SystemColors.ActiveCaption;
            tbConRegister.Location = new Point(49, 434);
            tbConRegister.Margin = new Padding(4, 3, 4, 3);
            tbConRegister.Name = "tbConRegister";
            tbConRegister.Size = new Size(132, 27);
            tbConRegister.TabIndex = 37;
            tbConRegister.Text = "Confirm Registration";
            tbConRegister.UseVisualStyleBackColor = false;
            tbConRegister.Click += tbConRegister_Click;
            // 
            // tbConfRegPassword
            // 
            tbConfRegPassword.Location = new Point(123, 346);
            tbConfRegPassword.Margin = new Padding(4, 3, 4, 3);
            tbConfRegPassword.Name = "tbConfRegPassword";
            tbConfRegPassword.Size = new Size(290, 23);
            tbConfRegPassword.TabIndex = 36;
            // 
            // tbRegPassword
            // 
            tbRegPassword.Location = new Point(123, 298);
            tbRegPassword.Margin = new Padding(4, 3, 4, 3);
            tbRegPassword.Name = "tbRegPassword";
            tbRegPassword.Size = new Size(290, 23);
            tbRegPassword.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 253);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 23);
            textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 204);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 23);
            textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 157);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 32;
            // 
            // tbConpassword
            // 
            tbConpassword.AutoSize = true;
            tbConpassword.Location = new Point(14, 351);
            tbConpassword.Margin = new Padding(4, 0, 4, 0);
            tbConpassword.Name = "tbConpassword";
            tbConpassword.Size = new Size(107, 15);
            tbConpassword.TabIndex = 31;
            tbConpassword.Text = "Confirm Password:";
            // 
            // tbpassword
            // 
            tbpassword.AutoSize = true;
            tbpassword.Location = new Point(61, 301);
            tbpassword.Margin = new Padding(4, 0, 4, 0);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(60, 15);
            tbpassword.TabIndex = 30;
            tbpassword.Text = "Password:";
            // 
            // tbemail
            // 
            tbemail.AutoSize = true;
            tbemail.Location = new Point(82, 256);
            tbemail.Margin = new Padding(4, 0, 4, 0);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(39, 15);
            tbemail.TabIndex = 29;
            tbemail.Text = "Email:";
            // 
            // tblname
            // 
            tblname.AutoSize = true;
            tblname.Location = new Point(55, 207);
            tblname.Margin = new Padding(4, 0, 4, 0);
            tblname.Name = "tblname";
            tblname.Size = new Size(66, 15);
            tblname.TabIndex = 28;
            tblname.Text = "Last Name:";
            // 
            // tbfname
            // 
            tbfname.AutoSize = true;
            tbfname.Location = new Point(54, 160);
            tbfname.Margin = new Padding(4, 0, 4, 0);
            tbfname.Name = "tbfname";
            tbfname.Size = new Size(67, 15);
            tbfname.TabIndex = 27;
            tbfname.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(411, 35);
            label1.TabIndex = 26;
            label1.Text = "New Applicant Registration";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 495);
            Controls.Add(tbclear);
            Controls.Add(tbConRegister);
            Controls.Add(tbConfRegPassword);
            Controls.Add(tbRegPassword);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tbConpassword);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            Controls.Add(tblname);
            Controls.Add(tbfname);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Form1";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbclear;
        private System.Windows.Forms.Button tbConRegister;
        private System.Windows.Forms.TextBox tbConfRegPassword;
        private System.Windows.Forms.TextBox tbRegPassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbConpassword;
        private System.Windows.Forms.Label tbpassword;
        private System.Windows.Forms.Label tbemail;
        private System.Windows.Forms.Label tblname;
        private System.Windows.Forms.Label tbfname;
        private System.Windows.Forms.Label label1;
    }
}

