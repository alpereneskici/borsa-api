using System;
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
    public partial class Adminpanel : Form
    {
        public Adminpanel()
        {
            InitializeComponent();
        }
        public string secilitc,secilisira,fiyat; 
       public void alıcı()
        {
            listViewislemTur.Columns.Clear();
            listViewislemTur.Items.Clear();
            listViewislemTur.View = View.Details;
            listViewislemTur.Columns.Add("Sıra", 30, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("TC", 70, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("Ad", 70, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("Soyad", 70, HorizontalAlignment.Left);

            listViewislemTur.Columns.Add("Bakiye", 70, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("Onay Bekleyen Bakiye", 150, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("Onay Bekleyen Bakiye Tür", 150, HorizontalAlignment.Left);




            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());
            List<string> tc = new List<string>();
            List<string> id = new List<string>();
            id = accsessmanager.select("Onay Bekleniyor", "BakiyeOnayDurumu", "id", "Banka");
            List<int> s = new List<int>();

            for (int j = 0; j < id.Count; j++)
            {
                s.Add(Convert.ToInt32(id[j]));

            }

            s.Sort();
            int i = 0;
            foreach (int a in s)
            {
                tc.Add(accsessmanager.tekselect(a, "id", "TC", "Banka"));
                listViewislemTur.Items.Add(a.ToString());
                listViewislemTur.Items[i].SubItems.Add(tc[i]);
                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(tc[i], "TC", "Ad", "Login"));

                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(tc[i], "TC", "Soyad", "Login"));

                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(a, "id", "Bakiye", "Banka"));
                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(a, "id", "OnayBekleyenBakiye", "Banka"));
                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(a, "id", "OnayBekleyenBakiyeTur", "Banka"));

                i++;


            }












        } // alıcı bilgilerini listeler
        public  void satıcı()
        {

            listViewislemTur.View = View.Details;
            listViewislemTur.Items.Clear();
            listViewislemTur.Columns.Clear();
            listViewislemTur.Columns.Add("Sıra", 30, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("TC", 60, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("Ad", 60, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("Soyad", 60, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("Ürün Türü", 60, HorizontalAlignment.Left);

            listViewislemTur.Columns.Add("Ürün Miktarı", 60, HorizontalAlignment.Left);
            listViewislemTur.Columns.Add("Onay Bekleyen Ürün Miktarı", 160, HorizontalAlignment.Left);

            listViewislemTur.Columns.Add("Sistem Tarafından Belirlenen Satış Fiyatı", 150, HorizontalAlignment.Left);



            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());
            List<string> id = new List<string>();
            List<string> tc = new List<string>();
            id = accsessmanager.select("Onay Bekleniyor", "UrunOnayDurumu", "id", "Urunler");


            List<int> s = new List<int>();

            for (int j = 0; j < id.Count; j++)
            {
                s.Add(Convert.ToInt32(id[j]));

            }

            s.Sort();
            int i = 0;
            foreach (int a in s)
            {
                tc.Add(accsessmanager.tekselect(a, "id", "TC", "Urunler"));
              
               
                listViewislemTur.Items.Add(a.ToString());
                listViewislemTur.Items[i].SubItems.Add(tc[i]);
                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(tc[i], "TC", "Ad", "Login"));

                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(tc[i], "TC", "Soyad", "Login"));
                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(a, "id", "UrunTipi", "Urunler"));
                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(a, "id", "UrunMiktarı", "Urunler")+" KG");
                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(a, "id", "OnayBekleyenUrunMiktar", "Urunler"));
            

                listViewislemTur.Items[i].SubItems.Add(accsessmanager.tekselect(a,"id", "UrunSatisFiyatı","Urunler") + " TL");
                i++;
               
              
            }






        } // alıcı bilgilerini listeler

        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            secilisira = listViewislemTur.SelectedItems[0].Text; // seçililen kullanıcının idsini alıyor
            ListViewItem item = listViewislemTur.SelectedItems[0];
            secilitc = item.SubItems[1].Text; // seçilen kullanıcın tcsini alıyor

            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());
            if (listViewislemTur.SelectedIndices.Count > 0)
            {

                if (comboBoxOnayTuru.Text == "Alıcı")
                {
                    string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";

                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(bugun);
                    string EURO_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                    string USD_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                    string CAD_Alis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='CAD']/BanknoteBuying").InnerXml;
                   
                    decimal snc=0;
                    string bakiyetemp = accsessmanager.tekselect(secilitc, "TC", "Bakiye", "Banka"); // kullanıcının bakiyesini çeker
                    string onaybakiyetemp = accsessmanager.tekselect(secilitc, "TC", "OnayBekleyenBakiye", "Banka"); // kullanıcının onaylanacak bakiyesini çeker 
                    string onaybakiyetip= accsessmanager.tekselect(secilitc, "TC", "OnayBekleyenBakiyeTur", "Banka");
                    if (onaybakiyetip == "TL")
                    {
                        snc = Convert.ToDecimal(bakiyetemp) + Convert.ToDecimal(onaybakiyetemp);
                    }
                    else if (onaybakiyetip == "USD")
                    {
                        snc = (Convert.ToDecimal(bakiyetemp) + (Convert.ToDecimal(onaybakiyetemp) * (Convert.ToDecimal(USD_Alis.Replace(".",",")))));

                    }
                    else if (onaybakiyetip == "CAD")
                    {
                        snc = (Convert.ToDecimal(bakiyetemp) + (Convert.ToDecimal(onaybakiyetemp) * (Convert.ToDecimal(CAD_Alis.Replace(".", ",")))));
                    }
                    else if (onaybakiyetip == "EUR")
                    {
                        snc = (Convert.ToDecimal(bakiyetemp) + (Convert.ToDecimal(onaybakiyetemp) * (Convert.ToDecimal(EURO_Alis.Replace(".", ",")))));
                    }
                    // onay bekleyen bakiyeyi bakiyeyle toplar 
                    accsessmanager.Update("Banka", "Bakiye", snc, secilitc, "TC"); // bakiyeyi günceller
                    accsessmanager.Update("Banka", "BakiyeOnayDurumu", "Onaylandı", secilitc, "TC"); // bakiyenin onay durumunu günceller


                    accsessmanager.Update("Banka", "OnayBekleyenBakiye", "0", secilitc, "TC"); //onay bekleyen bakiyeyi 0'lar

                    alıcı();
                }
                else if (comboBoxOnayTuru.Text == "Satıcı")
                {
                    int uruntemp = Convert.ToInt32(accsessmanager.tekselect(Convert.ToInt32(secilisira), "id", "UrunMiktarı","Urunler")); // urun miktarını tutar
                    int onayuruntemp = Convert.ToInt32(accsessmanager.tekselect(Convert.ToInt32(secilisira), "id", "OnayBekleyenUrunMiktar", "Urunler")); // onay miktarını tutar 
                    int snc = (uruntemp) + (onayuruntemp); // ürünmiktarı ve onay bekleyen ürün miktarını toplar
                    accsessmanager.Update("Urunler", "UrunMiktarı", snc, Convert.ToInt32(secilisira), "id");
                    accsessmanager.Update("Urunler", "OnayBekleyenUrunMiktar", 0, Convert.ToInt32(secilisira), "id");
                    accsessmanager.Update("Urunler", "UrunOnayDurumu", "Onaylandı", Convert.ToInt32(secilisira), "id"); // ürün onay durumunu günceller
                    satıcı();
                   
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Onaylamak istediğiniz kısmı seçiniz");
            }
        }

        private void comboBoxOnayTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOnayTuru.SelectedItem.ToString() == "Alıcı")
            {
                alıcı();




            }
            else if (comboBoxOnayTuru.SelectedItem.ToString() == "Satıcı")
            {
                satıcı();


            }
            else
            {

            }
        }

        private void Adminpanel_Load(object sender, EventArgs e)
        {
         
        }

        private void buttonReddet_Click(object sender, EventArgs e)
        {
            secilisira = listViewislemTur.SelectedItems[0].Text; // seçililen kullanıcının idsini alıyor
            ListViewItem item = listViewislemTur.SelectedItems[0];
            secilitc = item.SubItems[1].Text; // seçilen kullanıcın tcsini alıyor

            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());
            if (listViewislemTur.SelectedIndices.Count > 0) // seçilen kullanıcı var mı diye kontrol ediyor
            {
                if (comboBoxOnayTuru.Text == "Alıcı")
                {


                    accsessmanager.Update("Banka", "BakiyeOnayDurumu", "Onaylanmadı", secilitc, "TC"); // bakiyeyi onay durumunu onaylanmadı olarak değiştirir


                    accsessmanager.Update("Banka", "OnayBekleyenBakiye", 0, secilitc, "TC"); // onay bekleyen bakiyeyi 0lar


                    alıcı();
                }
                else if (comboBoxOnayTuru.Text == "Satıcı")
                {

                    accsessmanager.delete(Convert.ToInt32(secilisira), "id", "Urunler"); // ürünlerde şişkinlik olmasın diye kullanıcının onaylanmayan ürününü listeden siler
                    satıcı();

                }
            }
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            GirisEkrani f1 = new GirisEkrani();
            f1.Show();
            this.Hide();
        }

        
      
    }
}
