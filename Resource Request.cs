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
        private int FacId;
        private int ConsumableID;
        private int selectedId;

        public Resource_Request(int FacultyId)
        {
            InitializeComponent();
            FacId = FacultyId;
            LoadData();
            this.Load += Resource_Request_Load;
        }

        private void Resource_Request_Load(object sender, EventArgs e)
        {
            LoadFacultyRequests();
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
                comboBox2.DisplayMember = "item_name";
                comboBox2.ValueMember = "consumable_id";
                comboBox2.SelectedIndex = -1;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)numericUpDown1.Value;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt32(comboBox2.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isSubmitted = RequestF.SubmitRequest(FacId, selectedId, quantity);

            if (isSubmitted)
            {
                MessageBox.Show("Your Request have been Submitted");
            }
            else
            {
                MessageBox.Show("Your Request have not been Submitted . PLease Try Again.") ;
            }
        }

        private void clear()
        {
            comboBox2.SelectedIndex = -1;
            numericUpDown1.Value = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear(); 
        }

        private void LoadFacultyRequests()
        {
            DataTable table = RequestF.GetFacultyRequests(FacId);
            dataGridView1.DataSource = table;
        }
    }
}
