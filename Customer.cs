using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarRental1
{
    public partial class Customer : Form
    {
        private bool isAdmin;
        private string userId;

        public Customer(bool isAdmin, string userId)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.userId = userId;
            button2.Visible = isAdmin;
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rastl\OneDrive\Документы\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            CustomerDGV.Columns[0].HeaderText = "Номер паспорта";
            CustomerDGV.Columns[1].HeaderText = "ПІБ";
            CustomerDGV.Columns[2].HeaderText = "Адреса";
            CustomerDGV.Columns[3].HeaderText = "Телефон";

            CustomerDGV.Sort(CustomerDGV.Columns[0], ListSortDirection.Ascending);
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(isAdmin ? "Admin" : "User", userId); // Передача текущих значений userRole и userId
            main.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (PassNumbTb.Text == "" || NameTb.Text == "" || AddressTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else if (!IsValidPhoneNumber(PhoneTb.Text))
            {
                MessageBox.Show("Некоректний номер телефону. Будь ласка, введіть правильний номер.");
            }
            else if (!IsValidFullName(NameTb.Text))
            {
                MessageBox.Show("Некоректне Прізвище Ім'я По батькові. Будь ласка, введіть Прізвище Ім'я По батькові.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CustomerTbl values(@PassNumbTb, @NameTb, @AddressTb, @PhoneTb)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PassNumbTb", PassNumbTb.Text);
                    cmd.Parameters.AddWithValue("@NameTb", NameTb.Text);
                    cmd.Parameters.AddWithValue("@AddressTb", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@PhoneTb", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Клієнта успішно додано");
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (PassNumbTb.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTbl where PassNumb = @PassNumbTb";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PassNumbTb", PassNumbTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Клієнта видалено успішно");
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

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PassNumbTb.Text = CustomerDGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            AddressTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PassNumbTb.Text == "" || NameTb.Text == "" || AddressTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else if (!IsValidPhoneNumber(PhoneTb.Text))
            {
                MessageBox.Show("Некоректний номер телефону. Будь ласка, введіть правильний номер.");
            }
            else if (!IsValidFullName(NameTb.Text))
            {
                MessageBox.Show("Некоректне Прізвище Ім'я По батькові. Будь ласка, введіть Прізвище Ім'я По батькові.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CustomerTbl set CustName = @NameTb, CustAdd = @AddressTb, Phone = @PhoneTb where PassNumb = @PassNumbTb";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PassNumbTb", PassNumbTb.Text);
                    cmd.Parameters.AddWithValue("@NameTb", NameTb.Text);
                    cmd.Parameters.AddWithValue("@AddressTb", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@PhoneTb", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Дані оновлено успішно");
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

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Удаляем все символы, кроме цифр
            string digitsOnly = new string(phoneNumber.Where(char.IsDigit).ToArray());

            // Проверяем, что длина номера телефона соответствует ожидаемой длине
            if (digitsOnly.Length != 12)
            {
                return false;
            }

            // Проверяем, что номер начинается с "+"
            if (phoneNumber[0] != '+')
            {
                return false;
            }

            // Проверяем, что номер начинается с "+", а затем идут 12 цифр (включая код страны)
            foreach (char c in digitsOnly)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // Если прошли все проверки, возвращаем true
            return true;
        }

        private bool IsValidFullName(string fullName)
        {
            var parts = fullName.Split(' ');
            return parts.Length == 3 && parts.All(p => p.Length > 0 && char.IsUpper(p[0]));
        }

        private void label6_Click(object sender, EventArgs e) { }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SearchFullNameTb.Text == "")
            {
                MessageBox.Show("Будь ласка, введіть ПІБ для пошуку");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "select * from CustomerTbl where CustName LIKE @SearchFullNameTb";
                    SqlDataAdapter da = new SqlDataAdapter(query, Con);
                    da.SelectCommand.Parameters.AddWithValue("@SearchFullNameTb", "%" + SearchFullNameTb.Text + "%");
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Нічого не знайдено");
                    }
                    else
                    {
                        CustomerDGV.DataSource = ds.Tables[0];
                    }
                    Con.Close();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                    Con.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PassNumbTb.Text = "";
            NameTb.Text = "";
            AddressTb.Text = "";
            PhoneTb.Text = "";

            populate();
        }

    }
}
