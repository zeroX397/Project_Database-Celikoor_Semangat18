using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Cinema
    {
        #region DATAMEMBERS
        private int id;
        private string nama_cabang;
        private string alamat;
        private DateTime tgl_buka;
        private string kota;
        #endregion

        #region CONSTRUCTORS
        public Cinema(int id, string nama_cabang, string alamat, DateTime tgl_buka, string kota)
        {
            Id = id;
            Nama_cabang = nama_cabang;
            Alamat = alamat;
            Tgl_buka = tgl_buka;
            Kota = kota;
        }
        public Cinema()
        {
            Id = 0;
            Nama_cabang = "";
            Alamat = "";
            Tgl_buka = DateTime.Now;
            Kota = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama_cabang { get => nama_cabang; set => nama_cabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime Tgl_buka { get => tgl_buka; set => tgl_buka = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion

        #region METHODS
        public static void TambahData(Cinema obj)
        {
            //something new: 
            //obj.Tgllahir.ToString("YYYY-MM-dd") --> unt mengubah ke format yang diterima oleh mysql
            //obj.Posisi.Id --> mengambil ID dari posisi yang dimiliki oleh pegawai

            string perintah = "INSERT INTO cinemas " +
                "(nama_cabang, alamat, tgl_dibuka, kota) VALUES " + "('" 
                   + obj.Nama_cabang + "', '" + obj.Alamat + "', '" + obj.Tgl_buka.ToString("yyyy-MM-dd") + "', '" +
                    obj.Kota + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void UbahData(int id_cinema, Cinema obj)
        {
            string sql = "UPDATE cinemas " +
                $"SET nama_cabang = '{obj.nama_cabang}', " +
                $"alamat = '{obj.alamat}', " +
                $"tgl_dibuka = '{obj.Tgl_buka.ToString("yyyy-MM-dd")}', " +
                $"kota = '{obj.Kota}' " +
                $"WHERE id = '{id_cinema}';";
            Console.WriteLine(sql);
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static void HapusData(int KodeHapus)
        {
            string perintah = "DELETE FROM cinemas WHERE id = '" + KodeHapus.ToString() + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Cinema> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
                perintah = "SELECT * from cinemas";
            else
                perintah = "SELECT * from cinemas " +
                    "where " + filter + " like '%" + nilai + "%'";

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Cinema> listHasil = new List<Cinema>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                //pindah isi datareader ke penampung sementara
                Cinema tampung = new Cinema();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama_cabang = drHasil.GetValue(1).ToString();
                tampung.Alamat = drHasil.GetValue(2).ToString();
                tampung.Tgl_buka = drHasil.IsDBNull(3) ? DateTime.MinValue : Convert.ToDateTime(drHasil.GetValue(3));
                tampung.Kota = drHasil.GetValue(4).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void HapusData(string KodeHapus)
        {   //susun perintah query
            string perintah = "delete from cinemas where id='" + KodeHapus + "';";

            Koneksi.JalankanPerintahNonQuery(perintah); //kirim ke command
        }
        #endregion
    }
}
