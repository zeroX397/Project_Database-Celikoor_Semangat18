using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class Pegawai
    {
        #region Data Members
        private int id_Pegawai;
        private string nama_Pegawai;
        private string email_Pegawai;
        private string username_Pegawai;
        private string password_Pegawai;
        private string roles_Pegawai;
        #endregion

        #region Constructors
        public Pegawai(int id_Pegawai, string nama_Pegawai, string email_Pegawai, string username_Pegawai, string password_Pegawai, string roles_Pegawai)
        {
            Id_Pegawai = id_Pegawai;
            Nama_Pegawai = nama_Pegawai;
            Email_Pegawai = email_Pegawai;
            Username_Pegawai = username_Pegawai;
            Password_Pegawai = password_Pegawai;
            Roles_Pegawai = roles_Pegawai;
        }
        public Pegawai()
        {
            Id_Pegawai = 0;
            Nama_Pegawai = "";
            Email_Pegawai = "";
            Username_Pegawai = "";
            Password_Pegawai = "";
            Roles_Pegawai = "";
        }
        #endregion

        #region Properties
        public int Id_Pegawai { get => id_Pegawai; set => id_Pegawai = value; }
        public string Nama_Pegawai { get => nama_Pegawai; set => nama_Pegawai = value; }
        public string Email_Pegawai { get => email_Pegawai; set => email_Pegawai = value; }
        public string Username_Pegawai { get => username_Pegawai; set => username_Pegawai = value; }
        public string Password_Pegawai { get => password_Pegawai; set => password_Pegawai = value; }
        public string Roles_Pegawai { get => roles_Pegawai; set => roles_Pegawai = value; }
        #endregion

        #region METHODS
        public static void TambahData(Pegawai obj)
        {
            string sql = "INSERT INTO pegawais " + "(id, nama, email, username, password, roles) VALUES " + "('" + 
                obj.Id_Pegawai + "', '" +
                obj.Nama_Pegawai + "', '" +
                obj.Email_Pegawai + "', '" +
                obj.Username_Pegawai + "', '" +
                obj.Password_Pegawai + "', '" +
                obj.Roles_Pegawai + "');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }
        public static List<Pegawai> BacaData(string filter = "", string nilai = "")
        {
            string perintah;
            if (filter == "")
            {
                perintah = "SELECT * from pegawais";
            }
            else
            {
                perintah = "SELECT * from pegawais " +
                    "where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader drHasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Pegawai> listHasil = new List<Pegawai>();

            while (drHasil.Read() == true)//selama data reader masih ada isinya lakukan baca
            {
                Pegawai tampung = new Pegawai();
                /*Jabatan tampungPosisi = new Jabatan();

                tampungPosisi.Id = drHasil.GetValue(7).ToString();
                tampungPosisi.Nama = drHasil.GetValue(8).ToString();*/
                tampung.Id_Pegawai = int.Parse(drHasil.GetValue(0).ToString());
                tampung.Nama_Pegawai = drHasil.GetValue(1).ToString();
                tampung.Email_Pegawai= drHasil.GetValue(2).ToString();
                tampung.Username_Pegawai = drHasil.GetValue(3).ToString();
                tampung.Password_Pegawai = drHasil.GetValue(4).ToString();
                tampung.Roles_Pegawai = drHasil.GetValue(5).ToString();

                listHasil.Add(tampung);
            }
            return listHasil;
        }
<<<<<<< Updated upstream

        public static Pegawai Login(string username, string password)
        {
            string sql = "SELECT id, nama, email, username, password, roles FROM pegawais ";
            if (username == "" || password == "")
            {
                throw new Exception("Username atau password tidak boleh kosong");
            }
            else
            {
                sql += " WHERE username='" + username + "' and password='" + password + "';";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);
            Console.WriteLine(sql);

            Pegawai pegawaiHasil = new Pegawai();
            if (hasil.Read() == true)
            {

                pegawaiHasil.id_Pegawai = hasil.GetInt32(0);
                pegawaiHasil.nama_Pegawai = hasil.GetValue(1).ToString();
                pegawaiHasil.email_Pegawai = hasil.GetValue(2).ToString();
                pegawaiHasil.username_Pegawai = hasil.GetValue(3).ToString();
                pegawaiHasil.password_Pegawai = hasil.GetValue(4).ToString();
                pegawaiHasil.roles_Pegawai = hasil.GetValue(5).ToString();
                Console.WriteLine("Nama Pegawai:" + pegawaiHasil.nama_Pegawai);
                Console.WriteLine("Email Pegawai:" + pegawaiHasil.email_Pegawai);
                return pegawaiHasil;

            }
            return null;
        }
=======
>>>>>>> Stashed changes
        #endregion
    }
}
