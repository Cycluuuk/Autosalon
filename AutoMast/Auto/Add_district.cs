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
    public partial class Add_district : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Add_district()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            //head

            string sql_request = "SELECT em_surname FROM employees";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_head.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            //brigade

            sql_request = "SELECT br_name FROM brigade";

            request = new MySqlCommand(sql_request, obj_connection.connectDB);
            reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_brigade.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int head = cb_head.SelectedIndex + 1;
            int brigade = cb_brigade.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "INSERT INTO district(ds_id, ds_brigade, ds_head, ds_name ) VALUES(NULL, '" +
               brigade + "', '" +
               head + "', '" +
               tb_name.Text + "');";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
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
