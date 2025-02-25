namespace opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hvad er din højde i meter: ");
            double højde = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("hvad er din vægt: ");
            double vægt = Convert.ToDouble(Console.ReadLine());

            double bmi = vægt / (højde * højde);


            Console.WriteLine("BMI: " + bmi);

            Console.ReadLine();
           
        }
    }
}
