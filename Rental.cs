using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental1
{
    public partial class Rental : Form
    {
        private string userRole;
        private string userId;
        public Rental(string userRole, string userId)
        {
            InitializeComponent();
            this.userRole = userRole;
            this.userId = userId;
            // Добавляем обработчики событий
            CustNameTb.TextChanged += CustNameTb_TextChanged;
            CarRegCb.SelectionChangeCommitted += CarRegCb_SelectionChangeCommitted;

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rastl\OneDrive\Документы\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");
        string key = "";

        private void fillcombo()
        {
            try
            {
                Con.Open();
                string query = "SELECT RegNum FROM CarTbl where Available = 1";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                CarRegCb.ValueMember = "RegNum";
                CarRegCb.DisplayMember = "RegNum";
                CarRegCb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час заповнення комбо-боксу: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private bool CheckCustomerExists(string custName)
        {
            bool exists = false;
            try
            {
                Con.Open();
                string query = "SELECT COUNT(*) FROM CustomerTbl WHERE CustName = @CustName";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@CustName", custName);
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час перевірки існування клієнта: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return exists;
        }

        private void fillCustomer()
        {
            try
            {
                Con.Open();
                string query = "SELECT CustName FROM CustomerTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                CustNameTb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                CustNameTb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                foreach (DataRow row in dt.Rows)
                {
                    coll.Add(row["CustName"].ToString());
                }
                CustNameTb.AutoCompleteCustomSource = coll;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час заповнення комбо-боксу клієнтів: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from RentalTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                var ds = new DataSet();
                sda.Fill(ds);
                RentDGV.DataSource = ds.Tables[0];
                RentDGV.Columns[0].HeaderText = "Id прокату";
                RentDGV.Columns[1].HeaderText = "Номер Авто";
                RentDGV.Columns[2].HeaderText = "ПІБ";
                RentDGV.Columns[3].HeaderText = "Дата прокату";
                RentDGV.Columns[4].HeaderText = "Дата повернення";
                RentDGV.Columns[5].HeaderText = "Залог";

                RentDGV.Sort(RentDGV.Columns[0], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час завантаження даних оренди: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void UpdateonRent()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rastl\OneDrive\Документы\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    Con.Open();
                    string query = "UPDATE CarTbl SET Available = 0 WHERE RegNum = @RegNum";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RegNum", CarRegCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateonRentDelete()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rastl\OneDrive\Документы\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    Con.Open();
                    string query = "UPDATE CarTbl SET Available = 1 WHERE RegNum = @RegNum";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RegNum", key);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час оновлення даних: " + ex.Message);
            }
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void CarRegCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void CustCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CustNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                CarRegCb.SelectedValue == null ||
                string.IsNullOrWhiteSpace(CustNameTb.Text) ||
                RentDate.Value == null ||
                ReturnDate.Value == null ||
                string.IsNullOrWhiteSpace(FeesTb.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            // Проверяем, существует ли клиент в базе данных
            if (!CheckCustomerExists(CustNameTb.Text))
            {
                MessageBox.Show("Клієнт з таким ПІБ не існує в базі даних.");
                return;
            }
            try
            {
                Con.Open();
                string query = "INSERT INTO RentalTbl (CarReg, CustName, RentDate, ReturnDate, RentFee) VALUES (@CarReg , @CustName, @RentDate, @ReturnDate, @RentFee)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@CarReg", CarRegCb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@CustName", CustNameTb.Text);
                cmd.Parameters.AddWithValue("@RentDate", RentDate.Value.Date);
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate.Value.Date);
                cmd.Parameters.AddWithValue("@RentFee", FeesTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Автомобіль успішно орендовано");
                Con.Close();
                UpdateonRent();
                populate();
                fillcombo();
            }
            catch (Exception Myex)
            {
                MessageBox.Show(Myex.Message);
                Con.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm(userRole, userId);
            main.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (key == "")
            {
                MessageBox.Show("Оберіть строку для видалення");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM RentalTbl WHERE CarReg = @Key";  // Убедитесь, что имя столбца написано правильно
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Key", key);  // Убедитесь, что значение параметра соответствует типу данных столбца
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    UpdateonRentDelete();
                    populate();
                    fillcombo();
                    MessageBox.Show("Прокат видалено успішно");
                    key = "";
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                    Con.Close();
                }
            }
        }



        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            CarRegCb.SelectedValue = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustNameTb.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            RentDate.Value = Convert.ToDateTime(RentDGV.SelectedRows[0].Cells[3].Value);
            ReturnDate.Value = Convert.ToDateTime(RentDGV.SelectedRows[0].Cells[4].Value);
            FeesTb.Text = RentDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RentDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть запис для редагування");
                return;
            }

            if (CarRegCb.SelectedValue == null ||
                string.IsNullOrWhiteSpace(CustNameTb.Text) ||
                RentDate.Value == null ||
                ReturnDate.Value == null ||
                string.IsNullOrWhiteSpace(FeesTb.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            try
            {
                Con.Open();
                string query = "UPDATE RentalTbl SET CarReg = @CarReg, CustName = @CustName, RentDate = @RentDate, ReturnDate = @ReturnDate, RentFee = @RentFee WHERE RentId = @RentId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@CarReg", CarRegCb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@CustName", CustNameTb.Text);
                cmd.Parameters.AddWithValue("@RentDate", RentDate.Value.Date);
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate.Value.Date);
                cmd.Parameters.AddWithValue("@RentFee", FeesTb.Text);
                cmd.Parameters.AddWithValue("@RentId", RentDGV.SelectedRows[0].Cells["RentId"].Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Дані успішно оновлено");
                Con.Close();
                populate();
                fillcombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час оновлення даних: " + ex.Message);
                Con.Close();
            }
        }


        private void CustNameTb_Click(object sender, EventArgs e)
        {

        }

    }
}