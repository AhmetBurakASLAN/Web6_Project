
namespace WithClassSQL_02_CRUD
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
            this.btnHastalar = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnBolumler = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastalar
            // 
            this.btnHastalar.Location = new System.Drawing.Point(113, 52);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(95, 42);
            this.btnHastalar.TabIndex = 2;
            this.btnHastalar.Text = "Hastalar";
            this.btnHastalar.UseVisualStyleBackColor = true;
            this.btnHastalar.Click += new System.EventHandler(this.btnHastalar_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(113, 100);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(95, 43);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnBolumler
            // 
            this.btnBolumler.Location = new System.Drawing.Point(113, 4);
            this.btnBolumler.Name = "btnBolumler";
            this.btnBolumler.Size = new System.Drawing.Size(95, 42);
            this.btnBolumler.TabIndex = 4;
            this.btnBolumler.Text = "Bölümler";
            this.btnBolumler.UseVisualStyleBackColor = true;
            this.btnBolumler.Click += new System.EventHandler(this.btnBolumler_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.Location = new System.Drawing.Point(113, 159);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(95, 39);
            this.btnRandevu.TabIndex = 5;
            this.btnRandevu.Text = "Randevu";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 325);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.btnBolumler);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnHastalar);
            this.Name = "FormAna";
            this.Text = "Ana Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHastalar;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBolumler;
        private System.Windows.Forms.Button btnRandevu;
    }
}

