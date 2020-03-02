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
    public partial class FrmVille : Form
    {
        BindingSource bsPay;
        SqlCommand cmd;
        public FrmVille()
        {
            InitializeComponent();
        }

        private void FrmVille_Load(object sender, EventArgs e)
        {
            string sql = "select * from pays";
            bsPay = Fonctions.remplirList(cb_pays, sql, "pays", "nom_pays", "id_pays");
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_ville.Text != "")
            {
                cmd = new SqlCommand("insert into ville values ('" + txt_ville.Text + "'," + cb_pays.SelectedValue + ")", Fonctions.CnConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ville Aouter Avec Succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Tapez Le Nom De Ville S'il Vous Plait.", "Remplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_pays_Click(object sender, EventArgs e)
        {
            FrmPays f = new FrmPays();
            f.ShowDialog();
            string sql = "select * from pays";
            bsPay = Fonctions.remplirList(cb_pays, sql, "pays", "nom_pays", "id_pays");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
