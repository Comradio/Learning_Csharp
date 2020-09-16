using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    /*
     * СУММА И КОЛИЧЕСТВО ЧЕТНЫХ И НЕЧЕТНЫХ ЧИСЕЛ В ДИАПАЗОНЕ
     */
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0; //нечётные числа
            uint evenNumbersCount = 0; //чётные числа
            int sumOddNumbers = 0;
            int sumEvenNumbers = 0;

            Console.WriteLine("Введите первое число диапазона:");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона:");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    sumEvenNumbers += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    sumOddNumbers += currentValue;
                }
                currentValue++;
            }

            Console.WriteLine("Количество нечётных числе: " + oddNumbersCount);
            Console.WriteLine("Количество чётных числе: " + evenNumbersCount);
            Console.WriteLine("Сумма нечётных числе = " + sumOddNumbers);
            Console.WriteLine("Сумма чётных числе = " + sumEvenNumbers);
            Console.ReadLine();
        }
    }
}
