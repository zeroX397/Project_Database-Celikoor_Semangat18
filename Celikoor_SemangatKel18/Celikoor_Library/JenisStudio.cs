using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_Semangat18
{
    public class JenisStudio
    {


        private int iD;
        private string nama;
        private int kapasitas;

        public int ID { get => iD; set => iD = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }

        public JenisStudio(int iD, string nama, int kapasitas)
        {
            ID = iD;
            Nama = nama;
            Kapasitas = kapasitas;
        }


    }
}
