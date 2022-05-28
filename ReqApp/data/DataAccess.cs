using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ReqApp.models;
using System.Xml;
using System.Windows.Forms;

namespace ReqApp.data
{
    public static class DataAccess
    {

        #region Calisanlar
        static int calisanCount = 0;

        //--------------------------------------------Calişanlar----------------------------//
        public static bool saveCalisanlar(List<Calisan> calisan)
        {
            var path = @"../../data/Calisanlar.xml";

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Calisan>));

            var calisanlar = new List<Calisan>();
            //------------check if calisan exist--------------// 

            using (TextReader reader = new StreamReader(path))
            {
                object obj = deserializer.Deserialize(reader);
                calisanlar = (List<Calisan>)obj;

                if(calisanlar.Count != 0)
                {
                    for(int i = 0; i < calisanlar.Count; i++)
                    {

                        if ((calisanlar[i].Adi == calisan[calisan.Count - 1].Adi && calisanlar[i].Soyad
                            == calisan[calisan.Count - 1].Soyad) || calisanlar[i].user.username == calisan[calisan.Count - 1].user.username)
                        {
                            MessageBox.Show("Bu çalışan zaten vardır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }//end-ReadData

            using (TextWriter writer = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Calisan>));
                serializer.Serialize(writer, calisan);
            }//end-writeData
            return true;
        }
        public static List<Calisan> GetCalisanlar()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Calisan>));

            var calisanlar = new List<Calisan>();

            using (TextReader reader = new StreamReader(@"../../data/Calisanlar.xml"))
            {
                object obj = deserializer.Deserialize(reader);
                calisanlar = (List<Calisan>)obj;
            }//end-ReadData
            calisanCount = calisanlar.Count;
            return calisanlar;
        }// end
        public static bool DeleteCalisan(string Id)
        {
            var path = @"../../data/Calisanlar.xml";
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(path);

            XmlNode rootNode = xmlDoc.SelectSingleNode("ArrayOfCalisan");

            XmlNodeList CalisanList = rootNode.SelectNodes("Calisan");            
            // delete calisan
            for (int i = 0; i < CalisanList.Count; i++)
            {
                //--Check Name and Lastname to delete
                if (CalisanList[i].SelectSingleNode("Id").InnerText.Equals(Id))
                {
                    rootNode.RemoveChild(CalisanList[i]);

                    xmlDoc.Save(path);
                }//end-if
            }//end-for
            return true;
        }// end
         //----------------------------------------------------------------------------------//

        public static Calisan GetCalisan(string calisanAdi)
        {
            var calisanlar = GetCalisanlar();

            foreach(var calisan in calisanlar)
            {
                if (calisan.Adi == calisanAdi) return calisan;
            }

            return null;
        }
        #endregion

        #region Gereksinimler
        public static List<Gereksinim> GetGereksinimler()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Gereksinim>));

            var gereksinimler = new List<Gereksinim>();

            using (TextReader reader = new StreamReader(@"../../data/Gereksinimler.xml"))
            {
                object obj = deserializer.Deserialize(reader);
                gereksinimler = (List<Gereksinim>)obj;
            }//end-ReadData

            return gereksinimler;
        }

        public static Gereksinim GetGereksinim(string name)
        {
            var gereksinimler = GetGereksinimler();

            foreach(var gereksinim in gereksinimler)
            {
                if(gereksinim.GereksinimAdi == name)
                {
                    return gereksinim;
                }
            }

            return null;
        }

        public static bool AddGereksinim(List<Gereksinim> gereksinim)
        {
            var path = @"../../data/Gereksinimler.xml";

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Gereksinim>));

            var gereksinimler = new List<Gereksinim>();
            //------------check if gereksinim exist--------------// 

            using (TextReader reader = new StreamReader(path))
            {
                object obj = deserializer.Deserialize(reader);
                gereksinimler = (List<Gereksinim>)obj;

                if (gereksinimler.Count != 0)
                {
                    for (int i = 0; i < gereksinimler.Count; i++)
                    {

                        if (gereksinimler[i].GereksinimAdi == gereksinim[gereksinim.Count-1].GereksinimAdi &&
                            gereksinimler[i].GereksinimKodu == gereksinim[gereksinim.Count - 1].GereksinimKodu)
                        {
                            MessageBox.Show("Bu gereksinim mevcüttür!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }//end-ReadData

            using (TextWriter writer = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Gereksinim>));
                serializer.Serialize(writer, gereksinim);
            }//end-writeData

            return true;
        }

        public static bool DeleteGereksinim(string Id)
        {
            var path = @"../../data/Gereksinimler.xml";
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(path);

            XmlNode rootNode = xmlDoc.SelectSingleNode("ArrayOfGereksinim");

            XmlNodeList gereksinimler = rootNode.SelectNodes("Gereksinim");
            // delete calisan
            for (int i = 0; i < gereksinimler.Count; i++)
            {
                //--Check Name and Lastname to delete
                if (gereksinimler[i].SelectSingleNode("Id").InnerText.Equals(Id))
                {
                    rootNode.RemoveChild(gereksinimler[i]);

                    xmlDoc.Save(path);
                }//end-if
            }//end-for
            return true;
        }

        #endregion

        #region Gorevler 

        public static List<Gorev> GetGorevler()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Gorev>));

            var gorevler = new List<Gorev>();

            using (TextReader reader = new StreamReader(@"../../data/Gorevler.xml"))
            {
                object obj = deserializer.Deserialize(reader);
                gorevler = (List<Gorev>)obj;
            }//end-ReadData

            return gorevler;
        }

        public static bool AddGorev(List<Gorev> gorev)
        {
            var path = @"../../data/Gereksinimler.xml";

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Gereksinim>));

            var gorevler = new List<Gorev>();
            //------------check if gereksinim exist--------------// 

            using (TextReader reader = new StreamReader(path))
            {
                object obj = deserializer.Deserialize(reader);
                gorevler = (List<Gorev>)obj;

                if (gorevler.Count != 0)
                {
                    for (int i = 0; i < gorevler.Count; i++)
                    {
                        if(gorevler[i].GorevKodu == gorev[gorev.Count - 1].GorevKodu && gorevler[i].gorevDurumu == "Tamanlanmamiş")
                        {
                            MessageBox.Show("Bu gorev mevcüttür!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }//end-ReadData

            using (TextWriter writer = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Gorev>));
                serializer.Serialize(writer, gorevler);
            }//end-writeData

            return true;
        }

        #endregion

        #region Gorevlerim 
        public static List<Gorev> GetGereksinimler(string CalisanId)
        {
            var gorevler = GetGorevler();

            var gorevlerim = new List<Gorev>();

            foreach(var gorev in gorevler)
            {
                if(gorev.calisan.Id == CalisanId)
                {
                    gorevlerim.Add(gorev);
                }
            }

            return gorevlerim;
        }


        #endregion

        #region Dashboard 
        public static int TamalanmisGorevlerCount()
        {
            var gorevler = GetGorevler();
            int count = 0;
            foreach(var gorev in gorevler)
            {
                if(gorev.gorevDurumu == "Tamamlanmis")
                {
                    count++;
                }
            }

            return count;
        }

        public static int TamanlanmamisGorevlerCount()
        {
            var gorevler = GetGorevler();
            int count = 0;
            foreach (var gorev in gorevler)
            {
                if (gorev.gorevDurumu == "Tamamlanmamis")
                {
                    count++;
                }
            }

            return count;
        }

        public static int GereksinimlerCount()
        {
            var gereksinimler = GetGereksinimler();

            return gereksinimler.Count;   
        }


        public static int CalisanlarCount()
        {
            var calisanlar = GetCalisanlar();

            return calisanlar.Count;
        }

        #endregion

        #region Is degerlendirme

        #endregion
    }
}
