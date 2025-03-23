namespace DBS25P127
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuText;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(405, 118);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "Role";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.HighlightText;
            comboBox1.ForeColor = SystemColors.InfoText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(473, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Select Role";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(329, 186);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 3;
            label3.Text = "UserName";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(329, 230);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 4;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(329, 277);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 5;
            label5.Text = "Password";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(426, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(426, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(564, 359);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 12;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.InfoText;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(393, 66);
            label7.Name = "label7";
            label7.Size = new Size(216, 39);
            label7.TabIndex = 13;
            label7.Text = "SIGN UP";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = Color.Silver;
            linkLabel1.Location = new Point(405, 407);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(201, 34);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Have an Account . LOGIN";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label8
            // 
            label8.BackColor = Color.Black;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(0, 9);
            label8.Name = "label8";
            label8.Size = new Size(1038, 48);
            label8.TabIndex = 15;
            label8.Text = "Faculty Workload and Resource Allocation System";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 321);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(289, 321);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 17;
            label2.Text = "Confirm Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(426, 229);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(245, 23);
            comboBox2.TabIndex = 18;
            comboBox2.MouseHover += comboBox2_MouseHover;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(912, 450);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Signin";
            Text = "Signin";
            Load += Signin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button button1;
        private Label label7;
        private LinkLabel linkLabel1;
        private Label label8;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox2;
    }
}