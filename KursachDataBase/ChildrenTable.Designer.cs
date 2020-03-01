namespace KursachDataBase
{
    partial class ChildrenTable
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
            this.components = new System.ComponentModel.Container();
            this.Children_Table = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.classes = new System.Windows.Forms.ComboBox();
            this.kindergarten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Children_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Children_Table
            // 
            this.Children_Table.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Children_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Children_Table.Location = new System.Drawing.Point(12, 37);
            this.Children_Table.Name = "Children_Table";
            this.Children_Table.Size = new System.Drawing.Size(572, 484);
            this.Children_Table.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PapayaWhip;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(722, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PapayaWhip;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(590, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(590, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Вставить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BTN_INSERT_Click);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.PeachPuff;
            this.group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group.ForeColor = System.Drawing.Color.DarkOrange;
            this.group.FormattingEnabled = true;
            this.group.Location = new System.Drawing.Point(590, 37);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(220, 28);
            this.group.TabIndex = 19;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.PeachPuff;
            this.gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender.ForeColor = System.Drawing.Color.DarkOrange;
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(590, 93);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(220, 28);
            this.gender.TabIndex = 20;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // classes
            // 
            this.classes.BackColor = System.Drawing.Color.PeachPuff;
            this.classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classes.ForeColor = System.Drawing.Color.DarkOrange;
            this.classes.FormattingEnabled = true;
            this.classes.Location = new System.Drawing.Point(590, 149);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(220, 28);
            this.classes.TabIndex = 21;
            // 
            // kindergarten
            // 
            this.kindergarten.BackColor = System.Drawing.Color.PeachPuff;
            this.kindergarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kindergarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kindergarten.ForeColor = System.Drawing.Color.DarkOrange;
            this.kindergarten.FormattingEnabled = true;
            this.kindergarten.Location = new System.Drawing.Point(590, 205);
            this.kindergarten.Name = "kindergarten";
            this.kindergarten.Size = new System.Drawing.Size(220, 28);
            this.kindergarten.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(586, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Код Группы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(590, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Код Пола";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(590, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Код ДопЗанятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(590, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Код Садика";
            // 
            // fio
            // 
            this.fio.BackColor = System.Drawing.Color.PeachPuff;
            this.fio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.ForeColor = System.Drawing.Color.DarkOrange;
            this.fio.Location = new System.Drawing.Point(590, 255);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(236, 20);
            this.fio.TabIndex = 27;
            this.fio.Text = "ФИО";
            this.fio.Enter += new System.EventHandler(this.fio_Enter);
            this.fio.Leave += new System.EventHandler(this.fio_Leave);
            // 
            // birthday
            // 
            this.birthday.CustomFormat = "yyyy-MM-dd";
            this.birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthday.Location = new System.Drawing.Point(590, 320);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(200, 27);
            this.birthday.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(590, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Дата Рождения";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.PeachPuff;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.ForeColor = System.Drawing.Color.DarkOrange;
            this.id.Location = new System.Drawing.Point(591, 364);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(234, 20);
            this.id.TabIndex = 31;
            this.id.Text = "ИНН";
            this.id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.id.Enter += new System.EventHandler(this.id_Enter);
            this.id.Leave += new System.EventHandler(this.id_Leave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PapayaWhip;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(722, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 32);
            this.button4.TabIndex = 33;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PapayaWhip;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button5.ForeColor = System.Drawing.Color.DarkOrange;
            this.button5.Location = new System.Drawing.Point(590, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(252, 32);
            this.button5.TabIndex = 34;
            this.button5.Text = "Выбрать";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Кол-во записей : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(398, 11);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(142, 23);
            this.generate.TabIndex = 36;
            this.generate.Text = "генераци 100 записей";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(277, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 23);
            this.button6.TabIndex = 37;
            this.button6.Text = "Обновить Таблицу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(590, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 1);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(591, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 1);
            this.panel1.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Complex", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(815, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ChildrenTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(854, 533);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kindergarten);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.group);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Children_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChildrenTable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица Дети";
            this.Load += new System.EventHandler(this.ChildrenTable_Load);
            this.VisibleChanged += new System.EventHandler(this.ChildrenTable_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Children_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Children_Table;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox classes;
        private System.Windows.Forms.ComboBox kindergarten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
    }
}