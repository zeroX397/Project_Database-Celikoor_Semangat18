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
    public partial class FormPesanTiket : Form
    {
        public FormPesanTiket()
        {
            InitializeComponent();
        }

        private void FormPesanTiket_Load(object sender, EventArgs e)
        {
            int jumlahKursi = 60;
            List<String> listHuruf = new List<String>() { "A", "B", "C" };

            int tambah_i = 0;
            int tambah_j = 0;

            for (int i = 0; i < listHuruf.Count; i++)
            {
                for (int j = 0; j < jumlahKursi / 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Name = $"checkBox{listHuruf[i]}{(j + 1)}";
                        checkBox.Text = $"{j + 1}";
                        checkBox.Checked = false;
                        checkBox.Location = new Point(10 + tambah_i + (i * 20), 50 + tambah_j);
                        checkBox.CheckedChanged += checkBox_CheckedChanged;
                        this.Controls.Add(checkBox);
                        checkBox.BringToFront();
                    }

                }

                tambah_j += 50;
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                MessageBox.Show($"Kursi {checkBox.Text} telah dipesan");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
