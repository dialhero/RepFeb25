using System.ComponentModel.Design;

namespace opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isEqual = true;
            bool isNotEqual = true;
            bool isGreater = true;
            bool isLess = true;
            bool isNotGreaterOrEqual = true;
            bool isLessOrEqual = true;

            int tal1;
            int tal2;

            Console.WriteLine("skriv dit første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("skriv dit andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 == tal2)
            {
                isEqual = true;
            } else isEqual = false;

            if (tal2 != tal1)
            {
                isNotEqual = true;
            }
            else isNotEqual = false;

            if (tal1 > tal2) { isGreater = true; }
            else { isGreater = false; }

            if (tal1 < tal2) { isLess = true; }
            else isLess = false;

            if (tal1 >= tal2) {isNotGreaterOrEqual = true; }
            else isNotGreaterOrEqual = false;

            if (tal1 <= tal2) { isLessOrEqual = true; }
            else isLessOrEqual = false;
                


            Console.WriteLine("is equal: " + isEqual + ", is not equal: " + isNotEqual + ", is great: " + isGreater + ", is less:  " + isLess + ", is not greater or equal: " + isNotGreaterOrEqual + ", is less or equal: " + isLessOrEqual);


            Console.ReadLine();
        }
    }
}
