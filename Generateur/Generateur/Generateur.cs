using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
	public class Generateur
	{
        private ficheGenerateur m_fiche;
        //private Scenario m_scenario;

        public Generateur()
        {
            m_fiche = new ficheGenerateur(this);

            Application.Run(m_fiche);
        }

        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            Generateur generateur = new Generateur();
		}

        private void sauvegarderScenario()
        {

        }

        private void chargerScenario()
        {

        }
    }
}
