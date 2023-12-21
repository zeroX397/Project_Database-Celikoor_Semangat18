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
<<<<<<< HEAD
                JenisStudio p = new JenisStudio();
              
                p.Nama= textBoxNama.Text;
                p.Deskripsi = textBoxDeskripsi.Text;
                

                //tambahkan ke database:
                JenisStudio.TambahData(p);
=======
                JenisStudio js = new JenisStudio();
                js.ID = int.Parse(textBoxId.Text);
                js.Nama = textBoxNama.Text;
                js.Deskripsi = textBoxDesc.Text;

                //tambahkan ke database:
                JenisStudio.TambahData(js);
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351

                MessageBox.Show("Tambah Data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data gagal. Error : " + ex.Message);
            }
        }
<<<<<<< HEAD

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

=======
    }
}
>>>>>>> f7001c78a3f210d37bcf9a968a260f743c38d351
