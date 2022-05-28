using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqApp.models
{
    public class Degerlendirme
    { 
        public TeslimEdildi teslim { get; set; }

        public DegerlendirmeType degerlendirme { get; set; }

        public Sonuc sonuc { get; set; }
    }
}
