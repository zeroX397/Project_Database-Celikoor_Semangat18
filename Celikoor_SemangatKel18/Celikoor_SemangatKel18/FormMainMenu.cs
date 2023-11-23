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
            WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormLogin"];
            if(frm == null)
            {
                FormLoginKonsumen frmlog = new FormLoginKonsumen();
                Form form = Application.OpenForms["FormLoginKonsumen"];
                if (form == null)
                {
                    FormLoginKonsumen frmlogin = new FormLoginKonsumen();
                    frmlogin.MdiParent = this;
                    frmlogin.Show();
                }
                else
                {
                    form.Show();
                    form.BringToFront();
                }
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormRegisterKonsumen"];
            if (form == null)
            {
                FormRegisterKonsumen frmRegisterKonsumen = new FormRegisterKonsumen();
                frmRegisterKonsumen.MdiParent = this;
                frmRegisterKonsumen.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
