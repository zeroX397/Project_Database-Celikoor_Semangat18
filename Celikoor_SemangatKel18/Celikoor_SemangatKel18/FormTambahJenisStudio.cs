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
    public partial class FormTambahJenisStudio : Form
    {
        public FormTambahJenisStudio()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                JenisStudio js = new JenisStudio();
                js.ID = int.Parse(textBoxId.Text);
                js.Nama = textBoxNama.Text;
                js.Deskripsi = textBoxDesc.Text;

                //tambahkan ke database:
                JenisStudio.TambahData(js);

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
