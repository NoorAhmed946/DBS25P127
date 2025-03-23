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
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P127
{
    public partial class FacultyAdminRoles : Form
    {
        private int selectedRowId;
        public FacultyAdminRoles()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            this.Load += FacultyAdminRoles_Load;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FacultyAdminRoles_Load(object sender, EventArgs e) // page function 
        {
            LoadComboBoxes();
            LoadFacultyAdminRoles();
        }

        private void LoadComboBoxes()
        {
            using (MySqlConnection con = DatabaseHelper.Instance.getConnection())
            {

                // Load Faculty
                MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT faculty_id, name FROM faculty", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "faculty_id";
                comboBox1.SelectedIndex = -1;

                // Load Semesters
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
                comboBox2.SelectedIndex = -1;

            }
        }

        // LOAD DATA FOR GRID  

        private void LoadFacultyAdminRoles()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = @"
        SELECT 
            admin_role_id,
            faculty_id,
            role_name,
            semester_id
        FROM 
            faculty_admin_roles";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Hide internal ID column
                dataGridView1.Columns["admin_role_id"].Visible = false;
            }
        }

        // DATAGRID CLICK FUNCTION

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedRowId = Convert.ToInt32(row.Cells["admin_role_id"].Value);

                // Set values in controls
                comboBox1.SelectedValue = row.Cells["faculty_id"].Value;   // Faculty
                comboBox3.Text = row.Cells["role_name"].Value.ToString();   // Role Name (assume textBox1)
                comboBox2.SelectedValue = row.Cells["semester_id"].Value;  // Semester
            }
        }
        // ASSIGN 

        private void button1_Click(object sender, EventArgs e) // ASSIGN
        {
            int facultyId = Convert.ToInt32(comboBox1.SelectedValue);
            int semesterId = Convert.ToInt32(comboBox2.SelectedValue);
            string roleName = comboBox3.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Please enter a role name.");
                return;
            }

            bool isAssigned = NewFaculty.AddAdminRole(facultyId, roleName, semesterId);

            if (isAssigned)
            {
                MessageBox.Show("Role assigned successfully!");
                LoadFacultyAdminRoles();
            }
            else
            {
                MessageBox.Show("Error occurred while assigning role.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentHeadDashboard dp = new DepartmentHeadDashboard();
            dp.Show();
            this.Hide();
        }

        // UPDATE fUNCTION 

        //private void button2_Click(object sender, EventArgs e) // UPDATE
        //{
        //    if (selectedRowId == -1)
        //    {
        //        MessageBox.Show("Please select a record to update.");
        //        return;
        //    }

        //    int facultyId = Convert.ToInt32(comboBox1.SelectedValue);
        //    int semesterId = Convert.ToInt32(comboBox2.SelectedValue);
        //    string roleName = comboBox3.Text.Trim();

        //    if (string.IsNullOrEmpty(roleName))
        //    {
        //        MessageBox.Show("Please enter a role name.");
        //        return;
        //    }

        //    bool isUpdated = FacultyAdminRoles.UpdateAdminRole(selectedRowId, facultyId, roleName, semesterId);

        //    if (isUpdated)
        //    {
        //        MessageBox.Show("Role updated successfully!");
        //        LoadFacultyAdminRoles();
        //        selectedRowId = -1;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error occurred while updating.");
        //    }
        //}

        // DELETE FUNCTION 

        //private void button3_Click(object sender, EventArgs e) // DELETE
        //{
        //    if (selectedRowId == -1)
        //    {
        //        MessageBox.Show("Please select a record to delete.");
        //        return;
        //    }

        //    DialogResult result = MessageBox.Show("Are you sure you want to delete this role?", "Confirm", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes)
        //    {
        //        bool isDeleted = FacultyAdminRoles.DeleteAdminRole(selectedRowId);

        //        if (isDeleted)
        //        {
        //            MessageBox.Show("Role deleted successfully!");
        //            LoadFacultyAdminRoles();
        //            selectedRowId = -1;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error occurred while deleting.");
        //        }
        //    }
        //}


    }
}
