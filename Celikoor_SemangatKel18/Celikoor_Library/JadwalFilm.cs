using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class JadwalFilm
    {
        #region DATAMEMBERS
        private int id;
        private DateTime tanggal;
        private string jam_pemutaran;

        #endregion

        #region CONSTRUCTORS
        public JadwalFilm()
        {

        }

        public JadwalFilm(int id, DateTime tanggal, string jam_pemutaran)
        {
            this.id = id;
            this.tanggal = tanggal;
            this.jam_pemutaran = jam_pemutaran;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Jam_pemutaran { get => jam_pemutaran; set => jam_pemutaran = value; }
        #endregion

        #region METHODS
        public static List<JadwalFilm> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "SELECT * FROM jadwal_films";
            if (filter == "")
            {
                perintah += ";";
            }
            else
            {
                perintah += " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<JadwalFilm> listHasil = new List<JadwalFilm>();
            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                JadwalFilm tampung = new JadwalFilm();
                tampung.id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.tanggal = DateTime.Parse(drHasil.GetValue(1).ToString());
                tampung.jam_pemutaran = drHasil.GetValue(2).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(JadwalFilm g)
        {

        }
        
        public static void UbahData(int id_jadwal_film, JadwalFilm obj)
        {
        
        }

        public static void HapusData(int kode_hapus)
        {  
            
        }
        #endregion
    }
}
