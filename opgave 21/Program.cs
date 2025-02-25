using System.Diagnostics;

namespace opgave_21
{
    internal class Program
    {

        static double volume(double radius, double højde)
        {
            return Math.PI * radius * radius * højde;
        }
        static double volume(double længde, double bredde, double højde)
        {
            return længde * bredde * højde;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("er det en cube? svar (ja/nej): ");
            string input = Console.ReadLine();

            if (input == "ja")
            {
                Console.WriteLine("hvad er højden på din cylinder: ");
                double højde = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("hvad er radius:");
                double radius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(volume(radius, højde));


            }
            else
            {
                Console.WriteLine("hvad er højden på din kube: ");
                double højde = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("hvad er bredden på din kube: ");
                double bredde = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("hvad er længden på din kube: ");
                double længde = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(volume(længde, højde, bredde));

            }
            Console.ReadLine();
        }
    }
}
