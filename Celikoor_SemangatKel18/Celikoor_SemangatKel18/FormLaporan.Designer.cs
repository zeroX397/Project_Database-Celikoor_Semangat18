
namespace Celikoor_Semangat18
{
    partial class FormLaporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKonsumenGenreComedy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStudioUtilitasRendah = new System.Windows.Forms.Button();
            this.buttonFilmPenontonTdkHadir = new System.Windows.Forms.Button();
            this.buttonPeringkat = new System.Windows.Forms.Button();
            this.buttonFilmTerlaris = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.buttonKonsumenGenreComedy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStudioUtilitasRendah);
            this.panel1.Controls.Add(this.buttonFilmPenontonTdkHadir);
            this.panel1.Controls.Add(this.buttonPeringkat);
            this.panel1.Controls.Add(this.buttonFilmTerlaris);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 540);
            this.panel1.TabIndex = 55;
            // 
            // buttonKonsumenGenreComedy
            // 
            this.buttonKonsumenGenreComedy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonsumenGenreComedy.Location = new System.Drawing.Point(34, 421);
            this.buttonKonsumenGenreComedy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKonsumenGenreComedy.Name = "buttonKonsumenGenreComedy";
            this.buttonKonsumenGenreComedy.Size = new System.Drawing.Size(364, 54);
            this.buttonKonsumenGenreComedy.TabIndex = 61;
            this.buttonKonsumenGenreComedy.Text = "10 Konsumen yang sering menonton film komedi";
            this.buttonKonsumenGenreComedy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Laporan Sistem";
            // 
            // buttonStudioUtilitasRendah
            // 
            this.buttonStudioUtilitasRendah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudioUtilitasRendah.Location = new System.Drawing.Point(34, 340);
            this.buttonStudioUtilitasRendah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStudioUtilitasRendah.Name = "buttonStudioUtilitasRendah";
            this.buttonStudioUtilitasRendah.Size = new System.Drawing.Size(364, 54);
            this.buttonStudioUtilitasRendah.TabIndex = 60;
            this.buttonStudioUtilitasRendah.Text = "3 Studio dengan tingkat utilitas terendah";
            this.buttonStudioUtilitasRendah.UseVisualStyleBackColor = true;
            // 
            // buttonFilmPenontonTdkHadir
            // 
            this.buttonFilmPenontonTdkHadir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilmPenontonTdkHadir.Location = new System.Drawing.Point(34, 262);
            this.buttonFilmPenontonTdkHadir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilmPenontonTdkHadir.Name = "buttonFilmPenontonTdkHadir";
            this.buttonFilmPenontonTdkHadir.Size = new System.Drawing.Size(364, 54);
            this.buttonFilmPenontonTdkHadir.TabIndex = 59;
            this.buttonFilmPenontonTdkHadir.Text = "3 Film dengan Ketidakhadiran Penonton";
            this.buttonFilmPenontonTdkHadir.UseVisualStyleBackColor = true;
            this.buttonFilmPenontonTdkHadir.Click += new System.EventHandler(this.buttonFilmPenontonTdkHadir_Click);
            // 
            // buttonPeringkat
            // 
            this.buttonPeringkat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPeringkat.Location = new System.Drawing.Point(34, 168);
            this.buttonPeringkat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPeringkat.Name = "buttonPeringkat";
            this.buttonPeringkat.Size = new System.Drawing.Size(364, 73);
            this.buttonPeringkat.TabIndex = 58;
            this.buttonPeringkat.Text = "Peringkat 3 cabang dengan pemasukan terbanyak";
            this.buttonPeringkat.UseVisualStyleBackColor = true;
            this.buttonPeringkat.Click += new System.EventHandler(this.buttonPeringkat_Click);
            // 
            // buttonFilmTerlaris
            // 
            this.buttonFilmTerlaris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilmTerlaris.Location = new System.Drawing.Point(34, 88);
            this.buttonFilmTerlaris.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilmTerlaris.Name = "buttonFilmTerlaris";
            this.buttonFilmTerlaris.Size = new System.Drawing.Size(364, 56);
            this.buttonFilmTerlaris.TabIndex = 57;
            this.buttonFilmTerlaris.Text = "Film Terlaris setiap bulan sepanjang 2023";
            this.buttonFilmTerlaris.UseVisualStyleBackColor = true;
            this.buttonFilmTerlaris.Click += new System.EventHandler(this.buttonFilmTerlaris_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.Location = new System.Drawing.Point(902, 17);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 26);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(476, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 447);
            this.dataGridView1.TabIndex = 56;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKonsumenGenreComedy;
        private System.Windows.Forms.Button buttonStudioUtilitasRendah;
        private System.Windows.Forms.Button buttonFilmPenontonTdkHadir;
        private System.Windows.Forms.Button buttonPeringkat;
        private System.Windows.Forms.Button buttonFilmTerlaris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}