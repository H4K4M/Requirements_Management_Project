using ReqApp.data;
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
    public partial class IsDegerlendirme : Form
    {
        public List<string> selectedStates = new List<string>();
        private List<Teslim> teslimler = new List<Teslim>();
        private Teslim selectedTeslim { get; set; }
        private int selectedIndex { get; set; }

        public IsDegerlendirme()
        {
            InitializeComponent();

            fetchSubmittedTask();

            this.onaylaButton.Enabled = false;
            this.ReddetButonu.Enabled = false;
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

        private void GorevLinkKopylaButton_Click(object sender, EventArgs e)
        {
           
        }

        private void onaylaButton_Click(object sender, EventArgs e)
        {

        }

        private void ReddetButonu_Click(object sender, EventArgs e)
        {

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
                selectedGorevAdiText.Text = selectedTeslim.gorev.GorevAdi;
                selectedGorevAciklamasiTextBox.Text = selectedTeslim.gorev.Aciklama;
                calisanTextBox.Text = selectedTeslim.calisan.Adi;

                selectedGorevGereksinimlerList.Items.Clear();

                foreach (var teslim in selectedTeslim.gorev.gereksinimler)
                {
                    selectedGorevGereksinimlerList.Items.Add(teslim.GereksinimAdi);
                }
            }
        }

        /// <summary>
        /// state kontrol ediyor -> eğer seçilen state uyumlu ise onayla butonu aktif yoksa reddet butonu aktif olacak
        /// </summary>
        private void stateControl()
        {
            // states 
            // A. Tamamlanmamış, B. Tamamlanmamış, C. 

            // Accepted state strings 

            // Final Acceptance state -> E. Onayla 
        }

        /// <summary>
        /// mükemmel state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MukemmelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if(checkBox.Checked)
            {
                selectedStates.Insert(0, "Mükemmel");
                stateControl();
            }
            else
            {

                selectedStates.RemoveAt(0);
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
                selectedStates.Insert(1, "İyi Yapılmış");
                stateControl();
            }
            else
            {

                selectedStates.RemoveAt(1);
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
                selectedStates.Insert(2, "Tamamlanmış");
                stateControl();
            }
            else
            {

                selectedStates.RemoveAt(2);
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
                selectedStates.Insert(3, "Tamamlanmamış");
                stateControl();
            }
            else
            {

                selectedStates.RemoveAt(0);
            }
        }
    }
}
