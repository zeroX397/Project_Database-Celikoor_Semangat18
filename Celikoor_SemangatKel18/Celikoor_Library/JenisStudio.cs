using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class JenisStudio
    {
        private int id;
        private string nama;
        private string deskripsi;

        public JenisStudio()
        {
            Id = 0;
            Nama = "";
            Deskripsi = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
    }
}
