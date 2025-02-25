namespace opgave_19
{
    internal class Program
    {

        static int countvowels(string input)
        {
        
            int vowelcount = 0;
            string vowels = "aeiouyæøåAEIOUYÆØÅ";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    vowelcount++;
                }

            }
            return vowelcount;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("skriv: ");
            string input = Console.ReadLine();
            int result =countvowels(input);
            Console.WriteLine(result);
        }
    }
}
