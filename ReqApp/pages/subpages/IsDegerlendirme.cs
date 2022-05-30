/*
  Author: Muhammed Suwaneh
  Software Engineer & Student
  Eskişehir Osmangazi University
  May 2022
 */
using ReqApp.data;
using ReqApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ReqApp.pages.subpages
{
    public partial class IsDegerlendirme : Form
    {
        public string selectedStates { get; set; } = "";
        private List<Teslim> teslimler = new List<Teslim>();
        private Teslim selectedTeslim { get; set; }
        private int selectedIndex { get; set; }

        public IsDegerlendirme()
        {
            InitializeComponent();

            fetchSubmittedTask();

            this.onaylaButton.Enabled = false;
            this.ReddetButonu.Enabled = false;
            this.TamamlanmisCheckBox.Enabled = false;
            this.iyiYapilmisCheckBox.Enabled = false;
            this.TamamlanmamisCheckBox.Enabled = false;
        }

        private void fetchSubmittedTask()
        {
            teslimler = DataAccess.GetTeslimer();

            if(teslimler.Count > 0)
            {
                foreach(var teslim in teslimler)
                {
                    if(!teslim.teslimDegerlendirildiMi)
                    {
                        this.teslimlerListView.Rows.Add(teslim.Id, teslim.gorev.GorevAdi, teslim.calisan.Adi, teslim.TeslimTarihi);
                    }
                }
            }
        }

        /// <summary>
        /// Copy link to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GorevLinkKopylaButton_Click(object sender, EventArgs e)
        {
           if(this.gorevLinki.Text == "")
            {
                MessageBox.Show("Görev link yok.");
                return;
            }

            Clipboard.SetDataObject(this.gorevLinki.Text);

            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                MessageBox.Show($"Link copied: {(String)iData.GetData(DataFormats.Text)}");
            }
        }

        private void onaylaButton_Click(object sender, EventArgs e)
        {
            updateTeslim("Onaylandi");
        }

        private void ReddetButonu_Click(object sender, EventArgs e)
        {
            updateTeslim("Reddedildi");
        }

        private void updateTeslim(string degerlendirme)
        {
            var path = @"../../data/Teslimler.xml";

            var oldTeslims = DataAccess.GetTeslimer();
            var newTeslims = new List<Teslim>();

            foreach(var teslim in oldTeslims)
            {
                if(teslim.Id != selectedTeslim.Id)
                {
                    newTeslims.Add(teslim);
                }
            }

            selectedTeslim.gorev.gorevDurumu = degerlendirme;
            selectedTeslim.teslimDegerlendirildiMi = true;

            newTeslims.Add(selectedTeslim);

            // update teslim and teslim.xml

            using (TextWriter writer = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Teslim>));
                serializer.Serialize(writer, newTeslims);
            }//end-writeData


            path = @"../../data/Gorevler.xml";
            // update gorevler and gorevler.xml
            var oldGorevler = DataAccess.GetGorevler();
            var newGorevler = new List<Gorev>();

            foreach (var gorev in oldGorevler)
            {
                if (gorev.Id != selectedTeslim.gorev.Id)
                {
                    newGorevler.Add(gorev);
                }
            }

            newGorevler.Add(selectedTeslim.gorev);

            using (TextWriter writer = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Gorev>));
                serializer.Serialize(writer, newGorevler);
            }//end-writeData

            this.selectedGorevAdiText.Text = null;
            this.selectedGorevAciklamasiTextBox.Text = null;
            this.calisanTextBox.Text = null;
            this.gorevLinki.Text = null;

            this.selectedGorevGereksinimlerList.Items.Clear();
        }

        private void teslimlerListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedTeslimId = teslimlerListView.Rows[e.RowIndex].Cells[0].Value.ToString();

            foreach (var teslim in teslimler)
            {
                if (teslim.Id == selectedTeslimId)
                {
                    selectedTeslim = teslim;
                }
            }

            selectedIndex = e.RowIndex;

            if (selectedTeslim != null)
            {
                this.selectedGorevAdiText.Text = selectedTeslim.gorev.GorevAdi;
                this.selectedGorevAciklamasiTextBox.Text = selectedTeslim.gorev.Aciklama;
                this.calisanTextBox.Text = selectedTeslim.calisan.Adi;
                this.gorevLinki.Text = selectedTeslim.gorevLinki;

                selectedGorevGereksinimlerList.Items.Clear();

                foreach (var teslim in selectedTeslim.gorev.gereksinimler)
                {
                    selectedGorevGereksinimlerList.Items.Add(teslim.GereksinimAdi);
                }

                this.TamamlanmisCheckBox.Enabled = true;
                this.iyiYapilmisCheckBox.Enabled = true;
                this.TamamlanmamisCheckBox.Enabled = true;
            }
        }

        /// <summary>
        /// state kontrol ediyor -> eğer seçilen state uyumlu ise onayla butonu aktif yoksa reddet butonu aktif olacak
        /// </summary>
        private void stateControl()
        {
            // states 
            // a. Tamamlanmamış, b. Tamamlanmış, c.İyi yapılmış 

            // Accepted state strings 
            // 1. c -> İyi yapılmış
            // 2. cb -> İyi yapılmış, Tamamlanmış
            // 3. bc -> Tamamlanmış, İyi yapılmış

            // Final Acceptance state -> E. Onayla
            if((selectedStates == "c" || selectedStates == "cb" || selectedStates == "bc") 
                && selectedStates != "")
            {
                this.onaylaButton.Enabled = true;
                this.ReddetButonu.Enabled = false;
            } 
            else if(selectedStates == "")
            {
                this.ReddetButonu.Enabled = false;
                this.onaylaButton.Enabled = false;
            }

            else
            {
                this.onaylaButton.Enabled = false;
                this.ReddetButonu.Enabled = true;
            }
        }

        /// <summary>
        /// iyi yapilmis state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iyiYapilmisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                selectedStates += "c";
                stateControl();
            }
            else
            {
                removeState('c');
                stateControl();
            }
        }

        /// <summary>
        /// tamamlammış state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TamamlanmisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                selectedStates += "b";
                stateControl();
            }
            else
            {
                removeState('b');
                stateControl();
            };
        }

        /// <summary>
        /// tamamlanmamış state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tamamlanmamis_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                selectedStates += "a";
                stateControl();
            }
            else
            {

                removeState('a');
                stateControl();
            }
        }

        private void removeState(char character)
        {
            string temp = "";
            for(int i = 0; i < selectedStates.Length; i++)
            {
                if(selectedStates[i] != character)
                {
                    temp += selectedStates[i];
                }
            }

            selectedStates = temp;
        }
    }
}
