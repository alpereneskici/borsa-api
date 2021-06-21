using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevdeneme2
{
    public partial class AraPanel : Form
    {
        public string tc { get; set; }
        public AraPanel()
        {
            InitializeComponent();
        }
        // BU PANEL SADECE ARA SAHNELERDEN GEÇİŞ EKRANI
        private void buttonSatısEkran_Click(object sender, EventArgs e)
        {
            AlisverisEkranı f = new AlisverisEkranı();
            f.giristc = tc;
            f.Show();
            this.Hide();
        }

        private void buttonEklemeEkranı_Click(object sender, EventArgs e)
        {
            AliciVeSatıciBilgileri alıcıVeSatıcı = new AliciVeSatıciBilgileri();
            alıcıVeSatıcı.tc = tc;
            alıcıVeSatıcı.Show();
            this.Hide();
            
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            GirisEkrani f1 = new GirisEkrani();
            f1.Show();
            this.Hide();
        }

        private void buttonRaporOlustur_Click(object sender, EventArgs e)
        {
            Rapor_Olustur rapor = new Rapor_Olustur();
            this.Hide();
            rapor.giristc = tc;
            rapor.Show();
        }
    }
}
