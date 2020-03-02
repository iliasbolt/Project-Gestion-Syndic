using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class Cotisation_type : Form
    {
        public Cotisation_type()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private SqlCommand com;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void btn_Recette_valider_Click(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand("Insert into type_cotisation values ('" + textBox1.Text + "',1)", Fonctions.CnConnection());
                int a = -1;
                a = com.ExecuteNonQuery();
                if (a != -1)
                {
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("not Added !!");
                }
            }
            catch
            {
                MessageBox.Show("Name Not valid");
                return;
            }
        }
    }
}
