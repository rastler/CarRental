using System;
using System.Windows.Forms;

namespace CarRental1
{
    public partial class MainForm : Form
    {
        private string userRole;
        private string userId;

        public MainForm(string role = "User", string id = "")
        {
            InitializeComponent();
            userRole = role;
            userId = id;
            SetUpForm();
        }


        private void SetUpForm()
        {
            if (userRole != "Admin")
            {
                button5.Visible = false; // или button5.Enabled = false; если хотите просто отключить кнопку
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car car = new Car(userRole, userId);
            car.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer(userRole == "Admin", userId); // Передача userId
            customer.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental rent = new Rental(userRole, userId);
            rent.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users user = new Users(userId, userRole);
            user.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
