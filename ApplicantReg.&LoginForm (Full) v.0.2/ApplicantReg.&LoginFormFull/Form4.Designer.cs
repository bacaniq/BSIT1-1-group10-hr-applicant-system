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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblname = new System.Windows.Forms.Label();
            this.tbfname = new System.Windows.Forms.Label();
            this.dtfname = new System.Windows.Forms.DataGridView();
            this.dtemail = new System.Windows.Forms.DataGridView();
            this.dtShowApplicationStatus = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEditApplication = new System.Windows.Forms.Button();
            this.tbViewDraft = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtShowJobApplication = new System.Windows.Forms.DataGridView();
            this.dtlname = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtfname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowApplicationStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowJobApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlname)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "My Application Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // tblname
            // 
            this.tblname.AutoSize = true;
            this.tblname.Location = new System.Drawing.Point(50, 325);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(35, 13);
            this.tblname.TabIndex = 17;
            this.tblname.Text = "Email:";
            // 
            // tbfname
            // 
            this.tbfname.AutoSize = true;
            this.tbfname.Location = new System.Drawing.Point(25, 163);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(60, 13);
            this.tbfname.TabIndex = 16;
            this.tbfname.Text = "First Name:";
            // 
            // dtfname
            // 
            this.dtfname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtfname.Location = new System.Drawing.Point(98, 151);
            this.dtfname.Name = "dtfname";
            this.dtfname.Size = new System.Drawing.Size(308, 50);
            this.dtfname.TabIndex = 18;
            this.dtfname.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtfname_CellContentClick);
            // 
            // dtemail
            // 
            this.dtemail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtemail.Location = new System.Drawing.Point(98, 303);
            this.dtemail.Name = "dtemail";
            this.dtemail.Size = new System.Drawing.Size(308, 58);
            this.dtemail.TabIndex = 19;
            this.dtemail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtShowEmail_CellContentClick);
            // 
            // dtShowApplicationStatus
            // 
            this.dtShowApplicationStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtShowApplicationStatus.Location = new System.Drawing.Point(844, 480);
            this.dtShowApplicationStatus.Name = "dtShowApplicationStatus";
            this.dtShowApplicationStatus.Size = new System.Drawing.Size(308, 57);
            this.dtShowApplicationStatus.TabIndex = 21;
            this.dtShowApplicationStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtShowApplicationStatus_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Application Status:";
            // 
            // tbEditApplication
            // 
            this.tbEditApplication.Location = new System.Drawing.Point(257, 421);
            this.tbEditApplication.Name = "tbEditApplication";
            this.tbEditApplication.Size = new System.Drawing.Size(93, 29);
            this.tbEditApplication.TabIndex = 23;
            this.tbEditApplication.Text = "Edit";
            this.tbEditApplication.UseVisualStyleBackColor = true;
            this.tbEditApplication.Click += new System.EventHandler(this.tbEditApplication_Click);
            // 
            // tbViewDraft
            // 
            this.tbViewDraft.Location = new System.Drawing.Point(140, 421);
            this.tbViewDraft.Name = "tbViewDraft";
            this.tbViewDraft.Size = new System.Drawing.Size(93, 29);
            this.tbViewDraft.TabIndex = 26;
            this.tbViewDraft.Text = "View Draft";
            this.tbViewDraft.UseVisualStyleBackColor = true;
            this.tbViewDraft.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(994, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Application List";
            // 
            // dtShowJobApplication
            // 
            this.dtShowJobApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtShowJobApplication.Location = new System.Drawing.Point(558, 151);
            this.dtShowJobApplication.Name = "dtShowJobApplication";
            this.dtShowJobApplication.Size = new System.Drawing.Size(594, 299);
            this.dtShowJobApplication.TabIndex = 29;
            this.dtShowJobApplication.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtShowJobApplication_CellContentClick);
            // 
            // dtlname
            // 
            this.dtlname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlname.Location = new System.Drawing.Point(98, 225);
            this.dtlname.Name = "dtlname";
            this.dtlname.Size = new System.Drawing.Size(308, 55);
            this.dtlname.TabIndex = 31;
            this.dtlname.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlname_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Last Name:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 632);
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
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtfname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowApplicationStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtShowJobApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tblname;
        private System.Windows.Forms.Label tbfname;
        private System.Windows.Forms.DataGridView dtfname;
        private System.Windows.Forms.DataGridView dtemail;
        private System.Windows.Forms.DataGridView dtShowApplicationStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tbEditApplication;
        private System.Windows.Forms.Button tbViewDraft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtShowJobApplication;
        private System.Windows.Forms.DataGridView dtlname;
        private System.Windows.Forms.Label label8;
    }
}