using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierwinkelBL
{
    public class Bierspecificatie
    {
        public Bierspecificatie(Bierkleur? kleur, string brouwerij, Biervolume? volume, double? alcoholPercentage,string herkomstLand)
        {
            Kleur = kleur;
            Brouwerij = brouwerij;
            Volume = volume;
            if (alcoholPercentage < 0) throw new Exception("percentage <0");
            AlcoholPercentage = alcoholPercentage;
            HerkomstLand = herkomstLand;
        }

        public Bierkleur? Kleur { get; private set; }
        public string Brouwerij { get; private set; }
        public Biervolume? Volume { get; private set; }
        public double? AlcoholPercentage { get; private set; }
        public string HerkomstLand { get ; private set; }
        public override string ToString()
        {
            return $"{Kleur},{Brouwerij},{Volume},{AlcoholPercentage},{HerkomstLand}";
        }
    }
}
