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
    public partial class Cosumables : Form
    {
        public static string itemName;
        private int consumableID = -1;

        public Cosumables()
        {
            InitializeComponent();
            this.Load += Cosumables_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Cosumables_Load(object sender, EventArgs e)
        {
            LoadConsumables();
        }

        // Input Event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            itemName = textBox1.Text;
        }

        // Load Data into Grid
        private void LoadConsumables()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = "SELECT consumable_id, item_name FROM consumables";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["consumable_id"].Visible = false;
            }
        }

        // Add Consumable


        // Select Consumable from Grid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                consumableID = Convert.ToInt32(row.Cells["consumable_id"].Value);
                textBox1.Text = row.Cells["item_name"].Value.ToString();
            }
        }

        private void ResetForm()
        {
            textBox1.Text = string.Empty;
            consumableID = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = NewConsumables.AddConsumable(itemName);

            if (flag)
            {
                MessageBox.Show("Consumable added successfully!");
                ResetForm();
                LoadConsumables();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool flag = NewConsumables.UpdateConsumable(consumableID, itemName);

            if (flag)
            {
                MessageBox.Show("Consumable updated successfully!");
                ResetForm();
                LoadConsumables();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool flag = NewConsumables.DeleteConsumable(consumableID);

            if (flag)
            {
                MessageBox.Show("Consumable deleted successfully!");
                ResetForm();
                LoadConsumables();
            }
            else
            {
                MessageBox.Show("There is an error. Please try again.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();    
        }
    }
}
