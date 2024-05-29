namespace CarRental1
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PassTb = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Uname = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 468);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(79, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прокат автомобілів";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental1.Properties.Resources.user_image_20240413_12281062860cd97ff;
            this.pictureBox1.Location = new System.Drawing.Point(53, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(356, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Логін";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(356, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "Пароль";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PassTb
            // 
            // 
            // 
            // 
            this.PassTb.CustomButton.Image = null;
            this.PassTb.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.PassTb.CustomButton.Name = "";
            this.PassTb.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.PassTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassTb.CustomButton.TabIndex = 1;
            this.PassTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassTb.CustomButton.UseSelectable = true;
            this.PassTb.CustomButton.Visible = false;
            this.PassTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PassTb.Lines = new string[0];
            this.PassTb.Location = new System.Drawing.Point(484, 224);
            this.PassTb.MaxLength = 32767;
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '*';
            this.PassTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassTb.SelectedText = "";
            this.PassTb.SelectionLength = 0;
            this.PassTb.SelectionStart = 0;
            this.PassTb.ShortcutsEnabled = true;
            this.PassTb.Size = new System.Drawing.Size(239, 38);
            this.PassTb.TabIndex = 7;
            this.PassTb.UseSelectable = true;
            this.PassTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassTb.WaterMarkFont = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTb.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(488, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Очистити";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Uname
            // 
            this.Uname.AllowDrop = true;
            // 
            // 
            // 
            this.Uname.CustomButton.Image = null;
            this.Uname.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.Uname.CustomButton.Name = "";
            this.Uname.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.Uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Uname.CustomButton.TabIndex = 1;
            this.Uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Uname.CustomButton.UseSelectable = true;
            this.Uname.CustomButton.Visible = false;
            this.Uname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Uname.Lines = new string[0];
            this.Uname.Location = new System.Drawing.Point(482, 105);
            this.Uname.MaxLength = 32767;
            this.Uname.Name = "Uname";
            this.Uname.PasswordChar = '\0';
            this.Uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Uname.SelectedText = "";
            this.Uname.SelectionLength = 0;
            this.Uname.SelectionStart = 0;
            this.Uname.ShortcutsEnabled = true;
            this.Uname.Size = new System.Drawing.Size(239, 38);
            this.Uname.TabIndex = 6;
            this.Uname.UseSelectable = true;
            this.Uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Uname.WaterMarkFont = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Uname.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(494, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Увійти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(694, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 468);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox PassTb;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox Uname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}