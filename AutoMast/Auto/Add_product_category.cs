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
    public partial class Add_product_category : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Add_product_category()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            obj_connection.connectDB.Open();

            string sql_request = "INSERT INTO product_categories( pc_id, pc_name, pc_description) VALUES(NULL, '" +
               tb_name.Text + "', '" +
               tb_desc.Text + "');";

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
