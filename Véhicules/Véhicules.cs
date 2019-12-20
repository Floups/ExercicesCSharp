using System;
using System.Collections.Generic;
using System.Text;

namespace Véhicules
{
    enum Energies
    {
        Aucune,
        Essence,
        Gazole,
        GPL,
        Electrique
    }
    class Véhicules:IComparable<Véhicules>
    {
        public string Nom { get; }
        public int NbRoues { get; }
        public Energies Energies { get; }
        public double Prix { get; set; }
        public virtual string Description { get { return $"Véhicule {Nom} roule sur {NbRoues} roues et à l’énergie {Energies} "; } }
        public Véhicules(string nom, int nbRoues, Energies energies)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energies = energies;
        }

        public Véhicules(string nom,double prix)
        {
            Nom = nom;
            Prix = prix;
        }

        public int CompareTo(Véhicules obj)
        {
            return Prix.CompareTo(obj.Prix);
        }
    }
}
