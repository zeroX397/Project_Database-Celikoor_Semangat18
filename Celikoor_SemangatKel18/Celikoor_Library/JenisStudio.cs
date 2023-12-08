using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class JenisStudio
    {
        #region DATAMEMBERS
        private int id;
        private string nama;
        private string deskripsi;
        #endregion

        #region CONSTRUCTORS
        public JenisStudio()
        {
            Id = 0;
            Nama = "";
            Deskripsi = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region METHODS

        #endregion
    }
}
