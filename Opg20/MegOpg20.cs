namespace Opg20
{
    internal class MegOpg20
    {


        static double ArealCircle(double radius, double pi)
        {
            return (pi * (radius * radius));
        }

        static int ArealSquare(int sideA, int sideB)
        {
            return sideA * sideB;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Lad os beregne arealet af en firkant med sidelængderne A og B " +
                                    "\b og en cirkel med diameteren X:");

            Console.WriteLine("\nIndtast cirklens diameter: ");
            double diameter = Convert.ToInt32(Console.ReadLine());
            double radius = (diameter / 2.00);
            double pi = double.Pi;

            Console.WriteLine("\nIndtast firkantens længde på siden A i hele tal: ");
            int sideA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIndtast firkantens længde på siden B i hele tal: ");
            int sideB = Convert.ToInt32(Console.ReadLine());

            double arealCircle = ArealCircle(radius, pi);
            int arealSquare = ArealSquare(sideA, sideB);

            Console.WriteLine("\nArealet på din firkant er " + arealSquare + ", og arealet af cirklen er " + arealCircle);
            Console.ReadLine();
        }
    }
}
