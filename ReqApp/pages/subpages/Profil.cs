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
/* Hakam Chedo 152120181096
 * magnitar123@gmail.com
*/
namespace ReqApp.pages.subpages
{
    public partial class Profil : Form
    {
        Session _session { get; set; }

        public Profil(Session session)
        {
            InitializeComponent();

            _session = session;
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            this.usernameLabel.Text = _session.currentUser.user.username;
            this.emailLabel.Text = _session.currentUser.user.email; 
        }
    }
}
