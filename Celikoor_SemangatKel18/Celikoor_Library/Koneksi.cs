using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class Koneksi
    {
        private MySqlConnection DB_Connection;

        public MySqlConnection DB_Connection1 { get => DB_Connection; private set => DB_Connection = value; }
        public void Connect()
        {
            if (DB_Connection.State == System.Data.ConnectionState.Open)
            {
                DB_Connection.Close();
            }
            DB_Connection.Open();
        }

    }
}
