using System;
using System.Collections.Generic;
using System.Configuration;
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
        public Koneksi(string pServer, int pPort, string pDb, string pUID, string pPWD)
        {
            string vConnString = "Server=" + pServer + ";Port=" + pPort + ";Database=" + pDb + ";Uid=" + pUID + ";Pwd=" + pPWD + ";";

            DB_Connection = new MySqlConnection();
            DB_Connection.ConnectionString = vConnString;

            Connect();
        }
        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSettings"];
            var settingSection = userSetting.Sections["Celikoor_Semangat18.connect"] as ClientSettingsSection; 
            string vServer = settingSection.Settings.Get("dbServer").Value.ValueXml.InnerText;
            int vPort = int.Parse(settingSection.Settings.Get("dbPort").Value.ValueXml.InnerText);
            string vDb = settingSection.Settings.Get("dbName").Value.ValueXml.InnerText;
            string vUID = settingSection.Settings.Get("dbUsername").Value.ValueXml.InnerText;
            string vPWD = settingSection.Settings.Get("dbPassword").Value.ValueXml.InnerText;

            string vConnString = "Server=" + vServer + ";Port=" + vPort + ";Database=" + vDb + ";Uid=" + vUID + ";Pwd=" + vPWD + ";";

            DB_Connection = new MySqlConnection();
            DB_Connection.ConnectionString = vConnString;

            Connect();
        }
        public static MySqlDataReader JalankanPerintahSelect(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand cmd = new MySqlCommand(sql, k.DB_Connection);
            MySqlDataReader hasil = cmd.ExecuteReader();
            return hasil;
        }

        public static void JalankanPerintahNonQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand cmd = new MySqlCommand(sql, k.DB_Connection);
            cmd.ExecuteNonQuery();
        }

        public static MySqlDataReader AmbilData(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.DB_Connection);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }
    }
}
