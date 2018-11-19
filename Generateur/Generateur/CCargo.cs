using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
	class CCargo:CTransport
	{
		private int qteCargo;
		public CCargo()
		{

		}
		public CCargo(string Nom, int Vitesse, int Entretient, int Capacite, int Embarquement, int Debarquement, int qteCargo) : base(Nom, Vitesse, Entretient, Capacite, Embarquement,Debarquement)
		{
			this.qteCargo = qteCargo;
		}
	}
}
