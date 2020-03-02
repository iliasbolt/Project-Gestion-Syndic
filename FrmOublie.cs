using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class FrmOublie : Form
    {
        public FrmOublie()
        {
            InitializeComponent();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if ((txt_username.Text != "") && (txt_username.Text == "Tapez Votre Email"))
            {
                txt_username.Clear();
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Tapez Votre Email";
                txt_username.ForeColor = Color.Gray;
            }
        }

        private void btn_envoye_Click(object sender, EventArgs e)
        {
            string email = txt_username.Text;
            int at = email.IndexOf('@');
            int p = email.LastIndexOf('.');

            if (at != -1 && p != -1)
            {
                if (p > at)
                    MessageBox.Show("Nous vous envoyer a message a votre bote email", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbl_connecter_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
            this.Close();
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
    }
}
