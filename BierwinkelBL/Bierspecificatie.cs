using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierwinkelBL
{
    public class Bierspecificatie : Drankspecificatie
    {
        public Bierspecificatie(Bierkleur? kleur, string brouwerij, Drankvolume? volume, double? alcoholPercentage,string herkomstLand) : base(brouwerij,volume,alcoholPercentage,herkomstLand)
        {
            Kleur = kleur;           
        }

        public Bierkleur? Kleur { get; private set; }
       
        public override string ToString()
        {
            return $"{Kleur},{Brouwerij},{Volume},{AlcoholPercentage},{HerkomstLand}";
        }
        public override bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            if (!base.VoldoetAanSpecificatie(spec)) return false;
            if (spec.GetType()!=typeof(Bierspecificatie)) return false;
            if (((Bierspecificatie)spec).Kleur != null && ((Bierspecificatie)spec).Kleur != Kleur) return false;
            
            return true;
        }
    }
}
