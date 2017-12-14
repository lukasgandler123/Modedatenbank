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
            dgv_Benutzer.DataSource = t_benutzerTableAdapter.GetData();

            dgv_Benutzer.Columns[0].ReadOnly = true;
            dgv_Benutzer.Columns[7].Visible = false;
            
            // Passwort zurücksetzen
            DataGridViewButtonColumn button_pw = new DataGridViewButtonColumn();
            button_pw.Text = "Zurücksetzen";
            button_pw.HeaderText = "Passwörter";
            button_pw.UseColumnTextForButtonValue = true;
            dgv_Benutzer.Columns.Insert(8, button_pw);

            // Benutzer löschen
            DataGridViewButtonColumn button_loeschen = new DataGridViewButtonColumn();
            button_loeschen.Text = "Benutzer löschen";
            button_loeschen.HeaderText = "Löschen";
            button_loeschen.UseColumnTextForButtonValue = true;
            dgv_Benutzer.Columns.Insert(6, button_loeschen);
        }
        
        private void dgv_Benutzer_Bearbeiten(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Benutzer.Rows[e.RowIndex];
            DataGridViewColumn column = dgv_Benutzer.Columns[e.ColumnIndex];

            //MessageBox.Show(column.Index.ToString());
            //MessageBox.Show(row.Cells[6].Value.ToString());

            bool benutzernameVerfuegbar = true;

            // Neuen Benutzername prüfen
            if (column.Index == 6)
            {
                MySqlCommand select = new MySqlCommand("SELECT benutzername FROM t_benutzer;", con);

                try
                {
                    con.Open();
                    MySqlDataReader reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        if (row.Cells[6].Value.ToString().Equals(reader[0].ToString()))
                        {
                            benutzernameVerfuegbar = false;
                            break;
                        }
                    }
                    con.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            // Benutzername
            if (benutzernameVerfuegbar)
            {
                // E-Mail
                if (row.Cells[3].Value.ToString().Contains("@"))
                {

                    MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team07; password = T3amO7; database = team07");
                    MySqlCommand update = new MySqlCommand("UPDATE t_benutzer SET vorname = '" + row.Cells[1].Value.ToString() + "', " +
                        "nachname = '" + row.Cells[2].Value.ToString() + "', " +
                        "email = '" + row.Cells[3].Value.ToString() + "', " +
                        "telefon = '" + row.Cells[4].Value.ToString() + "', " +
                        "rolle = '" + row.Cells[5].Value.ToString().ToLower() + "', " +
                        "benutzername = '" + row.Cells[6].Value.ToString() + "' " +
                        "WHERE nutzerid = '" + row.Cells[0].Value + "'", con);

                    try
                    {
                        con.Open();
                        update.ExecuteNonQuery();
                        con.Close();
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
                MessageBox.Show("Benutzername nicht verfügbar!");

                // alten Benutzernamen in die Zelle schreiben
                MySqlCommand select = new MySqlCommand("SELECT benutzername FROM t_benutzer WHERE nutzerid = '" + row.Cells[0].Value + "';", con);
                try
                {
                    con.Open();
                    MySqlDataReader reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        row.Cells[6].Value = reader[0].ToString();
                    }
                    con.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dgv_Benutzer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Passwort zurücksetzen
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Benutzer.Rows[e.RowIndex];
                PasswortReseten pr = new PasswortReseten(Convert.ToInt32(row.Cells[0].Value));
                pr.ShowDialog();
            }

            // Löschen
            if(e.ColumnIndex == 9 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Benutzer.Rows[e.RowIndex];
                //DataGridViewRow row = dgv_Benutzer.Rows[e.RowIndex];
                DialogResult dr = MessageBox.Show("Wollen Sie den Benutzer '" + row.Cells[6].Value.ToString() + "' wirklich löschen", "Achtung", MessageBoxButtons.YesNo);

                if(dr == DialogResult.Yes)
                {
                    MySqlCommand delete = new MySqlCommand("DELETE FROM t_benutzer WHERE nutzerid = '" + row.Cells[0].Value + "'", con);

                    try
                    {
                        con.Open();
                        delete.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Benutzer erfolgreich gelöscht");

                        // Ansicht aktualisieren
                        dgv_Benutzer.DataSource = t_benutzerTableAdapter.GetData();
                    }
                    catch(MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
