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
    public partial class FormLoginKasir : Form
    {
        FormMainMenu frmMainMenu;
        public FormLoginKasir()
        {
            InitializeComponent();
        }

        private void FormLoginKasir_Load(object sender, EventArgs e)
        {
            frmMainMenu.MdiParent = this;
        }
    }
}
