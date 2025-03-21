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
    public partial class RoomAllocation : Form
    {   
        public int hours;
        public int selectedRowId;
        public RoomAllocation()
        {
            InitializeComponent();
            LoadComboBox();
            dataGridView1.CellClick += dataGridView1_CellClick;
            this.Load += RoomAllocation_Load;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RoomAllocation_Load(object sender, EventArgs e)
        {
            LoadFacultyRoomAllocation();
        }

        // load combo Boxes
        private void LoadComboBox()
        {
            using (MySqlConnection con = DatabaseHelper.Instance.getConnection())
            {
                // ROOM COMBOBOX FILL 
                MySqlDataAdapter data = new MySqlDataAdapter("Select room_name, room_id From rooms", con);
                DataTable dt = new DataTable();
                data.Fill(dt);
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "room_name";
                comboBox4.ValueMember = "room_id";
                comboBox4.SelectedIndex = -1;

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
                comboBox3.DataSource = dt3;
                comboBox3.DisplayMember = "semester";
                comboBox3.ValueMember = "semester_id";
                comboBox3.SelectedIndex = -1;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            hours = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e) // ASSIGN 
        {
            int facultyId = Convert.ToInt32(comboBox1.SelectedValue);
            int roomId = Convert.ToInt32(comboBox4.SelectedValue);
            int semesterId = Convert.ToInt32(comboBox3.SelectedValue);

            bool isAssign = NewRoom.AddFacultyRoomAllocation(facultyId, roomId,hours,semesterId);

            if (isAssign)
            {
                MessageBox.Show("Assigned successfully!");
                LoadFacultyRoomAllocation();
            }
            else
                MessageBox.Show("Error occurred.");

        }

        // load data for datagrid 

        private void LoadFacultyRoomAllocation()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = @"
        SELECT 
            allocation_id,
            faculty_id,
            room_id,
            reserved_hours,
            semester_id
        FROM 
            faculty_room_allocations";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Hide internal ID column
                dataGridView1.Columns["allocation_id"].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedRowId = Convert.ToInt32(row.Cells["allocation_id"].Value);

                // Set values in controls (adjust names if needed)
                comboBox1.SelectedValue = row.Cells["faculty_id"].Value;
                comboBox4.SelectedValue = row.Cells["room_id"].Value;
                numericUpDown1.Value = (int)row.Cells["reserved_hours"].Value;
                comboBox3.SelectedValue = row.Cells["semester_id"].Value;
            }
        }
    }
}
