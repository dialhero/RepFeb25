namespace Opg18
{
    internal class MegOpg18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast teksten, der skal vendes om:");
            string text = Console.ReadLine();
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            Console.WriteLine(reversedStr);
            Console.ReadLine();

            }
        }
    }

