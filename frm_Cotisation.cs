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
    public partial class frm_Cotisation : Form
    {
        public frm_Cotisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Cotisation":
                    pnl_selection.Location = new Point(0, 38);
                    ouvrire(new frm_recette_real());
                    break;
                case "btn_cotisation_Document":

                    pnl_selection.Location = new Point(258, 38);
                    ouvrire(new frm_recette_document());

                    break;
                case "btn_cotisation_Remarque":
                    pnl_selection.Location = new Point(514, 38);
                    ouvrire(new frm_recette_remarque());
                    break;

            }
        }

        private void ouvrire(Form frm)
        {
            if (this.pnl_form.Controls.Count > 0)
                this.pnl_form.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.AutoScroll = true;
            this.pnl_form.Controls.Add(fh);
            this.pnl_form.Tag = fh;
            fh.Show();
        }

        private void btn_cotisation_Document_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_cotisation":
                    pnl_selection.Location = new Point(0, 39);
                    ouvrire(new frm_cotisation_real());
                    break;
                case "btn_cotisation_Document":

                    pnl_selection.Location = new Point(258, 39);
                    ouvrire(new frm_cotisation_Document());

                    break;
                case "btn_cotisation_Remarque":
                    pnl_selection.Location = new Point(514, 39);
                    ouvrire(new frm_Cotisation_Remarque());
                    break;

            }
        }

        private void pnl_selection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Cotisation_Load(object sender, EventArgs e)
        {
            ouvrire(new frm_cotisation_real());
        }

        private void pnl_form_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
