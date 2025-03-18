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
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            button6 = new Button();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            button10 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button12 = new Button();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column5, Column8, Column2, Column3 });
            dataGridView1.Location = new Point(291, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(642, 257);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Contact Number";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Designation";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Reasearch Area";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Teaching Hours";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Desktop;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(358, 83);
            label2.Name = "label2";
            label2.Size = new Size(119, 27);
            label2.TabIndex = 20;
            label2.Text = "Select Designation ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(544, 146);
            button6.Name = "button6";
            button6.Size = new Size(93, 36);
            button6.TabIndex = 22;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lecturer", "Assistant Professor", "Associate Professor", "Professor" });
            comboBox1.Location = new Point(358, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 23);
            comboBox1.TabIndex = 23;
            comboBox1.Text = "Select ";
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
            panel2.Size = new Size(214, 483);
            panel2.TabIndex = 24;
            panel2.Paint += panel2_Paint;
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
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(56, 269);
            button7.Name = "button7";
            button7.Size = new Size(93, 64);
            button7.TabIndex = 2;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = false;
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
            // 
            // Faculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(938, 582);
            Controls.Add(button12);
            Controls.Add(panel2);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Faculty";
            Text = "Faculty";
            Load += Faculty_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox comboBox1;
        private Panel panel2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
    }
}