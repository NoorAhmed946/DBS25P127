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
    public partial class CourseAssignment : Form
    {
        int selectedRowId = -1;
        public CourseAssignment()
        {
            InitializeComponent();
            LoadComboBoxes();
            dataGridView1.CellClick += dataGridView1_CellClick ;
            this.Load += CourseAssignment_Load;
        }
        private void CourseAssignment_Load(object sender, EventArgs e)
        {
            LoadFacultyCourses();
        }

        private void LoadComboBoxes()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                // Load Faculty
                MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT faculty_id, name FROM faculty", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "faculty_id";
                comboBox1.SelectedIndex = -1;

                // Load Courses
                MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT course_id, course_name FROM courses", conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBox2.DataSource = dt2;
                comboBox2.DisplayMember = "course_name";
                comboBox2.ValueMember = "course_id";
                comboBox2.SelectedIndex = -1;  

                // Load Semesters
                MySqlDataAdapter da3 = new MySqlDataAdapter("SELECT semester_id,term , year  FROM semesters", conn);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                dt3.Columns.Add("semester", typeof(string));
                foreach (DataRow row in dt3.Rows)
                {
                    row["semester"] = row["term"] + "-" + row["year"];
                }
                comboBox3.DataSource = dt3;
                comboBox3.DisplayMember = "semester";
                comboBox3.ValueMember = "semester_id";
                comboBox3.SelectedIndex = -1;
            }
        }

        private void LoadFacultyCourses()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = @"
            SELECT 
             fc.faculty_course_id,
             fc.faculty_id,
             fc.course_id,
             fc.semester_id
             FROM 
             faculty_courses fc";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Optional: hide internal ID
                dataGridView1.Columns["faculty_course_id"].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Set selectedRowId
                selectedRowId = Convert.ToInt32(row.Cells["faculty_course_id"].Value);

                // Optional: update ComboBoxes with selected row values
                comboBox1.Text = row.Cells["faculty"].Value.ToString();
                comboBox2.Text = row.Cells["course"].Value.ToString();
                comboBox3.Text = row.Cells["semester"].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // ADD
        {
            int facultyId = Convert.ToInt32(comboBox1.SelectedValue);
            int courseId = Convert.ToInt32(comboBox2.SelectedValue);
            int semesterId = Convert.ToInt32(comboBox3.SelectedValue);

            bool success = facultyCourses.AddFacultyCourse(facultyId, courseId, semesterId);

            if (success)
                MessageBox.Show("Assigned successfully!");
            else
                MessageBox.Show("Error occurred.");
        }

        private void button1_Click(object sender, EventArgs e) // Update
        {
            int facultyCourseId = selectedRowId; // get from datagrid or selection
            int facultyId = Convert.ToInt32(comboBox1.SelectedValue);
            int courseId = Convert.ToInt32(comboBox2.SelectedValue);
            int semesterId = Convert.ToInt32(comboBox3.SelectedValue);

            bool success = facultyCourses.UpdateFacultyCourse(facultyCourseId, facultyId, courseId, semesterId);

            if (success)
                MessageBox.Show("Updated successfully!");
            else
                MessageBox.Show("Update failed.");
        }

        private void button3_Click(object sender, EventArgs e) // Clear 
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepartmentHeadDashboard dp = new DepartmentHeadDashboard();
            dp.Show();
            this.Hide();
        }
    }
}
