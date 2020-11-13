using System;

namespace WinFormKOS
{
    partial class FormHome
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
            this.btnEmanetİslem = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnOkuyucuEkle = new System.Windows.Forms.Button();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgEmanetler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgMevcutKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgOkuyucular = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmanetİslem
            // 
            this.btnEmanetİslem.Location = new System.Drawing.Point(12, 12);
            this.btnEmanetİslem.Name = "btnEmanetİslem";
            this.btnEmanetİslem.Size = new System.Drawing.Size(100, 75);
            this.btnEmanetİslem.TabIndex = 0;
            this.btnEmanetİslem.Text = "Emanet İşlemleri";
            this.btnEmanetİslem.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(118, 12);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(100, 75);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click_1);
            // 
            // btnOkuyucuEkle
            // 
            this.btnOkuyucuEkle.Location = new System.Drawing.Point(224, 12);
            this.btnOkuyucuEkle.Name = "btnOkuyucuEkle";
            this.btnOkuyucuEkle.Size = new System.Drawing.Size(100, 75);
            this.btnOkuyucuEkle.TabIndex = 2;
            this.btnOkuyucuEkle.Text = "Okuyucu Ekle";
            this.btnOkuyucuEkle.UseVisualStyleBackColor = true;
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.Location = new System.Drawing.Point(330, 12);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(100, 75);
            this.btnİstatistik.TabIndex = 3;
            this.btnİstatistik.Text = "İstatistik";
            this.btnİstatistik.UseVisualStyleBackColor = true;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Location = new System.Drawing.Point(436, 12);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(100, 75);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(722, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 75);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 344);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgEmanetler);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emanet Kitaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgEmanetler
            // 
            this.dgEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmanetler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmanetler.Location = new System.Drawing.Point(3, 3);
            this.dgEmanetler.Name = "dgEmanetler";
            this.dgEmanetler.Size = new System.Drawing.Size(796, 312);
            this.dgEmanetler.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgMevcutKitaplar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mevcut Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgMevcutKitaplar
            // 
            this.dgMevcutKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMevcutKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMevcutKitaplar.Location = new System.Drawing.Point(3, 3);
            this.dgMevcutKitaplar.Name = "dgMevcutKitaplar";
            this.dgMevcutKitaplar.Size = new System.Drawing.Size(796, 312);
            this.dgMevcutKitaplar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgOkuyucular);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(802, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Okuyucular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgOkuyucular
            // 
            this.dgOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOkuyucular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOkuyucular.Location = new System.Drawing.Point(3, 3);
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.Size = new System.Drawing.Size(796, 312);
            this.dgOkuyucular.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnİstatistik);
            this.Controls.Add(this.btnOkuyucuEkle);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnEmanetİslem);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnEmanetİslem;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnOkuyucuEkle;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgEmanetler;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgMevcutKitaplar;
        private System.Windows.Forms.DataGridView dgOkuyucular;
    }
}