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
    public partial class Frm_Bien : Form
    {
        public Frm_Bien()
        {
            InitializeComponent();
            btn_bien.PerformClick();
        }
        private void ouvrire(Form frm)
        {
            if (this.pnl_Bien_container.Controls.Count > 0)
                this.pnl_Bien_container.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.AutoScroll = true;
            this.pnl_Bien_container.Controls.Add(fh);
            this.pnl_Bien_container.Tag = fh;
            fh.Show();
        }

        private void btn_document_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_bien":
                    pnl_selection.Location = new Point(0, 38);
                    ouvrire(new Frm_Bien1());
                    break;
                case "btn_bien_remarque":
                    pnl_selection.Location = new Point(514, 38);
                    ouvrire(new Frm_Bien_Remarque());

                    break;
                case "btn_bien_document":
                    pnl_selection.Location = new Point(258, 38);
                    ouvrire(new Frm_Bien_Doc());
                    break;

            }
        }

        private void pnl_Bien_container_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Frm_Bien_Load(object sender, EventArgs e)
        {
            //ouvrire(new Frm_Bien1());
           
        }
    }
}
