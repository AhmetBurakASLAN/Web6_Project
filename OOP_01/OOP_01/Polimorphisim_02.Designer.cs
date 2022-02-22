
namespace OOP_01
{
    partial class Polimorphisim_02
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
            this.btnTekstil = new System.Windows.Forms.Button();
            this.btnCepTel = new System.Windows.Forms.Button();
            this.btnEkmek = new System.Windows.Forms.Button();
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvliFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTekstil
            // 
            this.btnTekstil.Location = new System.Drawing.Point(101, 178);
            this.btnTekstil.Name = "btnTekstil";
            this.btnTekstil.Size = new System.Drawing.Size(105, 23);
            this.btnTekstil.TabIndex = 1;
            this.btnTekstil.Text = "Tekstil";
            this.btnTekstil.UseVisualStyleBackColor = true;
            this.btnTekstil.Click += new System.EventHandler(this.btnTekstil_Click);
            // 
            // btnCepTel
            // 
            this.btnCepTel.Location = new System.Drawing.Point(101, 207);
            this.btnCepTel.Name = "btnCepTel";
            this.btnCepTel.Size = new System.Drawing.Size(105, 23);
            this.btnCepTel.TabIndex = 2;
            this.btnCepTel.Text = "Cep Telefonu";
            this.btnCepTel.UseVisualStyleBackColor = true;
            this.btnCepTel.Click += new System.EventHandler(this.btnCepTel_Click);
            // 
            // btnEkmek
            // 
            this.btnEkmek.Location = new System.Drawing.Point(101, 236);
            this.btnEkmek.Name = "btnEkmek";
            this.btnEkmek.Size = new System.Drawing.Size(105, 23);
            this.btnEkmek.TabIndex = 3;
            this.btnEkmek.Text = "Ekmek";
            this.btnEkmek.UseVisualStyleBackColor = true;
            this.btnEkmek.Click += new System.EventHandler(this.btnEkmek_Click);
            // 
            // dgvSepet
            // 
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAd,
            this.fiyat,
            this.kdvliFiyat});
            this.dgvSepet.Location = new System.Drawing.Point(12, 12);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.Size = new System.Drawing.Size(435, 150);
            this.dgvSepet.TabIndex = 4;
            // 
            // urunAd
            // 
            this.urunAd.HeaderText = "Ürün AD";
            this.urunAd.Name = "urunAd";
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.Name = "fiyat";
            // 
            // kdvliFiyat
            // 
            this.kdvliFiyat.HeaderText = "KDV Dahil Fiyat";
            this.kdvliFiyat.Name = "kdvliFiyat";
            // 
            // Polimorphisim_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 271);
            this.Controls.Add(this.dgvSepet);
            this.Controls.Add(this.btnEkmek);
            this.Controls.Add(this.btnCepTel);
            this.Controls.Add(this.btnTekstil);
            this.Name = "Polimorphisim_02";
            this.Text = "Polimorphisim_02";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTekstil;
        private System.Windows.Forms.Button btnCepTel;
        private System.Windows.Forms.Button btnEkmek;
        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvliFiyat;
    }
}