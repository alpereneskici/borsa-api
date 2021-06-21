
namespace odevdeneme2
{
    partial class GirisEkrani
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKayıtOl = new System.Windows.Forms.Button();
            this.LoginTcKimlikNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(80, 84);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 27);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Giriş";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginSifre
            // 
            this.LoginSifre.Location = new System.Drawing.Point(80, 56);
            this.LoginSifre.Name = "LoginSifre";
            this.LoginSifre.PasswordChar = '*';
            this.LoginSifre.Size = new System.Drawing.Size(100, 22);
            this.LoginSifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // buttonKayıtOl
            // 
            this.buttonKayıtOl.Location = new System.Drawing.Point(80, 117);
            this.buttonKayıtOl.Name = "buttonKayıtOl";
            this.buttonKayıtOl.Size = new System.Drawing.Size(100, 29);
            this.buttonKayıtOl.TabIndex = 6;
            this.buttonKayıtOl.Text = "Kayıt Ol";
            this.buttonKayıtOl.UseVisualStyleBackColor = true;
            this.buttonKayıtOl.Click += new System.EventHandler(this.buttonKayıtOl_Click);
            // 
            // LoginTcKimlikNo
            // 
            this.LoginTcKimlikNo.Location = new System.Drawing.Point(80, 28);
            this.LoginTcKimlikNo.MaxLength = 11;
            this.LoginTcKimlikNo.Name = "LoginTcKimlikNo";
            this.LoginTcKimlikNo.Size = new System.Drawing.Size(100, 22);
            this.LoginTcKimlikNo.TabIndex = 7;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::odevdeneme2.Properties.Resources.arkaplangecis;
            this.ClientSize = new System.Drawing.Size(209, 156);
            this.Controls.Add(this.LoginTcKimlikNo);
            this.Controls.Add(this.buttonKayıtOl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginSifre);
            this.Controls.Add(this.LoginButton);
            this.Name = "GirisEkrani";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox LoginSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKayıtOl;
        private System.Windows.Forms.TextBox LoginTcKimlikNo;
    }
}

