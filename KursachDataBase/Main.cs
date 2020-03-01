using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace KursachDataBase
{
    public partial class Main : Form
    {
        public static MySqlConnection mySqlConnection = new MySqlConnection();
        public static string Login="";

        Register Register;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            label2.Hide();

            Form1 form2 = (Form1)Application.OpenForms["Form1"]; // Где Form2 это имя формы содежащаяся в переменной Name.
            if (form2 == null) // Если форма не существует, то создаём
            {
                form2 = new Form1();
                form2.Show(); // Отображаем форму
                //this.Hide();
                //this.Visible = false;
            }
            else
                form2.Activate();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
           
            ReferenceTables ReferenceTables = (ReferenceTables)Application.OpenForms["ReferenceTables"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (ReferenceTables == null) // Если форма существует, то изменяем свойства её объектов
            {
                ReferenceTables = new ReferenceTables();
                ReferenceTables.Show();
                timer1.Start();
            }
            else
            {
                ReferenceTables.Activate();
                timer1.Start();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Kindergarten Kindergarten = (Kindergarten)Application.OpenForms["Kindergarten"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (Kindergarten == null) // Если форма существует, то изменяем свойства её объектов
            {
                Kindergarten = new Kindergarten();
                
                Kindergarten.Show();
                
                timer1.Start();
            }
            else
            {
               
                Kindergarten.timer2.Start();
                Kindergarten.Show();
               timer1.Start();
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChildrenTable ChildrenTable = (ChildrenTable)Application.OpenForms["ChildrenTable"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (ChildrenTable == null) // Если форма существует, то изменяем свойства её объектов
            {
                ChildrenTable = new ChildrenTable();
                ChildrenTable.Show();
                ChildrenTable.timer2.Start();
                timer1.Start();
            }
            else
            {
                ChildrenTable.Show();
                ChildrenTable.timer2.Start();
                timer1.Start();
            }
            //this.Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(mySqlConnection.State == ConnectionState.Open)
                mySqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            ClassesTable ClassesTable = (ClassesTable)Application.OpenForms["ClassesTable"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (ClassesTable == null) // Если форма существует, то изменяем свойства её объектов
            {
                ClassesTable = new ClassesTable();
                ClassesTable.Show();
                timer1.Start();
            }
            else
            {
                ClassesTable.Show();
                ClassesTable.timer2.Start();
                timer1.Start();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OperatorZapros OperatorZapros = (OperatorZapros)Application.OpenForms[" OperatorZapros"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (OperatorZapros == null) // Если форма существует, то изменяем свойства её объектов
            {
                OperatorZapros = new OperatorZapros();
                OperatorZapros.Show();
               // ChildrenTable.timer2.Start();
                timer1.Start();
            }
            else
            {
                OperatorZapros.Activate();
                //ChildrenTable.timer2.Start();
                timer1.Start();
            }

           // OperatorZapros.Show();
        }

        public int k = 0;
        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            //base.OnVisibleChanged(e);
            if (k == 0)
            {
                this.Visible = false;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form2 = (Form1)Application.OpenForms["Form1"]; // Где Form2 это имя формы содежащаяся в переменной Name.
            if (form2 == null) // Если форма не существует, то создаём
            {
                form2 = new Form1();
                form2.Show(); // Отображаем форму
                timer1.Start();
            }
            else
            {
                form2.Activate();
                timer1.Start();
            }
               

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left += 10;
            this.Opacity -= 0.05;
            if (this.Opacity == 0)
            {
                
                timer1.Stop();
                this.Hide();
            }
               
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            
            if (this.Left == 393)
            {

                timer2.Stop();
                return;
            }
            this.Left -= 10;
            this.Opacity += 0.05;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register = (Register)Application.OpenForms["Register"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (Register == null) // Если форма существует, то изменяем свойства её объектов
            {
                Register = new Register();
                Register.Show(); // Отображаем форму
                timer1.Start();

            }
            else
            {
                Register.Show(); // Отображаем форму
                Register.timer2.Start();
                timer1.Start();
               
            }


        }
    }
    
}
