using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachDataBase
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Clik(object sender, EventArgs e)
        {
            MySqlCommand Command =new MySqlCommand(
                "CREATE USER '" + Login.Text + "'@'localhost' " +
                "IDENTIFIED BY '" + Password.Text+ "'; " +
                "GRANT Alter, Create, Create View, Delete, Drop, Grant Option, Index, Insert, References, Select, Show View, Trigger, Update ON TABLE `kindergarten`.`children_table` TO `" + Login.Text + "`@`localhost`;" +
                "GRANT Alter, Create, Create View, Delete, Drop, Grant Option, Index, Insert, References, Select, Show View, Trigger, Update ON TABLE `kindergarten`.`classes_table` TO `" + Login.Text + "`@`localhost`;" +
                "GRANT Select ON TABLE `kindergarten`.`district_table` TO `" + Login.Text + "`@`localhost`;" +
                "GRANT Select ON TABLE `kindergarten`.`gender_table` TO `" + Login.Text + "`@`localhost`;" +
                "GRANT Select ON TABLE `kindergarten`.`group_table` TO `" + Login.Text + "`@`localhost`;" +
                "GRANT Select ON TABLE `kindergarten`.`kindergartentable` TO `" + Login.Text + "`@`localhost`;" +
                "GRANT Select ON TABLE `kindergarten`.`type_table` TO `" + Login.Text + "`@`localhost`;" +
                "GRANT Select ON TABLE `kindergarten`.`user_help` TO `" + Login.Text + "`@`localhost`;" +
                "GRANT Alter, Alter Routine, Create, Create Routine, Create Temporary Tables, Create User, Create View, Delete, Drop, Event, Execute, File, Grant Option, Index, Insert, Lock Tables, Process, References, Reload, Replication Client, Replication Slave, Select, Show Databases, Show View, Shutdown ON *.* TO `" + Login.Text + "`@`localhost`;", Main.mySqlConnection);
            Command.ExecuteNonQuery();

            string insertQuery = "INSERT INTO user_help(login_user, id_kindergarten) " +
                "VALUES('" + Login.Text + "'," + id_kindergarten.Text + ")";
            executeQuery(insertQuery);
            timer1.Start();
        }

        public void executeQuery(String query)
        {
            try
            {
                MySqlCommand command;
                command = new MySqlCommand(query, Main.mySqlConnection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Register_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e){ timer1.Start(); }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left += 10;
            this.Opacity -= 0.05;
            if (this.Opacity == 0)
            {

                Main Main = (Main)Application.OpenForms["Main"];

                Main.Opacity = 100;
                Main.Left = 393;
     
                Main.Show();
                timer1.Stop();
                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Form1 form2 = (Form1)Application.OpenForms["Form1"];
           // this.Left -= 10;
            if (this.Left <= 553)
            {
                timer2.Stop();
                return;
            }
            this.Left -= 10;
            this.Opacity += 0.05;
        }

        private void Register_VisibleChanged(object sender, EventArgs e)
        {
            id_kindergarten.Items.Clear();
            string selectQuery = "SELECT * FROM kindergartentable";

            MySqlCommand command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id_kindergarten.Items.Add(reader.GetString("id_kindergarten"));
            }
            reader.Close();
        }
    }
}
