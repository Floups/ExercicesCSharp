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
			var relevéMensuels = new List<RelevéMensuel>();
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Mois    | T° min | T° max | Précip(mm) | Ensol(H)");
			Console.WriteLine("----------------------------------------------------");
			var file = File.ReadAllLines("..\\..\\..\\DonnéesMétéoParis.txt", Encoding.UTF8);
			try
			{
				for (int i = 1; i < file.Length; i++)
				{
					var relevé = new RelevéMensuel(file[i]);
					relevéMensuels.Add(relevé);
					Console.WriteLine(relevé);
				}
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
			}
			
        }
    }
}
