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
    public partial class Faculty : Form
    {
        public string name;
        public string email;
        public string contact;
        public string researchArea;
        public int teachingHours;
        public string designation;
        public int selectedFacultyId;

        public Faculty()
        {
            InitializeComponent();
            this.Load += Faculty_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            LoadFaculty();
            loadDesignation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            email = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            researchArea = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            teachingHours = Convert.ToInt32(textBox4.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            designation = comboBox1.Text;
        }

        private void LoadFaculty() // load data in the faculty datagrid
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = @"
                SELECT 
            faculty_id,
            name,
            email,
            contact,
            designation_id,  -- Show the ID instead of designation name
            research_area,
            total_teaching_hours,
            user_id
        FROM faculty  ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Hide internal ID columns
                dataGridView1.Columns["faculty_id"].Visible = false;
                dataGridView1.Columns["user_id"].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the clicked row index is valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Capture selected faculty_id if needed
                selectedFacultyId = Convert.ToInt32(row.Cells["faculty_id"].Value);

                // Populate fields from DataGridView

                textBox1.Text = row.Cells["name"].Value?.ToString() ?? "";
                textBox2.Text = row.Cells["email"].Value?.ToString() ?? "";
                textBox3.Text = row.Cells["research_area"].Value?.ToString() ?? "";
                if (row.Cells["total_teaching_hours"].Value != DBNull.Value)
                {
                    teachingHours = Convert.ToInt32(row.Cells["total_teaching_hours"].Value);
                    textBox4.Text = teachingHours.ToString();
                }
                else
                {
                    teachingHours = 0;
                    textBox4.Text = "0";
                }
                textBox5.Text = row.Cells["contact"].Value != DBNull.Value
                                ? row.Cells["contact"].Value.ToString() : "";

                if (row.Cells["designation_id"].Value != DBNull.Value)
                {
                    comboBox1.SelectedValue = Convert.ToInt32(row.Cells["designation_id"].Value);
                }
                else
                {
                    comboBox1.SelectedIndex = -1;
                }
            }
        }

        // LOAD COMBO BOX FOR DESIGNATIONS 
        private  void loadDesignation()
        {
            
                using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
                {
                    string query = "SELECT lookup_id, value FROM lookup WHERE category = 'Designations'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "value";      // what user sees
                    comboBox1.ValueMember = "lookup_id";    // the actual ID you work with
                    comboBox1.SelectedIndex = -1;
                }

            
        }

        private void button9_Click(object sender, EventArgs e) // Save Faculty
        {
            bool flag = NewFaculty.AddFaculty(name, email,contact , researchArea, teachingHours, designation);

            if (flag)
            {
                MessageBox.Show("Faculty added successfully!");
                ResetForm();
                LoadFaculty();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void ResetForm() // Reset Form values
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            selectedFacultyId = -1;
        }

        private void button8_Click(object sender, EventArgs e) // Update Function 
        {
            bool flag = NewFaculty.UpdateFaculty(selectedFacultyId, name, email,contact, researchArea, teachingHours, designation);

            if (flag)
            {
                MessageBox.Show("Faculty updated successfully!");
                ResetForm();
                LoadFaculty();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button10_Click(object sender, EventArgs e) // Delete 
        {
            bool flag = NewFaculty.DeleteFaculty(selectedFacultyId);

            if (flag)
            {
                MessageBox.Show("Faculty deleted successfully!");
                ResetForm();
                LoadFaculty();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button7_Click(object sender, EventArgs e) // Clear 
        {

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            selectedFacultyId = -1;
        }

        private void button12_Click(object sender, EventArgs e) // back
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            contact = textBox5.Text;
        }
    }
}
