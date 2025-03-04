namespace Opg22
{
    internal class Opg22
    {

        static double ArealTriangle(int xHeight, int yBase)
        {
            return ((1/2)*xHeight*yBase);
        }

        static int ArealSquare(int sideA, int sideB)
        {
            return sideA * sideB;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Lad os beregne arealet af en firkant med sidelængderne A og B " +
                                    "\b og en trekant med højden X og grundlinjen Y:");

            Console.WriteLine("\nIndtast trekantens højde i hele tal: ");
            int xHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIndtast trekantens grundlinje i hele tal: ");
            int yBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIndtast firkantens længde på siden A i hele tal: ");
            int sideA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIndtast firkantens længde på siden B i hele tal: ");
            int sideB = Convert.ToInt32(Console.ReadLine());

            double arealTriangle = ArealTriangle(xHeight, yBase);
            int arealSquare = ArealSquare(sideA, sideB);

            Console.WriteLine("\nArealet på din firkant er " + arealSquare + ", og arealet af trekanten er " + arealTriangle);
            Console.ReadLine();
        }
    }
}

//Arealet af en trekant er ½*h*g