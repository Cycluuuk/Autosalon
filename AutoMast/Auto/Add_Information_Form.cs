using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Add_Information_Form : Form
    {
        public Add_Information_Form()
        {
            InitializeComponent();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            Main_From menu_form = new Main_From();
            this.Close();
            menu_form.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Update_product_category obj_form = new Update_product_category();
            obj_form.ShowDialog();
        }

        private void bt_add_staff_Click(object sender, EventArgs e)
        {
            Add_emploeey obj_form = new Add_emploeey();
            obj_form.ShowDialog();
        }

        private void bt_add_staff_category_Click(object sender, EventArgs e)
        {
            Add_emp_category obj_form = new Add_emp_category();
            obj_form.ShowDialog();
        }

        private void bt_add_brigade_Click(object sender, EventArgs e)
        {
            Add_brigade obj_form = new Add_brigade();
            obj_form.ShowDialog();
        }

        private void bt_add_district_Click(object sender, EventArgs e)
        {
            Add_district obj_form = new Add_district();
            obj_form.ShowDialog();
        }

        private void add_workshop_Click(object sender, EventArgs e)
        {
            Add_workshop obj_form = new Add_workshop();
            obj_form.ShowDialog();
        }

        private void bt_add_prod_category_Click(object sender, EventArgs e)
        {
            Add_product_category obj_form = new Add_product_category();
            obj_form.ShowDialog();
        }

        private void bt_add_prod_Click(object sender, EventArgs e)
        {
            Add_product obj_form = new Add_product();
            obj_form.ShowDialog();
        }

        private void bt_add_prod_record_Click(object sender, EventArgs e)
        {
            Add_product_record obj_form = new Add_product_record();
            obj_form.ShowDialog();
        }

        private void bt_change_staff_Click(object sender, EventArgs e)
        {
            Update_employeer obj_form = new Update_employeer();
            obj_form.ShowDialog();
        }

        private void bt_change_staff_personal_Click(object sender, EventArgs e)
        {
            Update_empl_personal obj_form = new Update_empl_personal();
            obj_form.ShowDialog();
        }

        private void bt_change_staff_category_Click(object sender, EventArgs e)
        {
            Update_empl_category obj_form = new Update_empl_category();
            obj_form.ShowDialog();
        }

        private void bt_change_brigade_Click(object sender, EventArgs e)
        {
            Update_brigade obj_form = new Update_brigade();
            obj_form.ShowDialog();
        }

        private void bt_change_district_Click(object sender, EventArgs e)
        {
            Update_district obj_form = new Update_district();
            obj_form.ShowDialog();
        }

        private void bt_change_workshop_Click(object sender, EventArgs e)
        {
            Update_workshop obj_form = new Update_workshop();
            obj_form.ShowDialog();
        }

        private void bt_change_prod_Click(object sender, EventArgs e)
        {
            Update_product obj_form = new Update_product();
            obj_form.ShowDialog();
        }
    }
}
