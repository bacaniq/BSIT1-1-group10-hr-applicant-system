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
            this.tblogin = new System.Windows.Forms.Button();
            this.tbforgotpassword = new System.Windows.Forms.LinkLabel();
            this.tbregisteraccount = new System.Windows.Forms.LinkLabel();
            this.tbboxpassword = new System.Windows.Forms.TextBox();
            this.tbboxemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(350, 301);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(89, 27);
            this.tblogin.TabIndex = 16;
            this.tblogin.Text = "Login";
            this.tblogin.UseVisualStyleBackColor = true;
            this.tblogin.Click += new System.EventHandler(this.tblogin_Click);
            // 
            // tbforgotpassword
            // 
            this.tbforgotpassword.AutoSize = true;
            this.tbforgotpassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbforgotpassword.Location = new System.Drawing.Point(457, 383);
            this.tbforgotpassword.Name = "tbforgotpassword";
            this.tbforgotpassword.Size = new System.Drawing.Size(86, 13);
            this.tbforgotpassword.TabIndex = 15;
            this.tbforgotpassword.TabStop = true;
            this.tbforgotpassword.Text = "Forgot Password";
            // 
            // tbregisteraccount
            // 
            this.tbregisteraccount.AutoSize = true;
            this.tbregisteraccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbregisteraccount.Location = new System.Drawing.Point(227, 383);
            this.tbregisteraccount.Name = "tbregisteraccount";
            this.tbregisteraccount.Size = new System.Drawing.Size(104, 13);
            this.tbregisteraccount.TabIndex = 14;
            this.tbregisteraccount.TabStop = true;
            this.tbregisteraccount.Text = "Register an Account";
            this.tbregisteraccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tbregisteraccount_LinkClicked);
            // 
            // tbboxpassword
            // 
            this.tbboxpassword.Location = new System.Drawing.Point(278, 257);
            this.tbboxpassword.Name = "tbboxpassword";
            this.tbboxpassword.Size = new System.Drawing.Size(265, 20);
            this.tbboxpassword.TabIndex = 13;
            // 
            // tbboxemail
            // 
            this.tbboxemail.Location = new System.Drawing.Point(278, 210);
            this.tbboxemail.Name = "tbboxemail";
            this.tbboxemail.Size = new System.Drawing.Size(265, 20);
            this.tbboxemail.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // tbemail
            // 
            this.tbemail.AutoSize = true;
            this.tbemail.Location = new System.Drawing.Point(237, 213);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(35, 13);
            this.tbemail.TabIndex = 10;
            this.tbemail.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 66.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 101);
            this.label1.TabIndex = 9;
            this.label1.Text = "Applicant Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.tbforgotpassword);
            this.Controls.Add(this.tbregisteraccount);
            this.Controls.Add(this.tbboxpassword);
            this.Controls.Add(this.tbboxemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

