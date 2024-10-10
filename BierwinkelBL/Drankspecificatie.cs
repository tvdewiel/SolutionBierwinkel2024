using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierwinkelBL
{
    public abstract class Drankspecificatie
    {
        public Drankspecificatie(string brouwerij, Drankvolume? volume, double? alcoholPercentage, string herkomstLand)
        {
            Brouwerij = brouwerij;
            Volume = volume;
            if (alcoholPercentage < 0) throw new Exception("percentage <0");
            AlcoholPercentage = alcoholPercentage;
            HerkomstLand = herkomstLand;
        }

        public string Brouwerij { get; private set; }
        public Drankvolume? Volume { get; private set; }
        public double? AlcoholPercentage { get; private set; }
        public string HerkomstLand { get; private set; }
        public virtual bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            bool ok = true;
            if (spec.Brouwerij != null && spec.Brouwerij.Length > 0 && spec.Brouwerij != Brouwerij) ok = false;
            if (spec.Volume != null && spec.Volume != Volume) ok = false;
            if (spec.AlcoholPercentage != null && spec.AlcoholPercentage != AlcoholPercentage) ok = false;
            if (spec.HerkomstLand != null && spec.HerkomstLand != HerkomstLand) ok = false;
            return ok;
        }
    }
}
