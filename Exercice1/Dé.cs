using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Dé
    {
        private int nbFace;
        private string type;
        private int chance;

        private int NbFace { get => nbFace; set => nbFace = value; }
        private string Type { get => type; set => type = value; }
        private int Chance { get => chance; set => chance = value; }

        public Dé(int nbFace, string type, int chance)
        {
            this.NbFace = nbFace;
            this.Type = type;
            this.Chance = chance;
        }

        public virtual string TypeDe()
        {
            return "Ceci est un dé";
        }

        public virtual int Resultat(int chance, int face)
        {
            return 0;
        }
    }
}
