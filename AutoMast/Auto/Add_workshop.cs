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
    public partial class Add_workshop : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Add_workshop()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT em_surname FROM employees";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_head.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            sql_request = "SELECT ds_name FROM district";

            request = new MySqlCommand(sql_request, obj_connection.connectDB);
            reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_districts.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int head = cb_head.SelectedIndex + 1;
            int district = cb_districts.SelectedIndex + 1;
            string max_id = "1";

            obj_connection.connectDB.Open();

            string sql_request = "SELECT MAX(wr_id) FROM workshop";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                max_id = reader[0].ToString(); ;
            }
            reader.Close();


             sql_request = "INSERT INTO workshop(wr_id, wr_district, wr_head, wr_name) VALUES('" +
               max_id +"','" +
               district +"' , '" +
               head + "', '" +
               tb_name.Text + "');";

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
