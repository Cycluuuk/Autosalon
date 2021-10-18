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
    public partial class Add_product : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Add_product()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT pc_name FROM product_categories";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

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

            obj_connection.connectDB.Open();

            string sql_request = "INSERT INTO manufactured_products(mp_id, mp_product_category, mp_name, mp_description )  VALUES(NULL, '" +
               category + "', '" +
               tb_name.Text + "', '" +
               tb_desc.Text+ "');";

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
