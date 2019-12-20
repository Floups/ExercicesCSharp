using System;
using System.Collections.Generic;
using System.Text;

namespace Relevés_Météo
{
    class RelevéMensuel
    {
        public DateTime Date { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public double Précip { get; set; }
        public double Ensol { get; set; }

        public RelevéMensuel(string texte)
        {
            var données=texte.Split('\t');
            Date = DateTime.Parse(données[0]);
            TempMin = Double.Parse(données[1]);
            TempMax = Double.Parse(données[2]);
            Précip = Double.Parse(données[3]);
            Ensol = Double.Parse(données[4]);
        }

        public override string ToString()
        {
            return string.Format("{0,8:MM/yyyy}|{1,8}|{2,8}|{3,12}|{4,11}", Date, TempMin, TempMax,Précip,Ensol) ;
        }
    }
}
