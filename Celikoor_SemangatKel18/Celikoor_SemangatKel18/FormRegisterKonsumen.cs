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
    }
}
