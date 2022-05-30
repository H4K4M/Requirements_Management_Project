/*
  Author: Muhammed Suwaneh
  Software Engineer & Student
  Eskişehir Osmangazi University
  May 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqApp.models
{
    public class Teslim
    {
        public string Id { get; set; }
        public Calisan calisan { get; set; }
        public Gorev gorev { get; set; }

        public string gorevLinki { get; set; }

        public string TeslimTarihi { get; set;}

        public bool teslimDegerlendirildiMi { get; set; } = false;
    }
}
