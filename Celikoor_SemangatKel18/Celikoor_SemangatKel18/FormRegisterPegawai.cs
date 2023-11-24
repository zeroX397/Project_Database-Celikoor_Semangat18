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
    public partial class FormRegisterPegawai : Form
    {
        FormMainMenu frmMainMenu;
        public FormRegisterPegawai()
        {
            InitializeComponent();
        }

        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            frmMainMenu = (FormMainMenu)Owner;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai tambahData = new Pegawai();
                tambahData.Nama_Pegawai = textBoxNama.Text;
                tambahData.Email_Pegawai= textBoxEmail.Text;
                tambahData.Username_Pegawai= textBoxUsername.Text;
                tambahData.Password_Pegawai= textBoxPass.Text;
                tambahData.Roles_Pegawai = comboBoxRolePegawai.SelectedValue.ToString();

                Pegawai.TambahData(tambahData);
                MessageBox.Show("Pendaftaran Berhasil. Anda bisa masuk sekarang.");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pendaftaran Gagal. Error: " + ex.Message);
            }
        }
    }
}
