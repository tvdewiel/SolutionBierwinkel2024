namespace BierwinkelBL
{
    public class Bier
    {
        public Bier(double prijsPerStuk, string naam, Bierspecificatie bierspecificatie, Setgrootte? minimumHoeveelheid)
        {
            if (prijsPerStuk <= 0) throw new Exception("prijs kleiner dan 0");
            PrijsPerStuk = prijsPerStuk;
            if (string.IsNullOrWhiteSpace(naam)) throw new Exception("naam is leeg");
            Naam = naam;           
            MinimumHoeveelheid = minimumHoeveelheid;
            Bierspecificatie=bierspecificatie;
        }
        public Bierspecificatie Bierspecificatie {  get;private set; }
        public double PrijsPerStuk {  get; private set; }
        public string Naam {  get;private set; }
       
        public Setgrootte? MinimumHoeveelheid { get;private set; }
        public override string ToString()
        {
            return $"{Naam},{MinimumHoeveelheid},{Bierspecificatie}";
        }
    }
}
