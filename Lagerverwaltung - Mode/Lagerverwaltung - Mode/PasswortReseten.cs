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
    public partial class PasswortReseten : Form
    {
        private int benutzerID;

        public PasswortReseten()
        {
            InitializeComponent();
        }

        public PasswortReseten(int benutzerID)
        {
            InitializeComponent();

            this.benutzerID = benutzerID;
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            if(txt_Passwort.Text.Equals(txt_PasswortBestaetigen.Text))
            {
                MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");
                HashPasswort hp = new HashPasswort();

                string hash = hp.Hash(txt_Passwort.Text.ToString(), 1000);

                MySqlCommand update = new MySqlCommand("UPDATE t_benutzer SET passwort = '" + hash + "' WHERE nutzerid = '" + benutzerID + "';", con);

                try
                {
                    con.Open();
                    update.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Passwort erfolgreich zurückgesetzt");

                    Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein!");
            }
        }
    }
}
