
namespace odevdeneme2
{
    partial class Adminpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminpanel));
            this.buttonOnayla = new System.Windows.Forms.Button();
            this.comboBoxOnayTuru = new System.Windows.Forms.ComboBox();
            this.listViewislemTur = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReddet = new System.Windows.Forms.Button();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.Location = new System.Drawing.Point(12, 338);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(385, 41);
            this.buttonOnayla.TabIndex = 0;
            this.buttonOnayla.Text = "Onayla";
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // comboBoxOnayTuru
            // 
            this.comboBoxOnayTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOnayTuru.FormattingEnabled = true;
            this.comboBoxOnayTuru.Items.AddRange(new object[] {
            "Alıcı",
            "Satıcı"});
            this.comboBoxOnayTuru.Location = new System.Drawing.Point(332, 12);
            this.comboBoxOnayTuru.Name = "comboBoxOnayTuru";
            this.comboBoxOnayTuru.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOnayTuru.TabIndex = 1;
            this.comboBoxOnayTuru.SelectedIndexChanged += new System.EventHandler(this.comboBoxOnayTuru_SelectedIndexChanged);
            // 
            // listViewislemTur
            // 
            this.listViewislemTur.HideSelection = false;
            this.listViewislemTur.Location = new System.Drawing.Point(12, 78);
            this.listViewislemTur.Name = "listViewislemTur";
            this.listViewislemTur.Size = new System.Drawing.Size(776, 254);
            this.listViewislemTur.TabIndex = 2;
            this.listViewislemTur.UseCompatibleStateImageBehavior = false;
            this.listViewislemTur.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(250, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Onay Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(223, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Onaylanacak Ürünün Sırasını seçip butona tıklayınız";
            // 
            // buttonReddet
            // 
            this.buttonReddet.Location = new System.Drawing.Point(403, 338);
            this.buttonReddet.Name = "buttonReddet";
            this.buttonReddet.Size = new System.Drawing.Size(385, 41);
            this.buttonReddet.TabIndex = 6;
            this.buttonReddet.Text = "Reddet";
            this.buttonReddet.UseVisualStyleBackColor = true;
            this.buttonReddet.Click += new System.EventHandler(this.buttonReddet_Click);
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Location = new System.Drawing.Point(203, 385);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(385, 41);
            this.buttonGeriDon.TabIndex = 7;
            this.buttonGeriDon.Text = "Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // Adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.buttonReddet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewislemTur);
            this.Controls.Add(this.comboBoxOnayTuru);
            this.Controls.Add(this.buttonOnayla);
            this.Name = "Adminpanel";
            this.Text = "Adminpanel";
            this.Load += new System.EventHandler(this.Adminpanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOnayla;
        private System.Windows.Forms.ComboBox comboBoxOnayTuru;
        private System.Windows.Forms.ListView listViewislemTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReddet;
        private System.Windows.Forms.Button buttonGeriDon;
    }
}