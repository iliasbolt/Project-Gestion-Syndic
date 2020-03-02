using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class frm_cotisationDocument_info : Form
    {
        string s;
        int id = 0;
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bsFct;

        public frm_cotisationDocument_info(string _s,int _id=0)
        {
            InitializeComponent();
            s = _s;
            id = _id;

            lbl_titre.Text = s;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

       

        private void frm_cotisationDocument_info_Load(object sender, EventArgs e)
        {
            string sql2 = "Select distinct Concat(nom,' ',prenom) as nm,c.id_cotisation as id from document_cotisation d join cotisation c on c.id_cotisation = d.id_cotisation join proprietaire p on p.id_proprietaire = c.id_proprietaire where c.archive = 1";


            
            bsFct = Fonctions.remplirList(cb_fct, sql2,"Cotisation", "nm", "id");
            if (lbl_titre.Text == "Modifier")
            {
                cmd = new SqlCommand("select * from document_cotisation where id_document = " + id,Fonctions.CnConnection());
                dr = cmd.ExecuteReader();

                dr.Read();
                txt_nom.Text = dr["nomDocument"].ToString();
                lbl_chemin.Text = dr["fichier"].ToString();

                lbl_titre.Text = "Modifier Document";

                cb_fct.SelectedValue = id;

                pnl_ajouter.Visible = false;
                pnl_modifier.Visible = true;
            }
            else
            {
                pnl_modifier.Visible = false;
                pnl_ajouter.Visible = true;
                lbl_titre.Text = "Ajouter";
            }

        }

        private void btn_annuler_ajt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string ch, name;

        private void btn_vider_Click(object sender, EventArgs e)
        {
            txt_nom.Clear();
            lbl_chemin.Text = "";
            txt_nom.Focus();
        }

        private void btn_valider_ajt_Click(object sender, EventArgs e)
        {
            if (lbl_titre.Text == "Ajouter")
            {
                if (txt_nom.Text != "" && lbl_chemin.Text != "" && cb_fct.SelectedIndex != -1)
                {
                    cmd = new SqlCommand("insert into document_cotisation values ('" + txt_nom.Text + "','" + lbl_chemin.Text + "'," + cb_fct.SelectedValue + ",1)",Fonctions.CnConnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Document Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.Copy(ch, Application.StartupPath + @"\DocumentCotisation\" + name);
                    
                }
                else
                    MessageBox.Show("Remplir Tous Les Champ S'il Vous Plait.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                if (txt_nom.Text != "" && lbl_chemin.Text != "" && cb_fct.SelectedIndex != -1)
                {
                    cmd = new SqlCommand("update document_cotisation set nomDocument = '" + txt_nom.Text + "' , ficher = '" + lbl_chemin.Text + "' where id_document = " + id,Fonctions.CnConnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Document Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Remplir Tous Les Champ S'il Vous Plait.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void btn_ficher_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ch = ofd.FileName;
                name = DateTime.Now.ToString().Replace(":", "").Replace("/", "").Replace(" ", "");
                name += Path.GetExtension(ch);
                lbl_chemin.Text = (Application.StartupPath + @"\DocumentCotisation\" + name);
            }
        }
    }
}
