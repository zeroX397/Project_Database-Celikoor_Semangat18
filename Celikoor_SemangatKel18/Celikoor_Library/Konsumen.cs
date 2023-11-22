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
            this.Id_Konsumen = id_Konsumen;
            this.Nama_Konsumen = nama_Konsumen;
            this.Email_Konsumen = email_Konsumen;
            this.NoHP_Konsumen = noHP_Konsumen;
            this.Gender_Konsumen = gender_Konsumen;
            this.Ttl_Konsumen = ttl_Konsumen;
            this.Saldo_Konsumen = saldo_Konsumen;
            this.Username_Konsumen = username_Konsumen;
            this.Password_Konsumen = password_Konsumen;
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

        private void Isi_Sendiri_YGY()
        {

        }
    }
}
