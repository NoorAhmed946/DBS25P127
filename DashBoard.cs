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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            faculty.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseMain courseMain = new CourseMain();
            courseMain.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FacultyReqMan facultyReqMan = new FacultyReqMan();
            facultyReqMan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResourceandClassroom resourceandClassroom = new ResourceandClassroom();
            resourceandClassroom.Show();
            this.Hide();
        }
    }
}
