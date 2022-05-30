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
    public class Session
    {
        public Calisan currentUser { get; set; }

        public DateTime LoggedInTime { get; set; }

        public Session() { }
    }
}
