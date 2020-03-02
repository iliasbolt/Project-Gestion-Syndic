using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class Statistique : Form
    {

        SqlCommand com = new SqlCommand();
        SqlDataReader reader;

        SqlCommand com1 = new SqlCommand();
        SqlDataReader reader1;
        public Statistique()
        {
            InitializeComponent();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {
          


            com = new SqlCommand("Select distinct concat(nom,' ',prenom) as nm,montant from cotisation c join proprietaire p on p.id_proprietaire = c.id_proprietaire where p.archive = 1 and c.archive = 1", Fonctions.CnConnection());
            reader = com.ExecuteReader();

            chart1.DataSource = reader;
            chart1.Series["cotisation"].XValueMember = "nm";
            chart1.Series["cotisation"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;


            chart1.Series["cotisation"].YValueMembers = "montant";
            chart1.Series["cotisation"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            reader = null;
            com = null;
            //recette

            com1 = new SqlCommand("Select distinct nomtype as nm,montant from recette r join type_recette t on r.id_type = t.id_type where r.archive = 1 and t.archive = 1", Fonctions.CnConnection());
            reader1 = com1.ExecuteReader();

            chart2.DataSource = reader1;
            chart2.Series["Recette"].XValueMember = "nm";
            chart2.Series["Recette"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            chart2.Series["Recette"].YValueMembers = "montant";
            chart2.Series["Recette"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;




        }
    }
}
