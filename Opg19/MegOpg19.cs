namespace Opg19
{
    internal class Program
    {
       
        static int countVowels(string input)
        {

            int vowelCount = 0;
            string vowels = "aeiouøæåAEIOUYÆØÅ";

            foreach (char c in input)
            {
                if(vowels.Contains(c))
                { 
                vowelCount++;
                }
                

            }
            return vowelCount;

        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg et ord, og så tæller jeg vokalerne: ");
            string input = Console.ReadLine();
            int result = countVowels(input);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    
    }
}
