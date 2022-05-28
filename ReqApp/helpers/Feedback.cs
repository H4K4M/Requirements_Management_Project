using ReqApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqApp.helpers
{
    public static class Feedback
    {
        public static string GetGorevDurumu(DegerlendirmeType degerlendirmeType)
        {
            switch(degerlendirmeType)
            {
                case DegerlendirmeType.Tamamlanmis:
                    return "Tamanlanmiş";
                case DegerlendirmeType.Tamamlanmamis:
                    return "Tamanlanmamiş";
                case DegerlendirmeType.IyiYapilmis:
                    return "İyi yapılmış";
                case DegerlendirmeType.Mukemmel:
                    return "Mükemmel";
                default: return "Tamanlanmamiş";
            }
        }
    }
}
