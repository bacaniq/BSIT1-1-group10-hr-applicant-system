namespace HRApplicantSystem
{
    partial class AuditTrailForm
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
            UserType = new ColumnHeader();
            Action = new ColumnHeader();
            ActionAt = new ColumnHeader();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(320, 74);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 0;
            label1.Text = "Audit Trail";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { UserType, Action, ActionAt });
            listView1.Location = new Point(233, 132);
            listView1.Name = "listView1";
            listView1.Size = new Size(315, 180);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // UserType
            // 
            UserType.Text = "UserType";
            // 
            // Action
            // 
            Action.DisplayIndex = 2;
            Action.Text = "Action";
            // 
            // ActionAt
            // 
            ActionAt.DisplayIndex = 1;
            ActionAt.Text = "ActionAt";
            // 
            // AuditTrailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "AuditTrailForm";
            Text = "AuditTrailForm";
            Load += AuditTrailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader UserType;
        private ColumnHeader ActionAt;
        private ColumnHeader Action;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
    }
}