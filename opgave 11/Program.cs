namespace opgave_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv nanvet på måneden med små bogstaver ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "januar":
                    Console.WriteLine("Årets første måned, ofte kold og med sne i mange lande. Navnet kommer fra den romerske gud Janus, der havde to ansigter – et der så fremad, og et der så tilbage.");
                    break;
                case "februar":
                    Console.WriteLine("Den korteste måned, kendt for fastelavn og valentinsdag. Navnet kommer fra det latinske ord \"februa\", der betyder renselse.");
                    break;
                case "marts":
                    Console.WriteLine("Forårets komme begynder så småt. Navnet kommer fra den romerske krigsgud Mars.");
                    break;
                case "april":
                    Console.WriteLine("Kendt for påske og for at være en måned med omskifteligt vejr. Navnet kommer fra det latinske ord \"aperire\", der betyder at åbne (blomsterne springer ud).");
                    break;
                case "maj":
                    Console.WriteLine("Foråret er i fuld gang, og naturen blomstrer. Navnet kommer fra den romerske gudinde Maia.");
                    break;
                case "juni":
                    Console.WriteLine("Sommerens begyndelse, ofte med varmt vejr og lange dage. Navnet kommer fra den romerske gudinde Juno.");
                    break;
                case "juli":
                    Console.WriteLine("Højsommer, mange holder ferie. Navnet kommer fra Julius Cæsar.");
                    break;
                case "august":
                    Console.WriteLine("Stadig sommer, men dagene begynder at blive kortere. Navnet kommer fra kejser Augustus.");
                    break;
                case "september":
                    Console.WriteLine("Efterårets begyndelse, bladene begynder at skifte farve. Navnet kommer fra det latinske ord \"septem\", der betyder syv (september var den syvende måned i den gamle romerske kalender).");
                    break;
                case "oktober":
                    Console.WriteLine("Efteråret er i fuld gang, og det kan være blæsende og regnfuldt. Navnet kommer fra det latinske ord \"octo\", der betyder otte.");
                    break;
                case "november":
                    Console.WriteLine("En mørk og ofte trist måned, hvor mange tænker på de døde. Navnet kommer fra det latinske ord \"novem\", der betyder ni.");
                    break;
                case "december":
                    Console.WriteLine("Årets sidste måned, kendt for jul og nytår. Navnet kommer fra det latinske ord \"decem\", der betyder ti.");
                    break;
               


            }
            Console.ReadLine();
        }
    }
}
