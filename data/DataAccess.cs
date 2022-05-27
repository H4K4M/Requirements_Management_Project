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
<<<<<<< HEAD
=======
        static int gorevCount = 0;
        static int calisanCount = 0;
        public static bool saveUser(User user)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(User));

            var path = @"../../data/Users.xml";

            // check if user exist 

            using (TextWriter tw = new StreamWriter(path))
            {
                serializer.Serialize(tw, user);
            }
>>>>>>> 531b064cca5188faab12020fa4119b0cd821ec69

        #region Calisanlar
        static int calisanCount = 0;

        //--------------------------------------------Calişanlar----------------------------//
        public static bool saveCalisanlar(List<Calisan> calisan)
        {
            var path = @"../../data/Calisanlar.xml";

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Calisan>));

            var calisanlar = new List<Calisan>();

            int current = 0;

            //------------check if calisan exist--------------// 

            using (TextReader reader = new StreamReader(@"../../data/Calisanlar.xml"))
            {
                object obj = deserializer.Deserialize(reader);
                calisanlar = (List<Calisan>)obj;

<<<<<<< HEAD
                if(calisanlar.Count != 0)
                {

                    if ((calisanlar[current].Adi == calisan[calisan.Count].Adi && calisanlar[current].Soyad
                        == calisan[current].Soyad) || calisanlar[calisan.Count].user.username == calisan[calisan.Count].user.username)
                    {
                        MessageBox.Show("Bu çalışan zaten vardır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    current++;
                }
            }//end-ReadData
=======
            return users;
        }
        //--------------------------------------------Calişanlar----------------------------//
        public static bool saveCalisanlar(List<Calisan> calisan)
        {
            var path = @"../../data/Calisanlar.xml";

            //------------check if calisan exist--------------// 
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode rootNode = xmlDoc.SelectSingleNode("ArrayOfCalisan");
            XmlNodeList CalisanList = rootNode.SelectNodes("Calisan");
            for (int i = 0; i < CalisanList.Count; i++)
            {
                if (CalisanList[i].SelectSingleNode("Adi").InnerText == calisan[calisan.Count - 1].Adi &&
                    CalisanList[i].SelectSingleNode("Soyad").InnerText == calisan[calisan.Count - 1].Soyad &&
                    calisanCount != calisan.Count)
                {
                    MessageBox.Show("Bu çalışan zaten vardır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }//end-if                                                            
            }//end-for
>>>>>>> 531b064cca5188faab12020fa4119b0cd821ec69
            //--------end check if calisan exist---------//

            //---------Calisanlar--------//
            using (TextWriter tw = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Calisan>));
                serializer.Serialize(tw, calisan);
            }//end-writeData           
            return true;
        }// end
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
        public static bool DeleteCalisan(Calisan calisan)
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
                if (CalisanList[i].SelectSingleNode("Adi").InnerText.Equals(calisan.Adi) &&
                    CalisanList[i].SelectSingleNode("Soyad").InnerText.Equals(calisan.Soyad))
                {
                    rootNode.RemoveChild(CalisanList[i]);

                    xmlDoc.Save(path);
                }//end-if
            }//end-for
            return true;
        }// end
         //----------------------------------------------------------------------------------//

<<<<<<< HEAD
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
=======

        //--------------------------------------Görevler-------------------------------------//

        public static bool saveGorev(Gorev gorev)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Gorev));

            var path = @"../../data/Gorevler.xml";

            // check if user exist 

            using (TextWriter tw = new StreamWriter(path))
            {
                serializer.Serialize(tw, gorev);
            }

            return true;
        }

        public static bool saveGorevler(List<Gorev> gorevler)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Gorev>));

            var path = @"../../data/Users.xml";

            using (TextWriter fs = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Gorev>));

                xmlSerializer.Serialize(fs, gorevler);
            }

            return true;
        }

        public static List<Gorev> GetGorevler()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Gorev>));

            var gorevler = new List<Gorev>();

            using (TextReader reader = new StreamReader(@"../../data/Users.xml"))
            {
                object obj = deserializer.Deserialize(reader);
                gorevler = (List<Gorev>)obj;
            }
            return gorevler;
        }
>>>>>>> 531b064cca5188faab12020fa4119b0cd821ec69
    }
}
