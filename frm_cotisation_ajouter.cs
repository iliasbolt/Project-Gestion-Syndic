using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class frm_cotisation_ajouter : Form
    {

        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlCommand com2 = new SqlCommand();
        SqlDataReader dr2;
        SqlCommand com22 = new SqlCommand();
        SqlConnection cn = new SqlConnection();
        BindingSource bsFac;
        int pos = 0;
        float montant = 0;
        public frm_cotisation_ajouter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cotisation_type f = new Cotisation_type();

            f.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMontant.Text = "";
            cmb_type.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }
        DataGridViewCheckBoxColumn ch = new DataGridViewCheckBoxColumn();
        private void frm_cotisation_ajouter_Load(object sender, EventArgs e)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }


            BindingSource bscombo = Fonctions.remplirList(cmb_type, "Select * from type_cotisation where archive = 1", "type_cotisation", "nomType", "id_type");
            cmb_type.DataSource = bscombo;


           
            ch.Name = "check";
            dataGridView1.Columns.Add(ch);
            
            remplirLst();
            

            string sql2 = "Select concat(nom,' ',prenom) as nm , b.id_proprietaire as ids from proprietaire p join Bien b on b.id_proprietaire = p.id_proprietaire ";


            bsFac = Fonctions.remplirList(cmb_proprietaire, sql2, "proprietaire2", "nm", "ids");
            cmb_proprietaire.Focus();

            cmb_proprietaire.SelectedIndex = 0;
            remplirLst();


            pos = int.Parse(cmb_proprietaire.ValueMember);

            remplirLst();
           

        }

        private void remplirLst()
        {
            int pos = 0;
            if (cmb_proprietaire.Items.Count > 0)
            {
                try
                {
                    pos = Convert.ToInt32(cmb_proprietaire.SelectedValue);
                    // MessageBox.Show(""+pos);
                }
                catch { }
            }

            string sql = "select NomApparetemnt from Bien where id_proprietaire = " + pos + " and archive = 1";
            bsgrill = Fonctions.remplirGrille(dataGridView1, sql, "Bien");



        }
        BindingSource bs = new BindingSource();
        BindingSource bsgrill = new BindingSource();
        private void cmb_proprietaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirLst();
            
        }
        string nomBien = "";
        int idBien = 0;
        string payment = "";
        private void btn_Proprietaire_Valider_Click(object sender, EventArgs e)
        {
            bool WhoCheked = false;
            bool iscellChecked = false;
            string sql = "";
            string sql2 = "";


          
            
            SqlCommand commande = new SqlCommand(sql,Fonctions.CnConnection());
           


            if (txtMontant.Text != "" || cmb_proprietaire.Text != "" || cmb_type.Text != "")
            {
                try
                {
                    com = new SqlCommand("insert into cotisation values('" + dateTimePicker1.Value.ToShortDateString() + "'," + float.Parse(txtMontant.Text) + "," + cmb_proprietaire.SelectedValue + ",(select distinct id_type from type_cotisation where nomType like '%" + cmb_type.Text + "%' and archive = 1),1);", cn);
                    int a = -1;
                    a = com.ExecuteNonQuery();
                    if (a != -1)
                    {
                        MessageBox.Show("Insertion Success !");
                        montant = float.Parse(txtMontant.Text.ToString());
                    }
                    else
                        MessageBox.Show("Echec Dans Insertion !");

                }
                catch {
                    MessageBox.Show("Echec Dans Insertion !");
                    return;
                }
                ////echence here its relly really hard ;;;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        iscellChecked = (bool)dataGridView1.Rows[i].Cells[0].Value;
                    }
                    catch {
                    }
                    if (iscellChecked)
                    {
                        WhoCheked = true;
                        nomBien = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        sql = "Select id_bien from Bien where NomApparetemnt like '%" + nomBien + "%'";
                        com2 = new SqlCommand(sql, Fonctions.CnConnection());
                        dr = com2.ExecuteReader();
                        dr.Read();

                        idBien = int.Parse(dr[0].ToString());
                        //dr.Close();
                        int a = -1;
                       // MessageBox.Show("" + idBien); MessageBox.Show("" + nomBien); MessageBox.Show("" + montant);

                        sql2 = "insert into echeance values(0,0,(select distinct b.charges from bien b join echeance e on e.id_bien = b.id_bien where b.id_bien = " + idBien + ")," + montant + "," + idBien + ",1)";
                        com22 = new SqlCommand(sql2, Fonctions.CnConnection());
                        a = com22.ExecuteNonQuery();
                        //if (a != -1)
                        //{
                        //    MessageBox.Show(" echeance insertion success |?");

                        //}
                        //else
                        //    MessageBox.Show("echeque in echeance |?");

                        ////////// now the payment if mounth and year ////
                        com = null;
                        com2 = null;
                        com22 = null;
                        dr.Close();
                        dr = null;
                        sql = "select distinct paiment from immeuble i join bien b on b.id_immeuble = i.id_immeuble where b.archive = 1 and id_bien = 31";
                        com = new SqlCommand(sql,Fonctions.CnConnection());
                        dr2 = com.ExecuteReader();
                        dr2.Read();
                        if (dr2 != null)
                        {
                            payment = dr2[0].ToString();
                            MessageBox.Show("paiment :>> "+payment);
                        }
                        else {
                            
                        }
                        if (payment == "annee")
                        {
                            string sqlMois = "Update echeance set annee = " + int.Parse(DateTime.Now.Year.ToString()) + " where id_bien = " + idBien + "";
                            com2 = new SqlCommand(sqlMois, Fonctions.CnConnection());
                            int a2 = -1; a2 = com2.ExecuteNonQuery();

                            //if (a2 != -1)
                            //    MessageBox.Show("nice in anne");
                            //else
                            //    MessageBox.Show("no no annee");

                        }
                        if (payment == "mois")
                        {
                            string sqlMois = "Update echeance set mois = "+int.Parse(DateTime.Now.Month.ToString())+" where id_bien = "+idBien+"";
                            com2 = new SqlCommand(sqlMois,Fonctions.CnConnection());
                            int a2 = -1;
                            a2 =  com2.ExecuteNonQuery();

                            //if(a2 != -1)
                            //    MessageBox.Show("nice in mois");
                            //else
                            //    MessageBox.Show("no no mois");


                        }
                       
                        
                        break;
                        
                    }
                    else {
                        MessageBox.Show("Checker Un Bien :)");

                    }

                    // }
                    //catch
                    //{
                    //    MessageBox.Show("Testew");
                    //}

                }

            }
        }
        bool clicked = false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!clicked)
            {
                dataGridView1.CurrentRow.Cells[0].Value = true;
                clicked = true;
            }
            else
            {

                dataGridView1.CurrentRow.Cells[0].Value = false;
                clicked = false;
            }


        }
    }
}
