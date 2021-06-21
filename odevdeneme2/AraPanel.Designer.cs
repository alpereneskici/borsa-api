
namespace odevdeneme2
{
    partial class AraPanel
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
            this.buttonSatısEkran = new System.Windows.Forms.Button();
            this.buttonEklemeEkranı = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonRaporOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSatısEkran
            // 
            this.buttonSatısEkran.Location = new System.Drawing.Point(12, 12);
            this.buttonSatısEkran.Name = "buttonSatısEkran";
            this.buttonSatısEkran.Size = new System.Drawing.Size(370, 36);
            this.buttonSatısEkran.TabIndex = 0;
            this.buttonSatısEkran.Text = "Satış Ekranı";
            this.buttonSatısEkran.UseVisualStyleBackColor = true;
            this.buttonSatısEkran.Click += new System.EventHandler(this.buttonSatısEkran_Click);
            // 
            // buttonEklemeEkranı
            // 
            this.buttonEklemeEkranı.Location = new System.Drawing.Point(418, 12);
            this.buttonEklemeEkranı.Name = "buttonEklemeEkranı";
            this.buttonEklemeEkranı.Size = new System.Drawing.Size(370, 36);
            this.buttonEklemeEkranı.TabIndex = 1;
            this.buttonEklemeEkranı.Text = "Para/Ürün Ekleme";
            this.buttonEklemeEkranı.UseVisualStyleBackColor = true;
            this.buttonEklemeEkranı.Click += new System.EventHandler(this.buttonEklemeEkranı_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(12, 96);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(776, 36);
            this.buttonGeri.TabIndex = 2;
            this.buttonGeri.Text = "Geri Dön";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonRaporOlustur
            // 
            this.buttonRaporOlustur.Location = new System.Drawing.Point(216, 54);
            this.buttonRaporOlustur.Name = "buttonRaporOlustur";
            this.buttonRaporOlustur.Size = new System.Drawing.Size(370, 36);
            this.buttonRaporOlustur.TabIndex = 3;
            this.buttonRaporOlustur.Text = "Rapor Olustur";
            this.buttonRaporOlustur.UseVisualStyleBackColor = true;
            this.buttonRaporOlustur.Click += new System.EventHandler(this.buttonRaporOlustur_Click);
            // 
            // AraPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::odevdeneme2.Properties.Resources.arkaplangecis;
            this.ClientSize = new System.Drawing.Size(800, 140);
            this.Controls.Add(this.buttonRaporOlustur);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.buttonEklemeEkranı);
            this.Controls.Add(this.buttonSatısEkran);
            this.Name = "AraPanel";
            this.Text = "AraPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSatısEkran;
        private System.Windows.Forms.Button buttonEklemeEkranı;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonRaporOlustur;
    }
}