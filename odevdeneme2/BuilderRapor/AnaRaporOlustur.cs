using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevdeneme2.BuilderRapor
{
    public abstract class AnaRaporOlustur
    {
        protected ReportInfo info;
        public string giristc { get; set; }
        public AnaRaporOlustur(ReportInfo info,string giristc)
        {
            this.info = info;
            this.giristc = giristc;
        }
        public string Out()
        {
            string s = "";
            s += buildRapor(giristc);
            return s;
        }
        public abstract string buildRapor(string giristc);

    }
}
