using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Relevés_Météo
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Mois    | T° min | T° max | Précip(mm) | Ensol(H)");
			Console.WriteLine("----------------------------------------------------");
            var a = new Stats(DAL.GetRelevésMensuels());
            Console.WriteLine(a.ReleveTempMax);
            Console.WriteLine(a.GetPréciptationsAnnée(2008));
            Console.WriteLine(a.EnsoleillementMoyenJuillet);
            Console.WriteLine(a.NbMoisChauds);
            foreach (var item in a.PrécipitationsMoyennesParAnnée)
            {
                Console.WriteLine(item);
            }
        }
    }
}
