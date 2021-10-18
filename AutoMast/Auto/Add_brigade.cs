﻿using System;
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
    public partial class Add_brigade : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Add_brigade()
        {
            InitializeComponent();
            this.CenterToScreen();

            obj_connection.connectDB.Open();

            string sql_request = "SELECT em_surname FROM employees";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            MySqlDataReader reader = request.ExecuteReader();

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

            string sql_request = "INSERT INTO brigade(br_id, br_head, br_name ) VALUES(NULL, '" +
               head + "', '" +
               tb_name.Text + "');";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }

        private void bt_retrun_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
