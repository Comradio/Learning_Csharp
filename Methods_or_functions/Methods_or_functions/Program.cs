using System;
using System.Xml.Serialization;

namespace Methods_or_functions
{
    class Program
    {
        /*static int Sum(int value1, int value2)
        {
            int result = value1 + value2;

            return result;
        }*/

        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        // метод может не иметь входных параметров и ничего не возвращать
        static void PrintLine()
        {
            Console.WriteLine("Метод PrintLine был вызван!");
        }

        static void PrintResult(int result)
        {
            Console.WriteLine($"Результат сложения: {result}");
        }
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            
            c = Sum(a, b);

            PrintLine();

            PrintResult(c);

            Console.WriteLine("==========");
        }
    }
}
