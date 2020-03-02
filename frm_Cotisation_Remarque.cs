using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class frm_Cotisation_Remarque : Form
    {

        BindingSource bsFac;
        BindingSource bsRem;
        SqlCommand cmd;
        bool ajt = false;

        public frm_Cotisation_Remarque()
        {
            InitializeComponent();
        }
        private void activier(bool b)
        {
            grp_facture.Enabled = b;
            grp_remarque.Enabled = b;
            grp_details.Enabled = !b;
            btn_ajouter.Enabled = b;
            if(b)
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
            if (cb_facture.Items.Count > 0)
            {
                try
                { pos = Convert.ToInt32(cb_facture.SelectedValue);
                   // MessageBox.Show(""+pos);
                }
                catch { }
            }

            string sql = "select * from remarque_cotisation where id_cotisation = " + pos+" and archive = 1";
            bsRem = Fonctions.remplirList(lst_Remaques, sql, "remarque_cotisation", "nomremarque", "id_remarque");

            txt_nomremarque.DataBindings.Clear();
            txt_remarque.DataBindings.Clear();
            txt_nomremarque.DataBindings.Add("Text", bsRem, "nomremarque");
            txt_remarque.DataBindings.Add("Text", bsRem, "remarque");


        }
        private void frm_Cotisation_Remarque_Load(object sender, EventArgs e)
        {
            string sql2 = "Select distinct Concat(nom,' ',prenom) as nm,c.id_cotisation as id from remarque_cotisation d join cotisation c on c.id_cotisation = d.id_cotisation join proprietaire p on p.id_proprietaire = c.id_proprietaire where c.archive = 1";
            bsFac = Fonctions.remplirList(cb_facture,sql2,"cotisation", "nm", "id");

            remplirLst();

            activier(true);
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
           // "Nom de Remarque"
                
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            
        }

        private void grp_details_Enter(object sender, EventArgs e)
        {

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
                    break;
                case "Modifier":
                    activier(false);
                    ajt = false;
                    break;
                case "Supprimer":
                    if (lst_Remaques.Items.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Remarque ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            MessageBox.Show(""+lst_Remaques.SelectedValue);
                            cmd = new SqlCommand("update remarque_cotisation  set archive = 0 where id_remarque = " + lst_Remaques.SelectedValue + "", Fonctions.CnConnection());
                            int a = -1;
                            a = cmd.ExecuteNonQuery();
                            if(a != -1)
                                MessageBox.Show("Remarque Supprimer Avec Succces.", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                MessageBox.Show("Remarque Ne Pas Supprimer !!! ", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            remplirLst();
                        }
                    }
                    break;
                case "Valider":
                    if (ajt)
                    {
                        cmd = new SqlCommand("insert into remarque_cotisation values ('" + txt_nomremarque.Text + "','" + txt_remarque.Text + "'," + cb_facture.SelectedValue + ",1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Remarque Ajouter Avec Succces.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        remplirLst();
                    }
                    else
                    {
                        if (lst_Remaques.Items.Count > 0)
                        {
                            cmd = new SqlCommand("update remarque_cotisation set nomremarque = '" + txt_nomremarque.Text + "' , remarque = '" + txt_remarque.Text + "' where id_remarque = " + lst_Remaques.SelectedValue + "", Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Remarque Modifier Avec Succces.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            remplirLst();
                        }
                    }
                    activier(true);
                    break;
                case "Annuler":
                    activier(true);
                    break;
            }
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
                case "btn_suivant":
                    bsRem.MoveNext();
                    break;
                case "btn_premiere":
                    bsRem.MoveFirst();
                    break;
            }
        }

        private void lst_Remaques_SelectedIndexChanged(object sender, EventArgs e)
        {
            //remplirLst();
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez Nom Pour Chercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez Nom Pour Chercher");
        }

        private void cb_facture_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirLst();
        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_chercher.Text != "Tapez Nom Pour Chercher")
                    bsRem.Filter = "nomremarque like '%" + txt_chercher.Text.Replace("'", "''") + "%'";
                else
                {
                    bsRem.Filter = "archive = 1 ";
                    lst_Remaques.SelectedIndex = 0;
                }

            }
            catch
            {
                bsRem.Filter = "archive = 1 ";
                lst_Remaques.SelectedIndex = 0;
            }
        }
    }
}
