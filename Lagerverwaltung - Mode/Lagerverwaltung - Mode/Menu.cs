using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung___Mode
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void neuenBenutzerAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Benutzer_Hinzufuegen bh = new Benutzer_Hinzufuegen();
            bh.ShowDialog();
        }

        private void tbp_Artikel_Click(object sender, EventArgs e)
        {

        }

        private void ausgansjournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ausgangsjournal aj = new Ausgangsjournal();
            aj.ShowDialog();
        }

        private void eingangsjournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eingangsjournal ej = new Eingangsjournal();
            ej.ShowDialog();
        }

        private void benutzerBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Benutzer_Bearbeiten bb = new Benutzer_Bearbeiten();
            bb.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //art_anlegen_form frm = new artanlegen_form();
            //frm.Show();
        }

        private void benutzerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_art_anlegen_Click(object sender, EventArgs e)
        {
            art_anlegen_form frm = new art_anlegen_form();
            frm.Show();

        }
    }
}
