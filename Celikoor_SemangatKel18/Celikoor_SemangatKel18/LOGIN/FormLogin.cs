using System;
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
    public partial class FormLoginKonsumen : Form
    {
        public FormLoginKonsumen()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterKonsumen frmRegisterKonsumen = new FormRegisterKonsumen();
            frmRegisterKonsumen.MdiParent = this;
            frmRegisterKonsumen.Show();
        }
    }
}
