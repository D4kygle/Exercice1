using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class DéOrdinaire : Dé
    {
        public DéOrdinaire(int nbFace, string type, int chance, int numeroChanceux) : base(nbFace, type, chance)
        {
        }

        public override string TypeDe()
        {
            return "Type : Ordinaire";
        }

        public override int Resultat(int chance, int face)
        {
            Random random = new Random();
            int nombre = random.Next(1, face++);

            return nombre;
        }
    }
}
