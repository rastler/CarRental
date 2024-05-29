namespace CarRental1
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressTb = new MetroFramework.Controls.MetroTextBox();
            this.PassNumbTb = new MetroFramework.Controls.MetroTextBox();
            this.NameTb = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchFullNameTb = new MetroFramework.Controls.MetroTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.PhoneTb = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 122);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(616, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Керувати клієнтами";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(551, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "Прокат автомобілів";
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.AllowUserToAddRows = false;
            this.CustomerDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDGV.ColumnHeadersHeight = 24;
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerDGV.GridColor = System.Drawing.Color.Black;
            this.CustomerDGV.Location = new System.Drawing.Point(509, 334);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.ReadOnly = true;
            this.CustomerDGV.RowHeadersVisible = false;
            this.CustomerDGV.RowHeadersWidth = 51;
            this.CustomerDGV.RowTemplate.Height = 24;
            this.CustomerDGV.Size = new System.Drawing.Size(924, 347);
            this.CustomerDGV.TabIndex = 49;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.CustomerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.CustomerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.CustomerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.CustomerDGV.ThemeStyle.ReadOnly = true;
            this.CustomerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerDGV.ThemeStyle.RowsStyle.Height = 24;
            this.CustomerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(848, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 38);
            this.label9.TabIndex = 48;
            this.label9.Text = "Список клієнтів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Телефон";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(167, 620);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 40);
            this.button4.TabIndex = 45;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(345, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 40);
            this.button3.TabIndex = 44;
            this.button3.Text = "ВИДАЛИТИ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1013, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 31);
            this.label5.TabIndex = 40;
            this.label5.Text = "Адреса";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(34, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 40);
            this.button2.TabIndex = 43;
            this.button2.Text = "РЕДАГУВАТИ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 31);
            this.label6.TabIndex = 36;
            this.label6.Text = "Номер паспорта";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(34, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 42;
            this.button1.Text = "ДОДАТИ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(553, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "ПІБ";
            // 
            // AddressTb
            // 
            // 
            // 
            // 
            this.AddressTb.CustomButton.Image = null;
            this.AddressTb.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.AddressTb.CustomButton.Name = "";
            this.AddressTb.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.AddressTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddressTb.CustomButton.TabIndex = 1;
            this.AddressTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddressTb.CustomButton.UseSelectable = true;
            this.AddressTb.CustomButton.Visible = false;
            this.AddressTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.AddressTb.Lines = new string[0];
            this.AddressTb.Location = new System.Drawing.Point(1130, 148);
            this.AddressTb.MaxLength = 32767;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.PasswordChar = '\0';
            this.AddressTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddressTb.SelectedText = "";
            this.AddressTb.SelectionLength = 0;
            this.AddressTb.SelectionStart = 0;
            this.AddressTb.ShortcutsEnabled = true;
            this.AddressTb.Size = new System.Drawing.Size(239, 34);
            this.AddressTb.TabIndex = 41;
            this.AddressTb.UseSelectable = true;
            this.AddressTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddressTb.WaterMarkFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // PassNumbTb
            // 
            this.PassNumbTb.AllowDrop = true;
            // 
            // 
            // 
            this.PassNumbTb.CustomButton.Image = null;
            this.PassNumbTb.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.PassNumbTb.CustomButton.Name = "";
            this.PassNumbTb.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.PassNumbTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassNumbTb.CustomButton.TabIndex = 1;
            this.PassNumbTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassNumbTb.CustomButton.UseSelectable = true;
            this.PassNumbTb.CustomButton.Visible = false;
            this.PassNumbTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PassNumbTb.Lines = new string[0];
            this.PassNumbTb.Location = new System.Drawing.Point(258, 145);
            this.PassNumbTb.MaxLength = 32767;
            this.PassNumbTb.Name = "PassNumbTb";
            this.PassNumbTb.PasswordChar = '\0';
            this.PassNumbTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassNumbTb.SelectedText = "";
            this.PassNumbTb.SelectionLength = 0;
            this.PassNumbTb.SelectionStart = 0;
            this.PassNumbTb.ShortcutsEnabled = true;
            this.PassNumbTb.Size = new System.Drawing.Size(239, 34);
            this.PassNumbTb.TabIndex = 38;
            this.PassNumbTb.UseSelectable = true;
            this.PassNumbTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassNumbTb.WaterMarkFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // NameTb
            // 
            // 
            // 
            // 
            this.NameTb.CustomButton.Image = null;
            this.NameTb.CustomButton.Location = new System.Drawing.Point(353, 2);
            this.NameTb.CustomButton.Name = "";
            this.NameTb.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.NameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTb.CustomButton.TabIndex = 1;
            this.NameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTb.CustomButton.UseSelectable = true;
            this.NameTb.CustomButton.Visible = false;
            this.NameTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.NameTb.Lines = new string[0];
            this.NameTb.Location = new System.Drawing.Point(622, 148);
            this.NameTb.MaxLength = 32767;
            this.NameTb.Name = "NameTb";
            this.NameTb.PasswordChar = '\0';
            this.NameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTb.SelectedText = "";
            this.NameTb.SelectionLength = 0;
            this.NameTb.SelectionStart = 0;
            this.NameTb.ShortcutsEnabled = true;
            this.NameTb.Size = new System.Drawing.Size(385, 34);
            this.NameTb.TabIndex = 39;
            this.NameTb.UseSelectable = true;
            this.NameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTb.WaterMarkFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1445, 26);
            this.panel2.TabIndex = 50;
            // 
            // SearchFullNameTb
            // 
            // 
            // 
            // 
            this.SearchFullNameTb.CustomButton.Image = null;
            this.SearchFullNameTb.CustomButton.Location = new System.Drawing.Point(347, 2);
            this.SearchFullNameTb.CustomButton.Name = "";
            this.SearchFullNameTb.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.SearchFullNameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchFullNameTb.CustomButton.TabIndex = 1;
            this.SearchFullNameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchFullNameTb.CustomButton.UseSelectable = true;
            this.SearchFullNameTb.CustomButton.Visible = false;
            this.SearchFullNameTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.SearchFullNameTb.Lines = new string[0];
            this.SearchFullNameTb.Location = new System.Drawing.Point(752, 294);
            this.SearchFullNameTb.MaxLength = 32767;
            this.SearchFullNameTb.Name = "SearchFullNameTb";
            this.SearchFullNameTb.PasswordChar = '\0';
            this.SearchFullNameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchFullNameTb.SelectedText = "";
            this.SearchFullNameTb.SelectionLength = 0;
            this.SearchFullNameTb.SelectionStart = 0;
            this.SearchFullNameTb.ShortcutsEnabled = true;
            this.SearchFullNameTb.Size = new System.Drawing.Size(379, 34);
            this.SearchFullNameTb.TabIndex = 51;
            this.SearchFullNameTb.UseSelectable = true;
            this.SearchFullNameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchFullNameTb.WaterMarkFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1154, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 34);
            this.button5.TabIndex = 52;
            this.button5.Text = "ПОШУК ЗА ПІБ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(188, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 40);
            this.button6.TabIndex = 53;
            this.button6.Text = "ОНОВИТИ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTb.Location = new System.Drawing.Point(258, 214);
            this.PhoneTb.Mask = "+00(000)000-00-00";
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(239, 30);
            this.PhoneTb.TabIndex = 56;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 713);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SearchFullNameTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustomerDGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.PassNumbTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox AddressTb;
        private MetroFramework.Controls.MetroTextBox PassNumbTb;
        private MetroFramework.Controls.MetroTextBox NameTb;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox SearchFullNameTb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MaskedTextBox PhoneTb;
    }
}