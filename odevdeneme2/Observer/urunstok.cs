using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevdeneme2.Observer
{
  public  class urunstok
    {
        public string satıcıtc { get; set; }
        public string tur { get; set; }
        public int stok { get; set; }
        
        public string birimfiyat { get; set; }
        
        
        public bool fiyat(decimal birimfiyat)
        {
         
          if((Convert.ToDecimal(birimfiyat))>=(Convert.ToDecimal(this.birimfiyat)))
            {
                return true;
                   
            }
          else
            {
                return false;
            }
          
           
        }
        public string Stokvar(string stok)
        {

            if ((Convert.ToInt32(stok)) <= (Convert.ToInt32(this.stok)))
            {
                return Notify();

            }
            else
            {
                return "Null";
            }


        }
        List<Observer> Gozlemciler;
        public urunstok()
        {
            this.Gozlemciler = new List<Observer>();
        }
        public void AboneEkle(Observer observer)
        {
            Gozlemciler.Add(observer);
        }
        //Gözlemci çıkar
        public void AboneCikar(Observer observer)
        {
            Gozlemciler.Remove(observer);
        }
        public string Notify()
        {
            string s = "";
            Gozlemciler.ForEach(g =>
            {
               s=g.Update(satıcıtc);
                
            });
            return s;
        }


    }
}
