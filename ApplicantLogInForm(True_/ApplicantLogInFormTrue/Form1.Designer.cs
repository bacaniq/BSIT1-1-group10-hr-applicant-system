namespace ApplicantLogInFormTrue
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbboxemail = new System.Windows.Forms.TextBox();
            this.tbboxpassword = new System.Windows.Forms.TextBox();
            this.tbregisteraccount = new System.Windows.Forms.LinkLabel();
            this.tbforgotpassword = new System.Windows.Forms.LinkLabel();
            this.tblogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 66.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applicant Login";
            // 
            // tbemail
            // 
            this.tbemail.AutoSize = true;
            this.tbemail.Location = new System.Drawing.Point(229, 218);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(35, 13);
            this.tbemail.TabIndex = 1;
            this.tbemail.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tbboxemail
            // 
            this.tbboxemail.Location = new System.Drawing.Point(270, 215);
            this.tbboxemail.Name = "tbboxemail";
            this.tbboxemail.Size = new System.Drawing.Size(265, 20);
            this.tbboxemail.TabIndex = 3;
            // 
            // tbboxpassword
            // 
            this.tbboxpassword.Location = new System.Drawing.Point(270, 262);
            this.tbboxpassword.Name = "tbboxpassword";
            this.tbboxpassword.Size = new System.Drawing.Size(265, 20);
            this.tbboxpassword.TabIndex = 4;
            // 
            // tbregisteraccount
            // 
            this.tbregisteraccount.AutoSize = true;
            this.tbregisteraccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbregisteraccount.Location = new System.Drawing.Point(219, 388);
            this.tbregisteraccount.Name = "tbregisteraccount";
            this.tbregisteraccount.Size = new System.Drawing.Size(104, 13);
            this.tbregisteraccount.TabIndex = 5;
            this.tbregisteraccount.TabStop = true;
            this.tbregisteraccount.Text = "Register an Account";
            // 
            // tbforgotpassword
            // 
            this.tbforgotpassword.AutoSize = true;
            this.tbforgotpassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbforgotpassword.Location = new System.Drawing.Point(449, 388);
            this.tbforgotpassword.Name = "tbforgotpassword";
            this.tbforgotpassword.Size = new System.Drawing.Size(86, 13);
            this.tbforgotpassword.TabIndex = 6;
            this.tbforgotpassword.TabStop = true;
            this.tbforgotpassword.Text = "Forgot Password";
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(342, 306);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(89, 27);
            this.tblogin.TabIndex = 8;
            this.tblogin.Text = "Login";
            this.tblogin.UseVisualStyleBackColor = true;
            this.tblogin.Click += new System.EventHandler(this.tblogin_Click);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tbemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbboxemail;
        private System.Windows.Forms.TextBox tbboxpassword;
        private System.Windows.Forms.LinkLabel tbregisteraccount;
        private System.Windows.Forms.LinkLabel tbforgotpassword;
        private System.Windows.Forms.Button tblogin;
    }
}

