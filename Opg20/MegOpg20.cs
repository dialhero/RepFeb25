namespace Opg20
{
    internal class MegOpg20
    {
        
        
        static void Areal(double diameter)
        { 
        
        int diameter = Convert.ToInt32(Console.ReadLine());
        double radius = (diameter / 2.00);
        double areal = double.Pi * (radius * radius);
        double circumference = double.Pi * diameter;

        Console.WriteLine("\nCirklens radius er: " + radius);
        Console.WriteLine("Cirklens areal er: " + areal);
        Console.WriteLine("Cirklens omkreds er: " + circumference);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lad os beregne arealet af et kvadrat med sidelængden X \bog en cirkel med diameteren X:");
            Console.WriteLine(
            Console.ReadLine();  
        }
    }
}
