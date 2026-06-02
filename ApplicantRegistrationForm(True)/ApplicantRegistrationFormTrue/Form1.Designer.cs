namespace ApplicantRegistrationFormTrue
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
            this.tbfname = new System.Windows.Forms.Label();
            this.tblname = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.Label();
            this.tbConpassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbConRegister = new System.Windows.Forms.Button();
            this.tbclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User Registration";
            // 
            // tbfname
            // 
            this.tbfname.AutoSize = true;
            this.tbfname.Location = new System.Drawing.Point(156, 152);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(60, 13);
            this.tbfname.TabIndex = 1;
            this.tbfname.Text = "First Name:";
            // 
            // tblname
            // 
            this.tblname.AutoSize = true;
            this.tblname.Location = new System.Drawing.Point(155, 192);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(61, 13);
            this.tblname.TabIndex = 2;
            this.tblname.Text = "Last Name:";
            // 
            // tbemail
            // 
            this.tbemail.AutoSize = true;
            this.tbemail.Location = new System.Drawing.Point(176, 232);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(35, 13);
            this.tbemail.TabIndex = 3;
            this.tbemail.Text = "Email:";
            // 
            // tbpassword
            // 
            this.tbpassword.AutoSize = true;
            this.tbpassword.Location = new System.Drawing.Point(160, 271);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(56, 13);
            this.tbpassword.TabIndex = 4;
            this.tbpassword.Text = "Password:";
            // 
            // tbConpassword
            // 
            this.tbConpassword.AutoSize = true;
            this.tbConpassword.Location = new System.Drawing.Point(117, 313);
            this.tbConpassword.Name = "tbConpassword";
            this.tbConpassword.Size = new System.Drawing.Size(94, 13);
            this.tbConpassword.TabIndex = 5;
            this.tbConpassword.Text = "Confirm Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(439, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(237, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(439, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(237, 271);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(439, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(237, 313);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(439, 20);
            this.textBox5.TabIndex = 10;
            // 
            // tbConRegister
            // 
            this.tbConRegister.Location = new System.Drawing.Point(296, 358);
            this.tbConRegister.Name = "tbConRegister";
            this.tbConRegister.Size = new System.Drawing.Size(113, 23);
            this.tbConRegister.TabIndex = 11;
            this.tbConRegister.Text = "Confirm Registration";
            this.tbConRegister.UseVisualStyleBackColor = true;
            this.tbConRegister.Click += new System.EventHandler(this.tbConRegister_Click);
            // 
            // tbclear
            // 
            this.tbclear.Location = new System.Drawing.Point(443, 358);
            this.tbclear.Name = "tbclear";
            this.tbclear.Size = new System.Drawing.Size(113, 23);
            this.tbclear.TabIndex = 12;
            this.tbclear.Text = "Clear";
            this.tbclear.UseVisualStyleBackColor = true;
            this.tbclear.Click += new System.EventHandler(this.tbclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbclear);
            this.Controls.Add(this.tbConRegister);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbConpassword);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tbfname;
        private System.Windows.Forms.Label tblname;
        private System.Windows.Forms.Label tbemail;
        private System.Windows.Forms.Label tbpassword;
        private System.Windows.Forms.Label tbConpassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button tbConRegister;
        private System.Windows.Forms.Button tbclear;
    }
}

