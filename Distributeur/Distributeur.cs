using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    class Distributeur
    {
        public List<Boisson> BoissonsDispo { get; }

        public Distributeur(List<Boisson> boissonsDispo)
        {
            BoissonsDispo = boissonsDispo;
        }

        public string ServirBoisson(Boissons boisson, int sucre, double solde)
        {
            double prix = 0;

            foreach (var item in BoissonsDispo)
                if (item.Nom == boisson)
                {
                    prix = item.Prix;
                    break;
                }
            if (solde < prix)
                throw new ArgumentOutOfRangeException("pas assez de sous");
            solde -= prix;
            if (sucre > 10)
                sucre = 10;
            if (boisson == Boissons.Soupe)
                return "Voici votre soupe";
            return $"Voici votre {boisson} avec {sucre}g";
        }

        public void ServirBoisson(Boissons boisson, double solde)
        {
            ServirBoisson(boisson, 3, solde);
        }
    }
}
