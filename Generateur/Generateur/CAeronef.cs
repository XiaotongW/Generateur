using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Generateur
{
	public abstract class CAeronef
	{
		protected string Nom;
		protected int Vitesse;
		protected int Entretient;
		protected int Capacite;

		public CAeronef()
		{

		}
		public CAeronef(string Nom, int Vitesse, int Entretient, int Capacite)
		{
			this.Nom = Nom;
			this.Vitesse = Vitesse;
			this.Entretient = Entretient;
			this.Capacite = Capacite;
		}
	}
}
