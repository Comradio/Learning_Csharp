using System;

namespace Null_concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            // <проверяемая переменная> ?? <дефолтное значение>
            // проверяемая переменная и дефолтное значение должны быть одного типа данных
            string result = str ?? "нет данных";

            Console.WriteLine(str ?? "нет данных");
            Console.WriteLine(result);

            string result1 = str ?? "";
            string result2 = str ?? string.Empty;

            Console.WriteLine("количество символов в строке: " + result1.Length);
            Console.WriteLine("количество символов в строке: " + result2.Length);
        }
    }
}
