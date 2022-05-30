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
    public class Calisan
    {
        public string Id { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }

        public string Dogum { get; set; }

        public string Maas { get; set; }

        public User user { get; set; }
    }
}
