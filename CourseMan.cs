using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBS25P127
{
    public partial class CourseMan : Form
    {
        public static string? courseName;
        public static string? courseType;
        public static int creditHours;
        public static int contactHours;
        private int selectedCourseId = -1;
        public CourseMan()
        {
            InitializeComponent();
            this.Load += CourseMan_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void CourseMan_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            courseName = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseType = comboBox1.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            creditHours = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            contactHours = (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e) // adding
        {
            bool flag = NewCourse.AddCourse(courseName, courseType, creditHours, contactHours);

            if (flag)
            {
                MessageBox.Show("Course added successfully!");
                textBox1.Text = string.Empty;
                comboBox1.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                LoadCourses(); // 🔄 Reload data into the DataGridView
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Update 
        {
            bool flag = NewCourse.UpdateCourse(selectedCourseId, courseName, courseType, creditHours, contactHours);

            if (flag)
            {
                MessageBox.Show("Course Updated successfully!");
                textBox1.Text = string.Empty;
                comboBox1.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                LoadCourses(); // 🔄 Reload data into the DataGridView
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Delete
        {
            bool flag = NewCourse.DeleteCourse(selectedCourseId);
            if (flag)
            {
                MessageBox.Show("Course Deleted successfully!");
                textBox1.Text = string.Empty;
                comboBox1.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                LoadCourses(); // 🔄 Reload data into the DataGridView
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadCourses() // Load Function 
        {

            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = "SELECT course_id, course_name, course_type, credit_hours, contact_hours FROM courses";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["course_id"].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the clicked row index is valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedCourseId = Convert.ToInt32(row.Cells["course_id"].Value);

                textBox1.Text = row.Cells["course_name"].Value.ToString();
                comboBox1.Text = row.Cells["course_type"].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(row.Cells["credit_hours"].Value);
                numericUpDown2.Value = Convert.ToInt32(row.Cells["contact_hours"].Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide();
            adminDashboard.Show();
        }
    }
}
