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
        private string noHP_Konsumen;
        private string gender_Konsumen;
        private DateTime ttl_Konsumen;
        private double saldo_Konsumen;
        private string username_Konsumen;
        private string password_Konsumen;
        #endregion

        #region Constructors
        public Konsumen(int id_Konsumen, string nama_Konsumen, string email_Konsumen, string noHP_Konsumen, string gender_Konsumen, 
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
            NoHP_Konsumen = "";
            Gender_Konsumen = "";
            Ttl_Konsumen = DateTime.Now;
            Saldo_Konsumen = 0;
            Username_Konsumen = "";
            Password_Konsumen = "";
        }
        #endregion

        #region Properties
        public int Id_Konsumen { get => id_Konsumen; set => id_Konsumen = value; }
        public string Nama_Konsumen { get => nama_Konsumen; set => nama_Konsumen = value; }
        public string Email_Konsumen { get => email_Konsumen; set => email_Konsumen = value; }
        public string NoHP_Konsumen { get => noHP_Konsumen; set => noHP_Konsumen = value; }
        public string Gender_Konsumen { get => gender_Konsumen; set => gender_Konsumen = value; }
        public DateTime Ttl_Konsumen { get => ttl_Konsumen; set => ttl_Konsumen = value; }
        public double Saldo_Konsumen { get => saldo_Konsumen; set => saldo_Konsumen = value; }
        public string Username_Konsumen { get => username_Konsumen; set => username_Konsumen = value; }
        public string Password_Konsumen { get => password_Konsumen; set => password_Konsumen = value; }
        #endregion

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
        public static void BacaData(Konsumen obj)
        {
            string sql = "SELECT * FROM konsumens;";

            Koneksi.JalankanPerintahSelect(sql);
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
        
    }
}
