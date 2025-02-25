namespace opgave_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" beregner fakultet af et tal. skriv et tal: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 1;

            for (int i = 1; i <= n; i++)
            {

                sum *= i;


            }
            Console.WriteLine($"the factorial is: {sum}");

            Console.ReadLine();
        }
    }
}
