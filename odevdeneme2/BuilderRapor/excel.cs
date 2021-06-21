using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using GemBox.Spreadsheet;
namespace odevdeneme2.BuilderRapor
{
    public class excel : AnaRaporOlustur
    {
        public excel(ReportInfo info, string giristc) : base(info, giristc)
        {
        }

        public override string buildRapor(string giristc)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile workbook = new ExcelFile();
            ExcelWorksheet worksheet = workbook.Worksheets.Add("Sonuclar");
            worksheet.Cells[0, 0].Value = "Tarih";
            worksheet.Cells[0, 1].Value = "Ürün Tipi";
            worksheet.Cells[0, 2].Value = "Alım Tutarı";
            worksheet.Cells[0, 3].Value = "Miktar";
            int row = 0;
            foreach (RaporIcerik user in base.info.Rapor)
            {
                worksheet.Cells[++row, 0].Value = user.tarih;
                worksheet.Cells[row, 1].Value = user.UrunTipi;
                worksheet.Cells[row, 2].Value = user.AlımTutari;
                worksheet.Cells[row, 3].Value = user.Miktar;
               
            }
          
            workbook.Save(giristc+".xlsx");

            string s = "Dosya Oluşturuldu";
        
   
            return s;
        }
    }
}
