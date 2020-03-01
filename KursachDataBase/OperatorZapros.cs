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
    public partial class OperatorZapros : Form
    {
        public OperatorZapros()
        {
            InitializeComponent();
        }

        //•	левое внешнее соединение; 
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("leftOuterJoin", Main.mySqlConnection);
            
            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        //•	правое внешнее соединение
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("rightOuterJoin", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        //•	симметричное внутреннее соединение без условия 
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("innerJoin1", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("innerJoin2", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("innerJoin3", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];

        }

        //•	симметричное внутреннее соединение с условием(ключи)

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("innerJoinWithConditionKey1", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("innerJoinWithConditionKey1", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        //•	симметричное внутреннее соединение с условием(даты)
        private void button9_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("innerJoinWithConditionDate1", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("innerJoinWithConditionDate2", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("Sum", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "classes_table");
            dataGridView1.DataSource = ds.Tables["classes_table"];

        }

        private void button11_Click(object sender, EventArgs e)
        {
          

            MySqlDataAdapter adapter = new MySqlDataAdapter("count", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kindergartentable");
            dataGridView1.DataSource = ds.Tables["kindergartentable"];

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("count2", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(" SELECT children_table.fio, group_table.group,  gender_table.gender, classes_table.name, classes_table.cost" +
                "FROM children_table,group_table,gender_table,classes_table " +
                "WHERE (children_table.id_group= group_table.id_group and children_table.id_gender = gender_table.id_gender and children_table.id_classes = classes_table.id_classes and classes_table.name =" + textBox1.Text+ " and classes_table.name LIKE '_____')", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "children_table");
            dataGridView1.DataSource = ds.Tables["children_table"];
        }

        private void OperatorZapros_Load(object sender, EventArgs e)
        {

        }

        private void OperatorZapros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main Main = (Main)Application.OpenForms["Main"];

            Main.Opacity = 100;
            Main.Left = 393;

            Main.Show();
        }
    }
}
