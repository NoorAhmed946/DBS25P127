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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P127
{
    public partial class Signin : Form
    {
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
        public Signin()
        {
            InitializeComponent();
            this.loadRoles();
            this.Load += new System.EventHandler(this.Signin_Load);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // CREATE ACCOUNT 
        {
            if (textBox4.Text != textBox1.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }

            // Check if role and email are selected
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role and an email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract data
            string username = textBox2.Text.Trim();
            string email = comboBox2.SelectedValue?.ToString();
            string password = textBox4.Text.Trim();
            int roleId = Convert.ToInt32(comboBox1.SelectedValue);

            // Call the CreateUser method from UserService
            bool isCreated = Signup.CreateUserAccount(username, email, password, roleId);

            if (isCreated)
            {
                MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                clearForm(); // Clear the form fields after successful creation

            }
            else
            {
                MessageBox.Show("Error Creating Account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            string msg = "If your email is not showing here Then you can't make Account.Contact Admin. ";
            toolTip.SetToolTip(comboBox2, msg);
        }

        // load roles in comboBoxes 
        private void loadRoles()
        {
            using (MySqlConnection con = DatabaseHelper.Instance.getConnection())
            {
                string query = "SELECT lookup_id, value FROM lookup WHERE category = 'UserRoles'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "value";
                comboBox1.ValueMember = "lookup_id";
                comboBox1.SelectedIndex = -1;

                string query2 = "SELECT email FROM faculty";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, con);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);

                comboBox2.DataSource = dt2;
                comboBox2.DisplayMember = "email";
                comboBox2.ValueMember = "email";
                comboBox2.SelectedIndex = -1;
            }
        }

        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
           
            string msg = "If your email is not showing here Then you can't make Account. Contact Admin.";
            toolTip.SetToolTip(comboBox2, msg);
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string enteredUsername = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(enteredUsername))
            {
                textBox2.BackColor = Color.White;
                return;
            }

            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", enteredUsername);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Username exists
                        textBox2.BackColor = Color.MistyRose;
                        toolTip1.SetToolTip(textBox2, "Username already exists!");
                    }
                    else
                    {
                        textBox2.BackColor = Color.White;
                        toolTip1.SetToolTip(textBox2, "");
                    }
                }
            }
        }

        // CREATE ACCOUNT 
      

        private void clearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void LoadData()
        {
            DataTable dt = Signup.LoadUnregisteredFacultyEmails();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "email";
            comboBox2.ValueMember = "email";
            comboBox2.SelectedIndex = -1;
        }

    }
}
