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
    public partial class ReferenceTables : Form
    {
        public ReferenceTables()
        {
            InitializeComponent();
        }

        private void ReferenceTables_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_district as №, district as Район  FROM district_table", Main.mySqlConnection);
        
            DataSet ds = new DataSet();
            adapter.Fill(ds, "district_table");
            District_Table.DataSource = ds.Tables["district_table"];


            adapter = new MySqlDataAdapter("SELECT id_type as №, type as ТипСадика  FROM type_table", Main.mySqlConnection);
            ds = new DataSet();
            adapter.Fill(ds, "type_table");
            Type_Table.DataSource = ds.Tables["type_table"];

            adapter = new MySqlDataAdapter("SELECT id_group as №, group_children as Группы  FROM group_table", Main.mySqlConnection);
            ds = new DataSet();
            adapter.Fill(ds, "group_table");
            Group_Table.DataSource = ds.Tables["group_table"];

            adapter = new MySqlDataAdapter("SELECT id_gender as №, gender as Пол  FROM gender_table", Main.mySqlConnection);
            ds = new DataSet();
            adapter.Fill(ds, "gender_table");
            Gender_Table.DataSource = ds.Tables["gender_table"];
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

        //tab1
        private void BTN_INSERT_Click_DISTRICT(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO district_table(district) VALUES('" + textBox1.Text + "')";
            executeQuery(insertQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_district as №, district as Район  FROM district_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "district_table");
            District_Table.DataSource = ds.Tables["district_table"];
        }

        private void BTN_UPDATE_Click_DISTRICT(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE district_table SET district='" + textBox1.Text + "'"+ " WHERE id_district = " + textBoxIDDistrict.Text;
            executeQuery(updateQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_district as №, district as Район  FROM district_table", Main.mySqlConnection);


            DataSet ds = new DataSet();
            adapter.Fill(ds, "district_table");
            District_Table.DataSource = ds.Tables["district_table"];

        }

        private void BTN_DELETE_Click_DISTRICT(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM district_table WHERE id_district = " + textBoxIDDistrict.Text;
            executeQuery(deleteQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_district as №, district as Район  FROM district_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "district_table");
            District_Table.DataSource = ds.Tables["district_table"];
        }
        //tab2
        private void BTN_INSERT_Click_TYPE(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO type_table(type) VALUES('" + textBox3.Text + "')";
            executeQuery(insertQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_type as №, type as ТипСадика  FROM type_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "type_table");
            Type_Table.DataSource = ds.Tables["type_table"];
        }

        private void BTN_UPDATE_Click_TYPE(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE type_table SET type='" + textBox3.Text + "'" + " WHERE id_type = " + textBoxIDType.Text;
            executeQuery(updateQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_type as №, type as ТипСадика  FROM type_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "type_table");
            Type_Table.DataSource = ds.Tables["type_table"];

        }

        private void BTN_DELETE_Click_TYPE(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM type_table WHERE id_type = " + textBoxIDType.Text;
            executeQuery(deleteQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_type as №, type as ТипСадика  FROM type_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "type_table");
            Type_Table.DataSource = ds.Tables["type_table"];
        }

        //tab3
        private void BTN_INSERT_Click_GROUP(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO group_table(group_children) VALUES('" + textBox5.Text + "')";
            executeQuery(insertQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_group as №, group_children as Группы  FROM group_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "group_table");
            Group_Table.DataSource = ds.Tables["group_table"];
        }

        private void BTN_UPDATE_Click_GROUP(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE group_table SET group_children='" + textBox5.Text + "'" + " WHERE id_group = " + textBoxIDGroup.Text;
            executeQuery(updateQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_group as №, group_children as Группы  FROM group_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "group_table");
            Group_Table.DataSource = ds.Tables["group_table"];
        }

        private void BTN_DELETE_Click_GROUP(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM group_table WHERE id_group = " + textBoxIDGroup.Text;
            executeQuery(deleteQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_group as №, group_children as Группы  FROM group_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "group_table");
            Group_Table.DataSource = ds.Tables["group_table"];
        }

        //tab4
        private void BTN_INSERT_Click_GENDER(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO gender_table(gender) VALUES('" + textBox7.Text + "')";
            executeQuery(insertQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_gender as №, gender as Пол  FROM gender_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "gender_table");
            Gender_Table.DataSource = ds.Tables["gender_table"];
        }

        private void BTN_UPDATE_Click_GENDER(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE gender_table SET gender='" + textBox7.Text + "'" + " WHERE id_gender = " + textBoxIDGender.Text;
            executeQuery(updateQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_gender as №, gender as Пол  FROM gender_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "gender_table");
            Gender_Table.DataSource = ds.Tables["gender_table"];
        }

        private void BTN_DELETE_Click_GENDER(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM gender_table WHERE id_gender = " + textBoxIDGender.Text;
            executeQuery(deleteQuery);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id_gender as №, gender as Пол  FROM gender_table", Main.mySqlConnection);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "gender_table");
            Gender_Table.DataSource = ds.Tables["gender_table"];
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReferenceTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Район")
                textBox1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
                textBox1.Text = "Район";
        }

        private void textBoxIDDistrict_Enter(object sender, EventArgs e)
        {
            if (textBoxIDDistrict.Text == "ID")
                textBoxIDDistrict.Clear();
        }

        private void textBoxIDDistrict_Leave(object sender, EventArgs e)
        {
            if (textBoxIDDistrict.Text == String.Empty)
                textBoxIDDistrict.Text = "ID";
        }

        private void textBoxIDType_Enter(object sender, EventArgs e)
        {
            if (textBoxIDType.Text == "ID")
                textBoxIDType.Clear();
        }

        private void textBoxIDType_Leave(object sender, EventArgs e)
        {
            if (textBoxIDType.Text == String.Empty)
                textBoxIDType.Text = "ID";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Тип Сада")
                textBox3.Clear();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == String.Empty)
                textBox3.Text = "Тип Сада";
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Группы")
                textBox5.Clear();
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == String.Empty)
                textBox5.Text = "Группы";
        }

        private void textBoxIDGroup_Enter(object sender, EventArgs e)
        {
            if (textBoxIDGroup.Text == "ID")
                textBoxIDGroup.Clear();
        }

        private void textBoxIDGroup_Leave(object sender, EventArgs e)
        {
            if (textBoxIDGroup.Text == String.Empty)
                textBoxIDGroup.Text = "ID";
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Пол")
                textBox7.Clear();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == String.Empty)
                textBox7.Text = "Пол";
        }

        private void textBoxIDGender_Enter(object sender, EventArgs e)
        {
            if (textBoxIDGender.Text == "ID")
                textBoxIDGender.Clear();
        }

        private void textBoxIDGender_Leave(object sender, EventArgs e)
        {
            if (textBoxIDGender.Text == String.Empty)
                textBoxIDGender.Text = "ID";
        }
    }
}
