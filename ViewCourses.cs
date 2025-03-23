using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P127
{
    public partial class ViewCourses : Form
    {
        private int FacID;
        public ViewCourses(int FacultyID)
        {
            InitializeComponent();
            FacID = FacultyID;
        }

        private void ViewCourses_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RequestF.GetFacultyCourses(FacID);

            // UI formatting should stay here
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["faculty_course_id"].HeaderText = "ID";
                dataGridView1.Columns["faculty_name"].HeaderText = "Faculty";
                dataGridView1.Columns["course_name"].HeaderText = "Course";
                dataGridView1.Columns["semester_name"].HeaderText = "Semester";

                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
