/*
  Author: Muhammed Suwaneh
  Software Engineer & Student
  Eskişehir Osmangazi University
  May 2022
 */
using ReqApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReqApp.data;
using ReqApp.helpers;
using System.Xml.Serialization;
using System.IO;

namespace ReqApp.pages.subpages
{
    public partial class Gorevlerim : Form
    {
        private List<Gorev> gorevlerim = new List<Gorev>();
        private Gorev selectedGorev = new Gorev();
        private Session _session;
        private int selectedIndex;

        public Gorevlerim(Session session)
        {
            InitializeComponent();
            _session = session;

            this.TeslimEtButonu.Enabled = false;
            fetchLoadGorevData();
        }

        public void fetchLoadGorevData()
        {
            gorevlerim = DataAccess.GetGorev(_session.currentUser.Id);

            if(gorevlerim.Count > 0)
            {
                foreach (var gorev in gorevlerim)
                {
                    gorevlerimListView.Rows.Add(gorev.Id, gorev.GorevAdi, gorev.EklemeTarihi);
                }
            } 
        }

        private void TeslimEtButonu_Click(object sender, EventArgs e)
        {
            if(gorevLinkTextBox.Text == "")
            {
                MessageBox.Show("Lütfen görev linki doldurunuz");
                return;
            }

            Teslim teslim = new Teslim
            {
                Id = Encryption.generateUserId(),
                calisan = _session.currentUser,
                gorev = selectedGorev,
                gorevLinki = gorevLinkTextBox.Text,
                TeslimTarihi = DateTime.Now.ToString()
            };

            var teslimler = DataAccess.GetTeslimer();

            teslimler.Add(teslim);

            if(DataAccess.addTeslim(teslimler))
            {
                this.selectedGoreAdiText.Text = null;
                this.selectedGorevAciklamasiTextBox.Text = null;
                this.gorevLinkTextBox.Text = null;
                this.selectedGorevGereksinimlerList.Items.Clear();

                this.TeslimEtButonu.Enabled = false;
                
                var allgorevs = DataAccess.GetGorevler();

                foreach(var gorev in allgorevs)
                {
                    if(gorev.Id == selectedGorev.Id && gorev.calisan.Id == selectedGorev.calisan.Id)
                    {
                        gorev.gorevDurumu = "Kontrol ediliyor";
                        gorev.teslimDurumu = "Teslim Edildi";
                    }
                }

                var path = @"../../data/Gorevler.xml";

                XmlSerializer deserializer = new XmlSerializer(typeof(List<Gorev>));

                using (TextWriter writer = new StreamWriter(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Gorev>));
                    serializer.Serialize(writer, allgorevs);
                }//end-writeData


                gorevlerimListView.Rows.RemoveAt(selectedIndex);
            }
        }

        private void gorevlerimListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TeslimEtButonu.Enabled = true;

            string selectedGorevId = gorevlerimListView.Rows[e.RowIndex].Cells[0].Value.ToString();

            foreach(var gorev in gorevlerim)
            {
                if(gorev.Id == selectedGorevId)
                {
                    selectedGorev = gorev;
                }
            }

            selectedIndex = e.RowIndex;

            if(selectedGorev != null)
            {
                selectedGoreAdiText.Text = selectedGorev.GorevAdi;
                selectedGorevAciklamasiTextBox.Text = selectedGorev.Aciklama;

                selectedGorevGereksinimlerList.Items.Clear();

                foreach(var gereksinim in selectedGorev.gereksinimler)
                {
                    selectedGorevGereksinimlerList.Items.Add(gereksinim.GereksinimAdi);
                }
            }
        }

        private void Gorevlerim_Load(object sender, EventArgs e)
        {

        }
    }
}
