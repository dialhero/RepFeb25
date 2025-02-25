namespace opgave_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv et årstal: ");
            int årstal = Convert.ToInt32(Console.ReadLine());

            bool skudår = årstal % 4 == 0;
            double skudårtal = årstal % 4;

            Console.WriteLine($"årstal er {skudår} skudår");

            Console.ReadLine();

        }
    }
}
