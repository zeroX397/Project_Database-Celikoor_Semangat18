using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Aktor
    {
        #region DATAMEMBERS
        private int id_Aktor;
        private string nama_Aktor;
        private DateTime tgl_lahir_Aktor;
        private string gender_Aktor;
        private string negara_asal_Aktor;
        //private string filmography;//histori aktor main di film apa

        #endregion

        #region CONSTRUCTOR
        public Aktor(int id_Aktor, string nama_Aktor, DateTime tgl_lahir_Aktor, string gender_Aktor, string negara_asal_Aktor, string filmography)
        {
            this.id_Aktor = id_Aktor;
            this.nama_Aktor = nama_Aktor;
            this.tgl_lahir_Aktor = tgl_lahir_Aktor;
            this.gender_Aktor = gender_Aktor;
            this.negara_asal_Aktor = negara_asal_Aktor;
            //this.filmography = filmography;
        }

        public Aktor()
        {
            this.id_Aktor = 0;
            this.nama_Aktor = "";
            this.tgl_lahir_Aktor = DateTime.Now;
            this.gender_Aktor = "";
            this.negara_asal_Aktor = "";
            //this.filmography = "";

        }

        #endregion

        #region PROPERTIES
        public int Id_Aktor { get => id_Aktor; set => id_Aktor = value; }
        public string Nama_Aktor { get => nama_Aktor; set => nama_Aktor = value; }
        public DateTime Tgl_lahir_Aktor { get => tgl_lahir_Aktor; set => tgl_lahir_Aktor = value; }
        public string Gender_Aktor { get => gender_Aktor; set => gender_Aktor = value; }
        public string Negara_asal_Aktor { get => negara_asal_Aktor; set => negara_asal_Aktor = value; }
        //public string Filmography { get => filmography; set => filmography = value; }
        #endregion

        #region METHODS
        public static void TambahData(Aktor obj)
        {
            string sql = "INSERT INTO aktors " + "( nama, tgl_lahir, gender, negara_asal) VALUES " + "('" +
                obj.nama_Aktor + "', '" +
                obj.tgl_lahir_Aktor.ToString("yyyy-MM-dd") + "', '" +
                obj.gender_Aktor + "', '" +
                obj.negara_asal_Aktor + "');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

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

                tampung.id_Aktor = int.Parse(drHasil.GetValue(0).ToString());
                tampung.nama_Aktor = drHasil.GetValue(1).ToString();
                tampung.tgl_lahir_Aktor = Convert.ToDateTime(drHasil.GetValue(2));
                tampung.gender_Aktor = drHasil.GetValue(3).ToString();
                tampung.Negara_asal_Aktor = drHasil.GetValue(4).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void HapusData(string KodeHapus)
        {   //susun perintah query
            string perintah = "delete from aktors where id='" + KodeHapus + "';";

            Koneksi.JalankanPerintahNonQuery(perintah); //kirim ke command
        }

        public static void UbahData(int id_aktor, Aktor obj)
        {
            string sql = "UPDATE aktors " +
                $"SET nama = '{obj.nama_Aktor}', " +
                $"tgl_lahir = '{obj.tgl_lahir_Aktor.ToString("yyyy-MM-dd")}', " +
                $"gender = '{obj.gender_Aktor}', " +
                $"negara_asal = '{obj.negara_asal_Aktor}' " +
                $"WHERE id = '{id_aktor}';";
            Console.WriteLine(sql);
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        #endregion
    }
}
