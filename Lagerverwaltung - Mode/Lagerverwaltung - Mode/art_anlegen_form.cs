using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lagerverwaltung___Mode
{
    public partial class art_anlegen_form : Form
    {
        MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");

        public art_anlegen_form()
        {
            InitializeComponent();
        }

        private void art_anlegen_artnr_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand insert = new MySqlCommand("INSERT INTO t_artikel (artikelnummer, kategorie, marke, bezeichnung, groesse)" +
                                "VALUES ('" + art_anlegen_artnr.Text.ToString() + "', " +
                                "'" + art_anlegen_kategorie.Text.ToString() + "', " + art_anlegen_bezeichnung.Text.ToString() + "'," + art_anlegen_marke.Text.ToString() + "',", con);
        }
    }
}
