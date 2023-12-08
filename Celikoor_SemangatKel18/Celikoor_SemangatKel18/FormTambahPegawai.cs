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
    public partial class FormTambahPegawai : Form
    {
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Pegawai p = new Pegawai();
                p.Id_Pegawai = int.Parse(textBoxId.Text);
                p.Nama_Pegawai = textBoxNama.Text;
                p.Email_Pegawai = textBoxEmail.Text;
                p.Username_Pegawai = textBoxUsername.Text;
                p.Password_Pegawai = textBoxPassword.Text;
                p.Roles_Pegawai = comboBox1.Text;

                //tambahkan ke database:
                Pegawai.TambahData(p);

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
