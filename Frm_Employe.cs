using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class Frm_Employe : Form
    {
        public Frm_Employe()
        {
            InitializeComponent();
            pnlDrop.Visible = false;
        }

        private void cacher()
        {
            if (pnlMenuBar.Height == 175)
            {
                pnlDrop.Visible = false;
                pnlMenuBar.Height = 43;
            }
        }

        private void ouvrire(Form frm)
        {
            if (this.pnlForms.Controls.Count > 0)
                this.pnlForms.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.AutoScroll = true;
            this.pnlForms.Controls.Add(fh);
            this.pnlForms.Tag = fh;
            fh.Show();
        }
        private void btn_drop_Click(object sender, EventArgs e)
        {
            if (pnlMenuBar.Height == 43)
            {
                pnlDrop.Visible = Visible;
                pnlMenuBar.Height = 175;
            }
            else
            {
                pnlDrop.Visible = false;
                pnlMenuBar.Height = 43;
            }
        }

        private void btn_employe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_employe":
                    cacher();
                    ouvrire(new Frm_Employes());
                    pnl_selection.Location = new Point(0, 39);
                    break;
                case "btn_document":
                    cacher();
                    ouvrire(new FrmDocEmploye());
                    pnl_selection.Location = new Point(243, 39);
                    break;
                case "btn_remarque":
                    cacher();
                    ouvrire(new FrmRemEmploye());
                    pnl_selection.Location = new Point(486, 39);
                    break;
                case "btn_contrat":
                    btn_drop.PerformClick();
                    ouvrire(new FrmContratEmp());
                    pnl_selection.Location = new Point(526, 77);
                    break;
                case "btn_conge":
                    btn_drop.PerformClick();
                    ouvrire(new FrmCongeEmploye());
                    pnl_selection.Location = new Point(526, 121);
                    break;
                case "btn_repos":
                    btn_drop.PerformClick();
                    ouvrire(new FrmReposEmp());
                    pnl_selection.Location = new Point(526, 165);
                    break;
            }
        }

        private void Frm_Employe_Load(object sender, EventArgs e)
        {
            btn_employe.PerformClick();
        }
    }
}
