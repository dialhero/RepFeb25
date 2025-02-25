namespace opgave_2
{
    internal class Program

        
    {
        static void Main(string[] args)
        {

            double temparatur;

            Console.WriteLine("skriv den temperatur du vil have conveteret: ");
            temparatur = Convert.ToDouble(Console.ReadLine());

            double fahr = temparatur * 9.00/5.00 + 32;
            double cels = (temparatur - 32) * (5.00/9.00);


            Console.WriteLine(temparatur + "C is " + fahr + "F");
            Console.WriteLine(temparatur + "F is " + cels + "C");

            Console.ReadLine();
        }
    }
}
