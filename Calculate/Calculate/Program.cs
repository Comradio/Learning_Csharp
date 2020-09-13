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

            Console.WriteLine("Введите первое число: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Выберите действие: +, -, *, /");
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
            Console.WriteLine("Введите второе число: ");
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
                    if (b == 0)
                    {
                        Console.WriteLine("На ноль делить здесь не положено!");
                        result = 0;
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine("Результат: " + result);
                    }
                    break;
                default:
                    Console.WriteLine("Была введена неверная операция!");
                    break;
            }
        }
    }
}
