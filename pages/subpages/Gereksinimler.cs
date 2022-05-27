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
        public Button GuncellemeButton = new Button
        {
            Text = "Güncel",
            Location = new Point(35, 171),
            Size = new Size(423, 43),
            BackColor = Color.Aquamarine
        };

        public Gereksinimler()
        {
            InitializeComponent();
        }

        private void Gereksinimler_Load(object sender, EventArgs e)
        {

        }

        private void YeniGereksinimButton_Click(object sender, EventArgs e)
        {

        }
    }
}
