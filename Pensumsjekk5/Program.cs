namespace Pensumsjekk5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var blågenser = new ClothingItem("Large", "Blå", "Hettegenser", 3, 56);
            var elektriskTannbørste = new ElectricItem("1 år", 12, "Elektrisk tannbørste", 3, 200);
            List<ISellable> sellables = new List<ISellable>();
            sellables.Add(elektriskTannbørste);
            sellables.Add(blågenser);
            sellables[0].KalkulerPris();
            int salgsprisGenser = blågenser.KalkulerPris();
            Console.WriteLine($"The sale price of the hoodies is: {salgsprisGenser}");
            int salgsprisTannbørste = elektriskTannbørste.KalkulerPris();
            Console.WriteLine($"The sale price of the toothbrushes is: {salgsprisTannbørste}");
        }
    }
}