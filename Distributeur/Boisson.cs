using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    enum Boissons
    {
        Café,
        Chocolat,
        Soupe
    }
    class Boisson
    {

        public Boissons Nom { get; }
        public double Prix { get; private set; }

        public Boisson(Boissons nom, double prix)
        {
            Nom = nom;
            Prix = prix;
        }

        public void ChangerPrix(double prix)
        {
            Prix = prix;
        }
    }
}
