using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace ReqApp.pages.subpages
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

       
        void ReadXmlUser()
        {
           /* DataSet ds = new DataSet();
            XmlReader xmlReader = XmlReader.Create(@"Users.xml", new XmlReaderSettings());
            ds.ReadXml(xmlReader);
            dataGridView1.DataSource = ds.Tables[0];
            xmlReader.Close();*/
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

           /* XDocument xdosya = XDocument.Load("Gorev.xml");
            XElement element = xdosya.Element("Gorev").Elements("User").FirstOrDefault(x => x.Element("UserName").Value == textBox1.Text);
            if (element != null)
            {
                element.SetElementValue("Görev", Gorev.Text);
                element.SetElementValue("Görev kodu", GorevKodu.Text);
                element.SetElementValue("Görevi yapan kişi", GorevKisi.Text);
                element.SetElementValue("Görev durumu", GorevDurumu.Text);
                element.SetElementValue("Eklenen tarıhı", EklenmeTarih.Text);
               
                xdosya.Save("Gorev.xml");
                MessageBox.Show("Bilgiler güncellendi");
                ReadXmlUser();
            }*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int cout = 0;
            

            label2.Text= cout.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int cout = 0;




            label3.Text = cout.ToString();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            int cout = 0;




            label5.Text = cout.ToString();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            int cout = 0;



            label7.Text = cout.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Gorev.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            GorevKodu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            GorevKisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            GorevDurumu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EklenmeTarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();*/
        }

      
    }
}
