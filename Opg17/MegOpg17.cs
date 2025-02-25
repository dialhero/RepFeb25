using System.ComponentModel;

namespace Opg17
{
    internal class MegOpg17
    {
    
        static int add(int a, int b)
            {
                return a + b;
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Vælg to tal:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = add(a, b);
            Console.WriteLine("\nSummen af de to tal er: " + sum);

            Console.ReadLine();
        }
    }
}


