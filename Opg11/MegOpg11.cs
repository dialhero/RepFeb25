namespace Opg11
{
    internal class MegOpg11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ugens dage ===\n");

            Console.WriteLine("Hvilken måned vil du høre om? Vælg et tal mellem 1-12.");
            Console.WriteLine("1. Januar");
            Console.WriteLine("2. Februar");
            Console.WriteLine("3. Marts");
            Console.WriteLine("4. April");
            Console.WriteLine("5. Maj");
            Console.WriteLine("6. Juni");
            Console.WriteLine("7. Juli");
            Console.WriteLine("8. August");
            Console.WriteLine("9. September");
            Console.WriteLine("10. Oktober");
            Console.WriteLine("11. November");
            Console.WriteLine("12. December\n");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Januar();
                    break;

                case "2":
                    Februar();
                    break;

                case "3":
                    Marts();
                    break;

                case "4":
                    April();
                    break;

                case "5":
                    Maj();
                    break;

                case "6":
                    Juni();
                    break;

                case "7":
                    Juli();
                    break;

                case "8":
                    August();
                    break;

                case "9":
                    September();
                    break;

                case "10":
                    Oktober();
                    break;

                case "11":
                    November();
                    break;

                case "12":
                    December();
                    break;
            }
        }
        static void Januar()
        {
            Console.WriteLine("\nJanuar");
            Console.WriteLine("--------------");
            Console.WriteLine("Årets første måned, ofte kold og med sne i mange lande. \bNavnet kommer fra den romerske gud Janus, der havde to ansigter – et der så fremad, og et der så tilbage.");
            Console.ReadLine();
        }

        static void Februar()
        {
            Console.WriteLine("\nFebruar");
            Console.WriteLine("--------------");
            Console.WriteLine("Den korteste måned, kendt for fastelavn og valentinsdag. \bNavnet kommer fra det latinske ord \"februa\", der betyder renselse.");
            Console.ReadLine();
        }

        static void Marts()
        {
            Console.WriteLine("\nMarts");
            Console.WriteLine("--------------");
            Console.WriteLine("Forårets komme begynder så småt. Navnet kommer fra den romerske krigsgud Mars.");
            Console.ReadLine();
        }

        static void April()
        {
            Console.WriteLine("\nApril");
            Console.WriteLine("--------------");
            Console.WriteLine("Kendt for påske og for at være en måned med omskifteligt vejr. \bNavnet kommer fra det latinske ord \"aperire\", der betyder at åbne (blomsterne springer ud).");
        }

        static void Maj()
        {
            Console.WriteLine("\nMaj");
            Console.WriteLine("--------------");
            Console.WriteLine("Foråret er i fuld gang, og naturen blomstrer. Navnet kommer fra den romerske gudinde Maia.");
            Console.ReadLine();
        }

        static void Juni()
        {
            Console.WriteLine("\nJuni");
            Console.WriteLine("--------------");
            Console.WriteLine("Sommerens begyndelse, ofte med varmt vejr og lange dage. Navnet kommer fra den romerske gudinde Juno.");
            Console.ReadLine();
        }

        static void Juli()
        {
            Console.WriteLine("\nJuli");
            Console.WriteLine("--------------");
            Console.WriteLine("Højsommer, mange holder ferie. Navnet kommer fra Julius Cæsar.");
            Console.ReadLine();
        }

        static void August()
        {
            Console.WriteLine("\nAugust");
            Console.WriteLine("--------------");
            Console.WriteLine("Stadig sommer, men dagene begynder at blive kortere. Navnet kommer fra kejser Augustus.");
            Console.ReadLine();
        }

        static void September()
        {
            Console.WriteLine("\nSeptember");
            Console.WriteLine("--------------");
            Console.WriteLine("Efterårets begyndelse, bladene begynder at skifte farve. \bNavnet kommer fra det latinske ord \"septem\", der betyder syv (september var den syvende måned i den gamle romerske kalender).");
            Console.ReadLine();
        }

        static void Oktober()
        {
            Console.WriteLine("\nOktober");
            Console.WriteLine("--------------");
            Console.WriteLine("Efteråret er i fuld gang, og det kan være blæsende og regnfuldt. \bNavnet kommer fra det latinske ord \"octo\", der betyder otte.");
            Console.ReadLine();
        }

        static void November()
        {
            Console.WriteLine("\nNovember");
            Console.WriteLine("--------------");
            Console.WriteLine("En mørk og ofte trist måned, hvor mange tænker på de døde. Navnet kommer fra det latinske ord \"novem\", der betyder ni.");
            Console.ReadLine();
        }

        static void December()
        {
            Console.WriteLine("\nDecember");
            Console.WriteLine("--------------");
            Console.WriteLine("Årets sidste måned, kendt for jul og nytår. Navnet kommer fra det latinske ord \"decem\", der betyder ti.");
            Console.ReadLine();
        }
    }
}
