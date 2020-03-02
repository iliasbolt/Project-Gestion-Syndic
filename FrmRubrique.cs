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
    public partial class FrmRubrique : Form
    {
        public FrmRubrique()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into rubrique values ('" + txt_nom.Text + "',1)", Fonctions.CnConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rubrique Ajouter Avec Succes!", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
