using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_Library;

namespace Celikoor_Semangat18
{
    public partial class FormTambahAktor : Form
    {
        public FormTambahAktor()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Aktor p = new Aktor();
                p.Id_Aktor = int.Parse(textBoxId.Text);
                p.Nama_Aktor = textBoxNama.Text;
                p.Tgl_lahir_Aktor= dateTimePickerTglLahir.Value.ToString("yyyy-MM-dd");
                p.Gender_Aktor = comboBox1.Text;
                p.Negara_asal_Aktor= textBoxNegara.Text;

                //tambahkan ke database:
                Aktor.TambahData(p);

                MessageBox.Show("Tambah Data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data gagal. Error : " + ex.Message);
            }
        }
    }
}
