
namespace PersonelTakipUygulaması
{
    partial class FormAna
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
            this.pnlAraclar = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDurumu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.dtpIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbTamEslesme = new System.Windows.Forms.RadioButton();
            this.rdbBenzer = new System.Windows.Forms.RadioButton();
            this.rdbBasla = new System.Windows.Forms.RadioButton();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.pnlAraclar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAraclar
            // 
            this.pnlAraclar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAraclar.Controls.Add(this.label9);
            this.pnlAraclar.Controls.Add(this.cmbDurumu);
            this.pnlAraclar.Controls.Add(this.label8);
            this.pnlAraclar.Controls.Add(this.cmbUnvan);
            this.pnlAraclar.Controls.Add(this.label7);
            this.pnlAraclar.Controls.Add(this.cmbDepartman);
            this.pnlAraclar.Controls.Add(this.dtpIseBaslamaTarihi);
            this.pnlAraclar.Controls.Add(this.dtpDogumTarihi);
            this.pnlAraclar.Controls.Add(this.txtPersonelNo);
            this.pnlAraclar.Controls.Add(this.txtTcNo);
            this.pnlAraclar.Controls.Add(this.txtSoyad);
            this.pnlAraclar.Controls.Add(this.txtAd);
            this.pnlAraclar.Controls.Add(this.label6);
            this.pnlAraclar.Controls.Add(this.label5);
            this.pnlAraclar.Controls.Add(this.label4);
            this.pnlAraclar.Controls.Add(this.label3);
            this.pnlAraclar.Controls.Add(this.label2);
            this.pnlAraclar.Controls.Add(this.label1);
            this.pnlAraclar.Location = new System.Drawing.Point(6, 11);
            this.pnlAraclar.Name = "pnlAraclar";
            this.pnlAraclar.Size = new System.Drawing.Size(304, 306);
            this.pnlAraclar.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(6, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "DURUMU";
            // 
            // cmbDurumu
            // 
            this.cmbDurumu.FormattingEnabled = true;
            this.cmbDurumu.Items.AddRange(new object[] {
            "aktif",
            "pasif"});
            this.cmbDurumu.Location = new System.Drawing.Point(125, 262);
            this.cmbDurumu.Name = "cmbDurumu";
            this.cmbDurumu.Size = new System.Drawing.Size(170, 21);
            this.cmbDurumu.TabIndex = 8;
            this.cmbDurumu.Tag = "Durumu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(6, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "ÜNVAN";
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] {
            "işçi",
            "ekip lideri",
            "yönetici yardımcısı",
            "yönetici"});
            this.cmbUnvan.Location = new System.Drawing.Point(125, 232);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(170, 21);
            this.cmbUnvan.TabIndex = 7;
            this.cmbUnvan.Tag = "Unvan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(6, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "DEPARTMAN";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Muhasebe",
            "Satış",
            "Üretim",
            "Teknik"});
            this.cmbDepartman.Location = new System.Drawing.Point(125, 207);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(170, 21);
            this.cmbDepartman.TabIndex = 6;
            this.cmbDepartman.Tag = "Departman";
            // 
            // dtpIseBaslamaTarihi
            // 
            this.dtpIseBaslamaTarihi.Location = new System.Drawing.Point(125, 181);
            this.dtpIseBaslamaTarihi.Name = "dtpIseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.Size = new System.Drawing.Size(170, 20);
            this.dtpIseBaslamaTarihi.TabIndex = 5;
            this.dtpIseBaslamaTarihi.Tag = "IseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.ValueChanged += new System.EventHandler(this.dtpIseBaslamaTarihi_ValueChanged);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(125, 152);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(170, 20);
            this.dtpDogumTarihi.TabIndex = 4;
            this.dtpDogumTarihi.Tag = "DogumTarihi";
            this.dtpDogumTarihi.ValueChanged += new System.EventHandler(this.dtpDogumTarihi_ValueChanged);
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(125, 123);
            this.txtPersonelNo.MaxLength = 5;
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(170, 20);
            this.txtPersonelNo.TabIndex = 3;
            this.txtPersonelNo.Tag = "PersonelNo";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(125, 93);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(170, 20);
            this.txtTcNo.TabIndex = 2;
            this.txtTcNo.Tag = "TcNo";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(125, 59);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(170, 20);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Tag = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(125, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(170, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.Tag = "Ad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "İŞE BAŞLAMA TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "DOĞUM TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "PERSONEL NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC KİMLİK NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.rdbTamEslesme);
            this.panel2.Controls.Add(this.rdbBenzer);
            this.panel2.Controls.Add(this.rdbBasla);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnTemizle);
            this.panel2.Controls.Add(this.btnHepsiniSil);
            this.panel2.Controls.Add(this.btnGetir);
            this.panel2.Controls.Add(this.btnBul);
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Location = new System.Drawing.Point(6, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 123);
            this.panel2.TabIndex = 1;
            // 
            // rdbTamEslesme
            // 
            this.rdbTamEslesme.AutoSize = true;
            this.rdbTamEslesme.Checked = true;
            this.rdbTamEslesme.Location = new System.Drawing.Point(211, 102);
            this.rdbTamEslesme.Name = "rdbTamEslesme";
            this.rdbTamEslesme.Size = new System.Drawing.Size(88, 17);
            this.rdbTamEslesme.TabIndex = 18;
            this.rdbTamEslesme.TabStop = true;
            this.rdbTamEslesme.Text = "Tam Eşleşme";
            this.rdbTamEslesme.UseVisualStyleBackColor = true;
            // 
            // rdbBenzer
            // 
            this.rdbBenzer.AutoSize = true;
            this.rdbBenzer.Location = new System.Drawing.Point(128, 103);
            this.rdbBenzer.Name = "rdbBenzer";
            this.rdbBenzer.Size = new System.Drawing.Size(58, 17);
            this.rdbBenzer.TabIndex = 17;
            this.rdbBenzer.Text = "Benzer";
            this.rdbBenzer.UseVisualStyleBackColor = true;
            // 
            // rdbBasla
            // 
            this.rdbBasla.AutoSize = true;
            this.rdbBasla.Location = new System.Drawing.Point(37, 103);
            this.rdbBasla.Name = "rdbBasla";
            this.rdbBasla.Size = new System.Drawing.Size(51, 17);
            this.rdbBasla.TabIndex = 16;
            this.rdbBasla.Text = "Basla";
            this.rdbBasla.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(9, 44);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(113, 44);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(84, 23);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Location = new System.Drawing.Point(211, 44);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(84, 23);
            this.btnHepsiniSil.TabIndex = 13;
            this.btnHepsiniSil.Text = "HEPSİNİ SİL";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(9, 73);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(137, 23);
            this.btnGetir.TabIndex = 14;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(158, 73);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(137, 23);
            this.btnBul.TabIndex = 15;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(9, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(137, 23);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(158, 10);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(137, 23);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Location = new System.Drawing.Point(316, 12);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.ReadOnly = true;
            this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlar.Size = new System.Drawing.Size(633, 426);
            this.dgvCalisanlar.TabIndex = 2;
            this.dgvCalisanlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellEnter);
            this.dgvCalisanlar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCalisanlar_KeyPress);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.dgvCalisanlar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAraclar);
            this.Name = "FormAna";
            this.Text = "Wissen Akademi Personel Takip";
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.pnlAraclar.ResumeLayout(false);
            this.pnlAraclar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAraclar;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDurumu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.DateTimePicker dtpIseBaslamaTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.RadioButton rdbTamEslesme;
        private System.Windows.Forms.RadioButton rdbBenzer;
        private System.Windows.Forms.RadioButton rdbBasla;
    }
}

