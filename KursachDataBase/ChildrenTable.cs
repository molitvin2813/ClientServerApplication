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
    public partial class ChildrenTable : Form
    {
       // string Param;
        public ChildrenTable()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ChildrenTable_VisibleChanged(object sender, EventArgs e)
        {
            /*if (Form1.Login.Text == "admin")
                generate.Show();
            else
                generate.Hide();*/
            MySqlDataAdapter adapter=null;
            if (Main.Login == "admin" || Main.Login == "root")
            { 
                adapter = new MySqlDataAdapter("SELECT children_table.inn as ИНН, children_table.fio as ФИО, " +
                    "children_table.birthday as ДеньРождения, children_table.id_kindergarten as №Садика, " +
                    "children_table.id_group as №Группы, children_table.id_gender as №Пола, " +
                    "children_table.id_classes as №ДопЗанятия  FROM children_table", Main.mySqlConnection);
            }
            else
            {
                int id_kindergarten = chooseSomeKindergarten();

                adapter = new MySqlDataAdapter("SELECT children_table.inn as ИНН, children_table.fio as ФИО, " +
                    "children_table.birthday as ДеньРождения, children_table.id_kindergarten as №Садика, " +
                    "children_table.id_group as №Группы, children_table.id_gender as №Пола, " +
                    "children_table.id_classes as №ДопЗанятия  FROM children_table WHERE children_table.id_kindergarten =" + id_kindergarten, Main.mySqlConnection);
            }
           
            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            Children_Table.DataSource = ds.Tables["children_table"];

            group.Items.Clear();
            gender.Items.Clear();
            classes.Items.Clear();
            kindergarten.Items.Clear();

            string selectQuery = "SELECT * FROM group_table";
            MySqlCommand command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                group.Items.Add(reader.GetString("id_group"));
            }

            selectQuery = "SELECT * FROM gender_table";
            reader.Close();
            command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                gender.Items.Add(reader.GetString("id_gender"));
            }

            selectQuery = "SELECT * FROM classes_table";
            reader.Close();
            command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                classes.Items.Add(reader.GetString("id_classes"));
            }

            selectQuery = "SELECT * FROM kindergartentable";
            reader.Close();
            command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                kindergarten.Items.Add(reader.GetString("id_kindergarten"));
            }
            reader.Close();
        }

        public int chooseSomeKindergarten()
        {
            string selectQuery = "SELECT * FROM user_help WHERE login_user= '" + Main.Login + "' ";
            string temp = "";
            MySqlCommand command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            MySqlDataReader read = command.ExecuteReader();
            read.Read();
            temp = read.GetString("id_kindergarten");
            read.Close();
            return Int32.Parse(temp);
            
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
            string insertQuery = "INSERT INTO children_table(id_kindergarten, fio, birthday, id_group, id_gender, id_classes) " +
                "VALUES(" + kindergarten.Text + ",'" + fio.Text + "','" + birthday.Text + "'," + group.Text + "," + gender.Text + ","+ classes.Text+")";
            executeQuery(insertQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT inn as ИНН, fio as ФИО, birthday as ДеньРождения, id_kindergarten as №Садика, id_group as №Группы, id_gender as №Пола, id_classes as №ДопЗанятия  FROM children_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            Children_Table.DataSource = ds.Tables["children_table"];
        }


        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            string Param="inn";
            UpdateTable(Param);
        }

        private void UpdateTable(string Param)
        {
            string updateQuery = "UPDATE children_table SET id_classes=" + classes.Text + ", fio='" + fio.Text
                + "', birthday='" + birthday.Text + "', id_group=" + group.Text + ", id_gender=" + gender.Text + " WHERE " + Param + " = " + id.Text;
            executeQuery(updateQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT inn as ИНН, fio as ФИО, birthday as ДеньРождения, id_kindergarten as №Садика, id_group as №Группы, id_gender as №Пола, id_classes as №ДопЗанятия  FROM children_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            Children_Table.DataSource = ds.Tables["children_table"];
            MessageBox.Show("Внесения примененны к полю ИНН " + id.Text);
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            string Param = "inn";
            DeleteFieldFromTable(Param);
        }

        private void DeleteFieldFromTable(string Param)
        {
            string deleteQuery = "DELETE FROM children_table WHERE "+Param+" = " + id.Text;
            executeQuery(deleteQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT inn as ИНН, fio as ФИО, birthday as ДеньРождения, id_kindergarten as №Садика, id_group as №Группы, id_gender as №Пола, id_classes as №ДопЗанятия  FROM children_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            Children_Table.DataSource = ds.Tables["children_table"];
            MessageBox.Show("Удалено поле с ИНН " + id.Text);
        }

       

        

        private void SearchField(string id_group, string id_gender, string id_classes, string id_kindergarten, string fio)
        {
            // MySqlCommand command;
            //MySqlDataReader mdr;
            string selectQuery = "SELECT inn as ИНН, fio as ФИО, birthday as ДеньРождения, id_kindergarten as №Садика, id_group as №Группы, id_gender as №Пола, id_classes as №ДопЗанятия  FROM children_table WHERE birthday = '" + birthday.Text + "'" 
                + id_group + id_gender + id_classes+ id_kindergarten + fio;
            //command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            // mdr = command.ExecuteReader();

            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, Main.mySqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            Children_Table.DataSource = ds.Tables["children_table"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader mdr;
            string selectQuery = "SELECT inn as ИНН, fio as ФИО, birthday as ДеньРождения, id_kindergarten as №Садика, id_group as №Группы, id_gender as №Пола, id_classes as №ДопЗанятия  FROM children_table WHERE inn = " + id.Text;
            command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                group.Text = mdr.GetDouble("id_group").ToString();
                birthday.Value = mdr.GetDateTime("birthday");
                gender.Text = mdr.GetInt32("id_gender").ToString();
                classes.Text = mdr.GetInt32("id_classes").ToString();
                kindergarten.Text = mdr.GetInt32("id_kindergarten").ToString();
                fio.Text = mdr.GetString("fio");
            }
            else
            {
                group.Text = "";
                //birthday.Value = mdr.GetDateTime("birthday");
                gender.Text = "";
                classes.Text = "";
                kindergarten.Text = "";
                fio.Text = "";
                MessageBox.Show("Нет ДопЗанятия С Таким ID");
            }
            mdr.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT COUNT(*) FROM children_table";
            MySqlCommand command = new MySqlCommand(selectQuery, Main.mySqlConnection);
            label8.Text = "Кол-во записей : " + Convert.ToInt32(command.ExecuteScalar());
        }

        private void generate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] str = { "Альберт", "Аркадий", "Виктор", "Виктория", "Мария", "Дениц" };
            for (int i = 0; i < 100; i++)
            { 
                string insertQuery = "INSERT INTO children_table(id_kindergarten, fio, birthday, id_group, id_gender, id_classes) " +
                    "VALUES(" + rnd.Next(108, 116) + ",'" + str[rnd.Next(0, 6)] + "','" + birthday.Text + "'," + rnd.Next(1, 4) + "," + rnd.Next(1, 4) + "," + rnd.Next(1, 3) + ")";
                executeQuery(insertQuery);
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT inn as ИНН, fio as ФИО, birthday as ДеньРождения, id_kindergarten as №Садика, id_group as №Группы, id_gender as №Пола, id_classes as №ДопЗанятия  FROM children_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            Children_Table.DataSource = ds.Tables["children_table"];
        }

        private void button6_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT inn as ИНН, fio as ФИО, birthday as ДеньРождения, id_kindergarten as №Садика, id_group as №Группы, id_gender as №Пола, id_classes as №ДопЗанятия  FROM children_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            Children_Table.DataSource = ds.Tables["children_table"];

           
        }

        private void ChildrenTable_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id_group = "", id_gender = "", id_classes = "", id_kindergarten = "", fio = "";
            if (this.group.Text != String.Empty)
                id_group = " And id_group = " + this.group.Text;
            if (this.gender.Text != String.Empty)
                id_gender = " And id_gender = " + this.gender.Text;
            if (this.classes.Text != String.Empty)
                id_classes = " And id_classes = " + this.classes.Text;
            if (this.kindergarten.Text != String.Empty)
                id_kindergarten = " And id_kindergarten = " + this.kindergarten.Text;
            if (this.fio.Text != String.Empty && this.fio.Text != "ФИО")
                fio = " And fio = '" + this.fio.Text + "'";

            SearchField(id_group, id_gender, id_classes, id_kindergarten, fio);
        }

        private void fio_Enter(object sender, EventArgs e)
        {
            if (fio.Text == "ФИО")
                fio.Clear();
        }

        private void fio_Leave(object sender, EventArgs e)
        {
            if (fio.Text == String.Empty)
                fio.Text = "ФИО";
        }

        private void id_Enter(object sender, EventArgs e)
        {
            if (id.Text == "ИНН")
                id.Clear();
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (id.Text == String.Empty)
                id.Text = "ИНН";
        }

        private void label5_Click(object sender, EventArgs e)
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
           
            if (this.Left == 256)
            {
                timer2.Stop();
                return;
            }
            this.Left -= 10;
            this.Opacity += 0.05;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = this.Left.ToString();
        }
    }
}
