namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast grader i celcuis");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast grader i fahrenheit");
            double weight = Convert.ToDouble(Console.ReadLine());

            double c = 25;
            double f = 77;
            double cToF;
            double fToC;

            cToF = c * (9.00 / 5.00) + 32;
            fToC = (f - 32) * (5.00 / 9.00);
            Console.WriteLine(c + "°C is " + cToF + "°F");
            Console.WriteLine(f + "°F is " + fToC + "°C");
            Console.ReadLine();
        }
    }
}
