namespace DBS25P127
{
    partial class ProjectAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectAssignment));
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Desktop;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(346, 139);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 3;
            label2.Text = "Faculty Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, -3);
            label1.Name = "label1";
            label1.Size = new Size(1129, 46);
            label1.TabIndex = 4;
            label1.Text = "Project Assignment ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 527);
            panel1.TabIndex = 14;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(56, 276);
            button3.Name = "button3";
            button3.Size = new Size(93, 64);
            button3.TabIndex = 2;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(56, 182);
            button2.Name = "button2";
            button2.Size = new Size(93, 59);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(56, 89);
            button1.Name = "button1";
            button1.Size = new Size(93, 60);
            button1.TabIndex = 0;
            button1.Text = "Assign";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Desktop;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(256, 12);
            button4.Name = "button4";
            button4.Size = new Size(53, 23);
            button4.TabIndex = 15;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Menu;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.ForeColor = SystemColors.MenuText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(346, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 24);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Select Faculty";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Desktop;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(695, 139);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 17;
            label3.Text = "Project Title";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Desktop;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(695, 217);
            label4.Name = "label4";
            label4.Size = new Size(128, 22);
            label4.TabIndex = 19;
            label4.Text = "SuperVision Hours";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(695, 242);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(237, 23);
            numericUpDown1.TabIndex = 20;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Desktop;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(346, 217);
            label5.Name = "label5";
            label5.Size = new Size(92, 22);
            label5.TabIndex = 22;
            label5.Text = "Semester";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Menu;
            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.ForeColor = SystemColors.MenuText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(346, 242);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(260, 24);
            comboBox2.TabIndex = 23;
            comboBox2.Text = "Select Semester";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.Menu;
            comboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox3.ForeColor = SystemColors.MenuText;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(695, 164);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(260, 24);
            comboBox3.TabIndex = 24;
            comboBox3.Text = "Select Title";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(432, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(412, 176);
            dataGridView1.TabIndex = 25;
            // 
            // ProjectAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1036, 479);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ProjectAssignment";
            Text = "ProjectAssignment";
            Load += ProjectAssignment_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
    }
}