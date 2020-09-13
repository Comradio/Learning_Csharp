using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, result;
            string act = "" ;

            a = float.Parse(Console.ReadLine());
            ConsoleKey consoleKey = Console.ReadKey().Key;

            switch (consoleKey)
            {
                case ConsoleKey.Multiply:
                    act = "*";
                    break;
                case ConsoleKey.Add:
                    act = "+";
                    break;
                case ConsoleKey.Subtract:
                    act = "-";
                    break;
                case ConsoleKey.Divide:
                    act = "/";
                    break;
                default:
                    break;
            }

            Console.WriteLine();
            b = float.Parse(Console.ReadLine());

            switch (act)
            {
                case "*":
                    result = a * b;
                    Console.WriteLine("Результат: " + result);
                    break;
                case "+":
                    result = a + b;
                    Console.WriteLine("Результат: " + result);
                    break;
                case "-":
                    result = a - b;
                    Console.WriteLine("Результат: " + result);
                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine("Результат: " + result);
                    break;
                default:
                    break;
            }
        }
    }
}
