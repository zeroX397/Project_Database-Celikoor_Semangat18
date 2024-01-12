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
    public partial class FormTambahKonsumen : Form
    {
        public FormTambahKonsumen()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Konsumen k = new Konsumen();
               
                k.Nama_Konsumen = textBoxNama.Text;
                k.NoHP_Konsumen = int.Parse(textBoxNoHP.Text);
                k.Email_Konsumen = textBoxEmail.Text;
                k.Ttl_Konsumen = dateTimePicker1.Value;
                k.Gender_Konsumen = textBoxGender.Text.ToUpper();
                k.Username_Konsumen = textBoxUsername.Text;
                k.Password_Konsumen = textBoxPass.Text;
               

                //tambahkan ke database:
                Konsumen.TambahData(k);

                MessageBox.Show("Tambah Data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data gagal. Error : " + ex.Message);
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
