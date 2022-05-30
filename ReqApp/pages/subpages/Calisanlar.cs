using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReqApp.models;
using ReqApp.data;
using ReqApp.helpers;
/* Hakam Chedo 152120181096
 * magnitar123@gmail.com
 */
namespace ReqApp.pages.subpages
{
    public partial class Calisanlar : Form
    { 
        private List<Calisan> calisanlar = new List<Calisan>();
        private List<User> users = new List<User>();
        private int Index;
        private Button GuncelemeButton = new Button
        {
            Text = "Güncel",
            Location = new Point(30, 300),
            Size = new Size(350, 53),
            BackColor = Color.Aquamarine
        };
        public Calisanlar()
        {
            InitializeComponent();

            calisanlar = DataAccess.GetCalisanlar();

            if(calisanlar.Count > 0)
            {
                for (int i = 0; i < calisanlar.Count(); i++)
                {
                    dataGridView1.Rows.Add(calisanlar[i].Id, calisanlar[i].Adi, calisanlar[i].Soyad, calisanlar[i].user.username, calisanlar[i].user.email,
                        calisanlar[i].Dogum, calisanlar[i].Maas);
                }
            }

            IptalButton.Hide();
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            if (AdTextBox.Text != "" && SoyadTextBox.Text != "" && DogumTextBox.Text != "" && MaasTextBox.Text != ""
                && emailTextBox.Text != "" && usernameTextBox.Text != "" && passwordTexBox.Text != "")
            {
                string generatedId = Encryption.generateUserId();
                var user = new User
                {
                    Id = generatedId,
                    username = usernameTextBox.Text,
                    email = emailTextBox.Text,
                    password = Encryption.Encrypt(passwordTexBox.Text),
                    role = "Staff"
                };

                calisanlar.Add(
                  new Calisan { Id = generatedId, Adi = AdTextBox.Text, Soyad = SoyadTextBox.Text, Dogum = DogumTextBox.Text, Maas = MaasTextBox.Text,
                  user = user }
              );

                //--------add calisan -------//
                if (DataAccess.saveCalisanlar(calisanlar))
                {
                    dataGridView1.Rows.Add(generatedId, AdTextBox.Text, SoyadTextBox.Text, usernameTextBox.Text, emailTextBox.Text, DogumTextBox.Text, MaasTextBox.Text);
                }//end-if
                else { calisanlar.RemoveAt(calisanlar.Count - 1); }
            }
            else { MessageBox.Show("Lütfen forum tammen doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                
            //Clear textboxes
            AdTextBox.Text = null;
            SoyadTextBox.Text = null;
            DogumTextBox.Text = null;
            MaasTextBox.Text = null;
            emailTextBox.Text = null;
            passwordTexBox.Text = null;
            usernameTextBox.Text = null;
            //----------------
        }//end

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if(senderGrid.Columns[e.ColumnIndex] == Sil) //SilmeButton click
                {
                    DataAccess.DeleteCalisan(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    //Clear Textboxes and get Eklebutton if silmebutton click while GuncelemeButton is on
                    if (GuncelemeButton.Visible)
                    {
                        EkleButton.Show();
                        GuncelemeButton.Hide();
                        IptalButton.Hide();
                        AdTextBox.Text = null;
                        SoyadTextBox.Text = null;
                        DogumTextBox.Text = null;
                        MaasTextBox.Text = null;
                        emailTextBox.Text = null;
                        passwordTexBox.Text = null;
                        usernameTextBox.Text = null;
                    }
                }//end-if
                else //GuncellemeButton click
                {
                    //---------Change button-------//
                    EkleButton.Hide();
                    GuncelemeButton.Show();
                    IptalButton.Show();
                    IptalButton.Location = new Point(450, 300);
                    IptalButton.Size = new Size(350, 53);
                    GuncelemeButton.Click += new EventHandler(GuncelemeButton_Click);
                    this.Controls.Add(GuncelemeButton);
                    //-----------------------------//
                    //------Add all info to textboxes---//
                    AdTextBox.Text = calisanlar[e.RowIndex].Adi;
                    SoyadTextBox.Text = calisanlar[e.RowIndex].Soyad;
                    DogumTextBox.Text = calisanlar[e.RowIndex].Dogum;
                    MaasTextBox.Text = calisanlar[e.RowIndex].Maas;
                    passwordTexBox.Enabled = false;
                    emailTextBox.Text = calisanlar[e.RowIndex].user.email;
                    usernameTextBox.Text = calisanlar[e.RowIndex].user.username;
                    Index = e.RowIndex;
                }//end-else
            }//end-if           
        }//end
        private void GuncelemeButton_Click(object sender, EventArgs e)
        {
            passwordTexBox.Enabled = false;

            DataAccess.DeleteCalisan(calisanlar[Index].Id);

            //----------Change Info------------------//
            calisanlar[Index].Id = this.CalisanId.ToString();
            calisanlar[Index].Adi = AdTextBox.Text;
            calisanlar[Index].Soyad = SoyadTextBox.Text;
            calisanlar[Index].Dogum = DogumTextBox.Text;
            calisanlar[Index].Maas = MaasTextBox.Text;
            calisanlar[Index].user.username = usernameTextBox.Text;
            calisanlar[Index].user.password = passwordTexBox.Text;
            calisanlar[Index].user.email = emailTextBox.Text;

            //-----------add calisan----------//
            if (DataAccess.saveCalisanlar(calisanlar))
            {
                dataGridView1.Rows[Index].Cells[0].Value = calisanlar[Index].user.Id;
                dataGridView1.Rows[Index].Cells[1].Value = calisanlar[Index].Adi;
                dataGridView1.Rows[Index].Cells[2].Value = calisanlar[Index].Soyad;
                dataGridView1.Rows[Index].Cells[3].Value = calisanlar[Index].user.username;
                dataGridView1.Rows[Index].Cells[4].Value = calisanlar[Index].user.email;
                dataGridView1.Rows[Index].Cells[5].Value = calisanlar[Index].user.password;
                dataGridView1.Rows[Index].Cells[6].Value = calisanlar[Index].Dogum;
                dataGridView1.Rows[Index].Cells[7].Value = calisanlar[Index].Maas;
            }//end-if

            //Clear
            AdTextBox.Text = null;
            SoyadTextBox.Text = null;
            DogumTextBox.Text = null;
            MaasTextBox.Text = null;
            usernameTextBox.Text = null;
            passwordTexBox.Text = null;
            emailTextBox.Text = null;
            GuncelemeButton.Hide();
            IptalButton.Hide();
            EkleButton.Show();
            GuncelemeButton.Click -= new EventHandler(GuncelemeButton_Click);
            //----------------
        }//end

        private void IptalButton_Click(object sender, EventArgs e)
        {
            AdTextBox.Text = null;
            SoyadTextBox.Text = null;
            DogumTextBox.Text = null;
            MaasTextBox.Text = null;
            passwordTexBox.Text = null;
            emailTextBox.Text = null;
            usernameTextBox.Text = null;
            GuncelemeButton.Hide();
            IptalButton.Hide();
            EkleButton.Show();
            GuncelemeButton.Click -= new EventHandler(GuncelemeButton_Click);
        }
    }
}
