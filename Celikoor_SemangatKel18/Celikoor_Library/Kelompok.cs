using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Kelompok
    {
        private int id;
        private string nama;

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
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public static void TambahData()
        {

        }
    }
}
