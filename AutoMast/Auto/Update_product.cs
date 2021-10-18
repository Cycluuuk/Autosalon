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
    public partial class Update_product : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        int selected_id = 1;

        public Update_product()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT mp_name FROM manufactured_products";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cm_id.Items.Add(reader.GetValue(0));
            }
            reader.Close();


            sql_request = "SELECT pc_name FROM product_categories";

            request = new MySqlCommand(sql_request, obj_connection.connectDB);
            reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_category.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_retrun_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int category = cb_category.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "UPDATE manufactured_products SET " +
            "mp_product_category = '" + category +
            "', mp_name = '" + tb_name.Text +
            "', mp_description  = '" + tb_desc.Text +
            "' WHERE mp_id = " + selected_id;

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);

            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            selected_id = cm_id.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "SELECT mp_product_category, mp_name, mp_description FROM manufactured_products WHERE mp_id = '" +
               selected_id + "'";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_category.SelectedIndex = int.Parse(reader["mp_product_category"].ToString()) - 1;
                tb_name.Text = reader["mp_name"].ToString();
                tb_desc.Text = reader["mp_description"].ToString();

            }
            reader.Close();

            obj_connection.connectDB.Close();
        }
    }
}
