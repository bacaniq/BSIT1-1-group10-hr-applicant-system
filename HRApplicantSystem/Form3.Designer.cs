namespace HRApplicantSystem
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
            tbstoredemail = new TextBox();
            label5 = new Label();
            tbConfirmNewPass = new TextBox();
            label4 = new Label();
            tbpasswordchange = new Button();
            tbNewPass = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbstoredemail
            // 
            tbstoredemail.Location = new Point(59, 155);
            tbstoredemail.Margin = new Padding(4, 3, 4, 3);
            tbstoredemail.Name = "tbstoredemail";
            tbstoredemail.Size = new Size(264, 23);
            tbstoredemail.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 137);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 16;
            label5.Text = "Email:";
            // 
            // tbConfirmNewPass
            // 
            tbConfirmNewPass.Location = new Point(59, 304);
            tbConfirmNewPass.Margin = new Padding(4, 3, 4, 3);
            tbConfirmNewPass.Name = "tbConfirmNewPass";
            tbConfirmNewPass.Size = new Size(264, 23);
            tbConfirmNewPass.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 286);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 14;
            label4.Text = "Confirm New Password:";
            // 
            // tbpasswordchange
            // 
            tbpasswordchange.BackColor = SystemColors.ActiveCaption;
            tbpasswordchange.FlatStyle = FlatStyle.Popup;
            tbpasswordchange.Location = new Point(99, 381);
            tbpasswordchange.Margin = new Padding(4, 3, 4, 3);
            tbpasswordchange.Name = "tbpasswordchange";
            tbpasswordchange.Size = new Size(169, 27);
            tbpasswordchange.TabIndex = 13;
            tbpasswordchange.Text = "Confirm Password Change";
            tbpasswordchange.UseVisualStyleBackColor = false;
            tbpasswordchange.Click += tbpasswordchange_Click;
            // 
            // tbNewPass
            // 
            tbNewPass.Location = new Point(59, 228);
            tbNewPass.Margin = new Padding(4, 3, 4, 3);
            tbNewPass.Name = "tbNewPass";
            tbNewPass.Size = new Size(264, 23);
            tbNewPass.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 210);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 11;
            label3.Text = "New Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(361, 46);
            label1.TabIndex = 10;
            label1.Text = "Change Password";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 438);
            Controls.Add(tbstoredemail);
            Controls.Add(label5);
            Controls.Add(tbConfirmNewPass);
            Controls.Add(label4);
            Controls.Add(tbpasswordchange);
            Controls.Add(tbNewPass);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbstoredemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConfirmNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tbpasswordchange;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

