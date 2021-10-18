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
    public partial class Add_product_record : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Add_product_record()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT mp_name FROM manufactured_products";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_product.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            sql_request = "SELECT distinct wr_name FROM workshop";

            request = new MySqlCommand(sql_request, obj_connection.connectDB);
            reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_workshop.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            obj_connection.connectDB.Close();

        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int product = cb_product.SelectedIndex + 1;
            int workshop = cb_workshop.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "INSERT INTO product_records(pr_id, pr_wokshop, pr_product_number, pr_count, pr_date  )  VALUES(NULL, '" +
                workshop + "', '" +
                product +  "', '" +
                tb_count.Text +"', CURDATE());";

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
