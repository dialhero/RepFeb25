using System.Runtime.Intrinsics.X86;

namespace Opg3
{
    internal class Opg3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beregn dit BMI\n");
            Console.WriteLine("\nHvad vejer du i kg?");
            double weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHvor høj er du i meter?");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height*height);

            Console.WriteLine("\nDit BMI er: " + bmi);

            Console.WriteLine("\nUnder 18,5: Undervægtig");
            Console.WriteLine("18,5 - 24,9: Normalvægtig");
            Console.WriteLine("25 - 29,9: Overvægtig");
            Console.WriteLine("30 og derover: Fedme");
            Console.ReadLine();
        }
    }
}
