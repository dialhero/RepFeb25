namespace Opg15
{
    internal class MegOpg15
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Lad os regne nogle tal sammen - Jeg finder summen af det tal interval, som du giver mig. :) ");
            Console.WriteLine("\nIndtast startværdi (X): ");
            
            int x = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateSum(1, x);

                Console.WriteLine($"\nSummen af alle heltal fra 1 til {x} er: {sum}");
                Console.ReadLine();
            }

        // Metode til at beregne summen af alle heltal mellem X og Y

                static int CalculateSum( int start, int end)
            {    
            int sum = 0;
                for (int i = start; i <= end; i++)
                {
                    sum += i;
                }
                return sum;                        
        }
        
        }

    }
