namespace KursachDataBase
{
    partial class Register
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.id_kindergarten = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.PeachPuff;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Login.ForeColor = System.Drawing.Color.DarkOrange;
            this.Login.Location = new System.Drawing.Point(42, 30);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(205, 20);
            this.Login.TabIndex = 8;
            this.Login.Text = "Login";
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.PeachPuff;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Password.ForeColor = System.Drawing.Color.DarkOrange;
            this.Password.Location = new System.Drawing.Point(42, 70);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(205, 20);
            this.Password.TabIndex = 7;
            this.Password.Text = "password";
            this.Password.UseSystemPasswordChar = true;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_register.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_register.Location = new System.Drawing.Point(11, 169);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(235, 31);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Зарегистрировать";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Clik);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KursachDataBase.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(11, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::KursachDataBase.Properties.Resources.user2;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 1);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(11, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 1);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // id_kindergarten
            // 
            this.id_kindergarten.BackColor = System.Drawing.Color.PeachPuff;
            this.id_kindergarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_kindergarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_kindergarten.ForeColor = System.Drawing.Color.DarkOrange;
            this.id_kindergarten.FormattingEnabled = true;
            this.id_kindergarten.Location = new System.Drawing.Point(11, 125);
            this.id_kindergarten.Name = "id_kindergarten";
            this.id_kindergarten.Size = new System.Drawing.Size(235, 28);
            this.id_kindergarten.TabIndex = 20;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(260, 227);
            this.Controls.Add(this.id_kindergarten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.btn_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход/Смена Пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Register_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox id_kindergarten;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
    }
}

