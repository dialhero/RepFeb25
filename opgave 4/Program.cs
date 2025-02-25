namespace opgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tal1;
            double tal2;
            

            Console.WriteLine("skriv dit første tal: ");
            tal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("skriv dit andet tal: ");
            tal2 = Convert.ToDouble(Console.ReadLine());

            double sum = tal1 + tal2;
            double diff = tal1 - tal2;
            double product = tal1 * tal2;
            double quotient = tal1 / tal2;
            double remainder = tal1 % tal2;

            Console.WriteLine("Sum: " + sum + ", difference: " + diff + ", procuct: " + product + ", quotient: " + quotient + ", remainder: " + remainder);

            Console.ReadLine();
        }
    }
}
