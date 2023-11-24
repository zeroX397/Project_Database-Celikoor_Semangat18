using System;
using Celikoor_Library;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tes
{
    public partial class FormRegisterKonsumen : Form
    {
        FormMainMenu frmMainMenu;
        public FormRegisterKonsumen()
        {
            InitializeComponent();
        }

        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            frmMainMenu = (FormMainMenu)Owner;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLoginKonsumen frmLoginKonsumen = new FormLoginKonsumen();
            frmLoginKonsumen.MdiParent = this;
            frmLoginKonsumen.ShowDialog();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                Konsumen tambahData = new Konsumen();
                tambahData.Nama_Konsumen = textBoxNama.Text;
                tambahData.Email_Konsumen = textBoxEmail.Text;
                tambahData.NoHP_Konsumen = textBoxNoHP.Text;
                tambahData.Gender_Konsumen = radioButtonLaki.Checked ? "L" : "P";
                tambahData.Ttl_Konsumen = dateTimePickerTglLahir.Value.Date;
                tambahData.Saldo_Konsumen = 0;
                tambahData.Username_Konsumen = textBoxUsername.Text;
                tambahData.Password_Konsumen = textBoxPass.Text;

                Konsumen.TambahData(tambahData);
                MessageBox.Show("Pendaftaran Berhasil. Anda bisa masuk sekarang.");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pendaftaran Gagal. Error: " + ex.Message);
            }
        }
    }
}
