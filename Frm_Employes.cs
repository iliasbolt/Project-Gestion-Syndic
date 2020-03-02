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
    public partial class Frm_Employes : Form
    {
        BindingSource bsEmp;
        BindingSource bsVille;
        BindingSource bsType;
        int pos = 0;
        public Frm_Employes()
        {
            InitializeComponent();
        }

        private void activer(bool b)
        {
            grp_emps.Enabled = b;
            grp_information.Enabled = !b;

            btn_modifier.Visible = b;
            btn_supprimer.Visible = b;

            btn_valider.Visible = !b;
            btn_annuler.Visible = !b;

            btn_ajouter.Enabled = b;
        }
        
        private void remplirEmps()
        {
            string sql = "select *,concat(prenom,' ',nom) as nomcomplete from employe where archive = 1";
            bsEmp = Fonctions.remplirList(lst_emps, sql, "Employe", "nomcomplete", "id_employe");

            txt_id.DataBindings.Clear();
            txt_nom.DataBindings.Clear();
            txt_prenom.DataBindings.Clear();
            txt_adresse.DataBindings.Clear();
            txt_codePostal.DataBindings.Clear();
            txt_telephone.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_cnss.DataBindings.Clear();
            txt_active.DataBindings.Clear();
            txt_archive.DataBindings.Clear();

            txt_id.DataBindings.Add("Text", bsEmp, "id_employe");
            txt_nom.DataBindings.Add("Text", bsEmp, "nom");
            txt_prenom.DataBindings.Add("Text", bsEmp, "prenom");
            txt_adresse.DataBindings.Add("Text", bsEmp, "adresse");
            txt_codePostal.DataBindings.Add("Text", bsEmp, "code_postal");
            txt_telephone.DataBindings.Add("Text", bsEmp, "telephone");
            txt_email.DataBindings.Add("Text", bsEmp, "email");
            txt_cnss.DataBindings.Add("Text", bsEmp, "num_cnss");
            txt_active.DataBindings.Add("Text", bsEmp, "actif");

            txt_archive.DataBindings.Add("Text", bsEmp, "archive");

            cb_type.DataBindings.Clear();
            cb_ville.DataBindings.Clear();

            bsVille = Fonctions.remplirList(cb_ville, "ville", "nom_ville", "id_ville");
            cb_ville.DataBindings.Add("SelectedValue", bsEmp, "id_ville");

            bsType = Fonctions.remplirList(cb_type, "type_employe", "nom_type", "id_type");
            cb_type.DataBindings.Add("SelectedValue", bsEmp, "id_type_employe");
            
        }

        private void Frm_Employes_Load(object sender, EventArgs e)
        {
            remplirEmps();

            activer(true);
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsEmp.MoveLast();
                    break;
                case "btn_suivant":
                    bsEmp.MoveNext();
                    break;
                case "btn_premiere":
                    bsEmp.MoveFirst();
                    break;
                case "btn_precedent":
                    bsEmp.MovePrevious();
                    break;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    pos = lst_emps.Items.Count;
                    bsEmp.AddNew();
                    txt_archive.Text = "true";
                    activer(false);
                    break;
                case "btn_modifier":
                    activer(false);
                    pos = lst_emps.SelectedIndex;
                    break;
                case "btn_supprimer":
                    if (lst_emps.Items.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Ce Employe ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            pos = lst_emps.SelectedIndex - 1;
                            txt_archive.Text = "False";
                            bsEmp.EndEdit();
                            Fonctions.syncr("Employe", Fonctions.CnConnection(), Fonctions.ds);
                            remplirEmps();

                            lst_emps.SelectedIndex = pos;
                        }
                    }
                    break;
                case "btn_valider":
                    bsEmp.EndEdit();
                    Fonctions.syncr("Employe", Fonctions.CnConnection(), Fonctions.ds);
                    remplirEmps();
                    lst_emps.SelectedIndex = pos;
                    activer(true);
                    break;
                case "btn_annuler":
                    bsEmp.CancelEdit();
                    activer(true);
                    break;
            }
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez Nom & Prenom Pour Chercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez Nom & Prenom Pour Chercher");
        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher.Text != "Tapez Nom & Prenom Pour Chercher")
            {
                string nom, prenom;
                string str = txt_chercher.Text.Replace("'", "''");
                if (txt_chercher.Text.IndexOf(' ') != -1)
                {
                    nom = str.Substring(0, str.IndexOf(' '));
                    prenom = str.Substring(str.IndexOf(' '), ((Convert.ToInt32(str.Length)) - str.IndexOf(' ')));
                }
                else
                {
                    nom = str;
                    prenom = str;
                }

                bsEmp.Filter = " nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%'";
            }
        }

        private void btn_pays_Click(object sender, EventArgs e)
        {
            FrmVille f = new FrmVille();
            f.ShowDialog();
            remplirEmps();
        }
    }
}
