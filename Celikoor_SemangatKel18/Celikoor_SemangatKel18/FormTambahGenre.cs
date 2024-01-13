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
        private bool isTambah = true;
        private Genre genreUpdate;
        public FormTambahGenre()
        {
            InitializeComponent();
        }
        public FormTambahGenre(Genre genreUpdate)
        {
            InitializeComponent();
            isTambah = false;
            this.genreUpdate = genreUpdate;

            textBoxId.Text = genreUpdate.Id_genre.ToString();
            textBoxNama.Text = genreUpdate.Nama_genre;
            textBoxDesc.Text = genreUpdate.Deskripsi_genre;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Genre genre = new Genre();
                genre.Nama_genre = textBoxNama.Text;
                genre.Deskripsi_genre = textBoxDesc.Text;

                //tambahkan ke database:
                if (isTambah)
                {
                    Genre.TambahData(genre);
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    Genre.UbahData(genreUpdate.Id_genre, genre);
                    MessageBox.Show("Ubah Data berhasil");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data gagal. Error : " + ex.Message);
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
