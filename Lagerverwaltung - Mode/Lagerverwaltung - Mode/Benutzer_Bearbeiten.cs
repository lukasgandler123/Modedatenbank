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
