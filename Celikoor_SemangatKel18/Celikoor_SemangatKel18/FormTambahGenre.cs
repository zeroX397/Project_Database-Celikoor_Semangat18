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
    public partial class FormTambahGenre : Form
    {
        public FormTambahGenre()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Genre genre = new Genre();
                genre.Id_genre = int.Parse(textBoxId.Text);
                genre.Nama_genre = textBoxNama.Text;
                genre.Deskripsi_genre = textBoxDesc.Text;

                //tambahkan ke database:
                Genre.TambahData(genre);

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
