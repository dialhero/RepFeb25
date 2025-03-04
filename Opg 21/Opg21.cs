namespace Opg_21
{
    internal class Opg21
    {
        
        
            static double VolumeCylinder(double radius, double pi, double height)
            {
                return (pi * (radius * radius)*height);
            }

            static int VolumeCube(int sideA)
            {
                return sideA * sideA * sideA;
            }

            static void Main(string[] args)
            {

                Console.WriteLine("Lad os beregne arealet af en kube med sidelængen A " +
                                        "\b og en cylinder med diameteren X og højden Y:");

                Console.WriteLine("\nIndtast cylinderens diameter: ");
                double diameter = Convert.ToInt32(Console.ReadLine());
                double radius = (diameter / 2.00);
                double pi = double.Pi;
                Console.WriteLine("\nIndtast cylinderens højde: ");
                double height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nIndtast firkantens længde på siden A i hele tal: ");
                int sideA = Convert.ToInt32(Console.ReadLine());

                double volumeCylinder = VolumeCylinder(radius, pi, height);
                int volumeCube = VolumeCube(sideA);

                Console.WriteLine("\nVolumen på din kube er " + volumeCube + ", og volumen af din cylinder er " + volumeCylinder);
                
                Console.ReadLine();
            }
        }
    }

