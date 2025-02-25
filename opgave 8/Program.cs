namespace opgave_8
{
    internal class Program
    {

        static void A(){
            Console.WriteLine("du har bestået med a");

        }
        static void Main(string[] args)


        {
            Console.WriteLine("Skriv din karakter: ");

            string choice =  Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "a":
                    A();
                    break;

            }
            
        }
    }
}
