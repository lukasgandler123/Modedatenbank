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
    public partial class Artikel_Bearbeiten : Form
    {
        MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");

        public Artikel_Bearbeiten(string kategorie, string marke, string bezeichnung, int artikelnummer)
        {
            InitializeComponent();

            txt_Bezeichnung.Text = bezeichnung;
            txt_Marke.Text = marke;
            cmb_Kategorie.Text = kategorie;
            artikelID = artikelnummer;
        }

        int artikelID;

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            MySqlCommand update = new MySqlCommand("UPDATE t_artikel SET kategorie = '" + cmb_Kategorie.Text.ToLower().ToString() + "', " +
                "marke = '" + txt_Marke.Text.ToString() + "', " +
                "bezeichnung = '" + txt_Bezeichnung.Text.ToString() + "' " +
                "WHERE artikelid = " + artikelID + ";", con);

            try
            {
                con.Open();
                update.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Änderungen erfolgreich übernommen");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Artikel_Bearbeiten_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(artikelID.ToString());

            // Rollen zu Combobox hinzufügen
            MySqlCommand select = new MySqlCommand("SELECT kategorie FROM t_artikel;", con);

            try
            {
                con.Open();
                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    if (!cmb_Kategorie.Items.Contains(reader[0].ToString()))
                    {
                        cmb_Kategorie.Items.Add(reader[0].ToString());
                    }
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
