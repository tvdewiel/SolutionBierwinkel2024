namespace BierwinkelBL
{
    public class Bier : Drank
    {
        public Bier(double prijsPerStuk, string naam, Bierspecificatie bierspecificatie, Setgrootte? minimumHoeveelheid) : base(prijsPerStuk,naam,minimumHoeveelheid)
        {         
            Bierspecificatie=bierspecificatie;
        }
        public Bierspecificatie Bierspecificatie {  get;private set; }
       
        public override string ToString()
        {
            return $"{Naam},{MinimumHoeveelheid},{Bierspecificatie}";
        }
    }
}
