using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using ReqApp.data;
using ReqApp.models;

namespace ReqApp.pages.subpages
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            initLabeCounts();
        }

        private void initLabeCounts()
        {
            var competeTaskCount = DataAccess.TamalanmisGorevlerCount();
            var incompleteTaskCount = DataAccess.TamanlanmamisGorevlerCount();
            var workersCount = DataAccess.CalisanlarCount();
            var reqCount = DataAccess.GereksinimlerCount();

            this.completeTaskLabel.Text = competeTaskCount.ToString();
            this.incompleteTaskLabel.Text = incompleteTaskCount.ToString();
            this.requirementLabel.Text = reqCount.ToString();
            this.workersLabel.Text = workersCount.ToString();
        }
    }
}
