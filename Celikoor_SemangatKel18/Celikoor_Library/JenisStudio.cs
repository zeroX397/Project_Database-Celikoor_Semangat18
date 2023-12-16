using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celikoor_Library;
using MySql.Data.MySqlClient;

namespace Celikoor_Semangat18
{
    public class JenisStudio
    {
        private int id;
        private string nama;
        private string deskripsi;

        public int ID { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        public JenisStudio()
        {
            ID = 0;
            Nama = "";
            Deskripsi = "";
        }

        public JenisStudio(int id, string nama, string deskripsi)
        {
            this.id = id;
            this.nama = nama;
            this.deskripsi = deskripsi;
        }

        public static List<JenisStudio> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "SELECT * from jenis_studios";
            }
            else
            {
                perintah = "SELECT * from jenis_studios " +
                    "where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<JenisStudio> listHasil = new List<JenisStudio>();
            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                //JenisStudio tampung = new JenisStudio();
                int tampungId = int.Parse(drHasil.GetValue(0).ToString());
                string tampungNama = drHasil.GetValue(1).ToString();
                string tampungdesc = drHasil.GetValue(2).ToString();
                JenisStudio tampung = new JenisStudio(tampungId, tampungNama, tampungdesc);
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(JenisStudio jenstud)
        {
            string perintah;
            if (jenstud.Deskripsi != null)
            {
                perintah = "INSERT INTO jenis_studios" + "(id, nama, deskripsi) VALUES " + "('" + jenstud.ID + "', '" + jenstud.Nama + "', '" + jenstud.Deskripsi + "');";
            }
            else
            {
                perintah = "INSERT INTO jenis_studios" + "(id, nama) VALUES " + "('" + jenstud.ID + "', '" + jenstud.Nama + "');";
            }

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void HapusData(string KodeHapus)
        {   //susun perintah query
            string perintah = "delete from jenis_studios where id='" + KodeHapus + "';";

            Koneksi.JalankanPerintahNonQuery(perintah); //kirim ke command
        }
    }
}
