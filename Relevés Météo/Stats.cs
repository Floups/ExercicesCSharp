using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Relevés_Météo
{
    class Stats
    {
        public List<RelevéMensuel> RelevéMensuels { get; }
        public RelevéMensuel ReleveTempMax { get {
                return RelevéMensuels.OrderBy(r => r.TempMax).LastOrDefault();    
            }
        }

        public double EnsoleillementMoyenJuillet { get {
                return RelevéMensuels.Where(r => r.Date.Month == 7).Average(r=>r.Ensol);
            }
        }

        public int NbMoisChauds { get {
                return RelevéMensuels.Where(r => r.TempMax > RelevéMensuels.Average(r => r.TempMax)).Count();
            }
        }

        public IEnumerable<double> PrécipitationsMoyennesParAnnée { get {
                return RelevéMensuels.GroupBy(r=>r.Date.Year).Select(r=>r.Average(r=>r.Précip));
            }
        }
        public Stats(List<RelevéMensuel> relevéMensuels)
        {
            RelevéMensuels = relevéMensuels;
        }

        public double GetPréciptationsAnnée(int year)
        {
            return RelevéMensuels.Where(r=>r.Date.Year==year).Sum(r => r.Précip);
        }
    }
}
