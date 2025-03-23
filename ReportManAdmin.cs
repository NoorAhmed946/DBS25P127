using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P127
{
    public partial class ReportManAdmin : Form
    {
        public ReportManAdmin()
        {
            LoadRequests();
            InitializeComponent();
            this.Load += ReportManAdmin_Load;
        }

        private void ReportManAdmin_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = RequestF.GetAdminOp();
            comboBox1.DisplayMember = "value";
            comboBox1.ValueMember = "lookup_id";
            comboBox1.SelectedIndex = -1;
        }

        private void LoadRequests()
        {
            dataGridView1.DataSource = RequestF.GetAllFacultyRequests();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["request_id"].HeaderText = "Request ID";
                dataGridView1.Columns["faculty_name"].HeaderText = "Faculty";
                dataGridView1.Columns["item_name"].HeaderText = "Item";
                dataGridView1.Columns["quantity"].HeaderText = "Quantity";
                dataGridView1.Columns["status"].HeaderText = "Status";
                dataGridView1.Columns["request_date"].HeaderText = "Date";

                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int requestId) && comboBox1.SelectedValue != null)
            {
                int selectedStatusId = Convert.ToInt32(comboBox1.SelectedValue);

                int rowsAffected = RequestF.UpdateRequestStatus(requestId, selectedStatusId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Request status updated successfully!");
                }
                else
                {
                    MessageBox.Show("No update made. Please check the Request ID.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request and a status.");
            }
        }
    }
}
