using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevdeneme2.BuilderRapor
{
    public class RaporManager
    {
        private  AnaRaporOlustur raporolustur;

        public string build()
        {
            string s = "";
            s=raporolustur.Out();
            return s;
          
        }
    }
}
