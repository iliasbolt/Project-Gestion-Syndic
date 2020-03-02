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
using System.Configuration;

namespace Syndic
{
    public partial class frm_Echeance : Form
    {

        SqlDataReader reader;
        SqlConnection cn;
        SqlCommand com;

        SqlCommand comMontant = new SqlCommand();
        SqlCommand comRecu = new SqlCommand();
        SqlDataReader readerMontant;
        SqlDataReader readerAll;
        SqlDataReader readerRecu;

        string sqlQuery="";
        
        string WhoChecked = "";
        

        public frm_Echeance()
        {
            InitializeComponent();

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void frm_Echeance_Load(object sender, EventArgs e)
        {
            txt_search = MyHint.LoadText(txt_search,"Nom de bien");
            rd_tous.Checked = true;

            //Fonctions.ouvrireConnection();
            cn = Fonctions.CnConnection();
            if(cn.State != ConnectionState.Open)
                cn.Open();

            ////les annee

            ////les Mois
            WhoChecked = "";

            sqlQuery = "Select id_echeance,mois,annee,montant,montant_recu,NomApparetemnt from echeance e inner join Bien b on b.id_bien = e.id_bien join immeuble i on i.id_immeuble = b.id_immeuble where e.archive = 1 and paiment like '%"+WhoChecked+"%' ";

            com = new SqlCommand(sqlQuery, Fonctions.CnConnection());
            reader = com.ExecuteReader();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Mois";
            dataGridView1.Columns[2].Name = "Anne";
            dataGridView1.Columns[3].Name = "Montant";
            dataGridView1.Columns[4].Name = "Montant Recu";
            dataGridView1.Columns[5].Name = "Bien";
            /////////////////////////////////
            // com = new SqlCommand("Select montant from Bien",cn);
            //readerMontant = com.ExecuteReader();
            //while (readerMontant.Read())
            //{

            //}



            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            }
            ////////// //////// ///////// /////////// ////////////// ////////////// ///////////

            reader.Close();

        }
        public DataGridView RemplireGrilleConnecte(DataGridView dataGridView1,SqlDataReader reader)
        {

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Mois";
            dataGridView1.Columns[2].Name = "Anne";
            dataGridView1.Columns[3].Name = "Montant";
            dataGridView1.Columns[4].Name = "Montant Recu";
            dataGridView1.Columns[5].Name = "Bien";

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
            }
            reader.Close();
            return dataGridView1;
        }
        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Nom de bien");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom de bien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void grp_chercher_Enter(object sender, EventArgs e)
        {

        }

        private void btn_chercherNom_Click(object sender, EventArgs e)
        {
            string text = txt_search.Text.ToString().Replace("'", "''");

            
           // com = null;
            dataGridView1.Rows.Clear();
            ////
            if (text!="")
            {
                
                if (rd_Mois.Checked) WhoChecked = "mois";
                if (rd_nomPrenom.Checked) WhoChecked = "annee";
                
                sqlQuery = "Select id_echeance,mois,annee,montant,montant_recu,NomApparetemnt from echeance e inner join Bien b on b.id_bien = e.id_bien join immeuble i on i.id_immeuble = b.id_immeuble where e.archive = 1 and NomApparetemnt like '%"+text+"%' ";
                 com = new SqlCommand(sqlQuery, cn);
                try
                {
                    reader = com.ExecuteReader();
                    dataGridView1.ColumnCount = 6;
                    dataGridView1.Columns[0].Name = "Id";
                    dataGridView1.Columns[1].Name = "Mois";
                    dataGridView1.Columns[2].Name = "Anne";
                    dataGridView1.Columns[3].Name = "Montant";
                    dataGridView1.Columns[4].Name = "Montant Recu";
                    dataGridView1.Columns[5].Name = "Bien";


                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

                    }
                }
                catch
                {

                }
              

            }
            reader.Close();
            if (text == "Taper Nom de bien pour rechercher")
            {
                //MessageBox.Show("Nice");
                sqlQuery = "Select id_echeance,mois,annee,montant,montant_recu,NomApparetemnt from echeance e inner join Bien b on b.id_bien = e.id_bien join immeuble i on i.id_immeuble = b.id_immeuble where e.archive = 1 ";
                com = new SqlCommand(sqlQuery, cn);
                reader = com.ExecuteReader();
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Id";
                dataGridView1.Columns[1].Name = "Mois";
                dataGridView1.Columns[2].Name = "Anne";
                dataGridView1.Columns[3].Name = "Montant";
                dataGridView1.Columns[4].Name = "Montant Recu";
                dataGridView1.Columns[5].Name = "Bien";

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

                }


            }

        }

        private void rd_Mois_CheckedChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();

            sqlQuery = "Select id_echeance,mois,annee,montant,montant_recu,NomApparetemnt from echeance e inner join Bien b on b.id_bien = e.id_bien join immeuble i on i.id_immeuble = b.id_immeuble where e.archive = 1 and paiment like '%" + WhoChecked + "%' ";


            if (rd_Mois.Checked) WhoChecked = "mois";
            if (rd_nomPrenom.Checked) WhoChecked = "annee";

            string text = txt_search.Text.ToString().Replace("'", "''");
            if (text != "")
            {
                SqlCommand comRecherche = new SqlCommand(sqlQuery, cn);
                reader = comRecherche.ExecuteReader();
                dataGridView1 = RemplireGrilleConnecte(dataGridView1, reader);


            }
            reader.Close();
            com = null;
            
        }

        private void rd_nomPrenom_CheckedChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();


            sqlQuery = "Select id_echeance,mois,annee,montant,montant_recu,NomApparetemnt from echeance e inner join Bien b on b.id_bien = e.id_bien join immeuble i on i.id_immeuble = b.id_immeuble where e.archive = 1 and paiment like '%" + WhoChecked + "%' ";


            if (rd_Mois.Checked) WhoChecked = "mois";
            if (rd_nomPrenom.Checked) WhoChecked = "annee";

            string text = txt_search.Text.ToString().Replace("'", "''");
            if (text != "")
            {
                try
                {
                    SqlCommand comRecherche = new SqlCommand(sqlQuery, cn);
                    reader = comRecherche.ExecuteReader();
                    dataGridView1 = RemplireGrilleConnecte(dataGridView1, reader);
                }
                catch {
                    return;
                }
              
                
            }

            //reader.Close();
            com = null;

        }

        private void rd_tous_CheckedChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            WhoChecked = "";
            sqlQuery = "Select id_echeance,mois,annee,montant,montant_recu,NomApparetemnt from echeance e inner join Bien b on b.id_bien = e.id_bien join immeuble i on i.id_immeuble = b.id_immeuble where e.archive = 1 and paiment like '%" + WhoChecked + "%' ";
            
            if (rd_Mois.Checked) WhoChecked = "mois";
            if (rd_nomPrenom.Checked) WhoChecked = "annee";

            string text = txt_search.Text.ToString().Replace("'", "''");
            if (text != "")
            {
                
                SqlCommand comRecherche = new SqlCommand(sqlQuery, cn);
                reader = comRecherche.ExecuteReader();
                dataGridView1 = RemplireGrilleConnecte(dataGridView1, reader);
                
            }
            reader.Close();
            com = null;

        }

        private void txt_search_Leave_1(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Nom de bien");
        }

        private void txt_search_Enter_1(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom de bien"); 
                
        }
        
        private void btn_derniere_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    try
                    {
                        pos = dataGridView1.RowCount - 1;
                        dataGridView1.Rows[pos].Cells[0].Selected = true;

                    }
                    catch {
                        pos = dataGridView1.RowCount - 1;
                        dataGridView1.Rows[pos].Cells[0].Selected = true;
                        return;
                    }
                  
                    break;
                case "btn_premiere":
                    try
                    {
                        pos = 0;
                        dataGridView1.Rows[pos].Cells[0].Selected = true;
                    }
                    catch {
                        pos = 0;
                        dataGridView1.Rows[pos].Cells[0].Selected = true;
                        return;
                    }
                   
                    break;
                case "btn_suivant":
                    
                    try
                    {
                        pos++;
                        dataGridView1.Rows[pos].Cells[0].Selected = true;
                    }
                    catch {
                        pos--;
                        return;
                    }
                    
                    break;
                case "btn_precedent":
                    
                    try
                    {
                        pos--;
                        dataGridView1.Rows[pos].Cells[0].Selected = true;
                    }
                    catch
                    {
                        pos++;
                        return;
                    }
                    break;
            }
            
        }
        int pos = 0;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            pos = dataGridView1.CurrentRow.Index;
        }
    }
}
