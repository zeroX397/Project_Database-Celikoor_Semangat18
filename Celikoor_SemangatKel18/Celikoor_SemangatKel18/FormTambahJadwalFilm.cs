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
    public partial class FormTambahJadwalFilm : Form
    {
        public FormTambahJadwalFilm()
        {
            InitializeComponent();
        }

        private void FormTambahJadwalFilm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the filter for image files
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            // Display the File Dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pictureBoxMov.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
