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
    public partial class Update_district : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        int employee = 1;
       
        public Update_district()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT br_name FROM brigade";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

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
                cm_id.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            sql_request = "SELECT sc_name FROM staff_categories";

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

        private void bt_select_Click(object sender, EventArgs e)
        {
            employee = cm_id.SelectedIndex + 1;
            obj_connection.connectDB.Open();

            string sql_request = "SELECT ec_staff_category, ec_brigade FROM empoloyees_characteristic WHERE ec_id = '" +
               employee + "'";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                cb_brigade.SelectedIndex = int.Parse(reader["ec_brigade"].ToString()) - 1;
                cb_category.SelectedIndex = int.Parse(reader["ec_staff_category"].ToString()) - 1;
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int brig = cb_brigade.SelectedIndex + 1;
            int categ = cb_category.SelectedIndex + 1; 

            obj_connection.connectDB.Open();

            string sql_request = "UPDATE empoloyees_characteristic SET ec_staff_category = '" +
            categ + "', ec_brigade = '" +
            brig + "' WHERE ec_id = " + employee;

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);

            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }
    }
}
