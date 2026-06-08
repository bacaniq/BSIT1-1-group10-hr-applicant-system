namespace ApplicantReg._LoginFormFull
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbpasswordchange = new System.Windows.Forms.Button();
            this.tbConfirmNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbstoredemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password:";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(257, 216);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(339, 20);
            this.tbNewPass.TabIndex = 4;
            // 
            // tbpasswordchange
            // 
            this.tbpasswordchange.Location = new System.Drawing.Point(297, 320);
            this.tbpasswordchange.Name = "tbpasswordchange";
            this.tbpasswordchange.Size = new System.Drawing.Size(145, 23);
            this.tbpasswordchange.TabIndex = 5;
            this.tbpasswordchange.Text = "Confirm Password Change";
            this.tbpasswordchange.UseVisualStyleBackColor = true;
            this.tbpasswordchange.Click += new System.EventHandler(this.tbpasswordchange_Click);
            // 
            // tbConfirmNewPass
            // 
            this.tbConfirmNewPass.Location = new System.Drawing.Point(257, 266);
            this.tbConfirmNewPass.Name = "tbConfirmNewPass";
            this.tbConfirmNewPass.Size = new System.Drawing.Size(339, 20);
            this.tbConfirmNewPass.TabIndex = 7;
            this.tbConfirmNewPass.TextChanged += new System.EventHandler(this.tbConfirmNewPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm New Password:";
            // 
            // tbstoredemail
            // 
            this.tbstoredemail.Location = new System.Drawing.Point(257, 168);
            this.tbstoredemail.Name = "tbstoredemail";
            this.tbstoredemail.Size = new System.Drawing.Size(339, 20);
            this.tbstoredemail.TabIndex = 9;
            this.tbstoredemail.TextChanged += new System.EventHandler(this.tbstoredemail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbstoredemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbConfirmNewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbpasswordchange);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Button tbpasswordchange;
        private System.Windows.Forms.TextBox tbConfirmNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbstoredemail;
        private System.Windows.Forms.Label label5;
    }
}