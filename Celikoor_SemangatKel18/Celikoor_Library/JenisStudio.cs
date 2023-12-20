using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class JenisStudio
    {


        private int iD;
        private string nama;
        private string deskripsi;

        public int ID { get => iD; set => iD = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

       public JenisStudio()
        {
            ID = 0;
            Nama = "";
            Deskripsi = "";
        }

        public static void TambahData(JenisStudio obj)
        {
            //something new: 
            //obj.Tgllahir.ToString("YYYY-MM-dd") --> unt mengubah ke format yang diterima oleh mysql
            //obj.Posisi.Id --> mengambil ID dari posisi yang dimiliki oleh pegawai

            string perintah = "INSERT INTO jenis_studios " +
                "( nama, deskripsi) VALUES " +
                "('" + obj.Nama + "', '" + obj.deskripsi + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(int KodeHapus)
        { 
            string perintah = "DELETE FROM jenis_studios WHERE id = '" + KodeHapus.ToString() + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<JenisStudio> BacaData()
        {
            string perintah = "SELECT * from cinemas";
            //if (filter != "")
            //    perintah = " " +
            //        "where " + filter + " like '%" + nilai + "%'";

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<JenisStudio> listHasil = new List<JenisStudio>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                //pindah isi datareader ke penampung sementara
                JenisStudio tampung = new JenisStudio();
                tampung.iD = int.Parse(drHasil.GetValue(0).ToString());
                tampung.nama = drHasil.GetValue(1).ToString();
                tampung.Deskripsi = drHasil.GetValue(2).ToString();

                listHasil.Add(tampung);
            }
            return listHasil;

        }
    }
}
