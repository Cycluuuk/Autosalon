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
    public partial class Update_product_category : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        int selected_id = 1;
        public Update_product_category()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT pc_name FROM product_categories";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cm_id.Items.Add(reader.GetValue(0));
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

            string sql_request = "SELECT pc_name, pc_description FROM product_categories WHERE pc_id = '" +
               selected_id + "'";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                tb_name.Text = reader["pc_name"].ToString();
                tb_desc.Text = reader["pc_description"].ToString();
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            obj_connection.connectDB.Open();

            string sql_request = "UPDATE product_categories SET " +
            "pc_name = '" + tb_name.Text +
            "', pc_description  = '" + tb_desc.Text +
            "' WHERE pc_id = " + selected_id;

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);

            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }
    }
}
