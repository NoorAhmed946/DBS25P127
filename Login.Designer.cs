﻿namespace DBS25P127
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(45, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Location = new Point(44, 176);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(263, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(227, 215);
            button1.Name = "button1";
            button1.Size = new Size(81, 38);
            button1.TabIndex = 2;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(45, 61);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 3;
            label1.Text = "Enter UserName ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Black;
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(44, 147);
            label2.Name = "label2";
            label2.Size = new Size(122, 26);
            label2.TabIndex = 4;
            label2.Text = "Enter Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.Black;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(123, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(184, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't Have a Account. SIGN-UP";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(-1, 9);
            label3.Name = "label3";
            label3.Size = new Size(864, 48);
            label3.TabIndex = 6;
            label3.Text = "Faculty Workload and Resource Allocation System";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.BackColor = Color.Black;
            linkLabel2.ImageAlign = ContentAlignment.MiddleRight;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(115, 278);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(125, 23);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(370, 73);
            label5.Name = "label5";
            label5.Size = new Size(141, 44);
            label5.TabIndex = 10;
            label5.Text = "LOG IN";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(270, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 364);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(34, 331);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 10;
            label4.Text = "Faculty Only :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 502);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "Login";
            Text = "login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private LinkLabel linkLabel2;
        private Label label5;
        private Panel panel1;
        private Label label4;
    }
}
