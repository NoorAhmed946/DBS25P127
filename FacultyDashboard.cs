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
    public partial class FacultyDashboard : Form
    {
        private int FacId;
        public FacultyDashboard(int facultyID)
        {
            InitializeComponent();
            FacId = facultyID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FacultyDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resource_Request Request = new Resource_Request(FacId);
            Request.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewCourses viewCourses = new ViewCourses(FacId);
            viewCourses.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
