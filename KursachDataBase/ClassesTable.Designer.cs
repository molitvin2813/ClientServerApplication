namespace KursachDataBase
{
    partial class ClassesTable
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
            this.Classes_Table = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Classes_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Classes_Table
            // 
            this.Classes_Table.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Classes_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Classes_Table.Location = new System.Drawing.Point(12, 47);
            this.Classes_Table.Name = "Classes_Table";
            this.Classes_Table.Size = new System.Drawing.Size(572, 458);
            this.Classes_Table.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PapayaWhip;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Complex", 12.75F);
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(594, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 32);
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
            this.button2.Location = new System.Drawing.Point(594, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 32);
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
            this.button1.Location = new System.Drawing.Point(594, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Вставить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BTN_INSERT_Click);
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(594, 89);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(220, 27);
            this.date.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(590, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Дата Проведения";
            // 
            // cost
            // 
            this.cost.BackColor = System.Drawing.Color.PeachPuff;
            this.cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.ForeColor = System.Drawing.Color.DarkOrange;
            this.cost.Location = new System.Drawing.Point(594, 132);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(220, 20);
            this.cost.TabIndex = 21;
            this.cost.Text = "Стоимость";
            this.cost.Enter += new System.EventHandler(this.cost_Enter);
            this.cost.Leave += new System.EventHandler(this.cost_Leave);
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.PeachPuff;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.ForeColor = System.Drawing.Color.DarkOrange;
            this.time.Location = new System.Drawing.Point(594, 187);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(220, 20);
            this.time.TabIndex = 23;
            this.time.Text = "Время";
            this.time.Enter += new System.EventHandler(this.time_Enter);
            this.time.Leave += new System.EventHandler(this.time_Leave);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.PeachPuff;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.DarkOrange;
            this.name.Location = new System.Drawing.Point(594, 242);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(222, 20);
            this.name.TabIndex = 25;
            this.name.Text = "Название";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.PeachPuff;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.ForeColor = System.Drawing.Color.DarkOrange;
            this.id.Location = new System.Drawing.Point(594, 355);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(222, 20);
            this.id.TabIndex = 27;
            this.id.Text = "Код Занятия";
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
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
            this.button4.Location = new System.Drawing.Point(594, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 32);
            this.button4.TabIndex = 29;
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
            this.button5.Location = new System.Drawing.Point(726, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 32);
            this.button5.TabIndex = 31;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Complex", 12.75F);
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Кол-во записей :  ";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(594, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 1);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(594, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1);
            this.panel1.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(596, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 1);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Location = new System.Drawing.Point(596, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 1);
            this.panel4.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Complex", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(785, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClassesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(824, 517);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.time);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Classes_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassesTable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица ДопЗанятия";
            this.Load += new System.EventHandler(this.ClassesTable_Load);
            this.VisibleChanged += new System.EventHandler(this.Kindergarten_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Classes_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Classes_Table;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
    }
}