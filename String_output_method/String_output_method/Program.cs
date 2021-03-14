using System;

namespace String_output_method
{
    class Program
    {
        static void PrintLine(char symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Введите количеств осимволов: ");
            uint symbolsCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol, symbolsCount);
            Console.ReadKey();
        }
    }
}
