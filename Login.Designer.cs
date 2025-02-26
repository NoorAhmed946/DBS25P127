namespace DBS25P127
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(227, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(227, 229);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(305, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(448, 284);
            button1.Name = "button1";
            button1.Size = new Size(88, 38);
            button1.TabIndex = 2;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(227, 155);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Login ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(227, 211);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(291, 347);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(172, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't Have a Account. SIGN-IN";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 18);
            label3.Name = "label3";
            label3.Size = new Size(616, 60);
            label3.TabIndex = 6;
            label3.Text = "Faculty Workload and Resource Allocation System";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(227, 92);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 7;
            label4.Text = "Role : ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Department Head", "Faculty Members", "Administrative Staff" });
            comboBox1.Location = new Point(227, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Select Role";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}
