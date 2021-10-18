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
    public partial class Main_From : Form
    {
        public Main_From()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void bt_show_data_Click(object sender, EventArgs e)
        {
            Show_Information_From form_obj = new Show_Information_From();
            this.Hide();
            form_obj.Show();
        }

        private void bt_change_data_Click(object sender, EventArgs e)
        {
            Add_Information_Form form_obj = new Add_Information_Form();
            this.Hide();
            form_obj.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_From_Load(object sender, EventArgs e)
        {

        }
    }
}
