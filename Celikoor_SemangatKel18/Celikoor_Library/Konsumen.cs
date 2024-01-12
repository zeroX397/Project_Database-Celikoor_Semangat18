using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Library
{
    public class Konsumen
    {
        #region Data Members
        private int id_Konsumen;
        private string nama_Konsumen;
        private string email_Konsumen;
        private int noHP_Konsumen;
        private string gender_Konsumen;
        private DateTime ttl_Konsumen;
        private double saldo_Konsumen;
        private string username_Konsumen;
        private string password_Konsumen;
        #endregion

        #region Constructors
        public Konsumen(int id_Konsumen, string nama_Konsumen, string email_Konsumen, int noHP_Konsumen, string gender_Konsumen, 
            DateTime ttl_Konsumen, double saldo_Konsumen, string username_Konsumen, string password_Konsumen)
        {
            Id_Konsumen = id_Konsumen;
            Nama_Konsumen = nama_Konsumen;
            Email_Konsumen = email_Konsumen;
            NoHP_Konsumen = noHP_Konsumen;
            Gender_Konsumen = gender_Konsumen;
            Ttl_Konsumen = ttl_Konsumen;
            Saldo_Konsumen = saldo_Konsumen;
            Username_Konsumen = username_Konsumen;
            Password_Konsumen = password_Konsumen;
        }
        public Konsumen()
        {
            Id_Konsumen = 0;
            Nama_Konsumen = "";
            Email_Konsumen = "";
            NoHP_Konsumen = 0;
            Gender_Konsumen = "";
            Ttl_Konsumen = new DateTime();
            Saldo_Konsumen = 0;
            Username_Konsumen = "";
            Password_Konsumen = "";
        }

        //public Konsumen(int v1, string v2, string v3, string v4, string v5, object p)
        //{
        //    V1 = v1;
        //    V2 = v2;
        //    V3 = v3;
        //    V4 = v4;
        //    V5 = v5;
        //    P = p;
        //}
        #endregion

        #region Properties
        public int Id_Konsumen { get => id_Konsumen; set => id_Konsumen = value; }
        public string Nama_Konsumen { get => nama_Konsumen; set => nama_Konsumen = value; }
        public string Email_Konsumen { get => email_Konsumen; set => email_Konsumen = value; }
        public int NoHP_Konsumen { get => noHP_Konsumen; set => noHP_Konsumen = value; }
        public string Gender_Konsumen { get => gender_Konsumen; set => gender_Konsumen = value; }
        public DateTime Ttl_Konsumen { get => ttl_Konsumen; set => ttl_Konsumen = value; }
        public double Saldo_Konsumen { get => saldo_Konsumen; set => saldo_Konsumen = value; }
        public string Username_Konsumen { get => username_Konsumen; set => username_Konsumen = value; }
        public string Password_Konsumen { get => password_Konsumen; set => password_Konsumen = value; }
        #endregion

        #region METHODS
        public static void TambahData(Konsumen obj)
        {
            string sql = "INSERT INTO konsumens(nama, email, no_hp, gender, tgl_lahir, saldo, username, password) " + 
                "VALUES("+
                "'" + obj.Nama_Konsumen + "'," +
                "'" + obj.Email_Konsumen + "'," +
                "'" + obj.NoHP_Konsumen+ "'," +
                "'" + obj.Gender_Konsumen + "'," +
                "'" + obj.Ttl_Konsumen.ToString("yyyy-MM-dd") + "'," +
                "'" + obj.Saldo_Konsumen + "'," +
                "'" + obj.Username_Konsumen + "'," +
                "'" + obj.Password_Konsumen + "');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static List<Konsumen> BacaData(string kriteria = "", string nilaiKriteria = "")
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * from konsumens";
            }
            else
            {
                sql = "SELECT * from konsumens" + "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader result = Koneksi.JalankanPerintahSelect(sql);
            List<Konsumen> userList = new List<Konsumen>();

            while (result.Read() == true)
            {
                Konsumen tmp = new Konsumen();
                tmp.Id_Konsumen = int.Parse(result.GetValue(0).ToString());
                tmp.Nama_Konsumen = result.GetValue(1).ToString();
                tmp.Email_Konsumen = result.GetValue(2).ToString();
                tmp.NoHP_Konsumen = int.Parse(result.GetValue(3).ToString());
                tmp.Gender_Konsumen = result.GetValue(4).ToString();
                tmp.Ttl_Konsumen = DateTime.Parse(result.GetValue(5).ToString());
                tmp.Saldo_Konsumen = int.Parse(result.GetValue(6).ToString());
                tmp.Username_Konsumen = result.GetValue(7).ToString();
                tmp.Password_Konsumen = result.GetValue(8).ToString();
                userList.Add(tmp);
            }
            return userList;
        }
        public static void UbahData(Konsumen obj)
        {   //password tdk boleh diubah melalui method ini
            string perintah = "UPDATE konsumens SET " +
                    "Nama='" + obj.Nama_Konsumen + "', " +
                    "email='" + obj.Email_Konsumen + "', " +
                    "no_hp='" + obj.NoHP_Konsumen + "', " +
                    "gender='" + obj.Gender_Konsumen + "', " +
                    "tgl_lahir='" + obj.Ttl_Konsumen + "', " +
                    "saldo='" + obj.Saldo_Konsumen + "' " +
                    "username='" + obj.Username_Konsumen + "' " +
                    "password='" + obj.Password_Konsumen + "')";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void HapusData(string KodeHapus)
        {   //susun perintah query
            string perintah = "delete from konsumens where id='" + KodeHapus + "';";

            Koneksi.JalankanPerintahNonQuery(perintah); //kirim ke command
        }

        public static Konsumen Login(string username, string password)
        {
            string sql = "SELECT * FROM konsumens ";
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

            Konsumen konsumenHasil = new Konsumen();
            if (hasil.Read() == true)
            {

                konsumenHasil.Id_Konsumen = hasil.GetInt32(0);
                konsumenHasil.Nama_Konsumen = hasil.GetValue(1).ToString();
                konsumenHasil.Email_Konsumen = hasil.GetValue(2).ToString();
                konsumenHasil.NoHP_Konsumen = int.Parse(hasil.GetValue(3).ToString());
                konsumenHasil.Gender_Konsumen = hasil.GetValue(4).ToString();
                konsumenHasil.Ttl_Konsumen = DateTime.Parse(hasil.GetValue(5).ToString());
                konsumenHasil.Saldo_Konsumen = int.Parse(hasil.GetValue(6).ToString());
                konsumenHasil.Username_Konsumen = hasil.GetValue(7).ToString();
                konsumenHasil.Password_Konsumen = hasil.GetValue(8).ToString();
                return konsumenHasil;

            }
            return null;
        }

        #endregion

    }
}
