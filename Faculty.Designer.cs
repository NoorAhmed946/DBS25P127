namespace DBS25P127
{
    partial class Faculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faculty));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            button10 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button12 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(-2, -3);
            label1.Name = "label1";
            label1.Size = new Size(1081, 46);
            label1.TabIndex = 0;
            label1.Text = "Faculty Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(317, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(642, 257);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Desktop;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(642, 225);
            label2.Name = "label2";
            label2.Size = new Size(119, 27);
            label2.TabIndex = 20;
            label2.Text = "Select Designation ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lecturer", "Assistant Professor", "Associate Professor", "Professor" });
            comboBox1.Location = new Point(642, 255);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 23);
            comboBox1.TabIndex = 23;
            comboBox1.Text = "Select ";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button9);
            panel2.Location = new Point(-2, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 577);
            panel2.TabIndex = 24;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaptionText;
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(56, 339);
            button10.Name = "button10";
            button10.Size = new Size(93, 59);
            button10.TabIndex = 3;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(56, 269);
            button7.Name = "button7";
            button7.Size = new Size(93, 56);
            button7.TabIndex = 2;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaptionText;
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(56, 204);
            button8.Name = "button8";
            button8.Size = new Size(93, 59);
            button8.TabIndex = 1;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaptionText;
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(56, 137);
            button9.Name = "button9";
            button9.Size = new Size(93, 60);
            button9.TabIndex = 0;
            button9.Text = "Save";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.Desktop;
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(245, 12);
            button12.Name = "button12";
            button12.Size = new Size(53, 27);
            button12.TabIndex = 25;
            button12.Text = "Back";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Desktop;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(320, 78);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 26;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Desktop;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(642, 78);
            label4.Name = "label4";
            label4.Size = new Size(97, 27);
            label4.TabIndex = 27;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Desktop;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(320, 225);
            label5.Name = "label5";
            label5.Size = new Size(119, 27);
            label5.TabIndex = 28;
            label5.Text = "Research Area";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Desktop;
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(642, 151);
            label7.Name = "label7";
            label7.Size = new Size(119, 27);
            label7.TabIndex = 30;
            label7.Text = "Teaching Hours";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 31;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(642, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 32;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(320, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 23);
            textBox3.TabIndex = 33;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(642, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 23);
            textBox4.TabIndex = 34;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Desktop;
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(317, 151);
            label6.Name = "label6";
            label6.Size = new Size(119, 27);
            label6.TabIndex = 35;
            label6.Text = "Contact Number";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(317, 181);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(233, 23);
            textBox5.TabIndex = 36;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Faculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 582);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button12);
            Controls.Add(panel2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Faculty";
            Text = "Faculty";
            Load += Faculty_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
    }
}