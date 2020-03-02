using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class frm_cotisation_real : Form
    {
        BindingSource bsProp = new BindingSource();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();


        public frm_cotisation_real()
        {
            InitializeComponent();
        }

        private void btn_Recette_Ajouter_Click(object sender, EventArgs e)
        {
            //SqlCommandBuilder com = new SqlCommandBuilder(da);
            //da.Update(ds.Tables["cotisation"]);


            //frm_cotisation_information f = new frm_cotisation_information("Ajouter");
            //f.ShowDialog();


            frm_cotisation_ajouter f = new frm_cotisation_ajouter();
            f.ShowDialog();
            
            SqlCommandBuilder com2 = new SqlCommandBuilder(da);
            da.Update(ds.Tables["cotisation"]);
        }

        private void frm_cotisation_real_Load(object sender, EventArgs e)
        {
            rd_nomPrenom.Checked = true;
            pnl_nomPrenom.Visible = true;
            ///
            ////////////
            txt_chercher = MyHint.LoadText(txt_chercher,"Nom ou Prenom");
            //////////

            ds.Tables.Clear();
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            da = new SqlDataAdapter("Select id_cotisation as [NumCotisation],date_cotisation as Date,montant as Montant,concat(nom,' ',prenom) as Proprietaire,nomType as Type from cotisation c join proprietaire p on p.id_proprietaire = c.id_proprietaire  join type_cotisation t on t.id_type = c.id_typeCotisation  where c.archive = 1", cn);
            if (!ds.Tables.Contains("cotisation"))
               da.Fill(ds, "cotisation");



            bsProp.DataSource = ds;
            bsProp.DataMember = "cotisation";

            dataGridView1.DataSource = bsProp;

        }

        private void rd_date_CheckedChanged(object sender, EventArgs e)
        {
            pnl_nomPrenom.Visible = false;
            pnl_date.Visible = true;
        }

        private void rd_nomPrenom_CheckedChanged(object sender, EventArgs e)
        {
            pnl_date.Visible = false;
            pnl_nomPrenom.Visible = true;

            
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            txt_chercher = MyHint.HintEnter(txt_chercher,"Nom ou Prenom");
            
        }
        
        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            txt_chercher = MyHint.HintLeave(txt_chercher, "Nom ou Prenom");
            
        }
        string search="";
        //string load = "";
        private void btn_chercherNom_Click(object sender, EventArgs e)
        {

            search = txt_chercher.Text.Replace("'", "''");

            if (txt_chercher.Text == "Taper Nom ou Prenom pour rechercher" || txt_chercher.Text == "")
            {
                SqlCommandBuilder com = new SqlCommandBuilder(da);
                da.Update(ds.Tables["cotisation"]);
                bsProp.Filter = "";
                dataGridView1.DataSource = bsProp;

                
            }
            else
            {
                bsProp.Filter = "[Proprietaire] like '%" + search+"%'";
                

            }
        }

        private void btn_chercherDate_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(dt_a.Value.ToShortDateString());
            //bsProp.Filter = "date_cotisation between '"+dt_de.Value.ToShortDateString() + "' and '"+dt_a.Value.ToShortDateString()+"' ";

            // second try 
            //
            da = new SqlDataAdapter("Select id_cotisation as [NumCotisation],date_cotisation as Date,montant as Montant,concat(nom,' ',prenom) as Proprietaire,t.nomType as Type from cotisation c join proprietaire p  on p.id_proprietaire = c.id_proprietaire  join type_cotisation t on t.id_type = c.id_typeCotisation  where c.archive = 1 and date_cotisation >= '" + dt_de.Value.ToShortDateString() + "' and date_cotisation <= '" + dt_a.Value.ToShortDateString() + "' ", cn);
            if (!ds.Tables.Contains("cotisation2"))
                da.Fill(ds, "cotisation2");

            bsProp.DataSource = ds;
            bsProp.DataMember = "cotisation2";

            dataGridView1.DataSource = bsProp;
            //Thread.Sleep(20);
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("Nothing Found !","empty",MessageBoxButtons.OK, MessageBoxIcon.Information);
                bsProp.DataSource = ds;
                bsProp.DataMember = "cotisation";
                dataGridView1.DataSource = bsProp;
            }
          
           


        }

        private void btn_Recette_Annuler_Click(object sender, EventArgs e)
        {
            bsProp.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bsProp.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bsProp.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsProp.MoveLast();
        }

        private void btn_Recette_modifier_Click(object sender, EventArgs e)
        {
            frm_cotisation_information f = new frm_cotisation_information("Modifier",int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            f.ShowDialog();

            
        }
    }
}
