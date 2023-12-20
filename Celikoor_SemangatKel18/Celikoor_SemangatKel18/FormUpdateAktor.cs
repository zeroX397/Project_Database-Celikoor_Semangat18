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
    public partial class FormUpdateAktor : Form
    {
        public FormUpdateAktor()
        {
            InitializeComponent();
        }

        public string kodeUbah;

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Aktor aktor = new Aktor();
                aktor.Id_Aktor = int.Parse(textBoxId.Text);
                aktor.Nama_Aktor = textBoxNama.Text;
                aktor.Tgl_lahir_Aktor = dateTimePickerTglLahir.Value.ToString("yyyy-MM-dd");
                aktor.Gender_Aktor = comboBox1.Text;
                aktor.Negara_asal_Aktor = textBoxNegara.Text;

                //ubah data di database:
                Aktor.UbahData(aktor);

                MessageBox.Show("Ubah Data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ubah Data gagal. Error : " + ex.Message);
            }
        }

        private void FormUpdateAktor_Load(object sender, EventArgs e)
        {
            //ambil objek yang akan diubah (isi list pasti hanya 1 objek saja)
            List<Aktor> listHasil = Aktor.BacaData("id", kodeUbah);

            //masukkan isi objek ke label/textbox yang sesuai
            textBoxId.Text = listHasil[0].Id_Aktor.ToString();
            textBoxNama.Text = listHasil[0].Nama_Aktor;
            dateTimePickerTglLahir.Value = DateTime.Parse(listHasil[0].Tgl_lahir_Aktor);
            comboBox1.Text = listHasil[0].Gender_Aktor;
            textBoxNegara.Text = listHasil[0].Negara_asal_Aktor;
        }
    }
}
