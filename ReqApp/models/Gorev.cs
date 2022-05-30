using ReqApp.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Yavuz Ucarkus 152120171006 yavuzucarkus9@gmail.com
namespace ReqApp.models
{
    public class Gorev
    {
        public string Id { get; set; }
        public string GorevAdi { get; set; }
        public string GorevKodu { get; set; }
        public string Aciklama { get; set; }

        public string gorevDurumu { get; set; } = "Tamamlanmamış";

        public string teslimDurumu { get; set; } = "Teslim Edilmedi";

        public string EklemeTarihi { get; set; }

        public Calisan calisan { get; set; }
        public List<Gereksinim> gereksinimler { get; set; }
    }
}
