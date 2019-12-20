using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{

    enum Couleurs
    {
        Blanc,
        Bleu,
        Vert,
        Jaune,
        orange,
        Rouge,
        Marron
    }

    enum Matières
    {
        Carton,
        Plastique,
        Bois,
        Métal
    }
    class Boite
    {
        public static int Compteur { get; private set; }
        public float Hauteur { get; }
        public float Largeur { get; }
        public float Longueur { get; }
        public Couleurs Couleur { get; set; }
        public Matières Matière { get; set; } = Matières.Carton;
        public float Volume { get { return Longueur * Largeur * Hauteur; } }
        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;
        public Boite(float hauteur = 30.0F, float largeur = 30.0F, float longueur = 30.0F)
        {
            Compteur++;
            Hauteur = hauteur;
            Largeur = largeur;
            Longueur = longueur;
        }

        public Boite(float hauteur, float largeur, float longueur, Matières matière) : this(hauteur, largeur, hauteur)
        {
            Matière = matière;
        }

        public void Etiqueter(string destinataire)
        {
            _etiquetteDest = new Etiquette { Couleur = Couleurs.Blanc, Format = Formats.L, Texte = destinataire };
        }

        public void Etiqueter(string destinataire, bool fragile)
        {
            if (fragile)
                _etiquetteFragile = new Etiquette { Couleur = Couleurs.Rouge, Format = Formats.S, Texte = "FRAGILE" };
            else Etiqueter(destinataire);
        }

        public void Etiqueter(Etiquette e1, Etiquette e2)
        {
            _etiquetteDest = e1;
            _etiquetteFragile = e2;
        }

        public static bool Compare(Boite b, Boite b2)
        {
            return (b.Matière == b2.Matière && b.Hauteur == b2.Hauteur && b.Largeur == b2.Largeur && b.Longueur == b2.Longueur);
        }

        public override string ToString()
        {
            return $"Hauteur : {Hauteur}, Longueur : {Longueur}, Largeur : {Largeur}, Couleur : {Couleur}, Matière : {Matière}, Volume : {Volume} \nEtiquette dest : {_etiquetteDest} \nEtiquette fragile : {_etiquetteFragile}";
        }
    }
}
