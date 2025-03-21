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
    public partial class Projects : Form
    {
        public static string projectTitle;
        public static string projectDescription;
        private int projectID = -1;
        public Projects()
        {
            InitializeComponent();
            this.Load += Projects_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            projectDescription = textBox2.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            projectTitle = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e) // add 
        {
            bool flag = NewProject.AddProject(projectTitle, projectDescription);

            if (flag)
            {
                MessageBox.Show("Project added successfully!");
                ResetForm();
                LoadProjects();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }

        }

        private void button2_Click(object sender, EventArgs e) // update
        {
            bool flag = NewProject.UpdateProject(projectID, projectTitle, projectDescription);

            if (flag)
            {
                MessageBox.Show("Project updated successfully!");
                ResetForm();
                LoadProjects();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button4_Click(object sender, EventArgs e) // delete 
        {
            bool flag = NewProject.DeleteProject(projectID);

            if (flag)
            {
                MessageBox.Show("Project deleted successfully!");
                ResetForm();
                LoadProjects();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }

        }

        private void LoadProjects()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = "SELECT project_id, title, description FROM projects";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["project_id"].Visible = false;
            }
        }

        // Select Project from Grid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                projectID = Convert.ToInt32(row.Cells["project_id"].Value);
                textBox1.Text = row.Cells["title"].Value.ToString();
                textBox2.Text = row.Cells["description"].Value.ToString();
            }
        }

        // Reset Form Inputs
        private void ResetForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            projectID = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void Projects_Load_1(object sender, EventArgs e)
        {

        }
    }
}
