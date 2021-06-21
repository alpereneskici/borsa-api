using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevdeneme2.BuilderRapor
{
    public class json : AnaRaporOlustur
    {
        public json(ReportInfo info, string giristc) : base(info, giristc)
        {
        }

        public override string buildRapor(string giristc)
        {
            string jsoncover = "";
            for(int i=0;i<base.info.Rapor.Count;i++)
            {
                jsoncover += JsonConvert.SerializeObject(base.info.Rapor[i], Formatting.Indented) + "\n";
            }
               
            return jsoncover;
           
        }
    }
}
