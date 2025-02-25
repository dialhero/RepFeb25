using System.ComponentModel;

namespace opgave_17
{
    internal class Program
    {

        static int add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("skriv dit første tal:");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("skriv dit andet tal:");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int sum = add(tal1, tal2);
            Console.WriteLine(sum);

            Console.ReadLine();


        }
    }
}
