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
            label1 = new Label();
            listView1 = new ListView();
            ApplicantName = new ColumnHeader();
            JobTitle = new ColumnHeader();
            Status = new ColumnHeader();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 66);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Screening";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ApplicantName, JobTitle, Status });
            listView1.Location = new Point(235, 106);
            listView1.Name = "listView1";
            listView1.Size = new Size(288, 160);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ApplicantName
            // 
            ApplicantName.Text = "ApplicantName";
            // 
            // JobTitle
            // 
            JobTitle.Text = "JobTitle";
            // 
            // Status
            // 
            Status.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 284);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Remarks:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(245, 326);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 4;
            button1.Text = "Qualified";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(416, 330);
            button2.Name = "button2";
            button2.Size = new Size(107, 30);
            button2.TabIndex = 5;
            button2.Text = "Not Qualified";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ScreeningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "ScreeningForm";
            Text = "ScreeningForm";
            Load += ScreeningForm_Load;
            ResumeLayout(false);
            PerformLayout();
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