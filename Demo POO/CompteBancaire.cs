using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_POO
{
    class CompteBancaire
    {
        public long Numero { get; }
        private string _nom;
        public CompteBancaire(long numero, string nom)
        {
            Numero = numero;
            this._nom = nom;
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        
    }
}
