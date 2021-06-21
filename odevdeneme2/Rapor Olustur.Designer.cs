
namespace odevdeneme2
{
    partial class Rapor_Olustur
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
            this.buttonRaporOlustur = new System.Windows.Forms.Button();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRaporOlustur
            // 
            this.buttonRaporOlustur.Location = new System.Drawing.Point(177, 94);
            this.buttonRaporOlustur.Name = "buttonRaporOlustur";
            this.buttonRaporOlustur.Size = new System.Drawing.Size(200, 46);
            this.buttonRaporOlustur.TabIndex = 0;
            this.buttonRaporOlustur.Text = "Rapor Oluştur";
            this.buttonRaporOlustur.UseVisualStyleBackColor = true;
            this.buttonRaporOlustur.Click += new System.EventHandler(this.buttonRaporOlustur_Click);
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(177, 24);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBaslangic.TabIndex = 1;
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Location = new System.Drawing.Point(177, 66);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBitis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(177, 146);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(200, 46);
            this.buttonGeri.TabIndex = 5;
            this.buttonGeri.Text = "GeriDon";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // Rapor_Olustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::odevdeneme2.Properties.Resources.arkaplangecis;
            this.ClientSize = new System.Drawing.Size(417, 198);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerBitis);
            this.Controls.Add(this.dateTimePickerBaslangic);
            this.Controls.Add(this.buttonRaporOlustur);
            this.Name = "Rapor_Olustur";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Olustur";
            this.Load += new System.EventHandler(this.Rapor_Olustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRaporOlustur;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGeri;
    }
}