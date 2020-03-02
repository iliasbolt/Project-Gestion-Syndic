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
using System.Security.Cryptography;

namespace Syndic
{
    public partial class FrmLogin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        string afterpass, salt;
        int id_utilisateur;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Name)
            {
                case "txt_username":
                    if ((txt_username.Text != "") && (txt_username.Text == "Nom Utilisateur Ou Email"))
                    {
                        txt_username.Clear();
                        txt_username.ForeColor = Color.Black;
                    }
                    break;
                case "txt_password":
                    if ((txt_password.Text != "") && (txt_password.Text == "Mot De Passe"))
                    {
                        txt_password.Clear();
                        txt_password.ForeColor = Color.Black;
                        txt_password.UseSystemPasswordChar = true;
                    }
                    break;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Name)
            {
                case "txt_username":
                    if (txt_username.Text == "")
                    {
                        txt_username.Text = "Nom Utilisateur Ou Email";
                        txt_username.ForeColor = Color.Gray;
                    }
                    break;
                case "txt_password":
                    if (txt_password.Text == "")
                    {
                        txt_password.Text = "Mot De Passe";
                        txt_password.UseSystemPasswordChar = false;
                        txt_password.ForeColor = Color.Gray;
                    }
                    break;
            }
        }

        private void btn_connecte_Click(object sender, EventArgs e)
        {
            if(cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            cmd = new SqlCommand("select id_utilisateur,salt,password from utilisateur where login = '" + txt_username.Text + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id_utilisateur = Convert.ToInt32(dr["id_utilisateur"]);
                byte[] data = Convert.FromBase64String(dr["password"].ToString());
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(dr["salt"].ToString()));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] resulta = transform.TransformFinalBlock(data, 0, data.Length);
                        afterpass = UTF8Encoding.UTF8.GetString(resulta);
                    }
                }
            }
            
            dr.Close();
            dr = null;

            if (afterpass == txt_password.Text)
            {
                cmd = new SqlCommand("insert into connexion values ('" + DateTime.Now + "'," + id_utilisateur + "," + 1 + ")", cn);
                cmd.ExecuteNonQuery();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Nom Utilisateur Ou Mot De Passe Est Incorrect.", "Connexion Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cn.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btn_close":
                    Application.Exit();
                    break;
                case "btn_minimaze":
                    WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmOublie f = new FrmOublie();
            f.Show();
            this.Hide();
        }
    }
}
