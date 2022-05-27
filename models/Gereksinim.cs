using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqApp.models
{
    public class Gereksinim
    {
        public string Id { get; set; }
        public string GereksinimAdi { get; set; }

        public string GereksinimKodu { get; set; }

        public string Aciklama { get; set; }

        public DateTime EklemeTarihi { get; set; }
    }
}
