namespace DBS25P127
{
    partial class ReportManAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportManAdmin));
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(953, 46);
            label1.TabIndex = 9;
            label1.Text = "Report Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Desktop;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(388, 87);
            label2.Name = "label2";
            label2.Size = new Size(181, 40);
            label2.TabIndex = 22;
            label2.Text = "Requests";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Desktop;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(256, 145);
            label5.Name = "label5";
            label5.Size = new Size(84, 27);
            label5.TabIndex = 29;
            label5.Text = "Sort By";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Approved ", "Pending", "Rejected", "Fulfilled" });
            comboBox2.Location = new Point(256, 175);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 23);
            comboBox2.TabIndex = 30;
            comboBox2.Text = "Select";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(733, 150);
            dataGridView1.TabIndex = 31;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Desktop;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(108, 371);
            label3.Name = "label3";
            label3.Size = new Size(153, 27);
            label3.TabIndex = 32;
            label3.Text = "Selected Request ID";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 401);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 33;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Desktop;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(620, 371);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 34;
            label4.Text = "Status";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fulfilled", "Pending", "Rejected" });
            comboBox1.Location = new Point(620, 401);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 35;
            comboBox1.Text = "Select";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(748, 437);
            button1.Name = "button1";
            button1.Size = new Size(93, 51);
            button1.TabIndex = 36;
            button1.Text = "Update Status";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ReportManAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(900, 500);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportManAdmin";
            Text = "ReportManAdmin";
            Load += ReportManAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
    }
}