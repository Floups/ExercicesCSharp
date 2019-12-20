using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{
    enum Formats
    {
        XS,
        S,
        M,
        L,
        XL
    }
    class Etiquette
    {
        public string Texte { get; set; }
        public Couleurs Couleur { get; set; }
        public Formats Format { get; set; }

        public override string ToString()
        {
            return $"Format : {Format}, Couleur : {Couleur}, Texte : {Texte}";
        }
    }
}
