namespace Opg9
{
    internal class MegOpg9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Er det et skudår?");
            Console.WriteLine("\nHvad er årstallet? ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Det er et skudår!");
            }
            else
            {
                Console.WriteLine("Det er ikke et skudår!");
            }

            Console.ReadLine();

        }
    }
}


// skudår hvis det er deleligt med 4 og 400, men ikke 100
// 1900 ikke et skudår med 2000 er