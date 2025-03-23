namespace DBS25P127
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            var loginResult = loginC.ValidateLogin(username, password);

            if (loginResult.isValid)
            {
                int userId = loginResult.userId;
                int roleId = loginResult.roleId;

                switch (roleId)
                {
                    case 1: // Admin
                        MessageBox.Show("Welcome Admin!");
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                        break;

                    case 3: // Department Head
                        MessageBox.Show("Welcome Department Head!");
                        DepartmentHeadDashboard departmentHeadDashboard = new DepartmentHeadDashboard();
                        departmentHeadDashboard.Show();
                        this.Hide();
                        break;

                    case 2: // Faculty
                        int facultyId = loginC.GetFacultyIdByUserId(userId);
                        if (facultyId != -1)
                        {
                            MessageBox.Show($"Welcome Faculty! Faculty ID: {facultyId}");
                            FacultyDashboard facultyDashboard = new FacultyDashboard(facultyId);
                            facultyDashboard.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Faculty record not found.");
                        }
                        break;

                    default:
                        MessageBox.Show("Unknown role.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signin form2 = new Signin();
            form2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
