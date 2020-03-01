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
    public partial class Kindergarten : Form
    {
        public Kindergarten()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Kindergarten_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_kindergarten as №Cадика, name as Название, id_district as №Района, id_type as №Типа, open_date as ДатаОткрытия, phone_number as НомерТелефона  FROM kindergartentable", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kindergartentable");
            Kindergarten_Table.DataSource = ds.Tables["kindergartentable"];
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
            string insertQuery = "INSERT INTO kindergartentable(name, phone_number, open_date, id_district, id_type) " +
                "VALUES('" + name.Text + "'," + phone.Text + ",'" + dateTimePicker1.Text + "'," + district.Text + "," + type.Text + ")";
            executeQuery(insertQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_kindergarten as №Cадика, name as Название, id_district as №Района, id_type as №Типа, open_date as ДатаОткрытия, phone_number as НомерТелефона  FROM kindergartentable", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kindergartentable");
            Kindergarten_Table.DataSource = ds.Tables["kindergartentable"];
        }

       private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE kindergartentable SET name='" + name.Text + "', phone_number=" + phone.Text
                + ", open_date='" + dateTimePicker1.Text + "', id_district=" + district.Text + ", id_type=" + type.Text + " WHERE id_kindergarten = " + id.Text;
            executeQuery(updateQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_kindergarten as №Cадика, name as Название, id_district as №Района, id_type as №Типа, open_date as ДатаОткрытия, phone_number as НомерТелефона  FROM kindergartentable", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kindergartentable");
            Kindergarten_Table.DataSource = ds.Tables["kindergartentable"];
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM kindergartentable WHERE id_kindergarten = " + id.Text;
            executeQuery(deleteQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_kindergarten as №Cадика, name as Название, id_district as №Района, id_type as №Типа, open_date as ДатаОткрытия, phone_number as НомерТелефона  FROM kindergartentable", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kindergartentable");
            Kindergarten_Table.DataSource = ds.Tables["kindergartentable"];
        }


        

        private void Kindergarten_VisibleChanged(object sender, EventArgs e)
        {
            /*if (Form1.Login.Text == "admin")
                generate.Show();
            else
                generate.Hide();*/

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_kindergarten as №Cадика, name as Название, id_district as №Района, id_type as №Типа, open_date as ДатаОткрытия, phone_number as НомерТелефона  FROM kindergartentable", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kindergartentable");
            Kindergarten_Table.DataSource = ds.Tables["kindergartentable"];

            district.Items.Clear();
            type.Items.Clear();
            string selectQuery = "SELECT * FROM district_table";

            MySqlCommand command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                district.Items.Add(reader.GetString("id_district"));
            }

            selectQuery = "SELECT * FROM type_table";
            reader.Close();
            command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                type.Items.Add(reader.GetString("id_type"));
            }
            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader mdr;
            string selectQuery = "SELECT * FROM kindergartentable WHERE id_kindergarten = " + id.Text;
            command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                phone.Text = mdr.GetInt32("phone_number").ToString();
                dateTimePicker1.Value = mdr.GetDateTime("open_date");
                district.Text = mdr.GetInt32("id_district").ToString();
                name.Text = mdr.GetString("name");
                type.Text = mdr.GetInt32("id_type").ToString(); ;
            }
            else
            {
                phone.Text = "";  
                district.Text = "";
                name.Text = "";
                type.Text ="" ;
                MessageBox.Show("Нет Садика С Таким ID");
            }
            mdr.Close();
        }

        private void SearchField(string phone, string district, string name, string type)
        {
            string selectQuery = "SELECT id_kindergarten as №Cадика, name as Название, id_district as №Района, id_type as №Типа, open_date as ДатаОткрытия, phone_number as НомерТелефона  FROM kindergartentable WHERE open_date = '" + dateTimePicker1.Text + "'"
                + phone + district + name + type;

            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, Main.mySqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "kindergartentable");
            Kindergarten_Table.DataSource = ds.Tables["kindergartentable"];
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT COUNT(*) FROM kindergartentable";
            MySqlCommand command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            label7.Text = "Кол-во записей : "+Convert.ToInt32(command.ExecuteScalar());
            
        }

        private void Kindergarten_Load_1(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] str = { "Солнышко", "Ветерок", "#154", "Мопс", "Гобзаврик", "Пылинка" };
            for (int i = 0; i < 100; i++)
            {
                string insertQuery = "INSERT INTO kindergartentable(name, phone_number, open_date, id_district, id_type) " +
                "VALUES('" + str[rnd.Next(0,6)] + "'," + rnd.Next(300,500) + ",'" + dateTimePicker1.Text + "'," + rnd.Next(1, 7) + "," + rnd.Next(1, 3) + ")";
                executeQuery(insertQuery);
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_kindergarten as №Cадика, name as Название, id_district as №Района, id_type as №Типа, open_date as ДатаОткрытия, phone_number as НомерТелефона  FROM kindergartentable", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kindergartentable");
            Kindergarten_Table.DataSource = ds.Tables["kindergartentable"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_kindergarten as №Cадика, name as Название, id_district as №Района, id_type as №Типа, open_date as ДатаОткрытия, phone_number as НомерТелефона  FROM kindergartentable", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            Kindergarten_Table.DataSource = ds.Tables["children_table"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string phone = "", district = "", name = "", type = "";
            if (this.phone.Text != String.Empty && this.phone.Text != "Контактный Телефон")
                phone = " And phone_number = " + this.phone.Text;
            if (this.district.Text != String.Empty)
                district = " And id_district = " + this.district.Text;
            if (this.name.Text != String.Empty && this.name.Text != "Название Садика")
                name = " And name = '" + this.name.Text + "'";
            if (this.type.Text != String.Empty )
                type = " And id_type = " + this.type.Text;


            SearchField(phone, district, name, type);
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Название Садика")
                name.Clear();
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == String.Empty)
                name.Text = "Название Садика";
        }

        private void phone_Enter(object sender, EventArgs e)
        {
            if (phone.Text == "Контактный Телефон")
                phone.Clear();
        }

        private void phone_Leave(object sender, EventArgs e)
        {
            if (phone.Text == String.Empty)
                phone.Text = "Контактный Телефон";
        }

        private void id_Enter(object sender, EventArgs e)
        {
            if (id.Text == "ID Садика")
                id.Clear();
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (id.Text == String.Empty)
                id.Text = "ID Садика";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (this.Left == 272)
            {
                timer2.Stop();
                return;
            }
            this.Left -= 10;
            this.Opacity += 0.05;


        }

       
    }
}
