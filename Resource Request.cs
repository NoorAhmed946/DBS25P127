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
    public partial class Resource_Request : Form
    {
        public int quantity;
        public string desc;
        public Resource_Request()
        {
            InitializeComponent();
        }

        private void Resource_Request_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // LOAD DATA IN COMBO BOXES 

        private void LoadData()
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                // Consumables data 
                string query = @"SELECT item_name , consumable_id from consumables";
                MySqlDataAdapter item = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                item.Fill(dataTable);

                comboBox2.DataSource = dataTable;
                comboBox2.DisplayMember = "item_nmae";
                comboBox2.ValueMember = "consumable_id";
                comboBox2.SelectedIndex = -1;


            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)numericUpDown1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            desc = textBox1.Text;
        }


    }
}
