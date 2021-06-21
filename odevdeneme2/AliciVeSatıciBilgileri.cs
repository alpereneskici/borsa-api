﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace odevdeneme2
{
    public partial class AliciVeSatıciBilgileri : Form
    {
        public AliciVeSatıciBilgileri()
        {
            InitializeComponent();
        }


        public string tc { get; set; }
        public string usertypes { get; set; }
        private void AlıcıVeSatıcıBilgileri_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBoxUrunMk.Visible = false;
            label2.Visible = false;
            textBoxPm.Visible = false;
            comboBoxParaCesiti.Text = "TL";
            comboBoxParaCesiti.Visible = false;
            label4.Visible = false;
            textBoxBirimFiyat.Visible = false;
        }

       

        private void comboBoxKullanıcıTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seçime göre textbox geitriyor ekrana
            if (comboBoxKullanıcıTipi.SelectedItem.ToString() == "Alıcı")
            {
                label2.Visible = true;
                comboBoxParaCesiti.Visible = true;
                textBoxPm.Visible = true;
                label3.Visible = false;
                textBoxUrunMk.Visible = false;
                label4.Visible = false;
                textBoxBirimFiyat.Visible = false;
            }
            else if (comboBoxKullanıcıTipi.SelectedItem.ToString() == "Satıcı")
            {
                textBoxPm.Text = "";
                label4.Visible = true;
                label4.Text = "Ürün Birim Fiyat'ı (KG/TL ";
                textBoxBirimFiyat.Visible = true;
                label2.Visible = true;
                comboBoxParaCesiti.Visible = false;
                textBoxPm.Visible = true;
                label3.Visible = true;
                textBoxUrunMk.Visible = true;
                label3.Text = "Ürün Miktarı";
                label2.Text = "Ürün Türü";
            }
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());
           
          
            List<string> urunler = new List<string>();
            List<string> urunid = new List<string>();
            urunler = accsessmanager.select(tc, "TC", "UrunTipi", "Urunler"); // giriş yapan kullanıcının sahip olduğu ürünleri alıyor
            urunid = accsessmanager.select(tc, "TC", "id", "Urunler");

            if (comboBoxKullanıcıTipi.SelectedItem.ToString() == "Alıcı")
            {

                accsessmanager.Update("Banka", "OnayBekleyenBakiye", textBoxPm.Text, tc, "TC");
                accsessmanager.Update("Banka", "OnayBekleyenBakiyeTur", comboBoxParaCesiti.Text, tc, "TC");
                accsessmanager.Update("Banka", "BakiyeOnayDurumu", "Onay Bekleniyor", tc, "TC");
            }
            else if (comboBoxKullanıcıTipi.SelectedItem.ToString() == "Satıcı")
            {

                if (urunler.Contains(textBoxPm.Text)) // eğer kullanıcı bu ürünü daha önce listelediyse sadece stok güncellemesi yapıyor     
                {
                    int a = urunler.IndexOf(textBoxPm.Text);
                    string b = urunid[a];
                    int c = Convert.ToInt32(b);

                    accsessmanager.Update("Urunler", "OnayBekleyenUrunMiktar", textBoxUrunMk.Text, c, "id");
                    accsessmanager.Update("Urunler", "UrunOnayDurumu", "Onay Bekleniyor", c, "id");
                    accsessmanager.Update("Urunler", "UrunSatisFiyatı", textBoxBirimFiyat.Text, c, "id");
                }
                else  // eğer kullanıcı bu ürünü daha önce listelemediyse ekleme işlemi yapıyor 
                {

                    accsessmanager.CustomerAdd(tc, textBoxPm.Text, "TC", "UrunTipi", "Urunler");
                    urunler = accsessmanager.select(tc, "TC", "UrunTipi", "Urunler");
                    urunid = accsessmanager.select(tc, "TC", "id", "Urunler");
                    int a = urunler.IndexOf(textBoxPm.Text);
                    string b = urunid[a];
                    int c = Convert.ToInt32(b);
                    accsessmanager.Update("Urunler", "UrunMiktarı", "0", c, "id");
                    accsessmanager.Update("Urunler", "OnayBekleyenUrunMiktar", textBoxUrunMk.Text, c, "id");
                    accsessmanager.Update("Urunler", "UrunOnayDurumu", "Onay Bekleniyor", c, "id");
                    accsessmanager.Update("Urunler", "UrunSatisFiyatı", textBoxBirimFiyat.Text, c, "id");
                }


            }
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AraPanel f1 = new AraPanel();
            f1.Show();
            this.Hide();
        }
    }
    }

