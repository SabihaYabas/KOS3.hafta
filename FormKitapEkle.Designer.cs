namespace WinFormKOS
{
    partial class FormKitapEkle
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
            this.kayitNo = new System.Windows.Forms.Label();
            this.kitapAdi = new System.Windows.Forms.Label();
            this.yazarAdi = new System.Windows.Forms.Label();
            this.yayinevi = new System.Windows.Forms.Label();
            this.basimYili = new System.Windows.Forms.Label();
            this.sayfaSayisi = new System.Windows.Forms.Label();
            this.tur = new System.Windows.Forms.Label();
            this.aciklama = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dolap = new System.Windows.Forms.Label();
            this.raf = new System.Windows.Forms.Label();
            this.sira = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtKayitNo = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.cbbYazarAdi = new System.Windows.Forms.ComboBox();
            this.cbbYayinevi = new System.Windows.Forms.ComboBox();
            this.cbbTur = new System.Windows.Forms.ComboBox();
            this.cbbDolap = new System.Windows.Forms.ComboBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFiltrele = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // kayitNo
            // 
            this.kayitNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kayitNo.AutoSize = true;
            this.kayitNo.Location = new System.Drawing.Point(3, 8);
            this.kayitNo.Name = "kayitNo";
            this.kayitNo.Size = new System.Drawing.Size(50, 13);
            this.kayitNo.TabIndex = 0;
            this.kayitNo.Text = "Kayıt No:";
            // 
            // kitapAdi
            // 
            this.kitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kitapAdi.AutoSize = true;
            this.kitapAdi.Location = new System.Drawing.Point(3, 38);
            this.kitapAdi.Name = "kitapAdi";
            this.kitapAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kitapAdi.Size = new System.Drawing.Size(60, 13);
            this.kitapAdi.TabIndex = 1;
            this.kitapAdi.Text = "Kitabın Adı:";
            // 
            // yazarAdi
            // 
            this.yazarAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yazarAdi.AutoSize = true;
            this.yazarAdi.Location = new System.Drawing.Point(3, 68);
            this.yazarAdi.Name = "yazarAdi";
            this.yazarAdi.Size = new System.Drawing.Size(55, 13);
            this.yazarAdi.TabIndex = 2;
            this.yazarAdi.Text = "Yazar Adı:";
            // 
            // yayinevi
            // 
            this.yayinevi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yayinevi.AutoSize = true;
            this.yayinevi.Location = new System.Drawing.Point(3, 98);
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Size = new System.Drawing.Size(50, 13);
            this.yayinevi.TabIndex = 3;
            this.yayinevi.Text = "Yayınevi:";
            // 
            // basimYili
            // 
            this.basimYili.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.basimYili.AutoSize = true;
            this.basimYili.Location = new System.Drawing.Point(3, 128);
            this.basimYili.Name = "basimYili";
            this.basimYili.Size = new System.Drawing.Size(54, 13);
            this.basimYili.TabIndex = 4;
            this.basimYili.Text = "Basım Yılı:";
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sayfaSayisi.AutoSize = true;
            this.sayfaSayisi.Location = new System.Drawing.Point(3, 158);
            this.sayfaSayisi.Name = "sayfaSayisi";
            this.sayfaSayisi.Size = new System.Drawing.Size(67, 13);
            this.sayfaSayisi.TabIndex = 5;
            this.sayfaSayisi.Text = "Sayfa Sayısı:";
            // 
            // tur
            // 
            this.tur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tur.AutoSize = true;
            this.tur.Location = new System.Drawing.Point(3, 188);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(26, 13);
            this.tur.TabIndex = 6;
            this.tur.Text = "Tür:";
            // 
            // aciklama
            // 
            this.aciklama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aciklama.AutoSize = true;
            this.aciklama.Location = new System.Drawing.Point(3, 233);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(53, 13);
            this.aciklama.TabIndex = 7;
            this.aciklama.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 8;
            // 
            // dolap
            // 
            this.dolap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dolap.AutoSize = true;
            this.dolap.Location = new System.Drawing.Point(3, 278);
            this.dolap.Name = "dolap";
            this.dolap.Size = new System.Drawing.Size(38, 13);
            this.dolap.TabIndex = 9;
            this.dolap.Text = "Dolap:";
            // 
            // raf
            // 
            this.raf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.raf.AutoSize = true;
            this.raf.Location = new System.Drawing.Point(3, 308);
            this.raf.Name = "raf";
            this.raf.Size = new System.Drawing.Size(27, 13);
            this.raf.TabIndex = 10;
            this.raf.Text = "Raf:";
            // 
            // sira
            // 
            this.sira.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sira.AutoSize = true;
            this.sira.Location = new System.Drawing.Point(3, 338);
            this.sira.Name = "sira";
            this.sira.Size = new System.Drawing.Size(28, 13);
            this.sira.TabIndex = 11;
            this.sira.Text = "Sıra:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.kayitNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sira, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.kitapAdi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.raf, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.yazarAdi, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dolap, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.yayinevi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.basimYili, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.aciklama, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.sayfaSayisi, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tur, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtKayitNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKitapAdi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbbYazarAdi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbbYayinevi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbbTur, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbbDolap, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtBasimYili, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSayfaSayisi, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtAciklama, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtRaf, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtSira, 1, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 360);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txtKayitNo
            // 
            this.txtKayitNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKayitNo.Location = new System.Drawing.Point(90, 5);
            this.txtKayitNo.Name = "txtKayitNo";
            this.txtKayitNo.Size = new System.Drawing.Size(157, 20);
            this.txtKayitNo.TabIndex = 12;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKitapAdi.Location = new System.Drawing.Point(90, 35);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(157, 20);
            this.txtKitapAdi.TabIndex = 13;
            // 
            // cbbYazarAdi
            // 
            this.cbbYazarAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbYazarAdi.FormattingEnabled = true;
            this.cbbYazarAdi.Location = new System.Drawing.Point(90, 64);
            this.cbbYazarAdi.Name = "cbbYazarAdi";
            this.cbbYazarAdi.Size = new System.Drawing.Size(157, 21);
            this.cbbYazarAdi.TabIndex = 14;
            // 
            // cbbYayinevi
            // 
            this.cbbYayinevi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbYayinevi.FormattingEnabled = true;
            this.cbbYayinevi.Location = new System.Drawing.Point(90, 94);
            this.cbbYayinevi.Name = "cbbYayinevi";
            this.cbbYayinevi.Size = new System.Drawing.Size(157, 21);
            this.cbbYayinevi.TabIndex = 15;
            // 
            // cbbTur
            // 
            this.cbbTur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbTur.FormattingEnabled = true;
            this.cbbTur.Location = new System.Drawing.Point(90, 184);
            this.cbbTur.Name = "cbbTur";
            this.cbbTur.Size = new System.Drawing.Size(157, 21);
            this.cbbTur.TabIndex = 16;
            // 
            // cbbDolap
            // 
            this.cbbDolap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbDolap.FormattingEnabled = true;
            this.cbbDolap.Location = new System.Drawing.Point(90, 274);
            this.cbbDolap.Name = "cbbDolap";
            this.cbbDolap.Size = new System.Drawing.Size(157, 21);
            this.cbbDolap.TabIndex = 17;
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBasimYili.Location = new System.Drawing.Point(90, 125);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(157, 20);
            this.txtBasimYili.TabIndex = 18;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSayfaSayisi.Location = new System.Drawing.Point(90, 155);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(157, 20);
            this.txtSayfaSayisi.TabIndex = 19;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAciklama.Location = new System.Drawing.Point(90, 213);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(157, 54);
            this.txtAciklama.TabIndex = 20;
            // 
            // txtRaf
            // 
            this.txtRaf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRaf.Location = new System.Drawing.Point(90, 305);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(157, 20);
            this.txtRaf.TabIndex = 21;
            // 
            // txtSira
            // 
            this.txtSira.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSira.Location = new System.Drawing.Point(90, 335);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(157, 20);
            this.txtSira.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnKaydet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSil, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTemizle, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 405);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 30);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKaydet.Location = new System.Drawing.Point(3, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(77, 24);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSil.Location = new System.Drawing.Point(86, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 24);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTemizle.Location = new System.Drawing.Point(169, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(78, 24);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // dg
            // 
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(279, 22);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(509, 360);
            this.dg.TabIndex = 14;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(597, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Filtrele:";
            // 
            // txtFiltrele
            // 
            this.txtFiltrele.Location = new System.Drawing.Point(654, 412);
            this.txtFiltrele.Name = "txtFiltrele";
            this.txtFiltrele.Size = new System.Drawing.Size(134, 20);
            this.txtFiltrele.TabIndex = 16;
            // 
            // FormKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.txtFiltrele);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Name = "FormKitapEkle";
            this.RightToLeftLayout = true;
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.FormKitapEkle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kayitNo;
        private System.Windows.Forms.Label kitapAdi;
        private System.Windows.Forms.Label yazarAdi;
        private System.Windows.Forms.Label yayinevi;
        private System.Windows.Forms.Label basimYili;
        private System.Windows.Forms.Label sayfaSayisi;
        private System.Windows.Forms.Label tur;
        private System.Windows.Forms.Label aciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dolap;
        private System.Windows.Forms.Label raf;
        private System.Windows.Forms.Label sira;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtKayitNo;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.ComboBox cbbYazarAdi;
        private System.Windows.Forms.ComboBox cbbYayinevi;
        private System.Windows.Forms.ComboBox cbbTur;
        private System.Windows.Forms.ComboBox cbbDolap;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFiltrele;
    }
}