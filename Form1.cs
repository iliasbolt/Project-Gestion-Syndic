using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Syndic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ouvrire(Form frm)
        {
            if (this.pnl_forms.Controls.Count > 0)
                this.pnl_forms.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.AutoScroll = true;
            this.pnl_forms.Controls.Add(fh);
            this.pnl_forms.Tag = fh;
            fh.Show();
        }
        private void btn_tableBord_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btn_tableBord":
                    lbl_titre.Text = "Tableau de bord - Syndic";
                    ouvrire(new FrmDashboard());
                    break;
                case "btn_facture":
                    lbl_titre.Text = "Facture - Syndic";
                    ouvrire(new FrmFactures());
                    break;
                case "btn_recette":
                    lbl_titre.Text = "Recette - Syndic";
                    ouvrire(new frm_recette());
                    break;
                case "btn_cotisation":
                    lbl_titre.Text = "Cotisation - Syndic";
                    ouvrire(new frm_Cotisation());
                    break;
                case "btn_echeance":
                    lbl_titre.Text = "Échéance - Syndic";
                    ouvrire(new frm_Echeance());
                    break;
                case "btn_immeuble":
                    lbl_titre.Text = "Immeuble - Syndic";
                    ouvrire(new Frm_immeuble());
                    break;
                case "btn_bien":
                    lbl_titre.Text = "Bien - Syndic";
                    ouvrire(new Frm_Bien());
                    break;
                case "btn_proprietaire":
                    lbl_titre.Text = "Proprietaire - Syndic";
                    ouvrire(new frm_Proprietaire());
                    break;
                case "btn_employe":
                    lbl_titre.Text = "Employer - Syndic";
                    ouvrire(new Frm_Employe());
                    break;
                case "btn_historique":
                    lbl_titre.Text = "Historique - Syndic";
                    ouvrire(new FrmHistorique());
                    break;
                case "btn_utilisateur":
                    lbl_titre.Text = "Utilisateur - Syndic";
                    ouvrire(new Frm_utilisateur());
                        break;
                case "btn_fournisseur":
                    lbl_titre.Text = "Fournisseur - Syndic";
                    ouvrire(new FrmFournisseur());
                    break;
                case "btn_article":
                    lbl_titre.Text = "Article - Syndic";
                    ouvrire(new FrmArticle());
                    break;
                case "btn_statistique":
                    lbl_titre.Text = "Statistique - Syndic";
                    ouvrire(new Statistique());
                    break;
                case "btn_parametre":
                    lbl_titre.Text = "Parametre - Syndic";
                    ouvrire(new FrmParametre());
                    break;
                case "btn_deconnection":
                    lbl_titre.Text = "Deconnecte - Syndic";
                    FrmLogin f = new FrmLogin();
                    f.Show();
                    this.Close();
                    break;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btn_close":
                    Application.Exit();
                    break;
                case "btn_minimaze":
                    WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnl_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_tableBord.PerformClick();
        }
    }
}
