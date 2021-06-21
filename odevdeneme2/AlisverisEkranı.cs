using odevdeneme2.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevdeneme2
{
    public partial class AlisverisEkranı : Form
    {
        public AlisverisEkranı()
        {
            InitializeComponent();
        }
        public string giristc { get; set; }
      // satıcı ürünlerini listeler
        public void satıcılis()
        {
            listViewUrunListe.View = View.Details;
            listViewUrunListe.Items.Clear();
            listViewUrunListe.Columns.Clear();

            listViewUrunListe.Columns.Add("TC", 60, HorizontalAlignment.Left);
            listViewUrunListe.Columns.Add("Ad", 60, HorizontalAlignment.Left);
            listViewUrunListe.Columns.Add("Soyad", 60, HorizontalAlignment.Left);
            listViewUrunListe.Columns.Add("Ürün Türü", 60, HorizontalAlignment.Left);

            listViewUrunListe.Columns.Add("Ürün Miktarı", 60, HorizontalAlignment.Left);

            listViewUrunListe.Columns.Add("Birim Satış Fiyatı", 150, HorizontalAlignment.Left);



            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());
            List<string> TC = new List<string>();
          if(comboBoxUrunTuru.Text=="Tüm Liste")
            {
                TC = accsessmanager.select("Onaylandı", "UrunOnayDurumu", "TC", "Urunler", "UrunSatisFiyatı");
            }
          else
            {
                TC = accsessmanager.select(comboBoxUrunTuru.Text, "UrunTipi", "TC", "Urunler", "UrunSatisFiyatı");
            }
           








            int i = 0;
            foreach(string tc in TC)
            {
                int kontrol = accsessmanager.tekselectint(tc, "TC", "UrunMiktarı", "Urunler");
                    if(kontrol!=0)
                {
                    listViewUrunListe.Items.Add(tc);
                    listViewUrunListe.Items[i].SubItems.Add(accsessmanager.tekselect(tc, "TC", "Ad", "Login"));
                    listViewUrunListe.Items[i].SubItems.Add(accsessmanager.tekselect(tc, "TC", "Soyad", "Login"));
                    listViewUrunListe.Items[i].SubItems.Add(accsessmanager.tekselect(tc, "TC", "UrunTipi", "Urunler"));
                    listViewUrunListe.Items[i].SubItems.Add(accsessmanager.tekselectint(tc, "TC", "UrunMiktarı", "Urunler").ToString() + "KG");
                    listViewUrunListe.Items[i].SubItems.Add(accsessmanager.tekselect(tc, "TC", "UrunSatisFiyatı", "Urunler").ToString() + "TL");
                    i++;
                }
              
            }
           

        }
        public void islem()
        {
            listViewYapılanİslem.View = View.Details;
            listViewYapılanİslem.Items.Clear();
            listViewYapılanİslem.Columns.Clear();

            listViewYapılanİslem.Columns.Add("İşlem Zamanı", 60, HorizontalAlignment.Left);
            listViewYapılanİslem.Columns.Add("Yapılan İşlem Detayları", 100, HorizontalAlignment.Left);
            listViewYapılanİslem.Columns.Add("Harcanan Tutar", 60, HorizontalAlignment.Left);
            listViewYapılanİslem.Columns.Add("Alıcının Kalan Parası", 100, HorizontalAlignment.Left);
            listViewYapılanİslem.Columns.Add("Satılan Malın Birim Fiyatı", 60, HorizontalAlignment.Left);

            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());
          

        }
        int zamansay = 120;
        private void AlısverisEkranı_Load(object sender, EventArgs e)
        {
            islem();
            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());
            List<string> a = new List<string>();
         // ürün tiplerini seçim listesine yazar
            a = accsessmanager.select("Onaylandı", "UrunOnayDurumu", "UrunTipi","Urunler");
      
            List<string> b= a.Distinct().ToList();
            foreach(string d in b)
            {
                comboBoxUrunTuru.Items.Add(d);
            }
            satıcılis();

            ZamanTut.Interval = 100;
            ZamanTut.Enabled = true;

        }


        int indis = 0;
        void islemlistele(string tarih)
        {
            
            CustomerManager veritabanı = new CustomerManager(new AccesCustomerDAL());
            
            string alantc = veritabanı.tekselect(tarih,"tarih","Alantc","İslemler");
            string Satantc = veritabanı.tekselect(tarih, "tarih", "Satantc", "İslemler");
            string alanad = veritabanı.tekselect(alantc, "TC", "Ad", "Login");
            string Satanad = veritabanı.tekselect(Satantc, "TC", "Ad", "Login");
            string alınanurun = veritabanı.tekselect(tarih, "tarih", "AlınanUrunTuru", "İslemler");
            string alınanurunmiktar = veritabanı.tekselect(tarih, "tarih", "AlınanUrunTuru", "İslemler");
            string toplamfiyat= veritabanı.tekselect(tarih, "tarih", "ToplamTutar", "İslemler");
           string birimfiyat= veritabanı.tekselect(tarih, "tarih", "BirimFiyat", "İslemler");
            listViewYapılanİslem.Items.Add(tarih);
            listViewYapılanİslem.Items[indis].SubItems.Add(alanad+" "+alınanurunmiktar + " Kg "+ alınanurun+" Almak isterse "+birimfiyat+" TL'den islem gerceklesir");

            listViewYapılanİslem.Items[indis].SubItems.Add(alanad+" "+Satanad+"'ın hesabına"+toplamfiyat+"TL gönderdi");

            listViewYapılanİslem.Items[indis].SubItems.Add(alanad+"'ın "+veritabanı.tekselect(alantc, "TC", "Bakiye", "Banka")+"Tl parası Kaldı");

            listViewYapılanİslem.Items[indis].SubItems.Add(birimfiyat);
         
        }
        private void comboBoxUrunTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            satıcılis();
        }
      
        void satınal(string comboboxUrunTuru, string txtalınacakmiktar,string GonderTC)
        {
            int satınaldiziindis = 0;
            string tarih = DateTime.Now.ToString();
            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL()); // DAL BAĞLANTISI
            List<string> TC = new List<string>(); // TÜM TCLERİ TUTUYOR
            List<string> TCy = new List<string>();// STOK OLAN TCLERİ TUTUYOR
            List<int> toplamstok = new List<int>();
            TC = accsessmanager.select(comboboxUrunTuru, "UrunTipi", "TC", "Urunler", "UrunSatisFiyatı"); // TÜM TCLERİ ALIYOR
            foreach (string stokkntrol in TC)
            {
                if ((accsessmanager.tekselectint(stokkntrol, "TC", "UrunMiktarı", "Urunler")) != 0)// STOK OLAN TCLERİ KONTROL EDİYOR
                {
                    TCy.Add(stokkntrol);
                }
            }
 

            int urunstok, alınacakmiktar;
            string urunbirimfiyat, sahipolunanpara;
            
        
             sahipolunanpara = accsessmanager.tekselect(GonderTC, "TC", "Bakiye", "Banka"); // giriş yapan kullanıcının parasını tutuyor

            int topstoktut = 0;
            toplamstok = accsessmanager.selectint("Onaylandı", "UrunOnayDurumu", "UrunMiktarı", "Urunler"); // veritabanında ki  stokları alıyor
            foreach (int t in toplamstok) //  stokları topluyor
            {
                topstoktut = topstoktut +t;
            }
            Thread.Sleep(20);
            alınacakmiktar = Convert.ToInt32(txtalınacakmiktar);
            if (topstoktut < Convert.ToInt32(txtalınacakmiktar))
            {
                MessageBox.Show("Stoklarda Aradığınız Kriterlere Uygun ürün Yok lütfen talimat oluşturunuz");

            }
            else
            {

                Boolean parayetmiyor = false;
                while (alınacakmiktar != 0)                //alınacak miktar 0 olana kadar dönecek bir döngü oluşturdum 
                {


                    urunbirimfiyat = accsessmanager.tekselect(TCy[satınaldiziindis], "TC", "UrunSatisFiyatı", "Urunler");

                   
                    urunstok = accsessmanager.tekselectint(TCy[satınaldiziindis], "TC", "UrunMiktarı", "Urunler"); // ürün stoğunu alıyr
                 

                    if (parayetmiyor != true) // para varmı kontrol ediyor
                    {
                      
                        
                        if (alınacakmiktar >= urunstok) // alınacak miktar en ucuz ürünün stoğunda var mı kontrol ediyor
                        {
                            decimal komisyon = ((Convert.ToDecimal(urunstok) * Convert.ToDecimal(urunbirimfiyat)) * Convert.ToDecimal(1)) / Convert.ToDecimal(100);
                            sahipolunanpara = (Convert.ToDecimal((sahipolunanpara)) - (komisyon)).ToString();

                            string muhasebeparatut = accsessmanager.tekselect("Muhasebe", "TC", "Bakiye", "Banka");
                            accsessmanager.Update("Banka", "Bakiye", (Convert.ToDecimal(muhasebeparatut) + (komisyon)).ToString(), "Muhasebe", "TC");
                            if (Convert.ToDecimal(sahipolunanpara) >= Convert.ToDecimal((urunstok * Convert.ToDecimal(urunbirimfiyat)))) // paramızın stoktakilerin hepsini almaya  yetiyorsa güncelleme işlemlerini yapmaya yarıyor
                            {
                             
                                alınacakmiktar = alınacakmiktar - urunstok;
                                sahipolunanpara = (Convert.ToDecimal(sahipolunanpara) - Convert.ToDecimal((urunstok * Convert.ToDecimal(urunbirimfiyat)))).ToString();
                                accsessmanager.Update("Banka", "Bakiye", sahipolunanpara, GonderTC, "TC");

                                Decimal satıcıparatut = Convert.ToDecimal(accsessmanager.tekselect(TCy[satınaldiziindis], "TC", "Bakiye", "Banka"));
                                Decimal bakiyee = (satıcıparatut) + Convert.ToDecimal((urunstok * Convert.ToDecimal(urunbirimfiyat)));
                                accsessmanager.Update("Banka", "Bakiye", bakiyee, TCy[satınaldiziindis], "TC");
                                int id = accsessmanager.tekselectint(TCy[satınaldiziindis], "TC", "id", "Urunler");
                                accsessmanager.Update("Urunler", "UrunMiktarı", "0",id, "id");
                               

                                accsessmanager.CustomerAdd(tarih, "tarih", "islemler");
                                accsessmanager.Update("islemler", "Satantc", TCy[satınaldiziindis],tarih, "tarih");
                                accsessmanager.Update("islemler", "Alantc", GonderTC, tarih, "tarih");
                                accsessmanager.Update("islemler", "AlınanUrunMiktar", urunstok, tarih, "tarih");
                                accsessmanager.Update("islemler", "AlınanUrunTuru", comboboxUrunTuru, tarih, "tarih");
                                accsessmanager.Update("islemler", "ToplamTutar", (urunstok* Convert.ToDecimal(urunbirimfiyat)), tarih, "tarih");
                                accsessmanager.Update("islemler", "BirimFiyat", (urunbirimfiyat), tarih, "tarih");

                               


                            }
                         
                            else // paramızın stoktakilerin hepsini almaya yetmiyorsa alınacak miktarı belirleyip  güncelleme işlemlerini yapmaya yarıyor
                            {

                               
                                alınacakmiktar = alınacakmiktar - Convert.ToInt32((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)));
                                accsessmanager.Update("Banka", "Bakiye", 0, GonderTC, "TC");

                                MessageBox.Show("Paranız " +((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat))).ToString() + " Tane Almanıza Yetiyorr");
                                int satıcıparatut = accsessmanager.tekselectint(TCy[satınaldiziindis], "TC", "Bakiye", "Banka");

                                accsessmanager.Update("Banka", "Bakiye", ((satıcıparatut) + (sahipolunanpara)), TCy[satınaldiziindis], "TC");
                                int id = accsessmanager.tekselectint(TCy[satınaldiziindis], "TC", "id", "Urunler");
                                accsessmanager.Update("Urunler", "UrunMiktarı", ((urunstok) - (Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat))).ToString(), Convert.ToInt32(id), "id");
                               
                               

                                accsessmanager.CustomerAdd(tarih, "tarih", "islemler");
                                accsessmanager.Update("islemler", "Satantc", TCy[satınaldiziindis], tarih, "tarih");
                                accsessmanager.Update("islemler", "Alantc", GonderTC, tarih, "tarih");
                                accsessmanager.Update("islemler", "AlınanUrunMiktar", (Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)).ToString(), tarih, "tarih");
                                accsessmanager.Update("islemler", "BirimFiyat", (urunbirimfiyat), tarih, "tarih");
                                accsessmanager.Update("islemler", "AlınanUrunTuru", comboboxUrunTuru, tarih, "tarih");
                                accsessmanager.Update("islemler", "ToplamTutar", sahipolunanpara, tarih, "tarih");

                                islemlistele(tarih); indis++;
                                parayetmiyor = true;
                                break;

                            }

                        }
                        else
                        {
                            decimal komisyon = ((Convert.ToDecimal(urunstok) * Convert.ToDecimal(urunbirimfiyat)) * Convert.ToDecimal(1)) / Convert.ToDecimal(100);
                            sahipolunanpara = (Convert.ToDecimal((sahipolunanpara)) - (komisyon)).ToString();
                            string muhasebeparatut = accsessmanager.tekselect("Muhasebe", "TC", "Bakiye", "Banka");
                            accsessmanager.Update("Banka", "Bakiye", (Convert.ToDecimal(muhasebeparatut) + (komisyon)).ToString(), "Muhasebe", "TC");

                            if (Convert.ToDecimal(sahipolunanpara) >= Convert.ToDecimal((alınacakmiktar * Convert.ToDecimal(urunbirimfiyat)))) // sahip olunan para alınacakmiktarın fiyatına yetiyor mu kontrol ediyor ediyorsa güncelleme işlemlerini yapar
                            {
                                urunstok = urunstok - alınacakmiktar;
                                sahipolunanpara = (Convert.ToDecimal(sahipolunanpara) - Convert.ToDecimal((alınacakmiktar * Convert.ToDecimal(urunbirimfiyat)))).ToString();
                                accsessmanager.Update("Banka", "Bakiye", sahipolunanpara, GonderTC, "TC");


                                int satıcıparatut = accsessmanager.tekselectint(TCy[satınaldiziindis], "TC", "Bakiye", "Banka");

                                accsessmanager.Update("Banka", "Bakiye", ((satıcıparatut) + (alınacakmiktar * Convert.ToDecimal(urunbirimfiyat))), TCy[satınaldiziindis], "TC");
                                int id = accsessmanager.tekselectint(TCy[satınaldiziindis], "TC", "id", "Urunler");
                                accsessmanager.Update("Urunler", "UrunMiktarı", (urunstok), id, "id");



                           
                                 accsessmanager.CustomerAdd(tarih, "tarih", "islemler");
                                accsessmanager.Update("islemler", "Satantc", TCy[satınaldiziindis], tarih, "tarih");
                                accsessmanager.Update("islemler", "Alantc", GonderTC, tarih, "tarih");
                                accsessmanager.Update("islemler", "AlınanUrunMiktar", alınacakmiktar, tarih, "tarih");
                                accsessmanager.Update("islemler", "BirimFiyat", (urunbirimfiyat), tarih, "tarih");
                                accsessmanager.Update("islemler", "AlınanUrunTuru", comboboxUrunTuru, tarih, "tarih");
                                accsessmanager.Update("islemler", "ToplamTutar", (alınacakmiktar * Convert.ToDecimal(urunbirimfiyat)), tarih, "tarih");
                        
                                alınacakmiktar = 0;
                                break;
                            }
                            else        //sahip olunan para alınacak miktarın parasına yetmiyorsa alınacak miktarı belirleyip güncelleme işlemlerini yapıyor
                            {
                                urunstok = urunstok - Convert.ToInt32((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)));
                                accsessmanager.Update("Banka", "Bakiye", "0", GonderTC, "TC");


                                MessageBox.Show("Paranız " + (Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)).ToString() + " Tane Almanıza Yetiyorr");

                                int satıcıparatut = accsessmanager.tekselectint(TCy[satınaldiziindis], "TC", "Bakiye", "Banka");

                                accsessmanager.Update("Banka", "Bakiye", ((satıcıparatut) + (sahipolunanpara)), TCy[satınaldiziindis], "TC");
                                int id = accsessmanager.tekselectint(TCy[satınaldiziindis], "TC", "id", "Urunler");
                                accsessmanager.Update("Urunler", "UrunMiktarı", (urunstok - Convert.ToInt32((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)))).ToString(), Convert.ToInt32(id), "id");


                     

                                accsessmanager.CustomerAdd(tarih, "tarih", "islemler");
                                accsessmanager.Update("islemler", "Satantc", TCy[satınaldiziindis], tarih, "tarih");
                                accsessmanager.Update("islemler", "Alantc", GonderTC, tarih, "tarih");
                                accsessmanager.Update("islemler", "AlınanUrunMiktar", (Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)).ToString(), tarih, "tarih");
                                accsessmanager.Update("islemler", "AlınanUrunTuru", comboboxUrunTuru, tarih, "tarih"); 
                                accsessmanager.Update("islemler", "BirimFiyat", (urunbirimfiyat), tarih, "tarih");
                                accsessmanager.Update("islemler", "ToplamTutar", sahipolunanpara, tarih, "tarih");
                                parayetmiyor = true;
                                islemlistele(tarih); indis++;
                            }
                         

                        }
                            
                    }
                    else // sahip olunan paranın yettiği kadar alınacakmiktar'dan alıp döngüyü durduruyor
                    {
                        MessageBox.Show("Paranız Bitti");
                        break;
                    }
                    islemlistele(tarih); indis++;
                }
            }
            
        }
        void satınal(string comboboxUrunTuru,string txtalınacakmiktar)
        {
            int satınaldiziindis = 0;
            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL()); // DAL BAĞLANTISI
            List<string> TC = new List<string>(); // TÜM TCLERİ TUTUYOR
            List<string> TCy = new List<string>();// STOK OLAN TCLERİ TUTUYOR
            List<string> toplamstok = new List<string>();
            TC = accsessmanager.select(comboboxUrunTuru, "UrunTipi", "TC", "Urunler", "UrunSatisFiyatı"); // TÜM TCLERİ ALIYOR
            foreach (string stokkntrol in TC)
            {
                if ((accsessmanager.tekselectint(stokkntrol, "TC", "UrunMiktarı", "Urunler")) != 0)// STOK OLAN TCLERİ KONTROL EDİYOR
                {
                    TCy.Add(stokkntrol);
                }
            }

            int urunstok, alınacakmiktar;
            string urunbirimfiyat, sahipolunanpara;
            sahipolunanpara = (accsessmanager.tekselect(giristc, "TC", "Bakiye", "Banka")); // giriş yapan kullanıcının parasını tutuyor
            int a = 0;
            int topstoktut = 0;
            toplamstok = accsessmanager.select("Onaylandı", "UrunOnayDurumu", "UrunMiktarı", "Urunler"); // veritabanında ki  stokları alıyor
            foreach (string t in toplamstok) //  stokları topluyor
            {
                topstoktut = topstoktut + Convert.ToInt32(t);
            }
            alınacakmiktar = Convert.ToInt32(txtalınacakmiktar);
            if (topstoktut < Convert.ToInt32(txtalınacakmiktar))
            {
                MessageBox.Show("Stoklarda Aradığınız Kriterlere Uygun ürün Yok lütfen talimat oluşturunuz");

            }
            else
            {
                Boolean parayetmiyor = false;

                while (alınacakmiktar != 0)                //alınacak miktar 0 olana kadar dönecek bir döngü oluşturdum 
                {
                    string tarih = DateTime.Now.ToString();
                    if (a > TCy.Count())
                    {
                        MessageBox.Show("Aradığınız ürün aradığınız fiyata  Yok Lütfen Talimat Olusturun");
                    }
                    else
                    {

                    urunbirimfiyat = accsessmanager.tekselect(TCy[a], "TC", "UrunSatisFiyatı", "Urunler"); // ürnün birim fiyatını alıyor

                    urunstok = accsessmanager.tekselectint(TCy[a], "TC", "UrunMiktarı", "Urunler"); // ürün stoğunu alıyr
                 

                        if (parayetmiyor != true) // para varmı kontrol ediyor
                        {
                            if (alınacakmiktar >= urunstok) // alınacak miktar en ucuz ürünün stoğunda var mı kontrol ediyor
                            {
                                decimal komisyon = ((Convert.ToDecimal(urunstok) * Convert.ToDecimal(urunbirimfiyat)) * Convert.ToDecimal(1)) / Convert.ToDecimal(100);
                                sahipolunanpara = (Convert.ToDecimal((sahipolunanpara)) - (komisyon)).ToString();

                                string muhasebeparatut = accsessmanager.tekselect("Muhasebe", "TC", "Bakiye", "Banka");
                                accsessmanager.Update("Banka", "Bakiye", (Convert.ToDecimal(muhasebeparatut) + (komisyon)).ToString(), "Muhasebe", "TC");

                                if (Convert.ToDecimal(sahipolunanpara) >= Convert.ToDecimal((urunstok * Convert.ToDecimal(urunbirimfiyat)))) // paramızın stoktakilerin hepsini almaya  yetiyorsa güncelleme işlemlerini yapmaya yarıyor
                                {

                                    alınacakmiktar = alınacakmiktar - urunstok;
                                    sahipolunanpara = (Convert.ToDecimal(sahipolunanpara) - Convert.ToDecimal((urunstok * Convert.ToDecimal(urunbirimfiyat)))).ToString();
                                    accsessmanager.Update("Banka", "Bakiye", sahipolunanpara, giristc, "TC");

                                    int satıcıparatut = accsessmanager.tekselectint(TCy[a], "TC", "Bakiye", "Banka");
                                    string bakiyee = ((Convert.ToDecimal(satıcıparatut)) + Convert.ToDecimal((urunstok * Convert.ToDecimal(urunbirimfiyat)))).ToString();
                                    accsessmanager.Update("Banka", "Bakiye", bakiyee, TCy[a], "TC");
                                    int id = accsessmanager.tekselectint(TCy[a], "TC", "id", "Urunler");
                                    accsessmanager.Update("Urunler", "UrunMiktarı", "0", Convert.ToInt32(id), "id");
                              
                               
                                        accsessmanager.Update("Banka", "Bakiye", accsessmanager.tekselectint(giristc, "TC", "Bakiye", "Banka"), giristc, "TC");

                                

                                    accsessmanager.CustomerAdd(tarih, "tarih", "islemler");
                                    accsessmanager.Update("islemler", "Satantc", TCy[satınaldiziindis], tarih, "tarih");
                                    accsessmanager.Update("islemler", "Alantc", giristc, tarih, "tarih");
                                    accsessmanager.Update("islemler", "AlınanUrunMiktar", (urunstok), tarih, "tarih");
                                    accsessmanager.Update("islemler", "AlınanUrunTuru", comboboxUrunTuru, tarih, "tarih");
                                    accsessmanager.Update("islemler", "BirimFiyat", urunbirimfiyat, tarih, "tarih");
                                    accsessmanager.Update("islemler", "ToplamTutar", (urunstok * Convert.ToDecimal(urunbirimfiyat)), tarih, "tarih");
                               

                                    a++;
                                }
                                else // paramızın stoktakilerin hepsini almaya yetmiyorsa alınacak miktarı belirleyip  güncelleme işlemlerini yapmaya yarıyor
                                {

                                    alınacakmiktar = alınacakmiktar -Convert.ToInt32((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)));
                                    accsessmanager.Update("Banka", "Bakiye",0, giristc, "TC");

                                 
                                    int satıcıparatut = accsessmanager.tekselectint(TCy[a], "TC", "Bakiye", "Banka");

                                    accsessmanager.Update("Banka", "Bakiye", (Convert.ToDecimal((satıcıparatut)) + Convert.ToDecimal((sahipolunanpara))).ToString(), TCy[a], "TC");
                                    int id = accsessmanager.tekselectint(TCy[a], "TC", "id", "Urunler");
                                    accsessmanager.Update("Urunler", "UrunMiktarı", ((urunstok) - Convert.ToInt32((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)))), Convert.ToInt32(id), "id");


                          
                                    accsessmanager.CustomerAdd(tarih, "tarih", "islemler");
                                    accsessmanager.Update("islemler", "Satantc", TCy[satınaldiziindis], tarih, "tarih");
                                    accsessmanager.Update("islemler", "Alantc", giristc, tarih, "tarih");
                                    accsessmanager.Update("islemler", "AlınanUrunTuru", comboboxUrunTuru, tarih, "tarih");
                                    accsessmanager.Update("islemler", "AlınanUrunMiktar", (Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)), tarih, "tarih");
                                        accsessmanager.Update("islemler", "BirimFiyat", urunbirimfiyat, tarih, "tarih");
                                        accsessmanager.Update("islemler", "ToplamTutar", sahipolunanpara, tarih, "tarih");
                                        parayetmiyor = true;
                                        islemlistele(tarih); indis++;

                                }








                            }
                            else
                            {
                                decimal komisyon = ((Convert.ToDecimal(alınacakmiktar) * Convert.ToDecimal(urunbirimfiyat)) * Convert.ToDecimal(1)) / Convert.ToDecimal(100);
                                sahipolunanpara = (Convert.ToDecimal((sahipolunanpara)) - (komisyon)).ToString();

                                string muhasebeparatut = accsessmanager.tekselect("Muhasebe", "TC", "Bakiye", "Banka");
                                accsessmanager.Update("Banka", "Bakiye", (Convert.ToDecimal(muhasebeparatut) + (komisyon)).ToString(), "Muhasebe", "TC");


                                if (Convert.ToDecimal(sahipolunanpara) >= Convert.ToDecimal((alınacakmiktar * Convert.ToDecimal(urunbirimfiyat)))) // sahip olunan para alınacakmiktarın fiyatına yetiyor mu kontrol ediyor ediyorsa güncelleme işlemlerini yapar
                                {
                                    urunstok = urunstok - alınacakmiktar;
                                    sahipolunanpara = (Convert.ToDecimal(sahipolunanpara) - Convert.ToDecimal((alınacakmiktar * Convert.ToDecimal(urunbirimfiyat)))).ToString();
                                    accsessmanager.Update("Banka", "Bakiye",sahipolunanpara, giristc, "TC");


                                    int satıcıparatut = accsessmanager.tekselectint(TCy[a], "TC", "Bakiye", "Banka");

                                    accsessmanager.Update("Banka", "Bakiye", (satıcıparatut) + (alınacakmiktar * Convert.ToDecimal(urunbirimfiyat)), TCy[a], "TC");
                                    int id = accsessmanager.tekselectint(TCy[a], "TC", "id", "Urunler");
                                    accsessmanager.Update("Urunler", "UrunMiktarı", (urunstok), (id), "id");




                              
                                    accsessmanager.CustomerAdd(tarih, "tarih", "islemler");
                                    accsessmanager.Update("islemler", "Satantc", TCy[satınaldiziindis], tarih, "tarih");
                                    accsessmanager.Update("islemler", "Alantc", giristc, tarih, "tarih");
                                    accsessmanager.Update("islemler", "AlınanUrunMiktar", alınacakmiktar, tarih, "tarih");
                                    accsessmanager.Update("islemler", "AlınanUrunTuru", comboboxUrunTuru, tarih, "tarih");
                                    accsessmanager.Update("islemler", "BirimFiyat", urunbirimfiyat, tarih, "tarih");
                                        accsessmanager.Update("islemler", "ToplamTutar", (alınacakmiktar * Convert.ToDecimal(urunbirimfiyat)), tarih, "tarih");
                                    alınacakmiktar = 0; 
                                }
                                else        //sahip olunan para alınacak miktarın parasına yetmiyorsa alınacak miktarı belirleyip güncelleme işlemlerini yapıyor
                                {
                                    urunstok = urunstok - Convert.ToInt32((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat)));
                                    accsessmanager.Update("Banka", "Bakiye", 0, giristc, "TC");


                                  
                                    int satıcıparatut = accsessmanager.tekselectint(TCy[a], "TC", "Bakiye", "Banka");

                                    accsessmanager.Update("Banka", "Bakiye", (satıcıparatut) + (sahipolunanpara), TCy[a], "TC");
                                    int id = accsessmanager.tekselectint(TCy[a], "TC", "id", "Urunler");
                                    accsessmanager.Update("Urunler", "UrunMiktarı", (urunstok) - Convert.ToInt32((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat))), (id), "id");




                                    accsessmanager.CustomerAdd(tarih, "tarih", "islemler");
                                    accsessmanager.Update("islemler", "Satantc", TCy[satınaldiziindis], tarih, "tarih");
                                    accsessmanager.Update("islemler", "Alantc", giristc, tarih, "tarih");
                                    accsessmanager.Update("islemler", "AlınanUrunMiktar", Convert.ToInt32((Convert.ToDecimal(sahipolunanpara) / Convert.ToDecimal(urunbirimfiyat))), tarih, "tarih");
                                    accsessmanager.Update("islemler", "AlınanUrunTuru", comboboxUrunTuru, tarih, "tarih");

                                    accsessmanager.Update("islemler", "ToplamTutar", sahipolunanpara, tarih, "tarih");
                                        accsessmanager.Update("islemler", "BirimFiyat", urunbirimfiyat, tarih, "tarih");
                                        parayetmiyor = true;
                                }

                            }
                         }
                   
                    else // sahip olunan paranın yettiği kadar alınacakmiktar'dan alıp döngüyü durduruyor
                    {
                        MessageBox.Show("Paranızın Yettiği Kadar Alım İşlemi Yapıldı");
                        break;
                    }
                        islemlistele(tarih); indis++;
                    }
                }
            }
        }
        //talimat alan fonksiyon
        void talimatalım(string tur, string fiyat, string alınacakmiktar,string TCGonder,int butonkontrol)
        {
            CustomerManager veritabanı = new CustomerManager(new AccesCustomerDAL());
            urunstok urun = new urunstok();
            urun.AboneEkle(new abone1());

            // tüm ürünler arasında yazılan ürünü satan tcleri ayırıyor
            List<string> tc = new List<string>();
            List<string> uruntipitc = new List<string>();

            List<string> urunstokolantc = new List<string>();
            tc = veritabanı.select("Onaylandı", "UrunOnayDurumu", "TC", "Urunler");
            int i = 0;
            int toplamstok = 0;
            foreach (string parcala in tc)
            {
                if (tur == veritabanı.tekselect(parcala, "TC", "UrunTipi", "Urunler"))
                {
                    uruntipitc.Add(parcala);
                    toplamstok += (veritabanı.tekselectint(parcala, "TC", "UrunMiktarı", "Urunler"));
                }
            }

            foreach (string parcala in uruntipitc)
            {
                urun.satıcıtc = parcala;
                urun.stok = veritabanı.tekselectint(parcala, "TC", "UrunMiktarı", "Urunler");
                urun.tur = tur;
                urun.birimfiyat = veritabanı.tekselect(parcala, "TC", "UrunSatisFiyatı", "Urunler");

                if (urun.fiyat(Convert.ToDecimal(fiyat)) && (urun.Stokvar(alınacakmiktar) != "Null"))
                {

                    satınal(tur, alınacakmiktar, TCGonder);
                    if (veritabanı.tekselect(TCGonder, tur, "TC", "AlınacakUrunTur", "TC", "Talimat") != "Null")
                    {
                        veritabanı.delete(Convert.ToInt32(veritabanı.tekselect(TCGonder, tur, "TC", "AlınacakUrunTur", "id", "Talimat")), "id", "Talimat");
                    }
                    else
                    {

                    }

                    i = 0;

                    break;


                }
              
                else if(urun.fiyat(Convert.ToDecimal(fiyat)) && (urun.Stokvar(urun.stok.ToString()) != "Null"&& urun.stok!=0))
                {
                  
                    if (veritabanı.tekselect(TCGonder, tur, "TC", "AlınacakUrunTur", "TC", "Talimat") != "Null")
                    {
                        satınal(tur, urun.stok.ToString(), TCGonder);
                        int kalanmiktar = Convert.ToInt32(veritabanı.tekselect(TCGonder, tur, "TC", "AlınacakUrunTur", "AlınacakUrunMiktar", "Talimat")) - urun.stok;
                        veritabanı.Update("Talimat", "AlınacakUrunMiktar",kalanmiktar,TCGonder,"TC");
                    }
                    else
                    {

                    }

                    i = 0;

                    break;
                }
                else
                {
                    i++;
                }

            }
            if (i != 0)
            {
                if(butonkontrol!=0)
                {
                    if (veritabanı.tekselect(giristc, "TC", "TC", "Talimat") == giristc)
                    {
                        if (veritabanı.tekselect(giristc, "TC", "AlınacakUrunTur", "Talimat") == tur)
                        {
                            veritabanı.Update("Talimat", "AlınacakUrunMiktar", Convert.ToInt32(alınacakmiktar), giristc, "TC");

                            veritabanı.Update("Talimat", "AlınacakUrunFiyat", (fiyat), giristc, "TC");
                            veritabanı.Update("Talimat", "Durum", "Bekleniyor", giristc, "TC");
                        }
                        else
                        {
                            veritabanı.CustomerAdd(giristc, "TC", "Talimat");
                            veritabanı.Update("Talimat", "Ad", veritabanı.tekselect(giristc, "TC", "Ad", "Login"), giristc, "TC");
                            veritabanı.Update("Talimat", "Soyad", veritabanı.tekselect(giristc, "TC", "Soyad", "Login"), giristc, "TC");
                            veritabanı.Update("Talimat", "AlınacakUrunTur", tur, giristc, "TC");
                            veritabanı.Update("Talimat", "AlınacakUrunMiktar", Convert.ToInt32(alınacakmiktar), giristc, "TC");

                            veritabanı.Update("Talimat", "AlınacakUrunFiyat", (fiyat), giristc, "TC");
                            veritabanı.Update("Talimat", "Durum", "Bekleniyor", giristc, "TC");
                        }
                    }
                    else
                    {
                        veritabanı.CustomerAdd(giristc, "TC", "Talimat");
                        veritabanı.Update("Talimat", "Ad", veritabanı.tekselect(giristc, "TC", "Ad", "Login"), giristc, "TC");
                        veritabanı.Update("Talimat", "Soyad", veritabanı.tekselect(giristc, "TC", "Soyad", "Login"), giristc, "TC");
                        veritabanı.Update("Talimat", "AlınacakUrunTur", tur, giristc, "TC");
                        veritabanı.Update("Talimat", "AlınacakUrunMiktar", Convert.ToInt32(alınacakmiktar), giristc, "TC");
                        veritabanı.Update("Talimat", "AlınacakUrunFiyat", (fiyat), giristc, "TC");
                        veritabanı.Update("Talimat", "Durum", "Bekleniyor", giristc, "TC");
                    }

                }
                
             
                

            }
        }
     

        private void buttonSatınAl_Click(object sender, EventArgs e)
        {
            satınal(comboBoxUrunTuru.Text,textBoxAlınacakMiktar.Text);
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            // geri dön butonu arapaneli açıyor
            AraPanel f1 = new AraPanel();
            f1.Show();
            this.Hide();
            ZamanTut.Enabled = false;
        }

        //sayaç bitince yapıalacklar
        private void ZamanTut_Tick(object sender, EventArgs e)
        {
            if (zamansay >= 0)
            {
                ZamanTut.Interval = 10;
                ZamanTut.Enabled = true;
                int sayac = zamansay--;
                label5.Text = sayac.ToString();
            }
            if(zamansay==0)
            {
                CustomerManager veritabanı = new CustomerManager(new AccesCustomerDAL());
                List<string> tc = new List<string>();

                tc = veritabanı.select("Bekleniyor", "Durum", "TC", "Talimat");
      


                int a = tc.Count;
                int c = 0;
                for (int i =0; i <= a-1; i++)
                {
                    
                    talimatalım(veritabanı.tekselect(tc[i], "TC", "AlınacakUrunTur", "Talimat"), veritabanı.tekselect(tc[i], "TC", "AlınacakUrunFiyat", "Talimat"), veritabanı.tekselectint(tc[i], "TC", "AlınacakUrunMiktar", "Talimat").ToString(), tc[i],c);
                    Thread.Sleep(1000);
                }
                label5.Text = "Tekrar Başlatmak için tıkla (Tekrar Kontrol eder)";
              
            }

        }

        private void buttonTalimat_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            i++;
            talimatalım(textBoxTur.Text, textBoxFiyat.Text, textBoxAlınacakMiktar.Text, giristc, i);

        }
    }
        }
   

