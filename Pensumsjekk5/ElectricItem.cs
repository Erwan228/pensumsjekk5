namespace Pensumsjekk5
{
    public class ElectricItem : InventoryItem, ISellable
    {

        public string Forsikringsinformasjon { get; private set; }
        public int Spenning { get; private set; }
        public ElectricItem(string forsikringsinformasjon, int spenning, string navn, int antall, int pris) : base(navn, antall, pris)
        {
            Forsikringsinformasjon = forsikringsinformasjon;
            Spenning = spenning;
            Navn = navn;
            Antall = antall;
            Pris = pris;
        }
        public int KalkulerPris()
        {
            return Pris * Antall;
        }

    }
}
