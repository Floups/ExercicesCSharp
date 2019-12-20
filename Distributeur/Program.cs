using System;
using System.Collections.Generic;

namespace Distributeur
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Boisson> boissons = new List<Boisson>();
            boissons.Add(new Boisson(Boissons.Café, 0.80));
            boissons.Add(new Boisson(Boissons.Chocolat, 0.75));
            boissons.Add(new Boisson(Boissons.Soupe, 1.00));
            Distributeur distributeur = new Distributeur(boissons);
            Console.WriteLine(distributeur.ServirBoisson(Boissons.Soupe, 5, 2));
            Console.WriteLine(distributeur.ServirBoisson(Boissons.Café, 12, 1));
            try
            {
                distributeur.ServirBoisson(Boissons.Chocolat, 0.20);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}