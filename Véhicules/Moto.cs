using System;
using System.Collections.Generic;
using System.Text;

namespace Véhicules
{
    class Moto : Véhicules
    {
        //public override string Description => "Je suis une moto \r\n" + base.Description;

        public override string Description
        {
            get
            {
                return "Je suis une moto \r\n" + base.Description;
            }
        }
        public Moto(string nom, Energies energies) : base(nom, 2, energies)
        {
        }

        public Moto(string nom, double prix) : base(nom, prix) { }
    }
}
