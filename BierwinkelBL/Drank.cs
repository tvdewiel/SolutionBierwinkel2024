using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierwinkelBL
{
    public class Drank
    {
        public Drank(double prijsPerStuk, string naam, Setgrootte? minimumHoeveelheid,Drankspecificatie drankspecificatie)
        {
            if (prijsPerStuk <= 0) throw new Exception("prijs kleiner dan 0");
            PrijsPerStuk = prijsPerStuk;
            if (string.IsNullOrWhiteSpace(naam)) throw new Exception("naam is leeg");
            Naam = naam;
            MinimumHoeveelheid = minimumHoeveelheid;
            Drankspecificatie = drankspecificatie;
        }

        public double PrijsPerStuk { get;private set; }
        public string Naam { get;private set; }
        public Setgrootte? MinimumHoeveelheid { get; private set; }
        public Drankspecificatie Drankspecificatie { get; private set; }
    }
}
