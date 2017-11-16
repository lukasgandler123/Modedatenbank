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
    public partial class Benutzer_Hinzufuegen : Form
    {
        MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");

        public Benutzer_Hinzufuegen()
        {
            InitializeComponent();
        }

        private void Benutzer_Hinzufuegen_Load(object sender, EventArgs e)
        {
            DropDownAktualisieren();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Anlegen_Click(object sender, EventArgs e)
        {
            // Daten überprüfen
            // Benutzername
            bool benutzernameVerfuegbar = true;
            MySqlCommand select = new MySqlCommand("SELECT benutzername FROM t_benutzer;", con);

            try
            {
                con.Open();
                MySqlDataReader reader = select.ExecuteReader();
                while(reader.Read())
                {
                    if(txt_Benutzername.Text.ToString().Equals(reader[0].ToString()))
                    {
                        benutzernameVerfuegbar = false;
                        break;
                    }
                }
                con.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Werte der Felder
            if (!txt_Benutzername.Text.Equals("") && !txt_Email.Text.Equals("") && !txt_Nachname.Text.Equals("") && !txt_Passwort.Text.Equals("") &&
                !txt_PasswortBestaetigen.Text.Equals("") && !txt_Telefon.Text.Equals("") && !txt_Vorname.Text.Equals("") && !cmb_Rolle.Text.Equals(""))
            {
                if (benutzernameVerfuegbar)
                {
                    // Passwort
                    if (txt_Passwort.Text.ToString().Equals(txt_PasswortBestaetigen.Text.ToString()))
                    {
                        // Email
                        if (txt_Email.Text.ToString().Contains("@"))
                        {
                            HashPasswort hp = new HashPasswort();

                            MySqlCommand insert = new MySqlCommand("INSERT INTO t_benutzer (vorname, nachname, email, telefon, rolle, benutzername, passwort)" +
                                "VALUES ('" + txt_Vorname.Text.ToString() + "', " +
                                "'" + txt_Nachname.Text.ToString() + "', " +
                                "'" + txt_Email.Text.ToString() + "', " +
                                "'" + txt_Telefon.Text.ToString() + "', " +
                                "'" + cmb_Rolle.Text.ToLower().ToString() + "', " +
                                "'" + txt_Benutzername.Text.ToString() + "', " +
                                "'" + hp.Hash(txt_Passwort.Text.ToString(), 1000) + "');", con);

                            try
                            {
                                con.Open();
                                insert.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Benutzer erfolgreich angelegt!");

                                // Inhalte der Eingabefelder löschen
                                cmb_Rolle.Text = "";
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
                                        //MessageBox.Show(ex.ToString());
                                    }
                                }

                                DropDownAktualisieren();
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bitte geben Sie eine gültige E-Mailadresse ein!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Die Passwörter stimmt nicht überein!");
                    }
                }
                else
                {
                    MessageBox.Show("Benutzername bereits vergeben!");
                } 
            }
            else
            {
                MessageBox.Show("In allen Feldern müssen Werte eingegeben werden!");
            }
        }

        private void DropDownAktualisieren()
        {
            // Rollen zu Combobox hinzufügen
            MySqlCommand select = new MySqlCommand("SELECT rolle FROM t_benutzer;", con);

            try
            {
                con.Open();
                MySqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    if (!cmb_Rolle.Items.Contains(reader[0].ToString()))
                    {
                        cmb_Rolle.Items.Add(reader[0].ToString());
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
