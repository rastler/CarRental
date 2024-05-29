using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental1
{
    public partial class Users : Form
    {
        private string currentUserId;
        private string userRole;

        public Users(string userId, string userRole)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.userRole = userRole;

            // Если текущий пользователь администратор, то блокируем поле для изменения ID
            if (userRole == "Admin")
            {
                Uid.Enabled = false;
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rastl\OneDrive\Документы\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM UserTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO UserTbl VALUES(@Uid, @Uname, @Upass)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Uid", Uid.Text);
                    cmd.Parameters.AddWithValue("@Uname", Uname.Text);
                    cmd.Parameters.AddWithValue("@Upass", Upass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Користувача успішно додано");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                    Con.Close();
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else
            {
                // Проверяем, является ли текущий пользователь администратором и не пытается ли он удалить свою собственную учетную запись
                if (userRole == "Admin" && currentUserId != Uid.Text)
                {
                    try
                    {
                        Con.Open();
                        string query = "DELETE FROM UserTbl WHERE Id=@Uid";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Uid", Uid.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Користувача успішно видалено");
                        Con.Close();
                        populate();
                    }
                    catch (Exception Myex)
                    {
                        MessageBox.Show(Myex.Message);
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ви не маєте прав для видалення цієї учетной записи");
                }
            }
        }


        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uid.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            Uname.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            Upass.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE UserTbl SET Uname=@Uname, Upass=@Upass WHERE Id=@Uid";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Uid", Uid.Text);
                    cmd.Parameters.AddWithValue("@Uname", Uname.Text);
                    cmd.Parameters.AddWithValue("@Upass", Upass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Користувача успішно оновлено");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                    Con.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(userRole, currentUserId);
            main.Show();
        }
    }
}
