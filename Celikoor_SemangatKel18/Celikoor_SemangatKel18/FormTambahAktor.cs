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
                p.Id_aktor = int.Parse(textBoxId.Text);
                p.Nama_aktor = textBoxNama.Text;
                p.Tgl_lahir_aktor = dateTimePickerTglLahir.Value;
                p.Gender_aktor = comboBox1.Text;
                p.Negara_asal_aktor = textBoxNegara.Text;

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
