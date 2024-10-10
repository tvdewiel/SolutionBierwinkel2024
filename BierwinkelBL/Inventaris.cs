using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierwinkelBL
{
    public class Inventaris
    {
        public Dictionary<string,Bier> Biertjes =new ();
        public List<Bier> ZoekBier(Bierspecificatie bier)
        {
            List<Bier> gevondenBiertjes=new List<Bier>();
            foreach(Bier b in Biertjes.Values)
            {
                if (bier.Kleur !=null && bier.Kleur != b.Bierspecificatie.Kleur) continue;
                if (bier.Brouwerij != null && bier.Brouwerij.Length > 0 && bier.Brouwerij != b.Bierspecificatie.Brouwerij) continue;
                if (bier.Volume!=null && bier.Volume != b.Bierspecificatie.Volume) continue;
                if (bier.AlcoholPercentage!=null && bier.AlcoholPercentage!=b.Bierspecificatie.AlcoholPercentage) continue;
                gevondenBiertjes.Add(b);
            }
            return gevondenBiertjes;
        }
        public void VoegBierToe(double prijsPerStuk,string naam,Bierspecificatie specificatie,Setgrootte minimumHoeveelheid)
        {
            Bier bier=new Bier(prijsPerStuk,naam,specificatie,minimumHoeveelheid);
            if (!Biertjes.ContainsKey(bier.Naam)) Biertjes.Add(bier.Naam,bier);
        }
        public Bier SelecteerBier(string naam)
        {
            if (Biertjes.ContainsKey(naam)) return Biertjes[naam];
            return null;
        }
    }
}
