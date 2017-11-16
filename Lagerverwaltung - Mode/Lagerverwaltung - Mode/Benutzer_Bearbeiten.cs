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
    public partial class Benutzer_Bearbeiten : Form
    {
        MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");

        public Benutzer_Bearbeiten()
        {
            InitializeComponent();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Benutzer_Bearbeiten_Load(object sender, EventArgs e)
        {
            MySqlCommand select = new MySqlCommand("SELECT * FROM t_benutzer;", con);

            // Liste mit allen Benutzern
            List<Benutzer> benutzerListe = new List<Benutzer>();

            try
            {
                con.Open();
                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    //reihen++;
                    // Liste befüllen
                    Benutzer bn = new Benutzer(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                    benutzerListe.Add(bn);
                }
                con.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //MessageBox.Show("reihen: " + reihen.ToString());
            //MessageBox.Show(benutzerListe.Count.ToString());

            tlp_Benutzer.RowCount = benutzerListe.Count;
            TabelleBefuellen(benutzerListe, benutzerListe.Count);
        }

        private void TabelleBefuellen(List<Benutzer> liste, int reihen)
        {
            tlp_Benutzer.Controls.Add(new Label() { Text = "Hi1" }, 0, 0);
            tlp_Benutzer.Controls.Add(new Label() { Text = "Hi2" }, 0, 1);
            tlp_Benutzer.Controls.Add(new Label() { Text = "Hi3" }, 0, 2);
        }
    }

    // Benutzer, die gespeichert werden
    public class Benutzer
    {
        public string vorname { get; set; }
        public string nachname { get; set; }
        public string email { get; set; }
        public string rolle { get; set; }
        public string benutzername { get; set; }

        public Benutzer(string vorname, string nachname, string email, string rolle, string benutzername)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.email = email;
            this.rolle = rolle;
            this.benutzername = benutzername;
        }
    }
}
