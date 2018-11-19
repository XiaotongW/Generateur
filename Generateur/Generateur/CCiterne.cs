using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Generateur
{
	class CCiterne : CAeronef
	{
		public CCiterne()
		{

		}
		public CCiterne(string Nom, int Vitesse, int Entretient, int Capacite) : base(Nom, Vitesse, Entretient, Capacite)
		{

		}
	}
}
