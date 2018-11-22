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

        private void ajouterAeroport()
        {
            string nomAeroport;
            string villeAeroport;
            int posX;
            int posY;
            int minPassager;
            int maxPassager;
            int minCargo;
            int maxCargo;

            if (txtNomAeroport.Text != "")
            {
                nomAeroport = txtNomAeroport.Text;
            }
            else
            {
                MessageBox.Show("Entrer un nom pour l'aéroport");
                nomAeroport = "";
            }

            if (txtVilleAeroport.Text != "")
            {
                villeAeroport = txtVilleAeroport.Text;
            }
            else
            {
                MessageBox.Show("Entrer une ville pour l'aéroport");
                villeAeroport = "";
            }

            minPassager = selMinPassager.Value;
            minCargo = selMinCargo.Value;

            if (selMaxPassager.Value > minPassager)
            {
                maxPassager = selMaxPassager.Value;
            }
            else
            {
                MessageBox.Show("Passager: Le maximum doit être plus grand que le minimum ");
                maxPassager = -1;
            }

            if (selMaxCargo.Value > minCargo)
            {
                maxCargo = selMaxCargo.Value;
            }
            else
            {
                MessageBox.Show("Cargo: Le maximum doit être plus grand que le minimum ");
                maxCargo = -1;
            }

            if (nomAeroport != "" && villeAeroport != "" && maxPassager != -1 && maxCargo != -1)
            {
                //m_generateur.ajouterAeroport(nomAeroport, villeAeroport, posX, posY, minPassager, maxPassager, minCargo, maxCargo);
            }

        }

        private void etqEmbarquementAeronef_Click(object sender, EventArgs e)
        {

        }

        private void cmdPositionAeroport_Click(object sender, EventArgs e)
        {
            m_carte = new ficheCarte();

            m_carte.ShowDialog();
        }

        private void cmdAjouterAeroport_Click(object sender, EventArgs e)
        {
            ajouterAeroport();
        }
    }
}

    
    

