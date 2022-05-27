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
    public partial class Gorevlerim : Form
    {
        Session _session { get; set; }

        public Gorevlerim(Session session)
        {
            InitializeComponent();

            _session = session;
        }

        private void Gorevlerim_Load(object sender, EventArgs e)
        {

        }
    }
}
