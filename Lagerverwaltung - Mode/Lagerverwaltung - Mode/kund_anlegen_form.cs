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
    public partial class kund_anlegen_form : Form
    {

        MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");

        public kund_anlegen_form()
        {
            InitializeComponent();
        }

        private void btn_kund_erfassen_Click(object sender, EventArgs e)
        {
            if (kund_anlegen_kunde.Text.Length > 50)
            {
                MessageBox.Show("Bitte geben Sie nicht mehr als 50 Zeichen ein");
            }
            if (kund_anlegen_land.Text.Length > 50)
            {
                MessageBox.Show("Bitte geben Sie nicht mehr als 50 Zeichen ein");
            }
            if (kund_anlegen_ort.Text.Length > 50)
            {
                MessageBox.Show("Bitte geben Sie nicht mehr als 50 Zeichen ein");
            }
            if (kund_anlegen_anschrift.Text.Length > 50)
            {
                MessageBox.Show("Bitte geben Sie nicht mehr als 50 Zeichen ein");
            }

            MySqlCommand insert = new MySqlCommand("INSERT INTO t_kunden (kunde, land, ort, anschrift, archiviert)" +
                                "VALUES ('" + kund_anlegen_kunde.Text.ToString() + "', '" + kund_anlegen_land.Text.ToString() + "', '" + kund_anlegen_ort.Text.ToString() + "' + '" + kund_anlegen_anschrift.Text.ToString() + "', 0)", con);

            try
            {
                con.Open();
                insert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Artikel wurde erfolgreich angelegt!");

                // Inhalte der Eingabefelder löschen
                kund_anlegen_kunde.Text = "";
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
                        if (!kund_anlegen_kunde.Items.Contains(reader[0].ToString()))
                        {
                            kund_anlegen_kunde.Items.Add(reader[0].ToString());
                        }
                    }
                    con.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    }
}
