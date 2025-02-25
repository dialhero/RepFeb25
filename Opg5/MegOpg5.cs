namespace Opg5
{
    internal class Opg5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lad os beregne arealet af en cirkel!");

            Console.WriteLine("\nGiv mig cirklens diameter: ");
            int diameter = Convert.ToInt32 (Console.ReadLine());
            double radius = (diameter / 2.00);
            double areal = double.Pi * (radius * radius);
            double circumference = double.Pi * diameter;

            Console.WriteLine("\nCirklens radius er: " + radius);
            Console.WriteLine("Cirklens areal er: " + areal);
            Console.WriteLine("Cirklens omkreds er: " + circumference);

            Console.ReadLine(); 


        }
    }
}
