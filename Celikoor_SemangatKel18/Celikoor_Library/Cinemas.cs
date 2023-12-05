using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_Library
{
    public class Cinemas
    {
        #region Data Members
        private string idcinema;
        private string namacabang;
        private string alamat;
        private string tglbuka;
        private string kota;

        public Cinemas(string idcinema, string namacabang, string alamat, string tglbuka, string kota)
        {
            this.Idcinema = idcinema;
            this.Namacabang = namacabang;
            this.Alamat = alamat;
            this.Tglbuka = tglbuka;
            this.Kota = kota;
        }

        public string Idcinema { get => idcinema; set => idcinema = value; }
        public string Namacabang { get => namacabang; set => namacabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Tglbuka { get => tglbuka; set => tglbuka = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion
    }
}
