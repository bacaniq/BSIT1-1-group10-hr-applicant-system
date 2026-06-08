namespace HRApplicantSystem
{
    partial class MaintenanceForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            tabPage2 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            listView2 = new ListView();
            RequirementName = new ColumnHeader();
            tabPage3 = new TabPage();
            button5 = new Button();
            button6 = new Button();
            textBox3 = new TextBox();
            listView3 = new ListView();
            columnHeader2 = new ColumnHeader();
            tabPage4 = new TabPage();
            button8 = new Button();
            button7 = new Button();
            textBox4 = new TextBox();
            listView4 = new ListView();
            columnHeader3 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 29);
            label1.Name = "label1";
            label1.Size = new Size(209, 45);
            label1.TabIndex = 0;
            label1.Text = "Maintenance";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(193, 94);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(405, 201);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(listView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(397, 173);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Departments";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(229, 138);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(95, 138);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Location = new Point(6, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(385, 76);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(listView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(397, 173);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Requirement Types";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(229, 136);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(95, 136);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 1;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { RequirementName });
            listView2.Location = new Point(15, 10);
            listView2.Name = "listView2";
            listView2.Size = new Size(371, 74);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // RequirementName
            // 
            RequirementName.Text = "RequirementName";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(listView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(397, 173);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Employment Types";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(67, 137);
            button5.Name = "button5";
            button5.Size = new Size(90, 30);
            button5.TabIndex = 4;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(195, 139);
            button6.Name = "button6";
            button6.Size = new Size(97, 28);
            button6.TabIndex = 3;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 1;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listView3.Location = new Point(10, 11);
            listView3.Name = "listView3";
            listView3.Size = new Size(377, 77);
            listView3.TabIndex = 0;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "EmploymentTypeName";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(listView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(397, 173);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Interview Types";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(204, 125);
            button8.Name = "button8";
            button8.Size = new Size(96, 29);
            button8.TabIndex = 4;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(84, 125);
            button7.Name = "button7";
            button7.Size = new Size(100, 29);
            button7.TabIndex = 3;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(115, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 1;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            listView4.Location = new Point(11, 11);
            listView4.Name = "listView4";
            listView4.Size = new Size(374, 72);
            listView4.TabIndex = 0;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "InterviewTypeName";
            // 
            // MaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "MaintenanceForm";
            Text = "MaintenanceForm";
            Load += MaintenanceForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ListView listView2;
        private Button button4;
        private Button button3;
        private TextBox textBox2;
        private ColumnHeader RequirementName;
        private Button button6;
        private TextBox textBox3;
        private ListView listView3;
        private ColumnHeader columnHeader2;
        private Button button7;
        private TextBox textBox4;
        private ListView listView4;
        private Button button5;
        private Button button8;
        private ColumnHeader columnHeader3;
    }
}