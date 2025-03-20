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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseMan newCourse = new CourseMan();
            this.Hide();
            newCourse.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Semesters semesters = new Semesters();
            this.Hide();
            semesters.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            this.Hide();
            rooms.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cosumables consumbale = new Cosumables();
            this.Hide();
            consumbale.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects();
            projects.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            this.Hide();
            faculty.Show();
        }
    }
}
