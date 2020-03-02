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
    public partial class FrmRemEmploye : Form
    {
        BindingSource bsEmp;
        BindingSource bsRem;
        SqlCommand cmd;
        bool ajt = false;
        int poss = 0;
        public FrmRemEmploye()
        {
            InitializeComponent();
        }

        private void activier(bool b)
        {
            grp_employes.Enabled = b;
            grp_remarque.Enabled = b;
            grp_details.Enabled = !b;
            btn_ajouter.Enabled = b;
            if (b)
            {
                btn_modifier.Text = "Modifier";
                btn_supprimer.Text = "Supprimer";
            }
            else
            {
                btn_modifier.Text = "Valider";
                btn_supprimer.Text = "Annuler";
            }
        }

        private void remplirLst()
        {
            int pos = 0;
            if (cb_employes.Items.Count > 0)
            {
                try
                { pos = Convert.ToInt32(cb_employes.SelectedValue); }
                catch { }
                string sql = "select * from remarque_employe where archive = 1 and id_employe = " + pos;
                bsRem = Fonctions.remplirList(lst_Remaques, sql, "remarque_employe", "nom", "id_remarque");

                txt_nomremarque.DataBindings.Clear();
                txt_remarque.DataBindings.Clear();
                txt_nomremarque.DataBindings.Add("Text", bsRem, "nom");
                txt_remarque.DataBindings.Add("Text", bsRem, "remarque");
            }
        }
        private void FrmRemEmploye_Load(object sender, EventArgs e)
        {
            string sql = "select *,concat(nom,' ',prenom) as nomComplet from employe where archive = 1";
            bsEmp = Fonctions.remplirList(cb_employes, sql, "Employe", "nomComplet", "id_employe");

            remplirLst();

            activier(true);
        }

        private void cb_employes_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirLst();
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez Le Nom Pour Chercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez Le Nom Pour Chercher");
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsRem.MoveLast();
                    break;
                case "btn_precedent":
                    bsRem.MovePrevious();
                    break;
                case "btn_premiere":
                    bsRem.MoveFirst();
                    break;
                case "btn_suivant":
                    bsRem.MoveNext();
                    break;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "Ajouter":
                    activier(false);
                    ajt = true;
                    txt_nomremarque.Clear();
                    txt_remarque.Clear();
                    txt_nomremarque.Focus();
                    if (lst_Remaques.Items.Count > 0)
                        poss = lst_Remaques.Items.Count;
                    break;
                case "Modifier":
                    activier(false);
                    ajt = false;
                    if (lst_Remaques.Items.Count > 0)
                        poss = lst_Remaques.SelectedIndex;
                    break;
                case "Supprimer":
                    if (lst_Remaques.SelectedIndex != -1)
                    {
                        if (lst_Remaques.Items.Count > 0)
                        {
                            poss = lst_Remaques.SelectedIndex;
                            if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Remarque ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                cmd = new SqlCommand("update remarque_employe set archive = 0 where id_remarque = " + lst_Remaques.SelectedValue + "", Fonctions.CnConnection());
                                cmd.ExecuteNonQuery();
                                remplirLst();
                                if (lst_Remaques.Items.Count > 0)
                                    lst_Remaques.SelectedIndex = poss - 1;
                            }
                        }
                    }
                    else
                        MessageBox.Show("Selectionner Un Remaque S'il Vous Plait .", "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Valider":
                    if (ajt)
                    {
                        cmd = new SqlCommand("insert into remarque_employe values ('" + txt_nomremarque.Text + "','" + txt_remarque.Text + "'," + cb_employes.SelectedValue + " , 1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Remarque Ajouter Avec Succces.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        remplirLst();
                        lst_Remaques.SelectedIndex = poss;
                    }
                    else
                    {
                        if (lst_Remaques.Items.Count > 0)
                        {
                            cmd = new SqlCommand("update remarque_employe set nom = '" + txt_nomremarque.Text + "' , remarque = '" + txt_remarque.Text + "' where id_remarque = " + lst_Remaques.SelectedValue + "", Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Remarque Modifier Avec Succces.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            remplirLst();
                            lst_Remaques.SelectedIndex = poss;
                        }
                    }
                    activier(true);
                    break;
                case "Annuler":
                    activier(true);
                    break;
            }
        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher.Text != "Tapez Le Nom Pour Chercher")
            {
                string str = txt_chercher.Text.Replace("'", "''");
                bsRem.Filter = " nom like '%" + str + "%'";
            }
        }
    }
}
