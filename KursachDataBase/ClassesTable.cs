using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KursachDataBase
{
    public partial class ClassesTable : Form
    {
        public ClassesTable()
        {
            InitializeComponent();
        }

        private void ClassesTable_Load(object sender, EventArgs e)
        {

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


        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO classes_table(time, cost, date, name) " +
                "VALUES(" + time.Text + "," + cost.Text + ",'" + date.Text + "','" + name.Text + "')";
            executeQuery(insertQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_classes as №, time as Время, cost as Стоимость, date as Дата,name as Название  FROM classes_table", Main.mySqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "classes_table");
            Classes_Table.DataSource = ds.Tables["classes_table"];
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE classes_table SET time=" + time.Text + ", cost=" + cost.Text
                + ", date='" + date.Text + "', name='" + name.Text + "' WHERE id_classes = " + id.Text;
            executeQuery(updateQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_classes as №, time as Время, cost as Стоимость, date as Дата,name as Название  FROM classes_table", Main.mySqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "classes_table");
            Classes_Table.DataSource = ds.Tables["classes_table"];
            MessageBox.Show("Изменено поле ID " + id.Text);
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM classes_table WHERE id_classes = " + id.Text;
            executeQuery(deleteQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_classes as №, time as Время, cost as Стоимость, date as Дата,name as Название  FROM classes_table", Main.mySqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "classes_table");
            Classes_Table.DataSource = ds.Tables["classes_table"];
            MessageBox.Show("Удалено поле ID " + id.Text);
        }
  
        private void Kindergarten_VisibleChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_classes as №, time as Время, cost as Стоимость, date as Дата,name as Название  FROM classes_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "classes_table");
            Classes_Table.DataSource = ds.Tables["classes_table"];
        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader mdr;
            string selectQuery = "SELECT id_classes as №, time as Время, cost as Стоимость, date as Дата,name as Название  FROM classes_table WHERE id_classes = " + id.Text;
            command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                cost.Text = mdr.GetDouble("cost").ToString();
                date.Value = mdr.GetDateTime("date");
                time.Text = mdr.GetInt32("time").ToString();
                name.Text = mdr.GetString("name");
            }
            else
            {
                cost.Text = "";
                //date = mdr.GetDateTime("date");
                time.Text = "";
                name.Text = "";
                MessageBox.Show("Нет ДопЗанятия С Таким ID");
            }
            mdr.Close();
        }

       

        private void SearchField(string cost, string time, string name)
        {
            // MySqlCommand command;
            //MySqlDataReader mdr;
          
            string selectQuery = "SELECT id_classes as №, time as Время, cost as Стоимость, date as Дата,name as Название  FROM classes_table WHERE date = '" + date.Text + "'"+ cost+time+name;
            //command = new MySqlCommand(selectQuery, Main.mySqlConnection);
           // mdr = command.ExecuteReader();

            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, Main.mySqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "classes_table");
            Classes_Table.DataSource = ds.Tables["classes_table"];
        }


        private void label6_Click_1(object sender, EventArgs e)
        {
            string selectQuery = "SELECT COUNT(*) FROM classes_table";
            MySqlCommand command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            label6.Text = "Кол-во записей : " + Convert.ToInt32(command.ExecuteScalar());
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Main Main = (Main)Application.OpenForms["Main"];
            Main.Show();
            Main.Opacity = 100;
            Main.Left = 393;
            timer1.Start();
            
        }


        private void button5_Click(object sender, EventArgs e)
        {

            string cost = "", time = "", name = "";
            if (this.cost.Text != String.Empty && this.cost.Text != "Стоимость")
                cost = " And cost = " + this.cost.Text;
            if (this.time.Text != String.Empty && this.time.Text != "Время")
                time = " And time = " + this.time.Text;
            if (this.name.Text != String.Empty && this.name.Text != "Название")
                name = " And name = '" + this.name.Text + "'";

            SearchField(cost, time, name);
        }

        private void cost_Enter(object sender, EventArgs e)
        {
            if (cost.Text == "Стоимость")
                cost.Clear();
        }

        private void cost_Leave(object sender, EventArgs e)
        {
            if (cost.Text == String.Empty)
                cost.Text = "Стоимость";

        }

        private void time_Enter(object sender, EventArgs e)
        {
            if (time.Text == "Время")
                time.Clear();
        }

        private void time_Leave(object sender, EventArgs e)
        {
            if (time.Text == String.Empty)
                time.Text = "Время";
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Название")
                name.Clear();
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == String.Empty)
                name.Text = "Название";
        }

        private void id_Enter(object sender, EventArgs e)
        {
            if (id.Text == "Код Занятия")
                id.Clear();
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (id.Text == String.Empty)
                id.Text = "Код Занятия";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Left -= 10;
            this.Opacity += 0.05;
            if (this.Left == 271)
            {
                timer2.Stop();
            }
        }

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

       
    }
}
