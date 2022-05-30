using ReqApp.data;
using ReqApp.helpers;
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

//Yavuz Ucarkus 152120171006
namespace ReqApp.pages.subpages
{
    public partial class Gorevler : Form
    {
        private List<Gorev> gorevler = new List<Gorev>();
        public Gorevler()
        {
            InitializeComponent();

            initForm();
        }

        private void initForm()
        {
            // fill çalişan combo box
            var calisanlar = DataAccess.GetCalisanlar();
            var gereksinimler = DataAccess.GetGereksinimler();

            if (calisanlar.Count == 0 || gereksinimler.Count == 0)
            {
                this.KaydetButonu.Enabled = false;
            }

            if (calisanlar.Count > 0)
            {
                foreach (var calisan in calisanlar)
                {
                    this.calisanComboBox.Items.Add(calisan.Adi);
                }

                this.calisanComboBox.SelectedIndex = 0;
            }
            // field gereksinim check box

            if(gereksinimler.Count > 0)
            {
                foreach (var gereksinim in gereksinimler)
                {
                    gereksinimlerCheckList.Items.Add(gereksinim.GereksinimAdi);
                }
            }

            // fill gorev list view 
            var gorevler = DataAccess.GetGorevler();
            if(gorevler.Count > 0)
            {
                foreach (var gorev in gorevler)
                {
                    this.gorevListView.Rows.Add(gorev.Id, gorev.GorevAdi, gorev.GorevKodu, gorev.calisan.Adi, gorev.gorevDurumu,
                        gorev.EklemeTarihi);
                }
            }
        }

        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            if(validateInputs())
            {
                string generatedId = Encryption.generateUserId();
                var selectedGereksinims = new List<Gereksinim>();

                for(int i = 0; i < this.gereksinimlerCheckList.Items.Count; i++)
                {
                    if (this.gereksinimlerCheckList.GetItemChecked(i))
                    {
                        var item = this.gereksinimlerCheckList.Items[i].ToString(); // get gereksinim name
                        var returnedGereksinim = DataAccess.GetGereksinim(item); // get gereksinim object 

                        if (returnedGereksinim != null)
                            selectedGereksinims.Add(returnedGereksinim);
                    }
                }

                // add new gorev to gorevler
                var calisan = DataAccess.GetCalisan(this.calisanComboBox.SelectedItem.ToString());

                gorevler = DataAccess.GetGorevler();

                gorevler.Add(new Gorev
                {
                    Id = generatedId,
                    GorevAdi = this.GorevAdiTextbox.Text,
                    GorevKodu = this.GorevKoduTextBox.Text,
                    Aciklama = this.aciklamaTextBox.Text,
                    EklemeTarihi = DateTime.Now.ToString(),
                    calisan = calisan,
                    gereksinimler = selectedGereksinims
                });

                //  save new assign gorev
                bool saved = DataAccess.AddGorev(gorevler);

                // uncheck all gereksinimler
                for(int i = 0; i < gereksinimlerCheckList.Items.Count; i++)
                {
                    gereksinimlerCheckList.SetSelected(i, false);
                }

                if (saved)
                {

                    this.gorevListView.Rows.Add(generatedId, GorevAdiTextbox.Text,GorevKoduTextBox.Text, calisan.Adi, 
                        gorevler[gorevler.Count - 1].gorevDurumu,
                        gorevler[gorevler.Count - 1].EklemeTarihi);
                }


                // empty all text boxes
                this.GorevAdiTextbox.Text = null;
                this.GorevKoduTextBox.Text = null;
                this.aciklamaTextBox.Text = null;
                this.calisanComboBox.SelectedIndex = 0;

            }
        }

        private bool validateInputs()
        {
            if (this.calisanComboBox.SelectedItem == null)
            {
                MessageBox.Show("Bir çalışan seçiniz");
                return false;
            }

            else if(this.GorevAdiTextbox.Text == "")
            {
                MessageBox.Show("Tüm boşluklar doldurulmalı");
                return false;
            }

            else if(this.GorevKoduTextBox.Text == "")
            {
                MessageBox.Show("Tüm boşluklar doldurulmalı");
                return false;
            }

            else if (this.aciklamaTextBox.Text == "")
            {
                MessageBox.Show("Tüm boşluklar doldurulmalı");
                return false;
            }

            else if(this.gereksinimlerCheckList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen en az bir gereksinim seçiniz");
                return false;
            }

            return true;
        }
        private void gorevListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if(senderGrid.Columns[e.ColumnIndex] == this.Silme)
                {
                    DataAccess.DeleteGorev(gorevListView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    gorevListView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
