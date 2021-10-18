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
    public partial class Update_empl_category : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        int category_id = 1;
        public Update_empl_category()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT sc_name FROM staff_categories";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cm_id.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            string special = "";

            category_id = cm_id.SelectedIndex + 1;
            obj_connection.connectDB.Open();

            string sql_request = "SELECT sc_name, sc_description, sc_special FROM staff_categories WHERE sc_id = '" +
               category_id + "'";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                tb_name.Text = reader["sc_name"].ToString();
                tb_desc.Text = reader["sc_description"].ToString();
                special = reader["sc_special"].ToString();
                if (special == "True")
                    rb_engineer.Checked = true;
                else
                    rb_worker.Checked = true;
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int special = 1;

            obj_connection.connectDB.Open();

            if (rb_engineer.Checked)
                special = 1;
            if (rb_worker.Checked)
                special = 0;


            string sql_request = "UPDATE staff_categories SET sc_name = '" +
            tb_name.Text + "', sc_description = '" +
            tb_desc.Text + "', sc_special  = '" +
            special + "' WHERE sc_id = " + category_id;

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);

            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }
    }
}
