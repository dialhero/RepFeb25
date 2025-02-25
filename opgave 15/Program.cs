namespace opgave_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("beregner summen af alle tal til og med et givent tal. vælg det givne tal: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"summen af tallene 1 til {n} er: {sum}");

            Console.ReadLine();
        }
    }
}
