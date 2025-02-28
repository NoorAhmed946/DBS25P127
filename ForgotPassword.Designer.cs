namespace DBS25P127
{
    partial class ForgotPassword
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
            label8 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(67, 34);
            label8.Name = "label8";
            label8.Size = new Size(669, 32);
            label8.TabIndex = 16;
            label8.Text = "Faculty Workload and Resource Allocation System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 151);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 17;
            label1.Text = "Enter Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 23);
            textBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 204);
            label2.Name = "label2";
            label2.Size = new Size(100, 43);
            label2.TabIndex = 19;
            label2.Text = "Enter Code";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 20;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(311, 88);
            label3.Name = "label3";
            label3.Size = new Size(254, 47);
            label3.TabIndex = 21;
            label3.Text = "RESET PASSWORD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(374, 308);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(124, 23);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to LOGIN Page";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}