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
    }
}
