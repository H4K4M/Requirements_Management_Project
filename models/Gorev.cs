using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqApp.models
{
    public class Gorev
    {
<<<<<<< HEAD
        public string Id { get; set; }
        public string GorevAdi { get; set; }
        public string GorevKodu { get; set; }
        public string Aciklama { get; set; }

        public string gorevDurumu { get; set; }

        public Calisan calisan { get; set; }
        public List<Gereksinim> gereksinimler { get; set; }
=======
        public int id { get; set; }
        public string gorevAdi { get; set; }
        public DateTime dateTime { get; set; }
        public Calisan calisan { get; set; }
        //public Gereksinim gereksinim { get; set; }


>>>>>>> 531b064cca5188faab12020fa4119b0cd821ec69
    }
}
