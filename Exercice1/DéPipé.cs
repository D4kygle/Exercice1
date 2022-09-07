using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class DéPipé : Dé
    {
        public DéPipé(int nbFace, string type, int chance, int numeroChanceux) : base(nbFace, type, chance)
        {
        }

        public override string TypeDe()
        {
            return "Type : pipé";
        }

        public override int Resultat(int chance, int face)
        {
            Random random = new Random();
            int nombreR = random.Next(1, 4);
            int nombre = 0;
            if (nombreR == 1)
            {
                nombre = random.Next(1, 4);
            }
            else
            {
                nombre = random.Next(4, 7);
            }

            return nombre;
        }
    }
}
