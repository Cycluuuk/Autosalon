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
    public partial class Show_Information_From : Form
    {
        Connect_to_server obj_connection = new Connect_to_server();
        public Show_Information_From()
        {
            InitializeComponent();
            this.CenterToScreen();
            try 
            {
                obj_connection.connectDB.Open();
            }
            catch { }
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            try 
            {
                obj_connection.connectDB.Close();
            }
            catch { }

            Main_From menu_form = new Main_From(); 
            this.Close();
            menu_form.Show();
        }

        private void bd_records_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT distinct wr_name, mp_name, pr_count, pr_date FROM product_records JOIN manufactured_products ON pr_product_number = mp_id JOIN workshop ON pr_wokshop = wr_id";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[4]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();
                db_data[db_data.Count - 1][2] = reader[2].ToString();
                db_data[db_data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();

            dgv_show_info.ColumnCount = 4;
            dgv_show_info.Columns[0].HeaderText = "Название Цеха";
            dgv_show_info.Columns[0].Width = 150;
            dgv_show_info.Columns[1].HeaderText = "Название продукта";
            dgv_show_info.Columns[1].Width = 100;
            dgv_show_info.Columns[2].HeaderText = "Количество";
            dgv_show_info.Columns[2].Width = 150;
            dgv_show_info.Columns[3].HeaderText = "Дата";
            dgv_show_info.Columns[3].Width = 150;


            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }

        private void bt_products_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT mp_name, pc_name, mp_description FROM manufactured_products JOIN product_categories ON mp_product_category = pc_id";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[3]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();
                db_data[db_data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            dgv_show_info.ColumnCount = 3;
            dgv_show_info.Columns[0].HeaderText = "Навзание продукта";
            dgv_show_info.Columns[0].Width = 200;
            dgv_show_info.Columns[1].HeaderText = "Название категории";
            dgv_show_info.Columns[1].Width = 200;
            dgv_show_info.Columns[2].HeaderText = "Описание продукта";
            dgv_show_info.Columns[2].Width = 500;
            

            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }

        private void bt_car_category_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT pc_name, pc_description FROM product_categories";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[2]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();
            }
            reader.Close();

            dgv_show_info.ColumnCount = 2;
            dgv_show_info.Columns[0].HeaderText = "Название категории";
            dgv_show_info.Columns[0].Width = 200;
            dgv_show_info.Columns[1].HeaderText = "Описание категории";
            dgv_show_info.Columns[1].Width = 500;


            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }

        private void bt_staff_info_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT em_name, em_surname, em_patronymic, br_name, sc_name FROM empoloyees_characteristic JOIN staff_categories ON sc_id = ec_staff_category JOIN brigade ON br_id = ec_brigade JOIN employees ON ec_id = em_id";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[5]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();
                db_data[db_data.Count - 1][2] = reader[2].ToString();
                db_data[db_data.Count - 1][3] = reader[3].ToString();
                db_data[db_data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();

            dgv_show_info.ColumnCount = 5;
            dgv_show_info.Columns[0].HeaderText = "Имя";
            dgv_show_info.Columns[0].Width = 150;
            dgv_show_info.Columns[1].HeaderText = "Фамилия";
            dgv_show_info.Columns[1].Width = 150;
            dgv_show_info.Columns[2].HeaderText = "Отчество";
            dgv_show_info.Columns[2].Width = 150;
            dgv_show_info.Columns[3].HeaderText = "Бригада";
            dgv_show_info.Columns[3].Width = 150;
            dgv_show_info.Columns[4].HeaderText = "Категория";
            dgv_show_info.Columns[4].Width = 150;


            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }


        private void bt_staff_all_info_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT em_name, em_surname, em_patronymic, em_phone, em_adress FROM employees";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[5]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();
                db_data[db_data.Count - 1][2] = reader[2].ToString();
                db_data[db_data.Count - 1][3] = reader[3].ToString();
                db_data[db_data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();

            dgv_show_info.ColumnCount = 5;
            dgv_show_info.Columns[0].HeaderText = "Имя";
            dgv_show_info.Columns[0].Width = 150;
            dgv_show_info.Columns[1].HeaderText = "Фамилия";
            dgv_show_info.Columns[1].Width = 150;
            dgv_show_info.Columns[2].HeaderText = "Отчество";
            dgv_show_info.Columns[2].Width = 150;
            dgv_show_info.Columns[3].HeaderText = "Номер телефона";
            dgv_show_info.Columns[3].Width = 150;
            dgv_show_info.Columns[4].HeaderText = "Email";
            dgv_show_info.Columns[4].Width = 200;


            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }

        private void bt_staff_category_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT sc_name, if(sc_special = 1, 'Инженерно-технологическая', 'Рабочая') , sc_description FROM staff_categories";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[3]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();
                db_data[db_data.Count - 1][2] = reader[2].ToString();
               
            }
            reader.Close();

            dgv_show_info.ColumnCount = 5;
            dgv_show_info.Columns[0].HeaderText = "Название категории";
            dgv_show_info.Columns[0].Width = 200;
            dgv_show_info.Columns[1].HeaderText = "Специализация";
            dgv_show_info.Columns[1].Width = 150;
            dgv_show_info.Columns[2].HeaderText = "Описание категории";
            dgv_show_info.Columns[2].Width = 500;

            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }
    

        private void bt_brigad_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT br_name, em_surname  FROM brigade JOIN employees ON br_head = em_id";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[2]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();

            }
            reader.Close();

            dgv_show_info.ColumnCount = 2;
            dgv_show_info.Columns[0].HeaderText = "Название бригады";
            dgv_show_info.Columns[0].Width = 200;
            dgv_show_info.Columns[1].HeaderText = "Начальник бригады";
            dgv_show_info.Columns[1].Width = 150;

            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }

        private void bt_workshop_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT wr_name, ds_name, em_surname FROM workshop JOIN employees ON em_id = wr_head JOIN district ON ds_id = wr_district";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[3]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();
                db_data[db_data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            dgv_show_info.ColumnCount = 3;
            dgv_show_info.Columns[0].HeaderText = "Название Цеха";
            dgv_show_info.Columns[0].Width = 200;
            dgv_show_info.Columns[1].HeaderText = "Название Участка";
            dgv_show_info.Columns[1].Width = 150;
            dgv_show_info.Columns[2].HeaderText = "Начальник Цеха";
            dgv_show_info.Columns[2].Width = 150;

            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }

        private void bt_district_Click(object sender, EventArgs e)
        {
            dgv_show_info.Rows.Clear(); // очистка содержимого таблицы
            dgv_show_info.Columns.Clear(); // очистка столбцов

            string sql_request = "SELECT ds_name, br_name, em_surname FROM district JOIN brigade ON ds_brigade = br_id JOIN employees ON em_id = ds_head";

            List<string[]> db_data = new List<string[]>(); // массив для хранения данных запроса

            MySqlCommand request = new MySqlCommand(sql_request, obj_connection.connectDB); // передача sql запроса по данным из подключения
            MySqlDataReader reader = request.ExecuteReader(); // Сохранение всех данных, полученных в запросое, в объект

            while (reader.Read()) // вывод всех полученных данных в массив db_data
            {
                db_data.Add(new string[3]);
                db_data[db_data.Count - 1][0] = reader[0].ToString();
                db_data[db_data.Count - 1][1] = reader[1].ToString();
                db_data[db_data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            dgv_show_info.ColumnCount = 3;
            dgv_show_info.Columns[0].HeaderText = "Название Участка";
            dgv_show_info.Columns[0].Width = 200;
            dgv_show_info.Columns[1].HeaderText = "Название Бригады";
            dgv_show_info.Columns[1].Width = 150;
            dgv_show_info.Columns[2].HeaderText = "Начальник Участка";
            dgv_show_info.Columns[2].Width = 150;

            foreach (string[] s in db_data) // вывод данных из массива db_data в таблицу
                dgv_show_info.Rows.Add(s);
        }
    }
}
