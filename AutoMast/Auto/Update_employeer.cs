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
    public partial class Update_employeer : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        int selected_id = 1;
        public Update_employeer()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT ds_name FROM district";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cm_id.Items.Add(reader.GetValue(0));
            }
            reader.Close();


            sql_request = "SELECT br_name FROM brigade";

            request = new MySqlCommand(sql_request, obj_connection.connectDB);
            reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_brigade.Items.Add(reader.GetValue(0));
            }
            reader.Close();


            sql_request = "SELECT em_surname FROM employees";

            request = new MySqlCommand(sql_request, obj_connection.connectDB);
            reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_head.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_retrun_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            selected_id = cm_id.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "SELECT ds_brigade, ds_head, ds_name FROM district WHERE ds_id = '" +
               selected_id + "'";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_brigade.SelectedIndex = int.Parse(reader["ds_brigade"].ToString()) - 1;
                cb_head.SelectedIndex = int.Parse(reader["ds_head"].ToString()) - 1;
                tb_name.Text = reader["ds_name"].ToString();
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int brigade = cb_brigade.SelectedIndex + 1;
            int head = cm_id.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "UPDATE district SET " +
            "ds_brigade = '" + brigade +
            "', ds_head = '" + head +
            "', ds_name  = '" + tb_name.Text +
            "' WHERE ds_id = " + selected_id;

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);

            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }
    }
}
