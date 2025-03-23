namespace DBS25P127
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            pictureBox5 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(-6, -1);
            label1.Name = "label1";
            label1.Size = new Size(1096, 46);
            label1.TabIndex = 11;
            label1.Text = "DashBoard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(96, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 151);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(339, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 151);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(127, 291);
            button1.Name = "button1";
            button1.Size = new Size(112, 51);
            button1.TabIndex = 30;
            button1.Text = "Reports Management";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(364, 291);
            button2.Name = "button2";
            button2.Size = new Size(112, 51);
            button2.TabIndex = 31;
            button2.Text = "Faculty Management";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(605, 291);
            button5.Name = "button5";
            button5.Size = new Size(112, 51);
            button5.TabIndex = 34;
            button5.Text = "New Course";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(581, 134);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(158, 151);
            pictureBox5.TabIndex = 35;
            pictureBox5.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(277, 553);
            button3.Name = "button3";
            button3.Size = new Size(112, 51);
            button3.TabIndex = 36;
            button3.Text = "Rooms";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(701, 553);
            button4.Name = "button4";
            button4.Size = new Size(112, 51);
            button4.TabIndex = 37;
            button4.Text = "Consumables";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(824, 291);
            button6.Name = "button6";
            button6.Size = new Size(112, 51);
            button6.TabIndex = 38;
            button6.Text = "Semester ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(487, 553);
            button7.Name = "button7";
            button7.Size = new Size(112, 51);
            button7.TabIndex = 39;
            button7.Text = "Projects";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(804, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 151);
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(684, 396);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(158, 151);
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(467, 396);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(158, 151);
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(253, 396);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(158, 151);
            pictureBox7.TabIndex = 43;
            pictureBox7.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Desktop;
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(12, 48);
            button8.Name = "button8";
            button8.Size = new Size(90, 38);
            button8.TabIndex = 44;
            button8.Text = "Logout";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1014, 624);
            Controls.Add(button8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox5);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button5;
        private PictureBox pictureBox5;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Button button8;
    }
}