using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqApp.models
{
    public class Degerlendirme
    { 
        public Teslim teslim { get; set; }

        public List<string> secilenStateler { get; set; }

        public string teslimSonucu { get; set; }
    }
}
