using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Kelompok
    {
        #region DATAMEMBERS
        private int id;
        private string nama;
        #endregion

        #region CONSTRUCTORS
        public Kelompok(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        public Kelompok()
        {
            Id = 0;
            Nama = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region METHODS
        public static void TambahData()
        {

        }
        #endregion
    }
}
