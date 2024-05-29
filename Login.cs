using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rastl\OneDrive\Документы\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void Login_Load(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void metroButton1_Click(object sender, EventArgs e) { }

        private void metroTextBox1_Click(object sender, EventArgs e) { }

        private void metroTextBox2_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Id FROM UserTbl WHERE Uname = @Uname AND Upass = @Upass";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@Uname", Uname.Text);
            cmd.Parameters.AddWithValue("@Upass", PassTb.Text);

            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int userId = Convert.ToInt32(reader["Id"]);
                reader.Close();

                string role = userId == 1 ? "Admin" : "User";

                MainForm mainForm = new MainForm(role, userId.ToString());
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный Логин или Пароль");
            }
            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            PassTb.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
