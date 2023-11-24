using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Studios
    {
        #region Data Members
        private string idstudio;
        private string nama;
        private string kapasitas;

        public Studios(string idstudio, string nama, string kapasitas)
        {
            this.Idstudio = idstudio;
            this.Nama = nama;
            this.Kapasitas = kapasitas;
        }

        public string Idstudio { get => idstudio; set => idstudio = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Kapasitas { get => kapasitas; set => kapasitas = value; }
        #endregion
    }
}
