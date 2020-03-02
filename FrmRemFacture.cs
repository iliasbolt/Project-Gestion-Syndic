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
    public partial class FrmRemFacture : Form
    {
        BindingSource bsFac;
        BindingSource bsRem;
        SqlCommand cmd;
        bool ajt = false;
        public FrmRemFacture()
        {
            InitializeComponent();
        }

        private void activier(bool b)
        {
            grp_facture.Enabled = b;
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
            if (cb_facture.Items.Count > 0)
            {
                try
                {pos = Convert.ToInt32(cb_facture.SelectedValue);} catch { }

                string sql = "select * from remarque_facture where archive = 1 and id_facture = " + pos;
                bsRem = Fonctions.remplirList(lst_Remaques, sql, "remarque_facture", "nom", "id_remaque");

                txt_nomremarque.DataBindings.Clear();
                txt_remarque.DataBindings.Clear();
                txt_nomremarque.DataBindings.Add("Text", bsRem, "nom");
                txt_remarque.DataBindings.Add("Text", bsRem, "remarque");
            }
        }
        private void FrmRemFacture_Load(object sender, EventArgs e)
        {
            string sql = "select * from facture where archive = 1";
            bsFac = Fonctions.remplirList(cb_facture, sql, "facture", "designation", "id_facture");

            remplirLst();

            activier(true);
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
                            cmd = new SqlCommand("update remarque_facture set archive = 0 where id_remaque = " + lst_Remaques.SelectedValue + "", Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Remarque Supprimer Avec Succces.", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            remplirLst();
                        }
                    }
                    break;
                case "Valider":
                    if (ajt)
                    {
                        cmd = new SqlCommand("insert into remarque_facture values ('" + txt_nomremarque.Text + "','" + txt_remarque.Text + "'," + cb_facture.SelectedValue + " , 1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Remarque Ajouter Avec Succces.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        remplirLst();
                    }
                    else
                    {
                        if (lst_Remaques.Items.Count > 0)
                        {
                            cmd = new SqlCommand("update remarque_facture set nom = '" + txt_nomremarque.Text + "' , remarque = '" + txt_remarque.Text + "' where id_remaque = " + lst_Remaques.SelectedValue + "", Fonctions.CnConnection());
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

        private void cb_facture_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirLst();
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez Nom Pour Chercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez Nom Pour Chercher");
        }
    }
}
