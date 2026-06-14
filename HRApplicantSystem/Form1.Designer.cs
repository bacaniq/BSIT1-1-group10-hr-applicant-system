namespace ApplicantLogInFormFull
{
    partial class Form1
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
            tblogin = new Button();
            tbforgotpassword = new LinkLabel();
            tbregisteraccount = new LinkLabel();
            tbboxpassword = new TextBox();
            tbboxemail = new TextBox();
            label2 = new Label();
            tbemail = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // tblogin
            // 
            tblogin.BackColor = SystemColors.ActiveCaption;
            tblogin.Location = new Point(182, 304);
            tblogin.Margin = new Padding(4, 3, 4, 3);
            tblogin.Name = "tblogin";
            tblogin.Size = new Size(104, 31);
            tblogin.TabIndex = 24;
            tblogin.Text = "Login";
            tblogin.UseVisualStyleBackColor = false;
            tblogin.Click += tblogin_Click;
            // 
            // tbforgotpassword
            // 
            tbforgotpassword.AutoSize = true;
            tbforgotpassword.LinkColor = Color.FromArgb(0, 0, 192);
            tbforgotpassword.Location = new Point(323, 459);
            tbforgotpassword.Margin = new Padding(4, 0, 4, 0);
            tbforgotpassword.Name = "tbforgotpassword";
            tbforgotpassword.Size = new Size(95, 15);
            tbforgotpassword.TabIndex = 23;
            tbforgotpassword.TabStop = true;
            tbforgotpassword.Text = "Forgot Password";
            tbforgotpassword.LinkClicked += tbforgotpassword_LinkClicked_1;
            // 
            // tbregisteraccount
            // 
            tbregisteraccount.AutoSize = true;
            tbregisteraccount.LinkColor = Color.FromArgb(0, 0, 192);
            tbregisteraccount.Location = new Point(21, 459);
            tbregisteraccount.Margin = new Padding(4, 0, 4, 0);
            tbregisteraccount.Name = "tbregisteraccount";
            tbregisteraccount.Size = new Size(113, 15);
            tbregisteraccount.TabIndex = 22;
            tbregisteraccount.TabStop = true;
            tbregisteraccount.Text = "Register an Account";
            tbregisteraccount.LinkClicked += tbregisteraccount_LinkClicked_1;
            // 
            // tbboxpassword
            // 
            tbboxpassword.Location = new Point(94, 236);
            tbboxpassword.Margin = new Padding(4, 3, 4, 3);
            tbboxpassword.Name = "tbboxpassword";
            tbboxpassword.Size = new Size(308, 23);
            tbboxpassword.TabIndex = 21;
            // 
            // tbboxemail
            // 
            tbboxemail.Location = new Point(94, 181);
            tbboxemail.Margin = new Padding(4, 3, 4, 3);
            tbboxemail.Name = "tbboxemail";
            tbboxemail.Size = new Size(308, 23);
            tbboxemail.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 239);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 19;
            label2.Text = "Password:";
            // 
            // tbemail
            // 
            tbemail.AutoSize = true;
            tbemail.Location = new Point(46, 185);
            tbemail.Margin = new Padding(4, 0, 4, 0);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(39, 15);
            tbemail.TabIndex = 18;
            tbemail.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(413, 63);
            label1.TabIndex = 17;
            label1.Text = "Applicant Login";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(163, 381);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(140, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "HR personnel? Click Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 500);
            Controls.Add(linkLabel1);
            Controls.Add(tblogin);
            Controls.Add(tbforgotpassword);
            Controls.Add(tbregisteraccount);
            Controls.Add(tbboxpassword);
            Controls.Add(tbboxemail);
            Controls.Add(label2);
            Controls.Add(tbemail);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tblogin;
        private System.Windows.Forms.LinkLabel tbforgotpassword;
        private System.Windows.Forms.LinkLabel tbregisteraccount;
        private System.Windows.Forms.TextBox tbboxpassword;
        private System.Windows.Forms.TextBox tbboxemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbemail;
        private System.Windows.Forms.Label label1;
        private LinkLabel linkLabel1;
    }
}

