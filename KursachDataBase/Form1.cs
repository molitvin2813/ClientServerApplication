using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using MySql.Data.MySqlClient;

namespace KursachDataBase
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Main.mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog ='kindergarten';username=" +
                    Login.Text + ";password=" + Password.Text + ";charset=utf8");
                Main.mySqlConnection.Open();
                //this.Hide();

                Main main = (Main)Application.OpenForms["Main"]; // Где Form1 это имя формы содежащаяся в переменной Name.
                if (main != null) // Если форма существует, то изменяем свойства её объектов
                {
                    if (Login.Text != "operator_kindergarten" && Login.Text != "admin")
                    {
                        main.groupBox2.Show();
                        main.groupBox1.Hide();
                    }

                    if (Login.Text == "operator_kindergarten")
                    {
                        main.groupBox1.Show();
                        main.groupBox2.Hide();
                    }
                    if (Login.Text == "admin" || Login.Text == "root")
                    {
                        main.groupBox1.Show();
                        main.groupBox2.Show();
                        main.label2.Show();
                    }
                    
                    main.k = 1;
                    main.Show();
                    main.Visible = true;
                    main.timer2.Start();
                    Main.Login = Login.Text;

                }


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/n Введены некорректные данные");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Login_Enter(object sender, EventArgs e)
        {
            //pictureBox1.BackgroundImage = Properties.Resources.user21;
            if (Login.Text == "Login")
                Login.Clear();
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            //pictureBox1.BackgroundImage = Properties.Resources.user2;
            if (Login.Text == String.Empty)
                Login.Text = "Login";
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "password")
                Password.Clear();
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == String.Empty)
                Password.Text = "password";
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Main main = (Main)Application.OpenForms["Main"];

            main.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


       /* private void timer1_Tick(object sender, EventArgs e)
        {
            Register.Left += 10;
            if (Register.Left >= 723)
            {
                timer1.Stop();
                this.TopMost = false;
                Register.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Register.Left -= 10;
            if (Register.Left <= 553)
            {
                timer2.Stop();
                this.Close();
            }
        }*/

       
    }
}
