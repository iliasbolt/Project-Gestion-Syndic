using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    static class MyHint 
    {
       

        public static TextBox HintEnter(TextBox txt_search,string name="") {
            
            if (txt_search.Text == "Taper " + name + " pour rechercher")
            {
                txt_search.Text = "";
                
            }
            return txt_search;
        }
        public static TextBox HintLeave(TextBox txt_search, string name = "")
        {
            if (txt_search.Text != "Taper " + name + " pour rechercher" && txt_search.Text != "")
            {

            }
            if (txt_search.Text == "")
            {
                txt_search.Text = "Taper " + name + " pour rechercher";
            }

            return txt_search;

        }
        public static TextBox LoadText(TextBox txt_search, string name = "")
        {
            txt_search.Text = "Taper " + name + " pour rechercher";
            //txt_search.Text = "Taper Nom de Coutisation pour rechercher";
            txt_search.ForeColor = Color.Gray;
            return txt_search;
        }
         
      


    }
}
