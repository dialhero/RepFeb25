using System.Transactions;

namespace opgave_20
{
    internal class Program
    {
        static bool isCircel = false;
        static double side;

        static double area(double side)
        {
            return side * side;
        }
        static double area(double radius, bool isCircle)
        {
            return Math.PI * radius * radius;
        }



        static void Main(string[] args)
        {

            Console.WriteLine("er det en cirkel? (ja/nej");
            string input = Console.ReadLine();

            if (input == "ja")
            {
                isCircel = true;
                Console.WriteLine("indtast radius hvis det er cirkel: ");
                double circleRadius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(area(circleRadius,isCircel));


            }
            else { 
                Console.WriteLine("indtast omkreds af firkant: ");
            side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(area(side));
            }

            Console.ReadLine();
        }
    }
}
