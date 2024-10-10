using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierwinkelBL
{
    public class Wijn : Drank
    {
        public Wijn(double prijsPerStuk, string naam, Wijnspecificatie wijnspecificatie, Setgrootte? minimumHoeveelheid) : base(prijsPerStuk, naam, minimumHoeveelheid)
        {
            Wijnspecificatie = wijnspecificatie;
        }
        public Wijnspecificatie Wijnspecificatie { get; private set; }

        public override string ToString()
        {
            return $"{Naam},{MinimumHoeveelheid},{Wijnspecificatie}";
        }
    }
}
