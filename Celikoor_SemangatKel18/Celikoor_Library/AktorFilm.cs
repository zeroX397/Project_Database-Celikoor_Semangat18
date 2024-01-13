using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class AktorFilm
    {
        #region DATAMEMBERS
        private int aktors_id;
        private string aktors_nama;
        private int films_id;
        private string films_judul;
        private string peran;

        #endregion

        #region CONSTRUCTORS
        public AktorFilm()
        {

        }

        public AktorFilm(int aktors_id, string aktors_nama, int films_id, string films_judul, string peran)
        {
            this.Aktors_id = aktors_id;
            this.Aktors_nama = aktors_nama;
            this.Films_id = films_id;
            this.Films_judul = films_judul;
            this.Peran = peran;
        }
        #endregion

        #region PROPERTIES
        public int Aktors_id { get => aktors_id; set => aktors_id = value; }
        public string Aktors_nama { get => aktors_nama; set => aktors_nama = value; }
        public int Films_id { get => films_id; set => films_id = value; }
        public string Films_judul { get => films_judul; set => films_judul = value; }
        public string Peran { get => peran; set => peran = value; }
        #endregion

        #region METHODS
        public static List<AktorFilm> BacaData(string filter = "", string nilai = "")
        {
            string perintah = "SELECT af.*, a.nama, f.judul FROM aktor_film af INNER JOIN aktors a ON af.aktors_id = a.id INNER JOIN films f ON af.films_id = f.id";
            if (filter == "")
            {
                perintah += ";";
            }
            else
            {
                perintah += " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<AktorFilm> listHasil = new List<AktorFilm>();
            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                AktorFilm tampung = new AktorFilm();
                tampung.aktors_id = int.Parse(drHasil.GetValue(0).ToString());
                tampung.films_id = int.Parse(drHasil.GetValue(1).ToString());
                tampung.peran = drHasil.GetValue(2).ToString();
                tampung.aktors_nama = drHasil.GetValue(3).ToString();
                tampung.Films_judul = drHasil.GetValue(4).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahData(AktorFilm g)
        {

        }
        
        public static void UbahData(int id_aktor, int id_film, AktorFilm obj)
        {
        
        }

        public static void HapusData(int id_aktor, int id_film)
        {  
            
        }
        #endregion
    }
}
