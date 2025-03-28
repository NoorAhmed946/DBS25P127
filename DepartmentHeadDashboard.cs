﻿using System;
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
    public partial class DepartmentHeadDashboard : Form
    {
        public DepartmentHeadDashboard()
        {
            InitializeComponent();
        }

        private void DepartmentHeadDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseAssignment courseAssignment = new CourseAssignment();
            this.Hide();
            courseAssignment.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FacultySchedule facultySchedule = new FacultySchedule();
            facultySchedule.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FacultyAdminRoles role = new FacultyAdminRoles();
            role.Show();
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
