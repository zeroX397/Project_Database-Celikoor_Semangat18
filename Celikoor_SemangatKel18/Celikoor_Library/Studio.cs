using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Studio
    {
        #region DATAMEMBERS
        private int id;
        private string nama;
        private int kapasitas;
        private int jenis_studio_id;
        private int cinema_id;
        private int harga_weekday;
        private int harga_weekend;

    
        #endregion

        #region CONSTRUCTORS

        public Studio()
        {
            Id = 0;
            Nama = "";
            Kapasitas = 0;
            Jenis_studio_id = 0;
            Cinema_id = 0;
            Harga_weekday = 0;
            Harga_weekend = 0;
        }

        public Studio(int id, string nama, int kapasitas, int jenis_studio_id, int cinema_id, int harga_weekday, int harga_weekend)
        {
            this.Id = id;
            this.Nama = nama;
            this.Kapasitas = kapasitas;
            this.Jenis_studio_id = jenis_studio_id;
            this.Cinema_id = cinema_id;
            this.Harga_weekday = harga_weekday;
            this.Harga_weekend = harga_weekend;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public int Jenis_studio_id { get => jenis_studio_id; set => jenis_studio_id = value; }
        public int Cinema_id { get => cinema_id; set => cinema_id = value; }
        public int Harga_weekday { get => harga_weekday; set => harga_weekday = value; }
        public int Harga_weekend { get => harga_weekend; set => harga_weekend = value; }
        #endregion

        #region METHODS
        public static void TambahData(Studio obj)
        {
            //something new: 
            //obj.Tgllahir.ToString("YYYY-MM-dd") --> unt mengubah ke format yang diterima oleh mysql
            //obj.Posisi.Id --> mengambil ID dari posisi yang dimiliki oleh pegawai

            string perintah = "INSERT INTO studios " +
                " nama, kapasitas, jenis_studio_id, cinema_id, harga_weekday, harga_weekend) VALUES " + 
                "('" + obj.Nama + "', '" + obj.kapasitas + "', '" + obj.jenis_studio_id + "', '" +
                    obj.cinema_id + "', '" + obj.harga_weekday + "', '" + obj.harga_weekend + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static void HapusData(int KodeHapus)
        {
            string perintah = "DELETE FROM studios WHERE id = '" + KodeHapus.ToString() + "';";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        public static List<Studio> BacaData()
        {
            string perintah = "SELECT * from studios";
            //if (filter != "")
            //    perintah = " " +
            //        "where " + filter + " like '%" + nilai + "%'";

            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Studio> listHasil = new List<Studio>();
            while (drHasil.Read() == true) //selama data reader masih ada isinya, lakukan baca
            {
                //pindah isi datareader ke penampung sementara
                Studio tampung = new Studio();
                tampung.Id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.nama = drHasil.GetValue(1).ToString();
                tampung.kapasitas = int.Parse(drHasil.GetValue(2).ToString());
                tampung.jenis_studio_id = int.Parse(drHasil.GetValue(3).ToString());
                tampung.cinema_id = int.Parse(drHasil.GetValue(4).ToString());
                tampung.harga_weekday = int.Parse(drHasil.GetValue(5).ToString());
                tampung.harga_weekend = int.Parse(drHasil.GetValue(6).ToString());
                listHasil.Add(tampung);
            }
            return listHasil;
        }
        #endregion
    }
}
