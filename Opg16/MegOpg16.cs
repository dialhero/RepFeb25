namespace Opg16
{
    internal class MegOpg16
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("Lad os regne nogle tal sammen - Jeg finder fakultetet af det tal, som du giver mig. :) ");
            Console.WriteLine("\nIndtast dit tal (X): ");
            
            int x = Convert.ToInt32(Console.ReadLine());

            int factorial = CalculateFactorial(x);

            Console.WriteLine($"\nFakulteten af {x} er: {factorial}");
            Console.ReadLine();
        }

        static int CalculateFactorial(int n)
        {
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;

        }

    }
}

