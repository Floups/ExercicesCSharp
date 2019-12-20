using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Relevés_Météo
{
    static class DAL
    {
        private const string  CHEMIN = "..\\..\\..\\DonnéesMétéoParis.txt";

        public static List<RelevéMensuel> GetRelevésMensuels()
        {
			var relevéMensuels = new List<RelevéMensuel>();
			var file = File.ReadAllLines(CHEMIN, Encoding.UTF8);
			try
			{
				for (int i = 1; i < file.Length; i++)
				{
					var relevé = new RelevéMensuel(file[i]);
					relevéMensuels.Add(relevé);
				}
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
			}
			return relevéMensuels;
        }
    }
}
