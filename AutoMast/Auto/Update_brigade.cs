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
    public partial class Update_brigade : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        int brigade = 1;
        public Update_brigade()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT br_name FROM brigade";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cm_id.Items.Add(reader.GetValue(0));
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

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int head = cb_head.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "UPDATE brigade SET br_head = '" +
            head + "', br_name = '" +
            tb_name.Text + "' WHERE br_id = " + brigade;

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);

            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }

        private void bt_retrun_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            brigade = cm_id.SelectedIndex + 1;
            obj_connection.connectDB.Open();

            string sql_request = "SELECT br_head, br_name FROM brigade WHERE br_id = '" +
               brigade + "'";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                tb_name.Text = reader["br_name"].ToString();
                cb_head.SelectedIndex = int.Parse(reader["br_head"].ToString())-1;
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }
    }
}
