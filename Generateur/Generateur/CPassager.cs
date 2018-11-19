using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
	class CPassager:CTransport
	{
		int nbPassager;

		public CPassager()
		{

		}
		public CPassager(string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement,int nbPassager) : base(Nom, Vitesse, Entretient, Capacite, Embarquement, Debarquement)
		{
			this.nbPassager = nbPassager;
		}
	}
}
