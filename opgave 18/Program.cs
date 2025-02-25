namespace opgave_18
{
    internal class Program
    {


        static string reverseString (string s)
        {
            char[] chars = s.ToCharArray ();
            Array.Reverse (chars);
            return new string (chars);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv: ");
            string n = Console.ReadLine();
            string omvendt = reverseString (n);
            Console.WriteLine(omvendt);

         

            Console.ReadLine();

        }
    }
}
