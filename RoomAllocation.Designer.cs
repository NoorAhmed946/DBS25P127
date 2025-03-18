﻿namespace DBS25P127
{
    partial class RoomAllocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomAllocation));
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(205, -1);
            label1.Name = "label1";
            label1.Size = new Size(815, 46);
            label1.TabIndex = 6;
            label1.Text = " Faculty Rooms Allocation";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-6, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 546);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(56, 283);
            button3.Name = "button3";
            button3.Size = new Size(93, 64);
            button3.TabIndex = 2;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(56, 190);
            button2.Name = "button2";
            button2.Size = new Size(93, 59);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(56, 89);
            button1.Name = "button1";
            button1.Size = new Size(93, 60);
            button1.TabIndex = 0;
            button1.Text = "Allocate";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Desktop;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(391, 145);
            label2.Name = "label2";
            label2.Size = new Size(92, 27);
            label2.TabIndex = 19;
            label2.Text = "Faculty Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.MenuText;
            comboBox1.ForeColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Department Head", "Faculty Members", "Administrative Staff" });
            comboBox1.Location = new Point(391, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 23);
            comboBox1.TabIndex = 20;
            comboBox1.Text = "Select Role";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Desktop;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(740, 145);
            label3.Name = "label3";
            label3.Size = new Size(92, 27);
            label3.TabIndex = 21;
            label3.Text = "Rooms";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.MenuText;
            comboBox2.ForeColor = SystemColors.ScrollBar;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(740, 175);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(260, 23);
            comboBox2.TabIndex = 22;
            comboBox2.Text = "Select Rooms";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Desktop;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(259, 58);
            button4.Name = "button4";
            button4.Size = new Size(53, 23);
            button4.TabIndex = 27;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3 });
            dataGridView1.Location = new Point(515, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 150);
            dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            Column1.HeaderText = "Faculty";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ClassRoom / Lab ";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Semester";
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "Reserved Hours";
            Column3.Name = "Column3";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Desktop;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(391, 231);
            label4.Name = "label4";
            label4.Size = new Size(92, 27);
            label4.TabIndex = 29;
            label4.Text = "Semester";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.MenuText;
            comboBox3.ForeColor = SystemColors.ScrollBar;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Department Head", "Faculty Members", "Administrative Staff" });
            comboBox3.Location = new Point(391, 261);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(260, 23);
            comboBox3.TabIndex = 30;
            comboBox3.Text = "Select Semester";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Desktop;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(740, 231);
            label5.Name = "label5";
            label5.Size = new Size(92, 27);
            label5.TabIndex = 31;
            label5.Text = "Reserved Hours";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(740, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 32;
            // 
            // RoomAllocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1116, 573);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "RoomAllocation";
            Text = "RoomAllocation";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
    }
}