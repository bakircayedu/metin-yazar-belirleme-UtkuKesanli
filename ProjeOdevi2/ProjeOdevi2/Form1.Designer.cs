namespace ProjeOdevi2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.textBoxMetinOku = new System.Windows.Forms.TextBox();
            this.btnStackYukle = new System.Windows.Forms.Button();
            this.listIstatistikler = new System.Windows.Forms.ListView();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.btnEnCokKelimeler = new System.Windows.Forms.Button();
            this.btnHashTablosu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(12, 12);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(182, 28);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // textBoxMetinOku
            // 
            this.textBoxMetinOku.Location = new System.Drawing.Point(200, 17);
            this.textBoxMetinOku.Name = "textBoxMetinOku";
            this.textBoxMetinOku.Size = new System.Drawing.Size(376, 20);
            this.textBoxMetinOku.TabIndex = 1;
            // 
            // btnStackYukle
            // 
            this.btnStackYukle.Location = new System.Drawing.Point(12, 46);
            this.btnStackYukle.Name = "btnStackYukle";
            this.btnStackYukle.Size = new System.Drawing.Size(182, 27);
            this.btnStackYukle.TabIndex = 2;
            this.btnStackYukle.Text = "Stack Yükle";
            this.btnStackYukle.UseVisualStyleBackColor = true;
            this.btnStackYukle.Click += new System.EventHandler(this.btnStackYukle_Click);
            // 
            // listIstatistikler
            // 
            this.listIstatistikler.HideSelection = false;
            this.listIstatistikler.Location = new System.Drawing.Point(200, 46);
            this.listIstatistikler.Name = "listIstatistikler";
            this.listIstatistikler.Size = new System.Drawing.Size(376, 124);
            this.listIstatistikler.TabIndex = 3;
            this.listIstatistikler.UseCompatibleStateImageBehavior = false;
            this.listIstatistikler.View = System.Windows.Forms.View.List;
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(12, 79);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(182, 27);
            this.btnAgacaAktar.TabIndex = 4;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // btnEnCokKelimeler
            // 
            this.btnEnCokKelimeler.Location = new System.Drawing.Point(12, 112);
            this.btnEnCokKelimeler.Name = "btnEnCokKelimeler";
            this.btnEnCokKelimeler.Size = new System.Drawing.Size(182, 26);
            this.btnEnCokKelimeler.TabIndex = 5;
            this.btnEnCokKelimeler.Text = "En Çok Kullanılan Kelimeleri Getir";
            this.btnEnCokKelimeler.UseVisualStyleBackColor = true;
            this.btnEnCokKelimeler.Click += new System.EventHandler(this.btnEnCokKelimeler_Click);
            // 
            // btnHashTablosu
            // 
            this.btnHashTablosu.Location = new System.Drawing.Point(12, 144);
            this.btnHashTablosu.Name = "btnHashTablosu";
            this.btnHashTablosu.Size = new System.Drawing.Size(182, 26);
            this.btnHashTablosu.TabIndex = 6;
            this.btnHashTablosu.Text = "Hash Tablosu Oluştur";
            this.btnHashTablosu.UseVisualStyleBackColor = true;
            this.btnHashTablosu.Click += new System.EventHandler(this.btnHashTablosu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 184);
            this.Controls.Add(this.btnHashTablosu);
            this.Controls.Add(this.btnEnCokKelimeler);
            this.Controls.Add(this.btnAgacaAktar);
            this.Controls.Add(this.listIstatistikler);
            this.Controls.Add(this.btnStackYukle);
            this.Controls.Add(this.textBoxMetinOku);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.TextBox textBoxMetinOku;
        private System.Windows.Forms.Button btnStackYukle;
        private System.Windows.Forms.ListView listIstatistikler;
        private System.Windows.Forms.Button btnAgacaAktar;
        private System.Windows.Forms.Button btnEnCokKelimeler;
        private System.Windows.Forms.Button btnHashTablosu;
    }
}

