namespace MyApplicationPage
{
    partial class Form4
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
            this.dtlname = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtShowJobApplication = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbViewDraft = new System.Windows.Forms.Button();
            this.tbEditApplication = new System.Windows.Forms.Button();
            this.dtShowApplicationStatus = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtemail = new System.Windows.Forms.DataGridView();
            this.dtfname = new System.Windows.Forms.DataGridView();
            this.tblname = new System.Windows.Forms.Label();
            this.tbfname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtlname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowJobApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowApplicationStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfname)).BeginInit();
            this.SuspendLayout();
            // 
            // dtlname
            // 
            this.dtlname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlname.Location = new System.Drawing.Point(135, 261);
            this.dtlname.Name = "dtlname";
            this.dtlname.Size = new System.Drawing.Size(308, 55);
            this.dtlname.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Last Name:";
            // 
            // dtShowJobApplication
            // 
            this.dtShowJobApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtShowJobApplication.Location = new System.Drawing.Point(590, 186);
            this.dtShowJobApplication.Name = "dtShowJobApplication";
            this.dtShowJobApplication.Size = new System.Drawing.Size(594, 299);
            this.dtShowJobApplication.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1026, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Application List";
            // 
            // tbViewDraft
            // 
            this.tbViewDraft.Location = new System.Drawing.Point(177, 457);
            this.tbViewDraft.Name = "tbViewDraft";
            this.tbViewDraft.Size = new System.Drawing.Size(93, 29);
            this.tbViewDraft.TabIndex = 41;
            this.tbViewDraft.Text = "View Draft";
            this.tbViewDraft.UseVisualStyleBackColor = true;
            // 
            // tbEditApplication
            // 
            this.tbEditApplication.Location = new System.Drawing.Point(294, 457);
            this.tbEditApplication.Name = "tbEditApplication";
            this.tbEditApplication.Size = new System.Drawing.Size(93, 29);
            this.tbEditApplication.TabIndex = 40;
            this.tbEditApplication.Text = "Edit";
            this.tbEditApplication.UseVisualStyleBackColor = true;
            // 
            // dtShowApplicationStatus
            // 
            this.dtShowApplicationStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtShowApplicationStatus.Location = new System.Drawing.Point(876, 515);
            this.dtShowApplicationStatus.Name = "dtShowApplicationStatus";
            this.dtShowApplicationStatus.Size = new System.Drawing.Size(308, 57);
            this.dtShowApplicationStatus.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Application Status:";
            // 
            // dtemail
            // 
            this.dtemail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtemail.Location = new System.Drawing.Point(135, 339);
            this.dtemail.Name = "dtemail";
            this.dtemail.Size = new System.Drawing.Size(308, 58);
            this.dtemail.TabIndex = 37;
            // 
            // dtfname
            // 
            this.dtfname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtfname.Location = new System.Drawing.Point(135, 187);
            this.dtfname.Name = "dtfname";
            this.dtfname.Size = new System.Drawing.Size(308, 50);
            this.dtfname.TabIndex = 36;
            // 
            // tblname
            // 
            this.tblname.AutoSize = true;
            this.tblname.Location = new System.Drawing.Point(87, 361);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(35, 13);
            this.tblname.TabIndex = 35;
            this.tblname.Text = "Email:";
            // 
            // tbfname
            // 
            this.tbfname.AutoSize = true;
            this.tbfname.Location = new System.Drawing.Point(62, 199);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(60, 13);
            this.tbfname.TabIndex = 34;
            this.tbfname.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 64);
            this.label2.TabIndex = 32;
            this.label2.Text = "My Application Page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 617);
            this.Controls.Add(this.dtlname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtShowJobApplication);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbViewDraft);
            this.Controls.Add(this.tbEditApplication);
            this.Controls.Add(this.dtShowApplicationStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtemail);
            this.Controls.Add(this.dtfname);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtlname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowJobApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowApplicationStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtlname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtShowJobApplication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tbViewDraft;
        private System.Windows.Forms.Button tbEditApplication;
        private System.Windows.Forms.DataGridView dtShowApplicationStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtemail;
        private System.Windows.Forms.DataGridView dtfname;
        private System.Windows.Forms.Label tblname;
        private System.Windows.Forms.Label tbfname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

