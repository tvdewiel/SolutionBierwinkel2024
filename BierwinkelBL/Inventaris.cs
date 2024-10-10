using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierwinkelBL
{
    public class Inventaris
    {
        public Dictionary<string,Drank> Dranken =new ();
        public List<Drank> ZoekDrank(Drankspecificatie drank)
        {
            List<Drank> gevondenDranken=new ();
            foreach(Drank d in Dranken.Values)
            {
                if (d.Drankspecificatie.VoldoetAanSpecificatie(drank))
                    gevondenDranken.Add(d);
            }
            return gevondenDranken;
        }
        public void VoegDrankToe(double prijsPerStuk,string naam,Drankspecificatie specificatie,Setgrootte minimumHoeveelheid)
        {
            Drank drank=new Drank(prijsPerStuk, naam,minimumHoeveelheid,specificatie);
            if (!Dranken.ContainsKey(drank.Naam)) Dranken.Add(drank.Naam,drank);
        }
        public Drank SelecteerDrank(string naam)
        {
            if (Dranken.ContainsKey(naam)) return Dranken[naam];
            return null;
        }
    }
}
