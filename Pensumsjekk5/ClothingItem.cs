namespace Pensumsjekk5
{
    public class ClothingItem : InventoryItem
    {
        public string Størrelse { get; private set; }
        public string Farge { get; private set; }
        public ClothingItem(string størrelse, string farge, string navn, int antall, int pris) : base(navn, antall, pris)
        {
            Størrelse = størrelse;
            Farge = farge;
            Navn = navn;
            Antall = antall;
            Pris = pris;
        }
    }
}
