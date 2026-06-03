namespace HRApplicantSystem
{
    partial class ApplicationStatusForm
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
            Status = new ColumnHeader();
            ChangedAt = new ColumnHeader();
            Remarks = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(266, 43);
            label1.Name = "label1";
            label1.Size = new Size(231, 37);
            label1.TabIndex = 0;
            label1.Text = "Application Status";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Status, ChangedAt, Remarks });
            listView1.Location = new Point(65, 101);
            listView1.Name = "listView1";
            listView1.Size = new Size(621, 255);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Status
            // 
            Status.Text = "Status";
            // 
            // ChangedAt
            // 
            ChangedAt.Text = "ChangedAt";
            // 
            // Remarks
            // 
            Remarks.Text = "Remarks";
            // 
            // ApplicationStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "ApplicationStatusForm";
            Text = "ApplicationStatusForm";
            Load += ApplicationStatusForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader Status;
        private ColumnHeader ChangedAt;
        private ColumnHeader Remarks;
    }
}