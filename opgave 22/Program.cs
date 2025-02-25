namespace opgave_22
{
    internal class Program
    {
        static bool isTrue = false;
        static double areal(double længde, double bredde)
        {
            return længde * bredde;
        }
        static double areal(double grundlinje, double højde, bool isTrue) {
            return 0.5 * grundlinje * højde;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("trekant (ja/nej): ");
            string input = Console.ReadLine().ToLower();

            if (input == "ja")
            {
                isTrue = true;
                Console.WriteLine("hvad er højden på din cylinder: ");
                double bredde = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("hvad er radius:");
                double længde = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(areal(længde, bredde));


            }
            else
            {
                Console.WriteLine("hvad er højden på din trekant: ");
                double højde = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("hvad er længden på grundlinjen: ");
                double grundlinje = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine(areal(grundlinje,højde));

            }
            Console.ReadLine();
        }
    }
}
