namespace DBS25P127
{
    partial class Cosumables
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
            Button button4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cosumables));
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(56, 290);
            button4.Name = "button4";
            button4.Size = new Size(93, 64);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(71, 3);
            label1.Name = "label1";
            label1.Size = new Size(855, 46);
            label1.TabIndex = 15;
            label1.Text = "Consumables";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 469);
            panel1.TabIndex = 21;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(56, 220);
            button3.Name = "button3";
            button3.Size = new Size(93, 64);
            button3.TabIndex = 2;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(56, 155);
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
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Desktop;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(345, 98);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 22;
            label2.Text = "Item Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(161, 150);
            dataGridView1.TabIndex = 24;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Desktop;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(260, 12);
            button5.Name = "button5";
            button5.Size = new Size(53, 23);
            button5.TabIndex = 26;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Cosumables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(925, 450);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Cosumables";
            Text = "Cosumables";
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
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button5;
    }
}