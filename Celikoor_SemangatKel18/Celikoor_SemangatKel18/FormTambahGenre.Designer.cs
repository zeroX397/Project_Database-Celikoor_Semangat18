﻿
namespace Celikoor_Semangat18
{
    partial class FormTambahGenre
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDesc);
            this.groupBox1.Controls.Add(this.labelDesc);
            this.groupBox1.Controls.Add(this.textBoxNama);
            this.groupBox1.Controls.Add(this.labelNama);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Location = new System.Drawing.Point(32, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 206);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesc.Location = new System.Drawing.Point(176, 89);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(198, 88);
            this.textBoxDesc.TabIndex = 21;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(26, 89);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(82, 20);
            this.labelDesc.TabIndex = 20;
            this.labelDesc.Text = "Deskripsi :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(176, 49);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(198, 26);
            this.textBoxNama.TabIndex = 4;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(26, 53);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(108, 20);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "Nama Genre :";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(176, 16);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(198, 26);
            this.textBoxId.TabIndex = 2;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(26, 19);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(31, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 38);
            this.label2.TabIndex = 33;
            this.label2.Text = "TAMBAH GENRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Transparent;
            this.buttonBatal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonBatal.Location = new System.Drawing.Point(32, 298);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(103, 40);
            this.buttonBatal.TabIndex = 35;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Transparent;
            this.buttonSimpan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSimpan.Location = new System.Drawing.Point(312, 298);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(117, 40);
            this.buttonSimpan.TabIndex = 34;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(402, 20);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 38);
            this.buttonExit.TabIndex = 36;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormTambahGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 366);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTambahGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahGenre";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button buttonExit;
    }
}