using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    class Aktors
    {
        private string idaktor;
        private string nama;
        private string tgllahir;
        private string gender;
        private string asal;

        public Aktors(string idaktor, string nama, string tgllahir, string gender, string asal)
        {
            this.Idaktor = idaktor;
            this.Nama = nama;
            this.Tgllahir = tgllahir;
            this.Gender = gender;
            this.Asal = asal;
        }

        public string Idaktor { get => idaktor; set => idaktor = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Tgllahir { get => tgllahir; set => tgllahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Asal { get => asal; set => asal = value; }
    }
}
