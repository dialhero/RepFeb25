namespace opgave_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv tallet på ugedagen: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("mandag");
                    break;
                case 2:
                    Console.WriteLine("tirsdag");
                    break;
                case 3:
                    Console.WriteLine("onsdag");
                    break;
                case 4:
                    Console.WriteLine("torsdag");
                    break;
                case 5:
                    Console.WriteLine("fredag");
                    break;
                case 6:
                    Console.WriteLine("lørdag");
                    break;
                case 7:
                    Console.WriteLine("søndag");
                    break;

            }
            Console.ReadLine();
        }
    }
}
