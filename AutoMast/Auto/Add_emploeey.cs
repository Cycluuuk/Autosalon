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

namespace Auto
{
    public partial class Add_emploeey : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Add_emploeey()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT br_name FROM brigade";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_brigade.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            sql_request = "SELECT sc_name FROM staff_categories";

            request = new MySqlCommand(sql_request, obj_connection.connectDB);
            reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_category.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            obj_connection.connectDB.Close();


        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int category = cb_category.SelectedIndex + 1;
            int brigade = cb_brigade.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "INSERT INTO employees (em_id, em_name, em_surname, em_patronymic, em_phone, em_adress) VALUES(NULL, '" +
              tb_name.Text + "', '" +
              tb_surname.Text +"', '" +
              tb_patron.Text + "', '" +
              tb_phone.Text + "', '" +
              tb_email.Text + "');";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            request.ExecuteNonQuery();

            string employeer_id = "";

            sql_request = "SELECT MAX(em_id) FROM employees";
            request = new MySqlCommand(sql_request, obj_connection.connectDB);

            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                employeer_id = reader[0].ToString();
            }
            reader.Close();

             sql_request = "INSERT INTO empoloyees_characteristic(ec_id,ec_staff_category, ec_brigade)  VALUES('"+ employeer_id +"', '" +
             category + "', '" +
             brigade + "');";


            request = new MySqlCommand(sql_request, obj_connection.connectDB);
            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
