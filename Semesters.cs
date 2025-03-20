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
    public partial class Semesters : Form
    {
        public static string term;
        public static int year;
        private int semesterID = -1;
        public Semesters()
        {
            InitializeComponent();
            this.Load += Semesters_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void Semesters_Load(object sender, EventArgs e)
        {
            LoadSemesters();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            term = comboBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            year = Convert.ToInt32(textBox2.Text);
        }
        private void LoadSemesters()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = "SELECT semester_id, term, year FROM semesters";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Hide the primary key column from the user
                dataGridView1.Columns["semester_id"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) // Add Semester
        {
            bool flag = NewSemester.AddSemester(term, year);

            if (flag)
            {
                MessageBox.Show("Semester added successfully!");
                comboBox1.SelectedIndex = 0;
                textBox2.Text = string.Empty;
                LoadSemesters();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Update Semester
        {
            bool flag = NewSemester.UpdateSemester(semesterID, term, year);

            if (flag)
            {
                MessageBox.Show("Semester updated successfully!");
                comboBox1.SelectedIndex = 0;
                textBox2.Text = string.Empty;
                LoadSemesters(); // Reload data into the DataGridView
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button4_Click(object sender, EventArgs e) // Delete Semester
        {
            bool flag = NewSemester.DeleteSemester(semesterID);

            if (flag)
            {
                MessageBox.Show("Semester deleted successfully!");
                comboBox1.SelectedIndex = 0;
                textBox2.Text = string.Empty;
                LoadSemesters(); // Reload data into the DataGridView
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the clicked row index is valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                semesterID = Convert.ToInt32(row.Cells["semester_id"].Value);

                comboBox1.Text = row.Cells["term"].Value.ToString();
                textBox2.Text = row.Cells["year"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
