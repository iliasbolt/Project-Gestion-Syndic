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
    public partial class frm_cotisation_Document : Form
    {
        BindingSource bsFact;
        SqlCommand cmd;
        SqlDataReader dr;


        public frm_cotisation_Document()
        {
            InitializeComponent();
            //
            
            
        }
        private void remplirDoc()
        {
            if (lst_cotisation.Items.Count > 0)
            {
                int pos = 0;
                lst_document.Items.Clear();
                try
                { pos = Convert.ToInt32(lst_cotisation.SelectedValue); }
                catch { }

                cmd = new SqlCommand("select concat(id_document,' - ',nomDocument) as idnom from document_cotisation where archive = 1 and id_cotisation = " + pos, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lst_document.Items.Add(dr["idnom"].ToString());
                }
                dr.Close();
                dr = null;
            }
        }
        private int GetID()
        {
            string str = lst_document.Text;

            int id = Int32.Parse((str).Substring(0, str.IndexOf(' ')));
            //MessageBox.Show(""+id);
            return id;
        }
        private void txt_search_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_Fact, "Tapez Designation Pour Chercher");
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_Fact, "Tapez Designation Pour Chercher");
        }

        private void frm_cotisation_Document_Load(object sender, EventArgs e)
        {
            string sql2 = "Select distinct Concat(nom,' ',prenom) as nm,c.id_cotisation as id from document_cotisation d join cotisation c on c.id_cotisation = d.id_cotisation join proprietaire p on p.id_proprietaire = c.id_proprietaire where c.archive = 1";
           

            bsFact = Fonctions.remplirList(lst_cotisation, sql2,"Cotisation", "nm", "id");
            remplirDoc();
        }

        private void txt_chercher_doc_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_doc, "Tapez ID Ou Nom De Document Pour Chercher");
        }

        private void txt_chercher_doc_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_doc, "Tapez ID Ou Nom De Document Pour Chercher");
        }

        private void btn_premiere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_premiere":
                    bsFact.MoveFirst();
                    break;
                case "btn_derniere":
                    bsFact.MoveLast();
                    break;
                case "btn_precedent":
                    bsFact.MovePrevious();
                    break;
                case "btn_suivant":
                    bsFact.MoveNext();
                    break;
            }
        }

        private void lst_cotisation_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirDoc();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    frm_cotisationDocument_info f = new frm_cotisationDocument_info("Ajouter");
                    f.ShowDialog();
                    remplirDoc();
                    break;
                case "btn_modifier":
                    if (lst_document.SelectedIndex != -1)
                    {
                        frm_cotisationDocument_info fr = new frm_cotisationDocument_info("Modifier", GetID());
                        fr.ShowDialog();
                        remplirDoc();
                    }
                    else
                        MessageBox.Show("Selectionner Un Document S'il Vous Plait.", "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_supprimer":
                    if (lst_document.Items.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Ce Document ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            cmd = new SqlCommand("update document_cotisation set archive = 0 where id_document = " + GetID(), Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            remplirDoc();
                        }
                    }
                    break;
            }
        }

        private void txt_chercher_Fact_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_chercher_Fact.Text != "Tapez montant Pour Chercher")
                    bsFact.Filter = "montant = " + txt_chercher_Fact.Text.Replace("'", "''") + "";
                else
                {
                    bsFact.Filter = "archive = 1 ";
                    lst_cotisation.SelectedIndex = 0;
                }
            
                   
            }
            catch {
                bsFact.Filter = "archive = 1 ";
                lst_cotisation.SelectedIndex = 0;
            }
           
        }

        private void txt_chercher_doc_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher_doc.Text != "Tapez ID Ou Nom De Document Pour Chercher")
            {
                if (lst_cotisation.Items.Count > 0)
                {
                    int pos = 0;
                    lst_document.Items.Clear();
                    try
                    { pos = Convert.ToInt32(lst_cotisation.SelectedValue); }
                    catch { }


                    string filt = txt_chercher_doc.Text.Replace("'", "''");
                    try
                    {
                        cmd = new SqlCommand("select concat(id_document,' - ',nomDocument) as idnom from document_cotisation where archive = 1 and id_cotisation = " + pos + " and id_document = " + Convert.ToInt32(filt), Fonctions.CnConnection());
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lst_document.Items.Add(dr["idnom"].ToString());
                        }
                        dr.Close();
                        dr = null;
                    }
                    catch
                    {
                        cmd = new SqlCommand("select concat(id_document,' - ',nomDocument) as idnom from document_cotisation where archive = 1 and id_cotisation = " + pos + " and nomDocument like '%" + filt + "%'", Fonctions.CnConnection());
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lst_document.Items.Add(dr["idnom"].ToString());
                        }
                        dr.Close();
                        dr = null;
                    }

                }
            }
            else
            {
                remplirDoc();
            }
        }

        private void lst_cotisation_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void lst_document_DoubleClick(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select ficher from document_cotisation where id_document = " + GetID(), Fonctions.CnConnection());
            string chemin = cmd.ExecuteScalar().ToString();
            
            Fonctions.OuvrirDocument(chemin);
        }
    }
}
