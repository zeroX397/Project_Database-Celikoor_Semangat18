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
        private bool isTambah = true;
        private JenisStudio jenisStudioUpdate;
        public FormTambahJenisStudio()
        {
            InitializeComponent();
        }
        public FormTambahJenisStudio(JenisStudio jenisStudioUpdate)
        {
            InitializeComponent();
            isTambah = false;
            this.jenisStudioUpdate = jenisStudioUpdate;

            label2.Text = "UBAH JENIS STUDIO";
            textBoxId.Text = jenisStudioUpdate.ID.ToString();
            textBoxNama.Text = jenisStudioUpdate.Nama;
            textBoxDeskripsi.Text = jenisStudioUpdate.Deskripsi;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                JenisStudio p = new JenisStudio();

                p.Nama= textBoxNama.Text;
                p.Deskripsi = textBoxDeskripsi.Text;
                

                //tambahkan ke database:
                if (isTambah)
                {
                    JenisStudio.TambahData(p);;
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    JenisStudio.UbahData(jenisStudioUpdate.ID, p);
                    MessageBox.Show("Ubah Data berhasil");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah/Ubah Data gagal. Error : " + ex.Message);
            }
        }
        private void buttonBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}