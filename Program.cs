namespace Opgave_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast alder");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast højde");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast vægt");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast initial");
            char initial = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Indtast navn");
            string name = Console.ReadLine();

            Console.WriteLine("Tast 'y' hvis du er studerence og 'n' hvis du ikke er studerende");
            char input = Convert.ToChar(Console.ReadLine());
            bool isStudent = false;
            if (input == 'y')
            {
                isStudent = true;
            }

            Console.WriteLine("Age: " + age + ", Height: " + height + ", Weight: " + weight + ", Initial: " + initial + ", Name: " + name + ", Is Student: " + isStudent);
            Console.ReadLine();
        }
    }
}
