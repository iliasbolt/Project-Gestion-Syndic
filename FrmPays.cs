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
    public partial class FrmPays : Form
    {
        SqlCommand cmd;
        public FrmPays()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text != "")
            {
                cmd = new SqlCommand("insert into pays values ('" + txt_nom.Text + "')", Fonctions.CnConnection());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pay Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Tapez Le Nom De Pay S'il Vous Plait.", "Remplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
