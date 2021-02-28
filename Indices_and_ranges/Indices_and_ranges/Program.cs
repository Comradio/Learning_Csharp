using System;

namespace Indices_and_ranges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 10, 5, 6, 77, 89, 1 };

            // ^ - символ, позволяющий получать символы в обратном порядке: ^1 - последний эелемнт
            Console.WriteLine(myArray[^1]);

            // диапазоны - 1..4 (элемент №4 не входит в итоговую последовательность)
            int[] myArray1 = myArray[1..4];

            // диапазон начинается с начала и заканчивается указанным элементом - ..4
            myArray1 = myArray[..4];

            // диапазон начинает с указанного элемента и заканчивается последним элементом - 4.. 
            myArray1 = myArray[4..];

            // можно указывать элементы массива с конца при помощи индексов
            myArray1 = myArray[^4..^1];

            // такой же тип данных, как и все другие (но это структура => хранится в стэке)
            Index myIndex = ^1;

            Console.WriteLine(myArray[myIndex]);

            // поля типа данных Index
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");

            // конструктор для индекса
            // true - указывает на то, что нужно брать элементы с конца массива
            // false - указывает на то, что нужно брать элементы с начала массива
            Index myIndex1 = new Index(3, true);
            Console.WriteLine(myArray[myIndex1]);
            myIndex1 = new Index(3, false);
            Console.WriteLine(myArray[myIndex1]);

            // диапазон
            // range содержит в себе два индекса типа Index - начала и конца
            Range myRange = new Range(1, 4);

            string str = "Hello world!!! :)";

            Console.WriteLine(str[^2..]);
            Console.WriteLine(str[0..6]);
            Console.WriteLine(str[6..11]);

            foreach (var item in myArray[..4])
            {
                Console.WriteLine($"{item}");
            }

            foreach (var item in myArray[3..7])
            {
                Console.WriteLine($"{item}");
            }

            foreach (var item in myArray[^5..^2])
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
