using System;

namespace Demo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire n = new CompteBancaire(14654644646);
            Console.WriteLine(n.Numero);
        }
    }
}
