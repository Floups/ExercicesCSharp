using System;
using System.Collections.Generic;
using System.Text;

namespace Véhicules
{
    class Voiture : Véhicules
    {
        public override string Description => $"Je suis une voiture \r\n" + base.Description;
        public Voiture(string nom, Energies energies) : base(nom, 4, energies)
        {
        }

        public Voiture(string nom, double prix) : base(nom, prix)
        {

        }

    }
}
