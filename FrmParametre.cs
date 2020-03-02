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
    public partial class FrmParametre : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bsVille;
        public FrmParametre()
        {
            InitializeComponent();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "Modifier":
                    grp_res.Enabled = true;
                    btn_modifier.Text = "Valider";
                    break;
                case "Valider":
                    if (txt_nom.Text != "" && txt_code.Text != "" && txt_titre.Text != "" && txt_adresse.Text != "")
                    {
                        grp_res.Enabled = false;
                        btn_modifier.Text = "Modifier";
                        cmd = new SqlCommand("update residence set nom = '" + txt_nom.Text + "' , adresse = '" + txt_adresse.Text + "' ,code_postal = " + Int32.Parse(txt_code.Text) + ", id_ville = " + cb_ville.SelectedValue + ", titrefoncier = '" + txt_titre.Text + "'", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("REsidense Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Remplier Tous Les Champs S'il Vous Plait", "Remplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void FrmParametre_Load(object sender, EventArgs e)
        {
            bsVille = Fonctions.remplirList(cb_ville, "ville", "nom_ville", "id_ville");
            grp_res.Enabled = false;


            cmd = new SqlCommand("select * from residence", Fonctions.CnConnection());
            dr = cmd.ExecuteReader();
            dr.Read();
            txt_nom.Text = dr["nom"].ToString();
            txt_adresse.Text = dr["adresse"].ToString();
            txt_code.Text = dr["code_postal"].ToString();
            txt_titre.Text = dr["titrefoncier"].ToString();

            cb_ville.SelectedValue = Convert.ToInt32(dr["id_ville"].ToString());
            dr.Close();
            dr = null;
        }

        private void btn_rubrique_Click(object sender, EventArgs e)
        {
            FrmVille f = new FrmVille();
            f.ShowDialog();
        }
    }
}
