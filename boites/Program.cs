using System;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite b = new Boite(longueur : 35.0F);
            Boite b2 = new Boite(31.0F, longueur: 35.0F);
            b2.Etiqueter("test",true);
            Boite b3 = new Boite(30.0F,40.0F,50.0F,Matières.Plastique);
            b3.Etiqueter(new Etiquette { Couleur = Couleurs.Blanc, Format = Formats.L, Texte = "test" }, new Etiquette { Couleur = Couleurs.Rouge, Format = Formats.S, Texte = "FRAGILE" });
            Console.WriteLine(b3);
        }
    }
}
