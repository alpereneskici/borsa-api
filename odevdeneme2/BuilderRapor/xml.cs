using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevdeneme2.BuilderRapor
{
    public class xml : AnaRaporOlustur
    {
        public xml(ReportInfo info, string giristc) : base(info, giristc)
        {
        }

        public override string buildRapor(string giristc)
        {
            string s = "";
            s = "xml formatı";
            return s;
        }
    }
}
