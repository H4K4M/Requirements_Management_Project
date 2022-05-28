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
        }

        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            if(validateInputs())
            {
                string generatedId = Encryption.generateUserId();
                var selectedGereksinims = new List<Gereksinim>();

                for(int i = 0; i < this.gereksinimlerCheckList.Items.Count; i++)
                {
                    if(this.gereksinimlerCheckList.GetItemChecked(i))
                    {
                        var item = this.gereksinimlerCheckList.GetItemChecked(i).ToString();
                        var returnedGereksinim = DataAccess.GetGereksinim(item);

                        if (returnedGereksinim != null)
                            selectedGereksinims.Add(returnedGereksinim);
                    }
                }

                gorevler.Add(new Gorev
                {
                    Id = generatedId,
                    GorevAdi = this.GorevAdiTextbox.Text,
                    GorevKodu = this.GorevKoduTextBox.Text,
                    Aciklama = this.aciklamaTextBox.Text,
                    calisan = DataAccess.GetCalisan(this.calisanComboBox.SelectedItem.ToString()),
                    gereksinimler = null
                });
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
    }
}
