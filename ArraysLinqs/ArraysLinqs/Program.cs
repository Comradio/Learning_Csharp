using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLinqs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 10, 4, 99, 49,  64, 111,  77, 4, 42, 10, 5 };
            int[] result;
            int test, index;
            // Максимальное число
            Console.WriteLine("Максимальное число массива: {0} ", myArray.Max());

            // Сумма всех чётных числе массива
            Console.WriteLine("Сумма всех чётных числе массива: {0} ", myArray.Where(i => i % 2 == 0).Sum());

            // Минимальное нечётное число
            Console.WriteLine("Минимальное нечётное число: {0} ", myArray.Where(i => i % 2 != 0).Min());

            // Уникальные эелемнты массива
            result = myArray.Distinct().ToArray();

            // Упорядочить массив от меньшего к большему
            result = myArray.OrderBy(i => i).ToArray();

            // Упорядочить массив от большего к меньшему
            result = myArray.OrderByDescending(i => i).ToArray();

            // Сортируюет массив
            Array.Sort(myArray);
            // Находит первый элемент, удовлетворяющий условию, начиная с начала
            test = Array.Find(myArray, i => i < 70);
            // Находит первый элемент, удовлетворяющий условию, начиная с конца
            test = Array.FindLast(myArray, i => i < 70);
            // Находит все эелемнты, удовлетворябщие условию
            result = Array.FindAll(myArray, i => i < 70);
            // Индекс элемента по условию с начала
            index = Array.FindIndex(myArray, i => i == 77);
            // Индекс эелемента по условию с конца
            index = Array.FindLastIndex(myArray, i => i == 77);
            // Массив в обратном порядке
            Array.Reverse(myArray);

            // Найти первый элемент по условию или вернуть стандартное значение для типа данных (int - 0, ссылочные типы - null)
            test = myArray.Where(i => i < 0).FirstOrDefault();
        }
    }
}
