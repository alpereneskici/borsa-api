using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using odevdeneme2.BuilderRapor;
namespace odevdeneme2
{
    public partial class Rapor_Olustur : Form
    {
        
        public Rapor_Olustur()
        {
            InitializeComponent();
        }
        public string giristc { get; set; }
        private void buttonRaporOlustur_Click(object sender, EventArgs e)
        {
            CustomerManager veritabanı = new CustomerManager(new AccesCustomerDAL());
            List<string> alımislemtarih = new List<string>();
            alımislemtarih = veritabanı.select(giristc, "Alantc", "tarih", "islemler");
            List<string> satımislemtarih = new List<string>();
            satımislemtarih = veritabanı.select(giristc, "Satantc", "tarih", "islemler");
            List<DateTime> tarihtut = new List<DateTime>();
            List<string> rapor = new List<string>();
            for (int i=0;i<alımislemtarih.Count;i++)
            {
                tarihtut.Add(Convert.ToDateTime(alımislemtarih[i]));
            }
            for (int i = 0; i < satımislemtarih.Count; i++)
            {
                tarihtut.Add(Convert.ToDateTime(satımislemtarih[i]));
            }
            tarihtut.Sort();
            int sayac = 0;
            for(int i=0;i<tarihtut.Count;i++)
            {
                if (dateTimePickerBaslangic.Value <= tarihtut[i] && (dateTimePickerBitis.Value >= tarihtut[i]))
                {
                    rapor.Add(tarihtut[i].ToString());
                    sayac++;
                }
                else if(sayac==0)
                {
                    MessageBox.Show("Seçilen Aralıkta İşlem Bulunamadı");
                    return;
                }
            }
            ReportInfo info = new ReportInfo();
          
            info.Rapor = new List<RaporIcerik>();
            for (int i=0;i<rapor.Count;i++)
            {
                RaporIcerik icerik = new RaporIcerik();
                icerik.tarih = rapor[i];
                icerik.Miktar = veritabanı.tekselect(rapor[i],"tarih", "AlınanUrunMiktar","islemler");
                icerik.AlımTutari = veritabanı.tekselect(rapor[i], "tarih", "ToplamTutar", "islemler");
                icerik.UrunTipi = veritabanı.tekselect(rapor[i], "tarih", "AlınanUrunTuru", "islemler");
                info.Rapor.Add(icerik);
            }
          
            AnaRaporOlustur manager = new excel(info,giristc);
           MessageBox.Show(manager.Out());
        


   

        }


        private void Rapor_Olustur_Load(object sender, EventArgs e)
        {

        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AraPanel f1 = new AraPanel();
            f1.Show();
            this.Hide();
        }
    }
}
