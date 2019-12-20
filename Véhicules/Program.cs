using System;
using System.Collections.Generic;

namespace Véhicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Véhicules v = new Voiture("test", Energies.Electrique);
            Véhicules m = new Moto("test", Energies.Essence);
            Véhicules v1 = new Voiture("Mégane", 19000);
            Véhicules v2 = new Moto("Intruder", 13000);
            Véhicules v3 = new Voiture("Enzo", 380000);
            Véhicules v4 = new Moto("Yamaha", 11000);
            var liste1 = new SortedList<string, Véhicules>();
            liste1.Add(v1.Nom, v1);
            liste1.Add(v2.Nom, v2);
            liste1.Add(v3.Nom, v3);
            liste1.Add(v4.Nom, v4);
            //foreach (var item in liste1)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value.Prix}");
            //}
            var liste2 = new SortedList<Véhicules, string>();
            liste2.Add(v1, v1.Nom);
            liste2.Add(v2, v2.Nom);
            liste2.Add(v3, v3.Nom);
            liste2.Add(v4, v4.Nom);
            //foreach (var item in liste2)
            //{
            //    Console.WriteLine($"{item.Key.Nom} : {item.Key.Prix}");
            //}
            string[] tab = new string[] { "Clio", "Mégane", "Golf", "Enzo", "Polo" };

            foreach (var item in tab)
            {
                if (liste1.TryGetValue(item, out Véhicules a))
                    Console.WriteLine($"{a.Nom}:{a.Prix}");
            }
        }
    }
}
