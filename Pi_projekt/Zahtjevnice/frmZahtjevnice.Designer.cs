﻿namespace Pi_projekt
{
    partial class frmZahtjevnice
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
            this.btnObirsi = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridViewOtpremnice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtpremnice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObirsi
            // 
            this.btnObirsi.Location = new System.Drawing.Point(452, 220);
            this.btnObirsi.Name = "btnObirsi";
            this.btnObirsi.Size = new System.Drawing.Size(75, 23);
            this.btnObirsi.TabIndex = 20;
            this.btnObirsi.Text = "Obriši";
            this.btnObirsi.UseVisualStyleBackColor = true;
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(371, 220);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni.TabIndex = 19;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(290, 220);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridViewOtpremnice
            // 
            this.dataGridViewOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtpremnice.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOtpremnice.Name = "dataGridViewOtpremnice";
            this.dataGridViewOtpremnice.Size = new System.Drawing.Size(515, 202);
            this.dataGridViewOtpremnice.TabIndex = 17;
            // 
            // frmZahtjevnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 252);
            this.Controls.Add(this.btnObirsi);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridViewOtpremnice);
            this.Name = "frmZahtjevnice";
            this.Text = "Zahtjevnice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtpremnice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObirsi;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridViewOtpremnice;
    }
}