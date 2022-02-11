
namespace Form_02
{
    partial class Form1
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
            this.btnOyunaBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayıGiriniz = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.lblHile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblTahminler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOyunaBasla
            // 
            this.btnOyunaBasla.Location = new System.Drawing.Point(25, 12);
            this.btnOyunaBasla.Name = "btnOyunaBasla";
            this.btnOyunaBasla.Size = new System.Drawing.Size(101, 38);
            this.btnOyunaBasla.TabIndex = 0;
            this.btnOyunaBasla.Text = "Oyuna Başla";
            this.btnOyunaBasla.UseVisualStyleBackColor = true;
            this.btnOyunaBasla.Click += new System.EventHandler(this.btnOyunaBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayıyı Giriniz ";
            // 
            // txtSayıGiriniz
            // 
            this.txtSayıGiriniz.Location = new System.Drawing.Point(25, 90);
            this.txtSayıGiriniz.Name = "txtSayıGiriniz";
            this.txtSayıGiriniz.Size = new System.Drawing.Size(100, 20);
            this.txtSayıGiriniz.TabIndex = 3;
            this.txtSayıGiriniz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSayıGiriniz_KeyDown);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(12, 189);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(315, 20);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "Oyunu Başlatmak için Oyun Başlaya basınız";
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(24, 121);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(101, 38);
            this.btnTahminEt.TabIndex = 0;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // lblHile
            // 
            this.lblHile.AutoSize = true;
            this.lblHile.Location = new System.Drawing.Point(165, 134);
            this.lblHile.Name = "lblHile";
            this.lblHile.Size = new System.Drawing.Size(25, 13);
            this.lblHile.TabIndex = 4;
            this.lblHile.Text = "Hile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(164, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(164, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hak:";
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.ForeColor = System.Drawing.Color.Red;
            this.lblHak.Location = new System.Drawing.Point(230, 59);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(19, 20);
            this.lblHak.TabIndex = 8;
            this.lblHak.Text = "5";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.Red;
            this.lblPuan.Location = new System.Drawing.Point(230, 20);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(29, 20);
            this.lblPuan.TabIndex = 7;
            this.lblPuan.Text = "50";
            // 
            // lblTahminler
            // 
            this.lblTahminler.AutoSize = true;
            this.lblTahminler.Location = new System.Drawing.Point(141, 97);
            this.lblTahminler.Name = "lblTahminler";
            this.lblTahminler.Size = new System.Drawing.Size(53, 13);
            this.lblTahminler.TabIndex = 9;
            this.lblTahminler.Text = "Tahminler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 246);
            this.Controls.Add(this.lblTahminler);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHile);
            this.Controls.Add(this.txtSayıGiriniz);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.btnOyunaBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyunaBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayıGiriniz;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Label lblHile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblTahminler;
    }
}

