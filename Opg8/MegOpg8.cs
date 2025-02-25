namespace Opg8
{
    internal class MegOpg8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMegans karakterdommer! \n\n");

            Console.WriteLine("Hvilken karakter har du fået?");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("C");
            Console.WriteLine("D");
            Console.WriteLine("E");
            Console.WriteLine("F\n");

            string choice = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "A":
                    Console.WriteLine("\nDu er bestået!");
                    break;

                case "B":
                    Console.WriteLine("\nDu er bestået!");
                    break;

                case "C":
                    Console.WriteLine("\nDu er bestået!");
                    break;

                case "D":
                    Console.WriteLine("\nDu er bestået!");
                    break;

                case "E":
                    Console.WriteLine("\nDu er bestået!");
                    break;

                case "F":
                    Console.WriteLine("\nDu er dumpet! Trøst dig selv med en god middag! <3");
                    break;
            }

            Console.ReadLine();
        }
    }
}
