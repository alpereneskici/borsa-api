
namespace odevdeneme2
{
    partial class AlisverisEkranı
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxUrunTuru = new System.Windows.Forms.ComboBox();
            this.listViewUrunListe = new System.Windows.Forms.ListView();
            this.textBoxAlınacakMiktar = new System.Windows.Forms.TextBox();
            this.buttonSatınAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewYapılanİslem = new System.Windows.Forms.ListView();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTalimat = new System.Windows.Forms.Button();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxTur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZamanTut = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxUrunTuru
            // 
            this.comboBoxUrunTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUrunTuru.FormattingEnabled = true;
            this.comboBoxUrunTuru.Items.AddRange(new object[] {
            "Tüm Liste"});
            this.comboBoxUrunTuru.Location = new System.Drawing.Point(289, 12);
            this.comboBoxUrunTuru.Name = "comboBoxUrunTuru";
            this.comboBoxUrunTuru.Size = new System.Drawing.Size(216, 24);
            this.comboBoxUrunTuru.TabIndex = 0;
            this.comboBoxUrunTuru.SelectedIndexChanged += new System.EventHandler(this.comboBoxUrunTuru_SelectedIndexChanged);
            // 
            // listViewUrunListe
            // 
            this.listViewUrunListe.HideSelection = false;
            this.listViewUrunListe.Location = new System.Drawing.Point(12, 62);
            this.listViewUrunListe.Name = "listViewUrunListe";
            this.listViewUrunListe.Size = new System.Drawing.Size(776, 161);
            this.listViewUrunListe.TabIndex = 1;
            this.listViewUrunListe.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxAlınacakMiktar
            // 
            this.textBoxAlınacakMiktar.Location = new System.Drawing.Point(607, 284);
            this.textBoxAlınacakMiktar.Name = "textBoxAlınacakMiktar";
            this.textBoxAlınacakMiktar.Size = new System.Drawing.Size(102, 22);
            this.textBoxAlınacakMiktar.TabIndex = 2;
            // 
            // buttonSatınAl
            // 
            this.buttonSatınAl.Location = new System.Drawing.Point(491, 351);
            this.buttonSatınAl.Name = "buttonSatınAl";
            this.buttonSatınAl.Size = new System.Drawing.Size(147, 52);
            this.buttonSatınAl.TabIndex = 3;
            this.buttonSatınAl.Text = "Satın Al";
            this.buttonSatınAl.UseVisualStyleBackColor = true;
            this.buttonSatınAl.Click += new System.EventHandler(this.buttonSatınAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(443, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alınacak Ürün Miktar";
            // 
            // listViewYapılanİslem
            // 
            this.listViewYapılanİslem.HideSelection = false;
            this.listViewYapılanİslem.Location = new System.Drawing.Point(21, 289);
            this.listViewYapılanİslem.Name = "listViewYapılanİslem";
            this.listViewYapılanİslem.Size = new System.Drawing.Size(384, 149);
            this.listViewYapılanİslem.TabIndex = 6;
            this.listViewYapılanİslem.UseCompatibleStateImageBehavior = false;
            this.listViewYapılanİslem.View = System.Windows.Forms.View.Details;
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Location = new System.Drawing.Point(559, 409);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(174, 42);
            this.buttonGeriDon.TabIndex = 7;
            this.buttonGeriDon.Text = "Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Listelenecek Ürün Türünü Seçiniz";
            // 
            // buttonTalimat
            // 
            this.buttonTalimat.Location = new System.Drawing.Point(644, 351);
            this.buttonTalimat.Name = "buttonTalimat";
            this.buttonTalimat.Size = new System.Drawing.Size(159, 52);
            this.buttonTalimat.TabIndex = 9;
            this.buttonTalimat.Text = "Talimat Oluştur";
            this.buttonTalimat.UseVisualStyleBackColor = true;
            this.buttonTalimat.Click += new System.EventHandler(this.buttonTalimat_Click_1);
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(607, 312);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(102, 22);
            this.textBoxFiyat.TabIndex = 10;
            // 
            // textBoxTur
            // 
            this.textBoxTur.Location = new System.Drawing.Point(607, 256);
            this.textBoxTur.Name = "textBoxTur";
            this.textBoxTur.Size = new System.Drawing.Size(102, 22);
            this.textBoxTur.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(435, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Alınacak Ürünün Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(422, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alınacak Maximum Fiyat";
            // 
            // ZamanTut
            // 
            this.ZamanTut.Tick += new System.EventHandler(this.ZamanTut_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(624, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(541, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Saniye Sonra Talimatlara bakılacak";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(95, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Anlık Yapılan İslemler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 17;
            // 
            // AlisverisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::odevdeneme2.Properties.Resources.arkaplangecis;
            this.ClientSize = new System.Drawing.Size(812, 458);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTur);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.buttonTalimat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.listViewYapılanİslem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSatınAl);
            this.Controls.Add(this.textBoxAlınacakMiktar);
            this.Controls.Add(this.listViewUrunListe);
            this.Controls.Add(this.comboBoxUrunTuru);
            this.Name = "AlisverisEkranı";
            this.Text = "AlısverisEkranı";
            this.Load += new System.EventHandler(this.AlısverisEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUrunTuru;
        private System.Windows.Forms.ListView listViewUrunListe;
        private System.Windows.Forms.TextBox textBoxAlınacakMiktar;
        private System.Windows.Forms.Button buttonSatınAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewYapılanİslem;
        private System.Windows.Forms.Button buttonGeriDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTalimat;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.TextBox textBoxTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ZamanTut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}