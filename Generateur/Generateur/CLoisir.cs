﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Generateur
{
	public class CLoisir : CAeronef
	{
		public CLoisir()
		{

		}
		public CLoisir(string Nom, int Vitesse, int Entretient, int Capacite):base(Nom, Vitesse,Entretient,Capacite)
		{

		}
		public override string ToString()
		{
			return string.Format(
				"{0} (Loisir), Capacité : {1}, Vitesse : {2}, entretient {3}",
				new object[] { this.Nom, this.Capacite, this.vitesse, this.entretient }
			);
		}
	}
}
