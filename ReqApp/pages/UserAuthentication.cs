/*
  Author: Muhammed Suwaneh
  Software Engineer & Student
  Eskişehir Osmangazi University
  May 2022
 */
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
using ReqApp.helpers;
using ReqApp.pages;
using ReqApp.data;
using ReqApp.models;
using System.Runtime.InteropServices;

namespace ReqApp
{
    public partial class SignIn : Form
    {

        private bool ErrorExist { get; set; } = true;
        private bool LoginSuccess { get; set; } = false;
        private string username { get; set; }

        private string password { get; set; }
        public SignIn()
        {
            InitializeComponent();

            // only to uncommented when no data for default users exist
            //saveDefaultUsers();
        }

        /// <summary>
        /// closes the sign in window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeSignInWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Controls user authentication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // validate user inputs
            validateUserInputs();

            if (!ErrorExist)
            {
                usernameErrorFeedback.Text = "";
                usernameErrorFeedback.Visible = false;
                passwordErrorFeedback.Text = "";
                passwordErrorFeedback.Visible = false;

                this.LoginButton.Enabled = false;

                // get inputs
                password = Encryption.Encrypt(userPasswordTextBox.Text); // encrypt password 
                username = usernameTextBox.Text;

                // authenticate user
                var calisanlar = DataAccess.GetCalisanlar();

                foreach(var calisan in calisanlar)
                {
                    // check if user exist with entered credentials
                    if(calisan.user.username == username && calisan.user.password == password)
                    {

                        this.loginFeedbackLabel.Visible = true;
                        this.loginFeedbackLabel.Text = "";
                        this.loginFeedbackLabel.Text = "Giriş Başarısılı oldu";
                        this.loginFeedbackLabel.ForeColor = Color.Green;

                        // create a session
                        Session newSession = new Session
                        {
                            currentUser = calisan,
                            LoggedInTime = DateTime.Now
                        };
                        // authorize user
                        EsoguTechReq reqApp = new EsoguTechReq(newSession);

                        // log user in 
                        TimeOut.SwapWindows(reqApp, this, 2000);

                        LoginSuccess = true;
                    }
                }

                if(!LoginSuccess)
                {
                    this.loginFeedbackLabel.Visible = true;
                    this.loginFeedbackLabel.Text = "Başarısız giriş. tekrar deneyin";
                    this.LoginButton.Enabled = true;
                }
            }

        }

        /// <summary>
        /// Validates user inputs
        /// </summary>
        private void validateUserInputs()
        {
            if(usernameTextBox.Text == string.Empty)
            {
                ErrorExist = true;
                usernameErrorFeedback.Text = "Kullanıcı Adı boş birakılmalı";
                usernameErrorFeedback.Visible = true;
            }

            if (userPasswordTextBox.Text == string.Empty)
            {
                ErrorExist = true;
                passwordErrorFeedback.Text = "Kullanıcı şifresi boş birakılmalı";
                passwordErrorFeedback.Visible = true;
            }

            else
            {
                ErrorExist = false;
            }
        }

        private void saveDefaultUsers()
        {
            string Id = Encryption.generateUserId();

            var user = new User { Id = Id, username = "muhammed", password = Encryption.Encrypt("1234"), email = "suwanehmuhammed@yahoo.com", role = "Administrator" };
   
            List<Calisan> calisan = new List<Calisan>
            {
                new Calisan { Id = Id, Adi = "muhammed", Soyad = "suwaneh", Dogum = "1998-1-1", Maas = "5000", user = user }
            };

            bool saved = DataAccess.saveCalisanlar(calisan);

            if(!saved)
            {
                MessageBox.Show("hata oluştu");
                this.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hand, int wMsg, int wParam, int IParam);

        private void sizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}


//new User { Id = Encryption.generateUserId(), username = "hakam", password = Encryption.Encrypt("1234"), email = "magnitar123@gmail.com", role = "Staff" },
//                new User { Id = Encryption.generateUserId(), username = "yavuz", password = Encryption.Encrypt("1234"), email = "yavuzucarkus9@gmail.com", role = "Staff" },
//                new User { Id = Encryption.generateUserId(), username = "enes", password = Encryption.Encrypt("1234"), email = "Jcooligame@gmail.com", role = "Staff" },
//                new User { Id = Encryption.generateUserId(), username = "resulberdi", password = Encryption.Encrypt("1234"), email = "akyyevresul99@gmail.com", role = "Staff" },