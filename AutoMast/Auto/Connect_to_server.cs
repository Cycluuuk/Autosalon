using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Auto
{
    class Connect_to_server
    {
        public static string connection = "server=127.0.0.1;user=root;database=mydb;port=3306;password=qwert12;";        //данные по подключению к бд
        public MySqlConnection connectDB = new MySqlConnection(connection);
    }
}
