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
    public class User
    {
        public string Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public string email { get; set; }

        public string role { get; set; }
    }
}
