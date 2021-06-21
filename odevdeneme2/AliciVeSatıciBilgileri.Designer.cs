
namespace odevdeneme2
{
    partial class AliciVeSatıciBilgileri
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
            this.comboBoxKullanıcıTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.textBoxPm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUrunMk = new System.Windows.Forms.TextBox();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.textBoxBirimFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxParaCesiti = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxKullanıcıTipi
            // 
            this.comboBoxKullanıcıTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKullanıcıTipi.FormattingEnabled = true;
            this.comboBoxKullanıcıTipi.Items.AddRange(new object[] {
            "Alıcı",
            "Satıcı"});
            this.comboBoxKullanıcıTipi.Location = new System.Drawing.Point(276, 22);
            this.comboBoxKullanıcıTipi.Name = "comboBoxKullanıcıTipi";
            this.comboBoxKullanıcıTipi.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKullanıcıTipi.TabIndex = 0;
            this.comboBoxKullanıcıTipi.SelectedIndexChanged += new System.EventHandler(this.comboBoxKullanıcıTipi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşlem Yapacağınız Kullanıcı Tipi";
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(276, 132);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(121, 23);
            this.buttonGonder.TabIndex = 2;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // textBoxPm
            // 
            this.textBoxPm.Location = new System.Drawing.Point(276, 52);
            this.textBoxPm.Name = "textBoxPm";
            this.textBoxPm.Size = new System.Drawing.Size(121, 22);
            this.textBoxPm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Para Miktarı";
            // 
            // textBoxUrunMk
            // 
            this.textBoxUrunMk.Location = new System.Drawing.Point(276, 80);
            this.textBoxUrunMk.Name = "textBoxUrunMk";
            this.textBoxUrunMk.Size = new System.Drawing.Size(121, 22);
            this.textBoxUrunMk.TabIndex = 5;
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Location = new System.Drawing.Point(276, 161);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(121, 23);
            this.buttonGeriDon.TabIndex = 7;
            this.buttonGeriDon.Text = "Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // textBoxBirimFiyat
            // 
            this.textBoxBirimFiyat.Location = new System.Drawing.Point(276, 108);
            this.textBoxBirimFiyat.Name = "textBoxBirimFiyat";
            this.textBoxBirimFiyat.Size = new System.Drawing.Size(121, 22);
            this.textBoxBirimFiyat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Birim Fiyat\'ı (KG/TL)\r\n";
            // 
            // comboBoxParaCesiti
            // 
            this.comboBoxParaCesiti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParaCesiti.FormattingEnabled = true;
            this.comboBoxParaCesiti.Items.AddRange(new object[] {
            "TL",
            "USD",
            "CAD",
            "EUR"});
            this.comboBoxParaCesiti.Location = new System.Drawing.Point(403, 52);
            this.comboBoxParaCesiti.Name = "comboBoxParaCesiti";
            this.comboBoxParaCesiti.Size = new System.Drawing.Size(56, 24);
            this.comboBoxParaCesiti.TabIndex = 10;
            // 
            // AliciVeSatıciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::odevdeneme2.Properties.Resources.arkaplangecis;
            this.ClientSize = new System.Drawing.Size(463, 187);
            this.Controls.Add(this.comboBoxParaCesiti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBirimFiyat);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUrunMk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPm);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKullanıcıTipi);
            this.Name = "AliciVeSatıciBilgileri";
            this.Text = "Para/Ürün Ekleme";
            this.Load += new System.EventHandler(this.AlıcıVeSatıcıBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKullanıcıTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.TextBox textBoxPm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUrunMk;
        private System.Windows.Forms.Button buttonGeriDon;
        private System.Windows.Forms.TextBox textBoxBirimFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxParaCesiti;
    }
}