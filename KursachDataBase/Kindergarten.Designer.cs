namespace KursachDataBase
{
    partial class Kindergarten
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
            this.Kindergarten_Table = new System.Windows.Forms.DataGridView();
            this.district = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Kindergarten_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Kindergarten_Table
            // 
            this.Kindergarten_Table.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Kindergarten_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kindergarten_Table.Location = new System.Drawing.Point(12, 34);
            this.Kindergarten_Table.Name = "Kindergarten_Table";
            this.Kindergarten_Table.Size = new System.Drawing.Size(572, 471);
            this.Kindergarten_Table.TabIndex = 0;
            // 
            // district
            // 
            this.district.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.district.FormattingEnabled = true;
            this.district.Location = new System.Drawing.Point(590, 34);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(220, 28);
            this.district.TabIndex = 1;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(590, 90);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(220, 28);
            this.type.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.PeachPuff;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.ForeColor = System.Drawing.Color.DarkOrange;
            this.phone.Location = new System.Drawing.Point(590, 188);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(220, 20);
            this.phone.TabIndex = 3;
            this.phone.Text = "Контактный Телефон";
            this.phone.Enter += new System.EventHandler(this.phone_Enter);
            this.phone.Leave += new System.EventHandler(this.phone_Leave);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.PeachPuff;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.DarkOrange;
            this.name.Location = new System.Drawing.Point(590, 135);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(220, 20);
            this.name.TabIndex = 4;
            this.name.Text = "Название Садика";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(585, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Код Района";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(590, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Код Собственности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(586, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата Основания ";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.PeachPuff;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.ForeColor = System.Drawing.Color.DarkOrange;
            this.id.Location = new System.Drawing.Point(590, 345);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(220, 20);
            this.id.TabIndex = 11;
            this.id.Text = "ID Садика";
            this.id.Enter += new System.EventHandler(this.id_Enter);
            this.id.Leave += new System.EventHandler(this.id_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(590, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Вставить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BTN_INSERT_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PapayaWhip;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(590, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PapayaWhip;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(590, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(590, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PapayaWhip;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(590, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 32);
            this.button4.TabIndex = 17;
            this.button4.Text = "Выбрать";
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
            this.button5.Location = new System.Drawing.Point(727, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 32);
            this.button5.TabIndex = 18;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Кол-во записей : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(388, 8);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(142, 23);
            this.generate.TabIndex = 37;
            this.generate.Text = "генераци 100 записей";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(267, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 23);
            this.button6.TabIndex = 38;
            this.button6.Text = "Обновить Таблицу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(592, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 1);
            this.panel3.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(590, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(590, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 1);
            this.panel2.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Complex", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(785, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // Kindergarten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(822, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.type);
            this.Controls.Add(this.district);
            this.Controls.Add(this.Kindergarten_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kindergarten";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица Детский Сад";
            this.Load += new System.EventHandler(this.Kindergarten_Load_1);
            this.VisibleChanged += new System.EventHandler(this.Kindergarten_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Kindergarten_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Kindergarten_Table;
        private System.Windows.Forms.ComboBox district;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer1;
    }
}