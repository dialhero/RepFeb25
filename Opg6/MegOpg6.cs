namespace Opg6
{
    internal class MegOpg6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Megans lommeregner");
            Console.WriteLine("\nGiv mig to tal, og lad mig evaluere dem! X ift. Y!");

            Console.WriteLine("\nDit første tal (X): ");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDit andet tal (Y): ");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X == Y)
            {
                Console.WriteLine("Is equal: True");
            }
            else
            {
                Console.WriteLine("Is equal: False");
            }

            if (X > Y)
            {
                Console.WriteLine("Is greater: True");
            }
            else
            {
                Console.WriteLine("Is greater: False");
            }

            if (X < Y)
            {
                Console.WriteLine("Is less: True");
            }
            else
            {
                Console.WriteLine("Is less: False");
            }

            if (X >= Y)
            {
                Console.WriteLine("Is greater or equal: True");
            }
            else if (X <= Y)
            {
                Console.WriteLine("Is less or equal: True");
            }
            else
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
