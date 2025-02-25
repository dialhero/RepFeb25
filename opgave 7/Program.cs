using Microsoft.VisualBasic;

namespace opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast et tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());

            if (tal > 0)
            {
                Console.WriteLine("dit tal er positivt");
            }
            if (tal < 0)
            {
                Console.WriteLine("dit tal er negativt");
            }
            if (tal == 0)
            {
                Console.WriteLine("dit tal er 0");
            }

            Console.ReadLine();
        }
    }
}
