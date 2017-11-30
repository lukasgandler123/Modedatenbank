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
using MySql.Data.MySqlClient;

namespace Lagerverwaltung___Mode
{
    public partial class frm_Anmelden : Form
    {
        public frm_Anmelden()
        {
            InitializeComponent();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            // Connection
            MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");
            HashPasswort hp = new HashPasswort();

            string benutzername = txt_Benutzername.Text.ToString();
            string passwort = txt_Passwort.Text.ToString();
            bool anmeldungErfolgreich = false;
            

            MySqlCommand selectPW = new MySqlCommand("SELECT passwort FROM t_benutzer WHERE benutzername = '" + benutzername + "';", con);
            
            // SQL Befehle ausführen
            try
            {
                con.Open();
                MySqlDataReader reader = selectPW.ExecuteReader();
                while(reader.Read())
                {
                    if (hp.Verify(passwort, reader[0].ToString()))
                    {
                        anmeldungErfolgreich = true;
                    }
                }
                con.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            // Anmeldung erfolgreich
            if(anmeldungErfolgreich)
            {
                MessageBox.Show("Anmeldung erfolgreich!");
                Hide();
                Menu men = new Menu();
                men.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Anmeldung fehlgeschlagen. Prüfen Sie Ihren Benutzernamen und Passwort");
            }
        }

        private void frm_Anmelden_Load(object sender, EventArgs e)
        {
            // Connection testen
            MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");
            try
            {
                con.Open();
                con.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
