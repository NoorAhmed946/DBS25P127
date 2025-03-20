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
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P127
{
    public partial class ProjectAssignment : Form
    {
        int selectedRowId = -1;
        public ProjectAssignment()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadData();
            this.Load += ProjectAssignment_Load;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProjectAssignment_Load(object sender, EventArgs e)
        {
            LoadFacultyProjects();
        }

        private void LoadData() // 1 for F , 2 for sem , 3 for title
        {
            using (MySqlConnection con = DatabaseHelper.Instance.getConnection())
            {
                // Load faculty
                MySqlDataAdapter dal = new MySqlDataAdapter("SELECT name , faculty_id from faculty", con);
                DataTable dt1 = new DataTable();
                dal.Fill(dt1);
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "faculty_id";

                // Load Title 
                MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT project_id , title FROM projects", con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBox3.DataSource = dt2;
                comboBox3.DisplayMember = "title";
                comboBox3.ValueMember = "project_id";

                // Load Semester 
                MySqlDataAdapter da3 = new MySqlDataAdapter("SELECT semester_id,term , year  FROM semesters", con);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                dt3.Columns.Add("semester", typeof(string));
                foreach (DataRow row in dt3.Rows)
                {
                    row["semester"] = row["term"] + "-" + row["year"];
                }
                comboBox2.DataSource = dt3;
                comboBox2.DisplayMember = "semester";
                comboBox2.ValueMember = "semester_id";

            }
        }

        private void LoadFacultyProjects()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = @"
        SELECT 
            faculty_project_id,
            faculty_id,
            project_id,
            semester_id,
            supervision_hours
        FROM 
            faculty_projects";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Optional: hide internal ID
                dataGridView1.Columns["faculty_project_id"].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Set selectedRowId
                selectedRowId = Convert.ToInt32(row.Cells["faculty_project_id"].Value);

                // Update comboBoxes or other controls based on new schema
                comboBox1.SelectedValue = row.Cells["faculty_id"].Value;
                comboBox2.SelectedValue = row.Cells["project_id"].Value;
                comboBox3.SelectedValue = row.Cells["semester_id"].Value;
                numericUpDown1.Value = (decimal)row.Cells["supervision_hours"].Value; // Assuming you have a textbox for hours
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentHeadDashboard dp = new DepartmentHeadDashboard();
            dp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int facultyId = Convert.ToInt32(comboBox1.SelectedValue);
            int projectId = Convert.ToInt32(comboBox2.SelectedValue);
            int semesterId = Convert.ToInt32(comboBox3.SelectedValue);
            int supervisionHours = Convert.ToInt32(numericUpDown1.Text); // Assuming supervision_hours input is in a textbox

            bool success = NewProject.AddFacultyProject(facultyId, projectId, semesterId, supervisionHours);

            if (success)
                MessageBox.Show("Project assigned successfully!");
            else
                MessageBox.Show("Error occurred while assigning project.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            numericUpDown1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e) // Update 
        {
            int facultyProjectId = selectedRowId; // get from DataGridView selection
            int facultyId = Convert.ToInt32(comboBox1.SelectedValue);
            int projectId = Convert.ToInt32(comboBox2.SelectedValue);
            int semesterId = Convert.ToInt32(comboBox3.SelectedValue);
            int supervisionHours = (int)numericUpDown1.Value;

            bool success = NewProject.UpdateFacultyProject(facultyProjectId, facultyId, projectId, semesterId, supervisionHours);

            if (success)
                MessageBox.Show("Updated successfully!");
            else
                MessageBox.Show("Update failed.");

        }

    }
}
