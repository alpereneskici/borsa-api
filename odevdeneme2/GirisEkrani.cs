using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using odevdeneme2.Observer;
using System.Xml;

namespace odevdeneme2
{
    public partial class GirisEkrani : Form
    {
        
        public GirisEkrani()
        {
            InitializeComponent();
        }



        public string giristc { get; set; }
        int hak = 3;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            CustomerManager accsessmanager = new CustomerManager(new AccesCustomerDAL());

            hak--;
           
            string tt="";
        // tc numarasının şifresi doğru mu kontrol ediyor
         if (LoginTcKimlikNo.Text != "")
            {
                tt = accsessmanager.tekselect(LoginTcKimlikNo.Text, "Tc", "sifre", "Login");
            }
            else
            {
                MessageBox.Show("Lütfen Tc Kimlik Numarası Giriniz");
            }

           

                if (tt != "")
                {
                    if (LoginSifre.Text == tt && LoginSifre.Text != "")
                    {
                        tt = accsessmanager.tekselect(LoginTcKimlikNo.Text, "Tc", "UserType", "Login");
                        // tcnin user typına göre panel açıyor
                        if (tt == "Admin")
                        {
                            Adminpanel araPanel = new Adminpanel();
                            araPanel.Show();
                            this.Hide();
                        }
                        else
                        {

                            AraPanel araPanel = new AraPanel();
                            AlisverisEkranı giris = new AlisverisEkranı();
                            araPanel.tc = LoginTcKimlikNo.Text;
                            araPanel.Show();
                            this.Hide();


                        }


                    }
                    else
                    {
                        if(hak==0)
                         {
                        MessageBox.Show("Giriş Haklarınızı Doldurdunuz Program Kapanıyor");
                        Application.Exit();
                         }
                        else
                            {
                        MessageBox.Show("Girdiğiniz bilgiler hatalı lütfen tekrar deneryin kalan haklarınız :  " + hak.ToString()); ;
                            }
                    }

                }
            }

        private void buttonKayıtOl_Click(object sender, EventArgs e)
        {
            // kayıt ekranını açıyor
            Form kayitekran = new KayitEkrani();
            kayitekran.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
            
         

          


        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
       
        }
    }
}
