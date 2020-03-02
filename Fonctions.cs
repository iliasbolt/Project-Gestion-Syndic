using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Drawing;

namespace Syndic
{
    static class Fonctions
    {
        static SqlConnection cn = new SqlConnection();
        public static DataSet ds = new DataSet();
        static public void ouvrireConnection()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
        }

        static public SqlConnection CnConnection()
        {
            SqlConnection cn = new SqlConnection();
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }

            return cn;
        }

        static private void remplirTable(string t)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            if (ds.Tables.Contains(t))
                ds.Tables[t].Clear();

            da.Fill(ds, t);
        }

        static private void remplirTable(string t, string tpk, string pk, string fk)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            if (ds.Tables.Contains(t))
                ds.Tables[t].Clear();

            da.Fill(ds, t);

            da = new SqlDataAdapter("select * from " + tpk, cn);
            if (ds.Tables.Contains(tpk))
                ds.Tables[tpk].Clear();
        
            da.Fill(ds, tpk);

            DataColumn c1 = ds.Tables[tpk].Columns[fk];
            DataColumn c2 = ds.Tables[t].Columns[pk];

            DataRelation r = new DataRelation("fk_" + t + "_" + tpk, c1, c2);
            ds.Relations.Add(r);
        }

        static private void remplirTable(string sql, string t, string tpk, string pk, string fk)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            if (ds.Tables.Contains(t))
                ds.Tables[t].Clear();

            da.Fill(ds, t);

            da = new SqlDataAdapter("select * from " + tpk, cn);
            if (ds.Tables.Contains(tpk))
                ds.Tables[tpk].Clear();

            da.Fill(ds, tpk);

            DataColumn c1 = ds.Tables[tpk].Columns[fk];
            DataColumn c2 = ds.Tables[t].Columns[pk];

            DataRelation r = new DataRelation("fk_" + t + "_" + tpk, c1, c2);
            ds.Relations.Add(r);
        }

        static private void remplirTableClear(string sql, string t)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, t);
        }

        static private void remplirTable(string sql, string t)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            if (ds.Tables.Contains(t))
                ds.Tables[t].Clear();

            da.Fill(ds, t);
        }
        static public void textHintEntre(TextBox t,string s)
        {
            if ((t.Text != "") && (t.Text == s))
            {
                t.Clear();
                t.ForeColor = Color.Black;
            }
        }

        static public void textHintLeave(TextBox t, string s)
        {
            if (t.Text == "")
            {
                t.Text = s;
                t.ForeColor = Color.Gray;
            }
        }

        static public void syncr(string t,SqlConnection cn,DataSet ds)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[t]);
            da = null;
            cb = null;
        }

        static public BindingSource remplirGrille(DataGridView d, string t)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            bs.DataSource = ds;
            bs.DataMember = t;

            d.DataSource = bs;
            return bs;
        }
        static public BindingSource remplirGrille(DataGridView d, string sql, string t)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql, t);

            bs.DataSource = ds;
            bs.DataMember = t;

            d.DataSource = bs;
            return bs;
        }

        static public BindingSource remplirList(ListControl l, string t, string dm, string vm)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            bs.DataSource = ds;
            bs.DataMember = t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;

            return bs;
        }

        static public BindingSource remplirList(ListControl l, string sql, string t, string dm, string vm)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql,t);

            bs.DataSource = ds;
            bs.DataMember = t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;

            return bs;
        }

        static public BindingSource remplirListRel(ListControl l, string t, string dm, string vm,string tpk,string pk,string fk,BindingSource bsk)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t,tpk,pk,fk);

            bs.DataSource = bsk;
            bs.DataMember = "fk_" + t + "_" + tpk;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;

            return bs;
        }

        static public BindingSource remplirListRel(ListControl l, string sql,string t, string dm, string vm, string tpk, string pk, string fk, BindingSource bsk)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql, t, tpk, pk, fk);

            bs.DataSource = bsk;
            bs.DataMember = "fk_" + t + "_" + tpk;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;

            return bs;
        }
        static public void refreshTable(string sql, string t)
        {
            ds.Tables[t].Clear();
            remplirTableClear(sql, t);
        }

        static public void OuvrirDocument(string chemin)
        {
            System.Diagnostics.Process.Start(chemin);
        }
        static public void Sunchronizer(string table)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommandBuilder com = new SqlCommandBuilder(da);
            da.Update(ds.Tables[table]);

        }
        static public string GiveMeSalt(string _nom,string _prenom)
        {
            string Result = "";

            List<string> listNom = new List<string>();
            List<string> listPrenom = new List<string>();

            int lenght = 0;
            int max_nom = 0;
            int max_Prenom = 0;

            if (_nom.Length < _prenom.Length)
                lenght = _nom.Length;
            else { lenght = _prenom.Length;
            }

            if (_nom != "" && _prenom != "" && _nom.Length > 2 && _prenom.Length > 2)
            {
                max_nom = _nom.Length;
                max_Prenom = _prenom.Length;
                //algo homie
                for (int i = 0; i < lenght; i++)
                {
                    listNom.Add(_nom[i].ToString());
                    listPrenom.Add(_prenom[i].ToString());
                }

                //string RandomName = "";
                //string RandomPrenom = "" ;
                int randomNumberNom = 0;
                int randomNumberPrenom = 0;
                int randomNumbers = 0;
                Random rNb = new Random();
                Random r2 = new Random();
                Random r = new Random();
                //1 time dude
                for (int i = 0; i < 2; i++)
                {
                    randomNumberNom = r.Next(i, max_nom);
                    
                    randomNumberPrenom = r2.Next(i, max_Prenom);
                    Result += listNom[randomNumberNom].ToString();
                    Result += listPrenom[randomNumberPrenom].ToString();
                    randomNumbers = rNb.Next(10, 99);
                    Result += "" + randomNumbers;
                    randomNumberNom = 0;
                    randomNumberPrenom = 0;
                    randomNumbers = 0;
                }
              
            }
            else {
                MessageBox.Show("Nom Ou Prenom Not Siaise Est Le minimum est 3 charactere en nom et prenom");

            }


            return Result;
        }

    }
}
