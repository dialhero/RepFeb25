using System.ComponentModel.Design;

namespace FahrenheitToCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvad er temperaturen?");

            Console.WriteLine("\nVælg temperatur skala: Fahrenheit eller Celsius?");
            string skala = Console.ReadLine();
            
            Console.WriteLine("\nHvad er temperaturen nu?");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (skala == "Fahrenheit" || skala == "fahrenheit" || skala == "F" || skala == "f")
            {
                double tempC = ((temp - 32) * (5.00/9.00));
                Console.WriteLine("\nTemperaturen er " + tempC + "grader Celsius.");
            }
            else if (skala == "Celsius" || skala == "celsius" || skala == "C" || skala == "c")
            {                              
                double tempF = (temp * (9.00/5.00) + 32);
                Console.WriteLine("\nTemperaturen er " + tempF + "grader Fahrenheit.");
            }
            else
            {
                Console.WriteLine("Den skala kender jeg ikke!");
            }

            Console.ReadLine();
          
        }
    }
}
