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
    public partial class CourseMain : Form
    {
        public CourseMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseMan courseMan = new CourseMan();
            courseMan.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseAssignment courseAssignment = new CourseAssignment();
            courseAssignment.Show();
            this.Hide();
        }
    }
}
