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
    public partial class Benutzer_Hinzufuegen : Form
    {
        public Benutzer_Hinzufuegen()
        {
            InitializeComponent();
        }

        private void Benutzer_Hinzufuegen_Load(object sender, EventArgs e)
        {
            // Rollen zu Combobox hinzufügen
            List<string> list = new List<string>();
            
            cmb_Rolle.Items.Add("hi");
        }
    }
}
