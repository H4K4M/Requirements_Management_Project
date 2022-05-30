/*
 @author Enes Ay 152120191097
 */

using ReqApp.data;
using ReqApp.helpers;
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
using System.Xml.Serialization;
using static System.Windows.Forms.ListView;

namespace ReqApp.pages.subpages
{
    public partial class Gereksinimler : Form
    {
        private List<Gereksinim> gereksinimler = new List<Gereksinim>();
        private int Index;

        public Button GuncelemeButton = new Button
        {
            Text = "Güncel",
            Location = new Point(440, 204),
            Size = new Size(318, 57),
            BackColor = Color.Aquamarine
        };

        public Gereksinimler()
        {
            InitializeComponent();

            gereksinimler = DataAccess.GetGereksinimler();

            if(gereksinimler.Count > 0)
            {
                foreach(var gereksinim in gereksinimler)
                {
                    this.gereksinimListView.Rows.Add(gereksinim.Id, gereksinim.GereksinimAdi, gereksinim.GereksinimKodu, gereksinim.Aciklama,
                        gereksinim.EklemeTarihi);
                }
            }
        }

        private void YeniGereksinimButton_Click(object sender, EventArgs e)
        {
            if(this.GereksinimAdiTextBox.Text != "" && this.GereksinimKoduTextBox.Text != "" && this.AciklamaTextBox.Text != "") 
            {
                string dateTime = DateTime.Now.ToString();

                string generatedId = Encryption.generateUserId();

                gereksinimler.Add(
                    new Gereksinim { Id = generatedId,
                                     GereksinimAdi = this.GereksinimAdiTextBox.Text,
                                     GereksinimKodu = this.GereksinimKoduTextBox.Text,
                                     Aciklama = this.AciklamaTextBox.Text,
                                     EklemeTarihi = dateTime
                                    }
                    );

                if(DataAccess.AddGereksinim(gereksinimler))
                {
                    this.gereksinimListView.Rows.Add(generatedId, this.GereksinimAdiTextBox.Text, this.GereksinimKoduTextBox.Text, this.AciklamaTextBox.Text,
                       dateTime);

                    this.GereksinimAdiTextBox.Text = null;
                    this.GereksinimKoduTextBox.Text = null;
                    this.AciklamaTextBox.Text = null;
                }

                else
                {
                    MessageBox.Show("Gereksinim eklenmedi. Tekrar deneyin");
                }
            }

            else
            {
                MessageBox.Show("Tüm boşluklar doldurulmalı", "Uyarı");
            }
        }

        private void gereksinimListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // delete gereksinim
                if(senderGrid.Columns[e.ColumnIndex] == this.Sil)
                {
                    DataAccess.DeleteGereksinim(gereksinimListView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    gereksinimListView.Rows.RemoveAt(e.RowIndex);

                    if (GuncelemeButton.Visible)
                    {
                        YeniGereksinimButton.Show();
                        GuncelemeButton.Hide();
                        this.GereksinimAdiTextBox.Text = null;
                        this.GereksinimKoduTextBox.Text = null;
                        this.AciklamaTextBox.Text = null;
                    }
                }
                // refilled gereksinim form is update is clicked
                else
                {
                    this.GuncelemeButton.Show();
                    YeniGereksinimButton.Hide();
                    GuncelemeButton.Click += new EventHandler(GuncelemeButton_Click);
                    this.Controls.Add(GuncelemeButton);

                    this.GereksinimAdiTextBox.Text = gereksinimler[e.RowIndex].GereksinimAdi;
                    this.GereksinimKoduTextBox.Text = gereksinimler[e.RowIndex].GereksinimKodu;
                    this.AciklamaTextBox.Text = gereksinimler[e.RowIndex].Aciklama;

                    Index = e.RowIndex;
                }
            }
        }
        
        private void GuncelemeButton_Click(object sender, EventArgs e)
        {
                //----------Change Info------------------//
            gereksinimler[Index].Id = gereksinimListView.Rows[Index].Cells[0].Value.ToString();
            gereksinimler[Index].GereksinimAdi = GereksinimAdiTextBox.Text;
            gereksinimler[Index].GereksinimKodu = GereksinimKoduTextBox.Text;
            gereksinimler[Index].Aciklama = AciklamaTextBox.Text;
            gereksinimler[Index].EklemeTarihi = gereksinimListView.Rows[Index].Cells[4].Value.ToString();

            bool deleted = DataAccess.DeleteGereksinim(gereksinimler[Index].Id);

            if (DataAccess.AddGereksinim(gereksinimler))
            {
                gereksinimListView.Rows[Index].Cells[0].Value = gereksinimler[Index].Id;
                gereksinimListView.Rows[Index].Cells[1].Value = gereksinimler[Index].GereksinimAdi;
                gereksinimListView.Rows[Index].Cells[2].Value = gereksinimler[Index].GereksinimKodu;
                gereksinimListView.Rows[Index].Cells[3].Value = gereksinimler[Index].Aciklama;
                gereksinimListView.Rows[Index].Cells[4].Value = gereksinimler[Index].EklemeTarihi;
            }//end-if

            //Clear
            GereksinimAdiTextBox.Text = null;
            GereksinimKoduTextBox.Text = null;
            AciklamaTextBox.Text = null;
            GuncelemeButton.Hide();
            YeniGereksinimButton.Show();
            GuncelemeButton.Click -= new EventHandler(GuncelemeButton_Click);
            //----------------
        }

        private void Gereksinimler_Load(object sender, EventArgs e)
        {

        }
    }
}
