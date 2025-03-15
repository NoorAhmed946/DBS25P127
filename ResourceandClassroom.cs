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
    public partial class ResourceandClassroom : Form
    {
        public ResourceandClassroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomAllocation room = new RoomAllocation();
            room.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resource_Request resReq = new Resource_Request();
            resReq.Show();
            this.Hide();
        }
    }
}
