using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class Aktor
    {
        private int id_aktor;
        private string nama_aktor;
        private DateTime tgl_lahir_aktor;
        private string gender_aktor;
        private string negara_asal_aktor;

        public Aktor()
        {
            Id_aktor = 0;
            Nama_aktor = "";
            Tgl_lahir_aktor = DateTime.Now;
            Gender_aktor = "";
            Negara_asal_aktor = "";
        }


        public int Id_aktor { get => id_aktor; set => id_aktor = value; }
        public string Nama_aktor { get => nama_aktor; set => nama_aktor = value; }
        public DateTime Tgl_lahir_aktor { get => tgl_lahir_aktor; set => tgl_lahir_aktor = value; }
        public string Gender_aktor { get => gender_aktor; set => gender_aktor = value; }
        public string Negara_asal_aktor { get => negara_asal_aktor; set => negara_asal_aktor = value; }

        

        public static List<Aktor> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "SELECT * from aktors";
            }
            else
            {
                perintah = "SELECT * from aktors " +
                    "where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Aktor> listHasil = new List<Aktor>();

            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                Aktor tampung = new Aktor();
                
                tampung.Id_aktor = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama_aktor = drHasil.GetValue(1).ToString();
                tampung.Tgl_lahir_aktor = DateTime.Parse(drHasil.GetValue(2).ToString());
                tampung.Gender_aktor = drHasil.GetValue(3).ToString();
                tampung.Negara_asal_aktor = drHasil.GetValue(4).ToString();

                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(Aktor obj)
        {
            string sql = "INSERT INTO aktors " + "(id, nama, tgl_lahir, gender, negara_asal) VALUES " + "('" + 
                obj.Id_aktor + "', '" + 
                obj.Nama_aktor + "', '" +
                obj.Tgl_lahir_aktor.ToString("yyyy-MM-dd") + "', '" + 
                obj.Gender_aktor + "', '" + 
                obj.Negara_asal_aktor + "');";

            Koneksi.JalankanPerintahNonQuery(sql);
        }
    }
}
