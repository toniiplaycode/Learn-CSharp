using System;
using System.Linq;

namespace CSBasic
{
    internal class Program
    {
        static void Logger()
        {
            Console.WriteLine($"caslled logger");
        }
        static void Sum(int a, int b, int c)
        {
            Console.WriteLine($"sum: {a + b + c}");
        }
        static void Country(string country = "Viet Nam")
        {
            Console.WriteLine("my country: " + country);
        }
        static float Divide(float a, float b)
        {
            return a / b;
        }

        static int Multi(int a, int b)
        {
            return a * b;
        }

        static double Multi(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            string name = "Thanh Toan";
            char word = 'T';
            int age = 20;
            Console.WriteLine("hello world " +  name + " " + age + " " + word);

            float a = 1.2f;
            float b = 1.2f;
            Console.WriteLine(a + b);

            double c = 2.34d;
            Console.WriteLine(c);

            const int canTho = 65;
            Console.WriteLine(canTho);

            int d = 1, e = 2, f = 3;
            Console.WriteLine(d + " " + e + " " + f);

            Console.WriteLine(Convert.ToInt32(9.123));
            Console.WriteLine(Convert.ToString(12345)); // số nguyên thành chuỗi
            Console.WriteLine(Convert.ToBoolean(0));
            Console.WriteLine(Convert.ToBoolean(1));

            Console.Write("tonii ");
            Console.Write("playps4 \n");

            Console.Write("Enter your name: ");
            string inputName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int inputAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputName + " " + inputAge );
            Double myNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(myNumber);

            Console.WriteLine(Math.Max(10, 20));
            Console.WriteLine(Math.Min(10, 20));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Abs(-30));
            Console.WriteLine(Math.Round(2.51));

            string id = "DH21TIN07";
            Console.WriteLine(id.ToLower());
            Console.WriteLine(id.Length);

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);

            int interpolation = 999;
            Console.WriteLine($"Interpolation: {interpolation}");

            string stringIndexOf = "abcde";
            Console.WriteLine(stringIndexOf.Substring(1));

            Console.WriteLine("Array: ");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            int[] arr2 = { 2, 3, 1, 5, 2, 9, 4 };
            Array.Sort(arr2);
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("using System.Linq: ");
            int[] myNumbers = { 1, 2, 3, 4 };
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());

            Console.WriteLine("Function: ");
            Logger();
            Sum(1, 2, 3);
            Country("Japan");
            Country();
            Console.WriteLine(Divide(5, 3));

            Console.WriteLine("Overloading: ");
            Console.WriteLine(Multi(9, 8));
            Console.WriteLine(Multi(9.2, 8.3));

            Console.Read(); // dừng màn hình
        }
    }
}   