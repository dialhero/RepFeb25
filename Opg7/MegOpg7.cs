namespace Opg7
{
    internal class MegOpg7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Megans taltjekker!");
            Console.WriteLine("\nGiv mig et tal, og lad mig evaluere det!");

            Console.WriteLine("\nHvad er dit tal? ");
            int X = Convert.ToInt32(Console.ReadLine());

            if (X > 0)
            {
                Console.WriteLine("Dit tal er positivt!");
            }
            else if (X < 0)
            {
                Console.WriteLine("Dit tal er negativt!");
            }
            else if (X == 0)
            {
                Console.WriteLine("Dit tal er nul!");
            }

            Console.ReadLine();
        }
    }
}
