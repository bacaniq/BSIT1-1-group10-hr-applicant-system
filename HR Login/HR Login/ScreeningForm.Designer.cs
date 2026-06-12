using System.Drawing;
using System.Windows.Forms;

namespace HR_Login
{
    partial class ScreeningForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ApplicantName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screening";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ApplicantName,
            this.JobTitle,
            this.Status});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(201, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(247, 139);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ApplicantName
            // 
            this.ApplicantName.Text = "ApplicantName";
            // 
            // JobTitle
            // 
            this.JobTitle.Text = "JobTitle";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remarks:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Qualified";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Not Qualified";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ScreeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "ScreeningForm";
            this.Text = "ScreeningForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader ApplicantName;
        private ColumnHeader JobTitle;
        private ColumnHeader Status;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}