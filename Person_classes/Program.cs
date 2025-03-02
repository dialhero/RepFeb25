namespace Person_classes
{

    public class Person
    {
        public string Name;
        public int Age;
        
        public void Speak()
        {
            Console.WriteLine("Hej jeg hedder " + Name + ". Jeg er " + Age + " år gammel"); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Megan";
            person.Age = 34;
            
            person.Speak();

            Console.ReadLine();

        }
    }
}
