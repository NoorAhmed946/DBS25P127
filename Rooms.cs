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
    public partial class Rooms : Form
    {
        public static string roomName;
        public static string roomType;
        public static int capacity;
        private int roomID = -1;

        public Rooms()
        {
            InitializeComponent();
            this.Load += Rooms_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        // Input Events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            roomName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            roomType = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int value))
            {
                capacity = value;
            }
            else
            {
                capacity = 0;
            }
        }

        // Load Data into Grid
        private void LoadRooms()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = "SELECT room_id, room_name, room_type, capacity FROM rooms";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["room_id"].Visible = false;
            }
        }

        // Add Room
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = NewRoom.AddRoom(roomName, roomType, capacity);

            if (flag)
            {
                MessageBox.Show("Room added successfully!");
                ResetForm();
                LoadRooms();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        // Update Room
        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = NewRoom.UpdateRoom(roomID, roomName, roomType, capacity);

            if (flag)
            {
                MessageBox.Show("Room updated successfully!");
                ResetForm();
                LoadRooms();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        // Delete Room
        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = NewRoom.DeleteRoom(roomID);

            if (flag)
            {
                MessageBox.Show("Room deleted successfully!");
                ResetForm();
                LoadRooms();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        // Select Room from Grid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                roomID = Convert.ToInt32(row.Cells["room_id"].Value);
                textBox1.Text = row.Cells["room_name"].Value.ToString();
                textBox2.Text = row.Cells["room_type"].Value.ToString();
                textBox3.Text = row.Cells["capacity"].Value.ToString();
            }
        }

        private void ResetForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            roomID = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
