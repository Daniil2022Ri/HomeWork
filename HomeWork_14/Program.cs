using System.Security.Cryptography.X509Certificates;

namespace HomeWork_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ResultMethodSum = Sum(10 + 10, 10);
            Console.WriteLine($"One using Method Sum {ResultMethodSum} ");
            PrintUserInformation(Name: "Daniil", age: 24);
            //PringUserInformation(age: 24 , Name: "Daniil");


            int x = 1;
            Increase( x);
            int X_1 = 1;
            IncreaseRef(ref  X_1);


            double x1;
            double x2;
            bool hasSolution = SolveEquation(1, 5, -6, out  x1, out  x2);

            if (hasSolution)
            {
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
            else
            {
                Console.WriteLine("No value");
            }

        }

        static int Sum(int a , int b)
        {
            return a + b;
        }

        static void PrintUserInformation(string Name , int age = 24, string country = "Russia")
        {
            Console.WriteLine($"Name: {Name} , Age {age}");
        }
        static void Increase( int value) // using ref
        {
            value++;
            Console.WriteLine($"Value Method {value}");
        }
        static void IncreaseRef(ref int valueRef) 
        {
            valueRef++;
        }
        static bool SolveEquation(double a , double b , double c , out double x1 , out double x2)
        {
            double d = b * b - 4 * a * c;

            if(d < 0 )
            {
                x1 = x2 = 0; // Out return Value

                return false;
            }

            x1 =(-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-d - Math.Sqrt(d)) / (2 * a);

            return true;
        }
    }
}
