namespace DBS25P127
{
    partial class CourseAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAssignment));
            label1 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(1115, 46);
            label1.TabIndex = 1;
            label1.Text = "Course Assignment";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(410, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(265, 23);
            comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBox3.Location = new Point(410, 218);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(265, 23);
            comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(410, 123);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Select Course";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(410, 192);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 8;
            label4.Text = "Select Semester ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5 });
            dataGridView1.Location = new Point(520, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 215);
            dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.HeaderText = "Faculty";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Semester";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Course";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Credit Hours";
            Column5.Name = "Column5";
            // 
            // label7
            // 
            label7.Location = new Point(813, 123);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 17;
            label7.Text = "Faculty";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(813, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Desktop;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(210, 23);
            button2.Name = "button2";
            button2.Size = new Size(53, 26);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 523);
            panel1.TabIndex = 21;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(56, 283);
            button3.Name = "button3";
            button3.Size = new Size(93, 64);
            button3.TabIndex = 2;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(56, 190);
            button1.Name = "button1";
            button1.Size = new Size(93, 59);
            button1.TabIndex = 1;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(56, 89);
            button4.Name = "button4";
            button4.Size = new Size(93, 60);
            button4.TabIndex = 0;
            button4.Text = "Assign";
            button4.UseVisualStyleBackColor = false;
            // 
            // CourseAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 702);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Enabled = false;
            Name = "CourseAssignment";
            Text = "CourseAssignment";
            WindowState = FormWindowState.Maximized;
            Load += CourseAssignment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label7;
        private ComboBox comboBox1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
    }
}