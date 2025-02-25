namespace Opg4
{
    internal class MegOpg4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Megans lommeregner");
            Console.WriteLine("\nGiv mig to tal, og se mig lave mate-magic! B-)");

            Console.WriteLine("\nDit første tal: ");
            int talA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDit andet tal: ");
            int talB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAbra Cadabra!");
            Console.WriteLine("\nSum: " + (talA + talB));
            Console.WriteLine("Difference: " + (talA - talB));
            Console.WriteLine("Produkt: " + (talA * talB));
            Console.WriteLine("Kvotienten: " + (talA / talB));
            Console.WriteLine("Modulus: " + (talA % talB));

            Console.ReadLine();
        }
    }
}
