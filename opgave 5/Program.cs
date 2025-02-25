namespace opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double radius;
            double diametere;
            double areal;
            double omkreds;


            Console.WriteLine("hvad er radius på din cirkel: ");
            radius =  Convert.ToDouble(Console.ReadLine());

            areal = 3.1415 * (radius*radius);
            omkreds = 2 * 3.1415 * radius;


            Console.WriteLine("Area: " + areal + " circumference: " + omkreds);
        }
    }
}
