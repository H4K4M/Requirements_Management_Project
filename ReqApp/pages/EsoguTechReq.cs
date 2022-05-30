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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReqApp.models;
using ReqApp;
using ReqApp.helpers;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using ReqApp.pages.subpages;

namespace ReqApp.pages
{
    public partial class EsoguTechReq : Form
    {
        private Session _session;
        private IconButton currentButton { get; set;  }

        private Form currentPage { get; set; } 

        public EsoguTechReq(Session session)
        {
            InitializeComponent();

            DashboardButton.BackColor = RGBColors.color2;

            _session = session; 

            if(_session.currentUser.user.role == "Staff")
            {
                Navigate(new Gorevlerim(_session));
            }

            else
            {
                Navigate(new Dashboard());
            }

            // controls what users see based on their roles
            controlUserRolesDisplays();

            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(33, 47, 96);
            public static Color color2 = Color.FromName("Black");
        }

        /// <summary>
        /// Navigates to the dashboard page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashboardButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // navigate page
            Navigate(new Dashboard());
        }

        /// <summary>
        /// Navigates tp the requirements page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RequirementsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // navigate page
            Navigate(new Gereksinimler());
        }

        /// <summary>
        /// Navigates to the task page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // navigate page
            Navigate(new subpages.Gorevler());
        }

        /// <summary>
        /// Navigates to the workers page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkersButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // navigate page
            Navigate(new Calisanlar());
        }

        /// <summary>
        /// Navigates to the profile page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // navigate page
            Navigate(new Profil(_session));
        }

        /// <summary>
        /// Navigates to the work evaluation page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkEvaluationButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // navigate page
            Navigate(new IsDegerlendirme());
        }

        /// <summary>
        /// Navigates to my task page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTaskButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            // navigate page
            Navigate(new Gorevlerim(_session));
        }

        /// <summary>
        /// logs user out of the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var reply = MessageBox.Show("Çıkış yapmak ister misin ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(reply == DialogResult.Yes)
            {
                SignIn signIn = new SignIn();
                TimeOut.SwapWindows(signIn, this, 1000);
            }
        }

        /// <summary>
        /// Navigates to the dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logo_Click(object sender, EventArgs e)
        {
            if(_session.currentUser.user.role == "Staff")
            {

                // update current page label
                ActivateButton(this.MyTaskButton);

                // switch to my task page
                Navigate(new Gorevlerim(_session));
            }

            else
            {

                ActivateButton(this.DashboardButton);

                // switch to dashboard page
                Navigate(new Dashboard());
            }
        }

        /// <summary>
        /// Navigates to a page
        /// </summary>
        /// <param name="page"></param>
        private void Navigate(Form page)
        {
            if(currentPage != null)
            {
                currentPage.Close();
            }

            currentPage = page;
            page.TopLevel = false;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            pagesPanel.Controls.Add(page);
            pagesPanel.Tag = page;
            page.BringToFront();
            page.Show();
        }

        /// <summary>
        ///  make current page button unique
        /// </summary>
        /// <param name="senderBtn"></param>
        public void ActivateButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                DisableButton();

                // update button properties
                currentButton = (IconButton)senderBtn;
                this.currentPageIcon.IconChar = currentButton.IconChar;
                currentButton.BackColor = RGBColors.color2;
                this.currentPageLabel.Text = currentButton.Text;
            }
        }

        /// <summary>
        /// restores button defaults
        /// </summary>
        public void DisableButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = RGBColors.color1;
                currentButton.ForeColor = Color.White;
            }

            if(currentButton != this.DashboardButton && DashboardButton.BackColor == RGBColors.color2)
            {
                DashboardButton.BackColor = RGBColors.color1;
            }

            if(currentButton != this.MyTaskButton && MyTaskButton.BackColor == RGBColors.color2 && _session.currentUser.user.role == "Staff")
            {
                MyTaskButton.BackColor = RGBColors.color1;
            }
        }

        /// <summary>
        /// controls what users see based on their roles
        /// </summary>
        public void controlUserRolesDisplays()
        {
            if(_session.currentUser.user.role == "Staff")
            {
                // hide all buttons execept my task button and profile
                this.DashboardButton.Visible = false;
                this.RequirementsButton.Visible = false;
                this.TaskButton.Visible = false;
                this.WorkersButton.Visible = false;
                this.WorkEvaluationButton.Visible = false;

                // change visible buttons position and other properties
                this.MyTaskButton.BackColor = RGBColors.color2;
                this.MyTaskButton.Location = new Point(21, 168);
                this.ProfileButton.Location = new Point(21, 228);
                this.LogoutButton.Location = new Point(21, 287);
            }

            else if(_session.currentUser.user.role == "Administrator")
            {
                this.MyTaskButton.Visible = false;
                this.LogoutButton.Location = new Point(15, 430);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hand, int wMsg, int wParam, int IParam);

        /// <summary>
        /// Window dragging event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Closes current window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maximizes the window size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaximizeWindowButton_Click(object sender, EventArgs e)
        {
            this.WindowState ^= FormWindowState.Maximized;
        }

        /// <summary>
        /// Minimizes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeWindowButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
