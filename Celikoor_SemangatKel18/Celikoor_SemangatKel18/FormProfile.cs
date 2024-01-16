using Celikoor_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Semangat18
{
    public partial class FormProfile : Form
    {
        public FormProfile(Konsumen konsumenLogin)
        {
            InitializeComponent();
            textIdKnonsumen.Text = konsumenLogin.Id_Konsumen.ToString();
            textNama.Text = konsumenLogin.Nama_Konsumen;
            textEmail.Text = konsumenLogin.Email_Konsumen;
            textNoHP.Text = konsumenLogin.NoHP_Konsumen;
            textGender.Text = konsumenLogin.Gender_Konsumen == "L" ? "Laki-Laki" : "Perempuan";
            textTTL.Text = konsumenLogin.Ttl_Konsumen.ToString("yyyy-MM-dd");
            textSaldo.Text = konsumenLogin.Saldo_Konsumen.ToString();
            textUsername.Text = konsumenLogin.Username_Konsumen;
            textPassword.Text = konsumenLogin.Password_Konsumen;
        }
    }
}
