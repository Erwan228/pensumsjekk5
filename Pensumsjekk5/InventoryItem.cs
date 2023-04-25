namespace Pensumsjekk5
{
    public class InventoryItem : ISellable
    {
        public string Navn { get; set; }
        public int Antall { get; set; }
        public int Pris { get; set; }
        public InventoryItem(string navn, int antall, int pris)
        {
            Navn = navn;
            Antall = antall;
            Pris = pris;
        }
    }
}
