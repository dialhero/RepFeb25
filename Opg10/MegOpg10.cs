namespace Opg10
{
    internal class Opg10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ugens dage ===\n");

            Console.WriteLine("Hvilken dag på ugen er det? Vælg et tal mellem 1-7.");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7\n");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Det er mandag");
                    break;

                case "2":
                    Console.WriteLine("Det er tirsdag");
                    break;

                case "3":
                    Console.WriteLine("Det er onsdag");
                    break;

                case "4":
                    Console.WriteLine("Det er torsdag");
                    break;

                case "5":
                    Console.WriteLine("Det er fredag");
                    break;

                case "6":
                    Console.WriteLine("Det er lørdag");
                    break;

                case "7":
                    Console.WriteLine("Det er søndag");
                    break;
            }

        Console.ReadLine();
        }
    }
}
