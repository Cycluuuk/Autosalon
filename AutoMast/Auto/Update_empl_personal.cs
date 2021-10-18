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
    public partial class Update_empl_personal : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        int selected_id = 1;
        public Update_empl_personal()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT em_surname FROM employees";

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

        private void bt_apply_Click(object sender, EventArgs e)
        {


            obj_connection.connectDB.Open();

            string sql_request = "UPDATE employees SET " +
            "em_name = '" + tb_name.Text +
            "', em_surname = '" + tb_surname.Text +
            "', em_patronymic = '" + tb_patron.Text +
            "', em_phone = '" + tb_phone.Text +
            "', em_adress  = '" +  tb_email.Text +
            "' WHERE em_id = " + selected_id;

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);

            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {

            selected_id = cm_id.SelectedIndex + 1;

            obj_connection.connectDB.Open();

            string sql_request = "SELECT em_name, em_surname, em_patronymic, em_phone, em_adress FROM employees WHERE em_id = '" +
               selected_id + "'";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

            while (reader.Read())
            {
                tb_name.Text = reader["em_name"].ToString();
                tb_surname.Text = reader["em_surname"].ToString();
                tb_patron.Text = reader["em_patronymic"].ToString();
                tb_phone.Text = reader["em_phone"].ToString();
                tb_email.Text = reader["em_adress"].ToString();
            }
            reader.Close();

            obj_connection.connectDB.Close();
        }
    }
}
