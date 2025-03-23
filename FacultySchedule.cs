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
    public partial class FacultySchedule : Form
    {
        public string dayOfWeek;
        public TimeSpan time1;
        public TimeSpan time2;
        public int selectedRowId;
        public FacultySchedule()
        {
            InitializeComponent();
            this.Load += FacultySchedule_Load; // safer load
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void FacultySchedule_Load(object sender, EventArgs e)
        {
            loadComboBox();
            LoadFacultySchedule();
        }

        private void loadComboBox()
        {
            using (MySqlConnection con = DatabaseHelper.Instance.getConnection())
            {
                //  ROOMS COMBOBOX FILL
                MySqlDataAdapter data = new MySqlDataAdapter("Select room_name, room_id From rooms", con);
                DataTable dt = new DataTable();
                data.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "room_name";
                comboBox1.ValueMember = "room_id";
                comboBox1.SelectedIndex = -1;

                // Course + Faculty 
                string query = @"SELECT M.faculty_course_id, 
                        f.name AS faculty_name, 
                        c.course_name 
                 FROM faculty_courses M 
                 JOIN faculty f ON M.faculty_id = f.faculty_id 
                 JOIN courses c ON M.course_id = c.course_id";

                MySqlDataAdapter data2 = new MySqlDataAdapter(query, con);
                DataTable dt2 = new DataTable();
                data2.Fill(dt2);

                // Add combined column for display
                dt2.Columns.Add("faculty", typeof(string));
                foreach (DataRow row in dt2.Rows)
                {
                    row["faculty"] = row["faculty_name"] + " - " + row["course_name"];
                }

                comboBox2.DataSource = dt2;
                comboBox2.DisplayMember = "faculty";
                comboBox2.ValueMember = "faculty_course_id";
                comboBox2.SelectedIndex = -1;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayOfWeek = comboBox3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            time1 = dateTimePicker1.Value.TimeOfDay;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            time2 = dateTimePicker2.Value.TimeOfDay;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedRowId = Convert.ToInt32(row.Cells["schedule_id"].Value);

                // Set combo boxes and time pickers
                comboBox2.SelectedValue = row.Cells["faculty_course_id"].Value;
                comboBox1.SelectedValue = row.Cells["room_id"].Value;
                comboBox3.SelectedItem = row.Cells["day_of_week"].Value.ToString();

                // Set time pickers
                dateTimePicker1.Value = DateTime.Today + (TimeSpan)row.Cells["start_time"].Value;
                dateTimePicker2.Value = DateTime.Today + (TimeSpan)row.Cells["end_time"].Value;
            }
        }
        private void LoadFacultySchedule()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = @"
            SELECT 
                schedule_id,
                faculty_course_id,
                room_id,
                day_of_week,
                start_time,
                end_time
            FROM 
                faculty_course_schedule";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Hide internal ID column
                dataGridView1.Columns["schedule_id"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) // Add button 
        {
            int facultyCourseId = Convert.ToInt32(comboBox2.SelectedValue);
            int facultyId = NewFaculty.GetFacultyIdFromFacultyCourseId(facultyCourseId);
            int roomId = Convert.ToInt32(comboBox1.SelectedValue);
            string dayOfWeek = comboBox3.SelectedItem.ToString();
            TimeSpan startTime = time1;
            TimeSpan endTime = time2;


            bool isOverLapping = NewFaculty.IsScheduleOverlapping(facultyId, dayOfWeek, startTime, endTime);

            if (isOverLapping)
            {
                MessageBox.Show("Schedule overlaps with another class for this faculty!", "Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool added = NewFaculty.AddFacultySchedule(facultyCourseId, roomId, dayOfWeek, startTime, endTime);
                if (added)
                    MessageBox.Show("Schedule added successfully!");
                else
                    MessageBox.Show("Failed to add schedule.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentHeadDashboard dp = new DepartmentHeadDashboard();
            dp.Show();
            this.Hide();
        }
    }
}
