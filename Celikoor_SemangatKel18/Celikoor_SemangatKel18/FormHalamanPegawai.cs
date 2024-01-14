using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Semangat18
{
    public partial class FormHalamanPegawai : Form
    {
        public FormHalamanPegawai()
        {
            InitializeComponent();
        }
        FormLogin frmLogin;
        private void FormHalamanPegawai_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            FormMainMenu frm = new FormMainMenu();
            frm.Owner = this.Owner;
            frm.ShowDialog();
        }
    }
}
