using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental1
{
    public partial class Car : Form
    {
        private string userRole;
        private string userId;
        public Car(string userRole, string userId)
        {
            InitializeComponent();
            this.userRole = userRole;
            this.userId = userId;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rastl\OneDrive\Документы\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "SELECT c.RegNum, c.Brand, c.Model, c.Color, b.TypeBody, c.Issue, c.Available, c.Price " +
                           "FROM CarTbl c " +
                           "INNER JOIN BodyTbl b ON c.Body = b.BodyId";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];
            CarsDGV.Columns[0].HeaderText = "НомерАвто";
            CarsDGV.Columns[0].Width = 70;
            CarsDGV.Columns[1].HeaderText = "Бренд";
            CarsDGV.Columns[1].Width = 80;
            CarsDGV.Columns[2].HeaderText = "Модель";
            CarsDGV.Columns[2].Width = 80;
            CarsDGV.Columns[3].HeaderText = "Колір";
            CarsDGV.Columns[3].Width = 77;
            CarsDGV.Columns[4].HeaderText = "Тип кузова";
            CarsDGV.Columns[4].Width = 130;
            CarsDGV.Columns[5].HeaderText = "Рік Випуску";
            CarsDGV.Columns[5].Width = 80;
            CarsDGV.Columns[6].HeaderText = "Доступний";
            CarsDGV.Columns[6].Width = 80;
            CarsDGV.Columns[7].HeaderText = "Ціна(грн)";
            CarsDGV.Columns[7].Width = 50;
            CarsDGV.Sort(CarsDGV.Columns[0], ListSortDirection.Ascending);

            // Установка стиля отображения значения для столбца "Доступний"
            CarsDGV.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == 6 && e.Value != null)
                {
                    string value = e.Value.ToString();
                    if (value == "1")
                        e.Value = "так";
                    else if (value == "0")
                        e.Value = "ні";
                }
            };

            Con.Close();
        }
        private void LoadBodyTypes()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM BodyTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("BodyId");
                dt.Columns.Add("TypeBody");
                dt.Load(rdr);
                BodyCb.ValueMember = "BodyId";
                BodyCb.DisplayMember = "TypeBody";
                BodyCb.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "SELECT c.RegNum, c.Brand, c.Model, c.Color, b.TypeBody, c.Issue, c.Available, c.Price " +
                               "FROM CarTbl c " +
                               "INNER JOIN BodyTbl b ON c.Body = b.BodyId " +
                               "WHERE " +
                               "(c.RegNum LIKE @RegNumTb OR @RegNumTb IS NULL) AND " +
                               "(c.Brand LIKE @BrandTb OR @BrandTb IS NULL) AND " +
                               "(c.Model LIKE @ModelTb OR @ModelTb IS NULL) AND " +
                               "(c.Color LIKE @ColorTb OR @ColorTb IS NULL) AND " +
                               "(c.Body = @BodyId OR @BodyId IS NULL) AND " +
                               "(c.Issue LIKE @IssueTb OR @IssueTb IS NULL) AND " +
                               "(c.Available = @AvailableCb OR @AvailableCb IS NULL) AND " +
                               "(c.Price LIKE @PriceTb OR @PriceTb IS NULL)";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@RegNumTb", string.IsNullOrEmpty(RegNumTb.Text) ? DBNull.Value : (object)("%" + RegNumTb.Text + "%"));
                cmd.Parameters.AddWithValue("@BrandTb", string.IsNullOrEmpty(BrandTb.Text) ? DBNull.Value : (object)("%" + BrandTb.Text + "%"));
                cmd.Parameters.AddWithValue("@ModelTb", string.IsNullOrEmpty(ModelTb.Text) ? DBNull.Value : (object)("%" + ModelTb.Text + "%"));
                cmd.Parameters.AddWithValue("@ColorTb", string.IsNullOrEmpty(ColorTb.Text) ? DBNull.Value : (object)("%" + ColorTb.Text + "%"));
                cmd.Parameters.AddWithValue("@BodyId", BodyCb.SelectedItem == null ? DBNull.Value : (object)BodyCb.SelectedValue);
                cmd.Parameters.AddWithValue("@IssueTb", string.IsNullOrEmpty(IssueTb.Text) ? DBNull.Value : (object)("%" + IssueTb.Text + "%"));
                cmd.Parameters.AddWithValue("@AvailableCb", AvailableCb.SelectedIndex == -1 ? DBNull.Value : (object)(AvailableCb.SelectedIndex == 0 ? 1 : 0));
                cmd.Parameters.AddWithValue("@PriceTb", string.IsNullOrEmpty(PriceTb.Text) ? DBNull.Value : (object)("%" + PriceTb.Text + "%"));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Нічого не знайдено");
                }
                else
                {
                    CarsDGV.DataSource = ds.Tables[0];
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || ColorTb.Text == "" || IssueTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO CarTbl VALUES (@RegNumTb, @BrandTb, @ModelTb, @ColorTb, @BodyId, @IssueTb, @AvailableCb, @PriceTb)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RegNumTb", RegNumTb.Text);
                    cmd.Parameters.AddWithValue("@BrandTb", BrandTb.Text);
                    cmd.Parameters.AddWithValue("@ModelTb", ModelTb.Text);
                    cmd.Parameters.AddWithValue("@ColorTb", ColorTb.Text);
                    cmd.Parameters.AddWithValue("@BodyId", BodyCb.SelectedValue); // Получаем значение BodyId из выбранного элемента
                    cmd.Parameters.AddWithValue("@IssueTb", IssueTb.Text);
                    cmd.Parameters.AddWithValue("@AvailableCb", AvailableCb.SelectedIndex == 0 ? 1 : 0);
                    cmd.Parameters.AddWithValue("@PriceTb", PriceTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Автомобіль успішно додано");
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


        private void Car_Load(object sender, EventArgs e)
        {
            populate();
            LoadBodyTypes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CarTbl where RegNum = @RegNum";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RegNum", RegNumTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Автомобіль видалено успішно");
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

        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegNumTb.Text = CarsDGV.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = CarsDGV.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = CarsDGV.SelectedRows[0].Cells[2].Value.ToString();
            ColorTb.Text = CarsDGV.SelectedRows[0].Cells[3].Value.ToString();
            BodyCb.SelectedValue = GetBodyId(CarsDGV.SelectedRows[0].Cells[4].Value.ToString());
            IssueTb.Text = CarsDGV.SelectedRows[0].Cells[5].Value.ToString();
            AvailableCb.SelectedIndex = Convert.ToInt32(CarsDGV.SelectedRows[0].Cells[6].Value) == 1 ? 0 : 1; // Преобразование в индекс
            PriceTb.Text = CarsDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private int GetBodyId(string typeBody)
        {
            Con.Open();
            string query = "SELECT BodyId FROM BodyTbl WHERE TypeBody = @TypeBody";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@TypeBody", typeBody);
            int bodyId = (int)cmd.ExecuteScalar();
            Con.Close();
            return bodyId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || ColorTb.Text == "" || IssueTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Відсутня інформація");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE CarTbl SET Brand = @BrandTb, Model = @ModelTb, Color = @ColorTb, Body = @BodyId, Issue = @IssueTb, Available = @AvailableCb, Price = @PriceTb WHERE RegNum = @RegNumTb";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RegNumTb", RegNumTb.Text);
                    cmd.Parameters.AddWithValue("@BrandTb", BrandTb.Text);
                    cmd.Parameters.AddWithValue("@ModelTb", ModelTb.Text);
                    cmd.Parameters.AddWithValue("@ColorTb", ColorTb.Text);
                    cmd.Parameters.AddWithValue("@BodyId", BodyCb.SelectedValue); // Получаем значение BodyId из выбранного элемента
                    cmd.Parameters.AddWithValue("@IssueTb", IssueTb.Text);
                    cmd.Parameters.AddWithValue("@AvailableCb", AvailableCb.SelectedIndex == 0 ? 1 : 0);
                    cmd.Parameters.AddWithValue("@PriceTb", PriceTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Автомобіль успішно оновлено");
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
            MainForm main = new MainForm(userRole, userId);
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AvailableCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegNumTb_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        


        private void button6_Click(object sender, EventArgs e)
        {
            RegNumTb.Text = "";
            BrandTb.Text = "";
            ModelTb.Text = "";
            ColorTb.Text = "";
            BodyCb.SelectedIndex = -1;
            IssueTb.Text = "";
            AvailableCb.SelectedIndex = -1;
            PriceTb.Text = "";

            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {
        
        }
    }
}
