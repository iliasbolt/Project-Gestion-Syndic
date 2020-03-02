using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Syndic
{
    public partial class Imprimer : Form
    {
        ReportClass r;
        string filter;
        public Imprimer(ReportClass _r, string _filter = "")
        {
            InitializeComponent();
            this.r = _r;
            this.filter = _filter;
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {
            CRV.ReportSource = r;
            CRV.SelectionFormula = filter;
        }
    }
}
