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
    public partial class Add_emp_category : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Add_emp_category()
        {
            InitializeComponent();
            this.CenterToScreen();
            rb_engineer.Checked = true;
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            int special = 1;

            obj_connection.connectDB.Open();

            if (rb_engineer.Checked)
                special = 1;
            if (rb_worker.Checked)
                special = 0;

            string sql_request = "INSERT INTO staff_categories(sc_id, sc_name, sc_description, sc_special) VALUES(NULL,'" +
               tb_name.Text + "', '" +
               tb_desc.Text + "', '" +
               special + "');";

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB);
            request.ExecuteNonQuery();

            obj_connection.connectDB.Close();
            this.Close();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_emp_category_Load(object sender, EventArgs e)
        {

        }
    }
}
