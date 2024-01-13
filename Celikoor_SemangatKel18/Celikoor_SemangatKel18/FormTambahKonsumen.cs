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
        private bool isTambah = true;
        private Konsumen konsumenUpdate;
        public FormTambahKonsumen()
        {
            InitializeComponent();
        }
        public FormTambahKonsumen(Konsumen konsumenUpdate)
        {
            InitializeComponent();
            isTambah = false;
            this.konsumenUpdate = konsumenUpdate;

            textBoxNama.Text = konsumenUpdate.Nama_Konsumen;
            textBoxNoHP.Text = konsumenUpdate.NoHP_Konsumen;
            textBoxEmail.Text = konsumenUpdate.Email_Konsumen;
            dateTimePicker1.Value = konsumenUpdate.Ttl_Konsumen;
            textBoxGender.Text = konsumenUpdate.Gender_Konsumen.ToUpper();
            textBoxUsername.Text = konsumenUpdate.Username_Konsumen;
            textBoxPass.Text = konsumenUpdate.Password_Konsumen;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Konsumen k = new Konsumen();
               
                k.Nama_Konsumen = textBoxNama.Text;
                k.NoHP_Konsumen = textBoxNoHP.Text;
                k.Email_Konsumen = textBoxEmail.Text;
                k.Ttl_Konsumen = dateTimePicker1.Value;
                k.Gender_Konsumen = textBoxGender.Text.ToUpper();
                k.Username_Konsumen = textBoxUsername.Text;
                k.Password_Konsumen = textBoxPass.Text;
               

                //tambahkan ke database:
                if (isTambah)
                {
                    Konsumen.TambahData(k);
                    MessageBox.Show("Tambah Data berhasil");
                } else
                {
                    Konsumen.UbahData(konsumenUpdate.Id_Konsumen, k);
                    MessageBox.Show("Ubah Data berhasil");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah/Ubah Data gagal. Error : " + ex.Message);
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahKonsumen_Load(object sender, EventArgs e)
        {

        }
    }
}
