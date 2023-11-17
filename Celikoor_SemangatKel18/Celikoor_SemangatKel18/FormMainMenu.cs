using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tes
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Button login di Form Main Menu buat apa
        }

        private void konsumenRegister_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegisterKonsumen frmRegisterKonsumen = new FormRegisterKonsumen();
            frmRegisterKonsumen.MdiParent = this;
            frmRegisterKonsumen.Show();
        }

        private void konsumenLogin_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginKonsumen frmLoginKonsumen = new FormLoginKonsumen();
            frmLoginKonsumen.MdiParent = this;
            frmLoginKonsumen.Show();
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kasirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void operatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
