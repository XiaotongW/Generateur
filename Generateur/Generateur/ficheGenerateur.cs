using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
    public partial class ficheGenerateur : Form
    {
        private Generateur m_generateur;
        private ficheCarte m_carte;

        public ficheGenerateur(Generateur generateur)
        {
            InitializeComponent();
            m_generateur = generateur;
        }

        private void afficherListeAeronef()
        {

        }

        private void afficherListeAeroport()
        {

        }

        private void etqEmbarquementAeronef_Click(object sender, EventArgs e)
        {

        }
    }
}
