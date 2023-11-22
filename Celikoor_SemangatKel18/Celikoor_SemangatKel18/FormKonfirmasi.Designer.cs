
namespace tes
{
    partial class FormKonfirmasi
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.radioButtonKaryawan = new System.Windows.Forms.RadioButton();
            this.radioButtonKustomer = new System.Windows.Forms.RadioButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(484, 8);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 26);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anda Login Sebagai?";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel.Controls.Add(this.radioButtonKaryawan);
            this.panel.Controls.Add(this.radioButtonKustomer);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(0, 38);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(551, 144);
            this.panel.TabIndex = 11;
            // 
            // radioButtonKaryawan
            // 
            this.radioButtonKaryawan.AutoSize = true;
            this.radioButtonKaryawan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonKaryawan.Location = new System.Drawing.Point(339, 89);
            this.radioButtonKaryawan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonKaryawan.Name = "radioButtonKaryawan";
            this.radioButtonKaryawan.Size = new System.Drawing.Size(98, 23);
            this.radioButtonKaryawan.TabIndex = 4;
            this.radioButtonKaryawan.TabStop = true;
            this.radioButtonKaryawan.Text = "Karyawan";
            this.radioButtonKaryawan.UseVisualStyleBackColor = true;
            // 
            // radioButtonKustomer
            // 
            this.radioButtonKustomer.AutoSize = true;
            this.radioButtonKustomer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonKustomer.Location = new System.Drawing.Point(64, 89);
            this.radioButtonKustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonKustomer.Name = "radioButtonKustomer";
            this.radioButtonKustomer.Size = new System.Drawing.Size(89, 23);
            this.radioButtonKustomer.TabIndex = 3;
            this.radioButtonKustomer.TabStop = true;
            this.radioButtonKustomer.Text = "Kustomer";
            this.radioButtonKustomer.UseVisualStyleBackColor = true;
            // 
            // FormKonfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(519, 220);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKonfirmasi";
            this.Text = "FormKonfirmasi";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton radioButtonKaryawan;
        private System.Windows.Forms.RadioButton radioButtonKustomer;
    }
}