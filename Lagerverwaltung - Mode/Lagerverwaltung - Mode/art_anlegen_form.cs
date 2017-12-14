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

        }

        private void btn_anlegen_Click(object sender, EventArgs e)
        {

            if (art_anlegen_kategorie.Text.Length > 50)
            {
                MessageBox.Show("Bitte geben Sie nicht mehr als 50 Zeichen ein");
            }
            if (art_anlegen_marke.Text.Length > 50)
            {
                MessageBox.Show("Bitte geben Sie nicht mehr als 50 Zeichen ein");
            }
            if (art_anlegen_bezeichnung.Text.Length > 50)
            {
                MessageBox.Show("Bitte geben Sie nicht mehr als 50 Zeichen ein");
            }

            MySqlCommand insert = new MySqlCommand("INSERT INTO t_artikel (artikelnummer, kategorie, marke, bezeichnung, groesse)" +
                                "VALUES ('" + art_anlegen_kategorie.Text.ToString() + "', " + art_anlegen_bezeichnung.Text.ToString() + "'," + art_anlegen_marke.Text.ToString() + "',", con);

            try
            {
                con.Open();
                insert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Artikel wurde erfolgreich angelegt!");

                // Inhalte der Eingabefelder löschen
                art_anlegen_kategorie.Text = "";
                foreach (Control c in Controls)
                {
                    try
                    {
                        TextBox t;
                        t = (TextBox)c;
                        t.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }




                MySqlCommand select = new MySqlCommand("SELECT kategorie FROM t_artikel;", con);

                try
                {
                    con.Open();
                    MySqlDataReader reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!art_anlegen_kategorie.Items.Contains(reader[0].ToString()))
                        {
                            art_anlegen_kategorie.Items.Add(reader[0].ToString());
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
}

 

