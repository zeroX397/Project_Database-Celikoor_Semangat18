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
            Ttl_Konsumen = new DateTime();
            Saldo_Konsumen = 0;
            Username_Konsumen = "";
            Password_Konsumen = "";
        }
<<<<<<< HEAD
=======

        //public Konsumen(int v1, string v2, string v3, string v4, string v5, object p)
        //{
        //    V1 = v1;
        //    V2 = v2;
        //    V3 = v3;
        //    V4 = v4;
        //    V5 = v5;
        //    P = p;
        //}
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
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

<<<<<<< HEAD
        public static List<Konsumen> BacaData()
        {
            string sql = "SELECT id, nama, email, no_hp,gender,tgl_lahir, saldo, username, password" +
                " FROM konsumens ";
            //if (kriteria == "")
            //{
            //    sql += ";";
            //}
            //else
            //{
            //    sql += " WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%';";
            //}
=======
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
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
            MySqlDataReader result = Koneksi.JalankanPerintahSelect(sql);
            List<Konsumen> userList = new List<Konsumen>();

            while (result.Read() == true)
            {
                Konsumen tmp = new Konsumen();
                tmp.Id_Konsumen = int.Parse(result.GetValue(0).ToString());
                tmp.Nama_Konsumen = result.GetValue(1).ToString();
                tmp.Email_Konsumen = result.GetValue(2).ToString();
                tmp.NoHP_Konsumen = result.GetValue(3).ToString();
<<<<<<< HEAD
                tmp.gender_Konsumen = result.GetValue(4).ToString();
                tmp.Ttl_Konsumen = (DateTime)result.GetValue(5);
                tmp.saldo_Konsumen = int.Parse(result.GetValue(6).ToString());
                tmp.username_Konsumen = result.GetValue(7).ToString();
                tmp.password_Konsumen = result.GetValue(8).ToString();
=======
                tmp.Gender_Konsumen = result.GetValue(4).ToString();
                tmp.Ttl_Konsumen = result.GetValue(5).ToString();
                tmp.Saldo_Konsumen = int.Parse(result.GetValue(6).ToString());
                tmp.Username_Konsumen = result.GetValue(7).ToString();
                tmp.Password_Konsumen = result.GetValue(8).ToString();
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
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

        //public static void HapusData(string KodeHapus)
        //{   //susun perintah query
        //    string perintah = "delete from konsumens where id='" + KodeHapus + "';";

        //    Koneksi.JalankanPerintahNonQuery(perintah); //kirim ke command
        //}

        #endregion

    }
}
