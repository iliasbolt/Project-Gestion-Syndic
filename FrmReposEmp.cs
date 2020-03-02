using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Syndic
{
    public partial class FrmReposEmp : Form
    {
        BindingSource bsRop;
        public FrmReposEmp()
        {
            InitializeComponent();
        }

        private void remplirGrille()
        {
            string sql = "select r.id_repos,r.id_employe,e.nom as 'Nom',e.prenom as 'Prenom',r.nb_jour as 'Nombre Jours',r.jours as 'Les Jours' from repos_employe r inner join employe e on r.id_employe = e.id_employe where r.archive = 1";
            bsRop = Fonctions.remplirGrille(dt_grid, sql, "repos_employe");
        }
        private void FrmReposEmp_Load(object sender, EventArgs e)
        {
            remplirGrille();
            dt_grid.Columns[0].Visible = false;
            dt_grid.Columns[1].Visible = false;
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsRop.MoveLast();
                    break;
                case "btn_precedent":
                    bsRop.MovePrevious();
                    break;
                case "btn_suivant":
                    bsRop.MoveNext();
                    break;
                case "btn_premier":
                    bsRop.MoveFirst();
                    break;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    FrmAMRepos f = new FrmAMRepos("Ajouter");
                    f.ShowDialog();
                    remplirGrille();
                    dt_grid.Rows[dt_grid.Rows.Count - 1].Cells[2].Selected = true;
                    break;
                case "btn_modifier":
                    int pos;
                    if (dt_grid.Rows.Count > 0)
                    {
                        pos = dt_grid.CurrentRow.Index;
                        FrmAMRepos fr = new FrmAMRepos(Convert.ToInt32(dt_grid.CurrentRow.Cells[1].Value), Convert.ToInt32(dt_grid.CurrentRow.Cells[0].Value), "Modifier");
                        fr.ShowDialog();
                        remplirGrille();
                        dt_grid.Rows[pos].Cells[2].Selected = true;
                    }
                    else
                        MessageBox.Show("Acun Contract Pour Modifier.", "Aucun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_supprimer":
                    if (dt_grid.Rows.Count > 0)
                    {
                        pos = dt_grid.CurrentRow.Index;
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Ce Repos ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            SqlCommand cmd = new SqlCommand("update repos_employe set archive = 0 where id_repos = " + dt_grid.CurrentRow.Cells[0].Value, Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            remplirGrille();
                        }
                        if (pos != 0)
                            dt_grid.Rows[pos - 1].Cells[2].Selected = true;
                    }
                    else
                        MessageBox.Show("Acun Repos Pour Supprimer.", "Aucun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez Nom Ou Prenom Pour Chercher");
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez Nom Ou Prenom Pour Chercher");
        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher.Text != "Tapez Nom Ou Prenom Pour Chercher")
            {
                string str = txt_chercher.Text.Replace("'", "''");
                string nom = "", prenom = " ";
                if (str.IndexOf(' ') != -1)
                {
                    nom = str.Substring(0, str.IndexOf(' '));
                    prenom = str.Substring(str.IndexOf(' '), (str.Length - str.IndexOf(' ')));
                }
                else
                    nom = str;

                bsRop.Filter = " nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%'";
            }
        }
    }
}
